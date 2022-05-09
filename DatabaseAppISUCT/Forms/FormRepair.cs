using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DatabaseAppISUCT
{
    public partial class FormRepair : MaterialForm
    {

        #region Fields
        static readonly string _connection = "Data Source=DESKTOP-TT3J386\\SQLEXPRESS;Initial Catalog=machine;Persist Security Info=True;User ID=M1sty;Password=5uJ63SpXER";
        private DateTime _dateStart;
        private DateTime _dateEnd;
        private int _typeRepairID;
        private int _machineID;
        private int _repairID;
        SqlConnection connection = new SqlConnection(_connection);
        private string _commandText;
        private SqlDataReader _reader;
        private SqlDataAdapter _adapter;
        #endregion

        public FormRepair()
        {
            InitializeComponent();
            #region UISettings
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            if (FormSettings.ThemeManager.Theme == MaterialSkinManager.Themes.DARK)
            {
                this.repairDataGridView.ForeColor = Color.Black;
            }
            #endregion
            connection.Open();
            _commandText = "SELECT * FROM BasicTypeRepairInformation";
            using (SqlCommand firstCommand = new SqlCommand(_commandText, connection))
            {
                _adapter = new SqlDataAdapter(firstCommand);
                _adapter.Fill(this.dataSet1.BasicTypeRepairInformation);
                comboBox1.DataSource = this.dataSet1.BasicTypeRepairInformation;
                comboBox1.DisplayMember = "Description";
                comboBox1.ValueMember = "TypeRepairID";
            }
            string anotherCommand = "Select * from AllMachineData";
            using (SqlCommand secondCommand = new SqlCommand(anotherCommand, connection))
            {
                _adapter = new SqlDataAdapter(secondCommand);
                _adapter.Fill(this.dataSet1.AllMachineData);
                comboBox2.DataSource = this.dataSet1.AllMachineData;
                comboBox2.DisplayMember = "Description";
                comboBox2.ValueMember = "MachineID";
            }
        }

        #region LoadUISettingMethod
        private void LoadTheme()
        {
            foreach (Control btnD in this.Controls)
            {
                if (btnD.GetType() == typeof(Button))
                {
                    Button btn = (Button)btnD;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        #endregion

        private void FormRepair_Load(object sender, EventArgs e)
        {
            this.repairTableAdapter.Fill(this.dataSet1.Repair);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            repairBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _dateStart = Convert.ToDateTime(dateStartDateTimePicker.Text);
                _dateEnd = Convert.ToDateTime(endDateDateTimePicker.Text);
                _typeRepairID = Convert.ToInt32(comboBox1.SelectedValue);
                _machineID = Convert.ToInt32(comboBox2.SelectedValue);
                this.repairTableAdapter.InsertQuery(_dateStart, _typeRepairID, _machineID, _dateEnd);
                this.repairTableAdapter.Fill(this.dataSet1.Repair);
            }
            #region CatchingExceptions
            catch (SqlException ex)
            {
                if (ex.Message.Contains("R_27"))
                {
                    MessageBox.Show("Вы указали несуществующую запись в поле MachineID! Отказ в операции!");
                }
                else if (ex.Message.Contains("R_26"))
                {
                    MessageBox.Show("Вы указали несуществующую запись в поле TypeRepairID! Отказ в операции!");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("TypeRepairID"))
                {
                    MessageBox.Show("Необходимо указывать TypeRepairID, Nulls не разрешены");
                }
                if (ex.Message.Contains("MachineID"))
                {
                    MessageBox.Show("Необходимо указывать MachineID, Nulls не разрешены");
                }
            }
            #endregion
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                _dateStart = Convert.ToDateTime(dateStartDateTimePicker.Text);
                _dateEnd = Convert.ToDateTime(endDateDateTimePicker.Text);
                _typeRepairID = Convert.ToInt32(comboBox1.SelectedValue);
                _machineID = Convert.ToInt32(comboBox2.SelectedValue);
                _repairID = Convert.ToInt32(repairIDTextBox.Text);
                _commandText = "UPDATE [dbo].[Repair] SET [DateStart] = @DateStart, [TypeRepairID] = @TypeRepairID, [MachineID] = @MachineID, [EndDate] = @EndDate WHERE [RepairID] = @Original_RepairID";
                using (SqlCommand command = new SqlCommand(_commandText, connection))
                {
                    _adapter = new SqlDataAdapter(command);
                    command.Parameters.AddWithValue("@DateStart", _dateStart);
                    command.Parameters.AddWithValue("@TypeRepairID", _typeRepairID);
                    command.Parameters.AddWithValue("@Original_RepairID", _repairID);
                    command.Parameters.AddWithValue("@MachineID", _machineID);
                    command.Parameters.AddWithValue("@EndDate", _dateEnd);
                    _adapter.Fill(this.dataSet1.Repair);
                    this.repairTableAdapter.Fill(this.dataSet1.Repair);
                }
            }
            #region CatchingExceptions
            catch (SqlException ex)
            {
                if (ex.Message.Contains("R_27"))
                {
                    MessageBox.Show("Вы указали несуществующую запись в поле MachineID! Отказ в операции!");
                }
                else if (ex.Message.Contains("R_26"))
                {
                    MessageBox.Show("Вы указали несуществующую запись в поле TypeRepairID! Отказ в операции!");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("TypeRepairID"))
                {
                    MessageBox.Show("Необходимо указывать TypeRepairID, Nulls не разрешены");
                }
                if (ex.Message.Contains("MachineID"))
                {
                    MessageBox.Show("Необходимо указывать MachineID, Nulls не разрешены");
                }
            }
            #endregion
        }

        private void bindingNavigator(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.repairBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            #region CatchingExceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.repairTableAdapter.Fill(this.dataSet1.Repair);
            }
            #endregion

            _machineID = Convert.ToInt32(machineIDTextBox.Text);
            _commandText = "SELECT Description FROM AllMachineData where MachineID = @MachineID";
            using (SqlCommand thisCommand = connection.CreateCommand())
            {
                thisCommand.CommandText = _commandText;
                thisCommand.Parameters.AddWithValue("@MachineID", _machineID);
                _reader = thisCommand.ExecuteReader();
                while (_reader.Read())
                {
                    comboBox2.Text = _reader["Description"].ToString();
                }
                _reader.Close();
            }
            _typeRepairID = Convert.ToInt32(typeRepairIDTextBox.Text);
            _commandText = "SELECT Description FROM BasicTypeRepairInformation where TypeRepairID = @TypeRepairID";
            using (SqlCommand thisCommand = connection.CreateCommand())
            {
                thisCommand.CommandText = _commandText;
                thisCommand.Parameters.AddWithValue("@TypeRepairID", _typeRepairID);
                _reader = thisCommand.ExecuteReader();
                while (_reader.Read())
                {
                    comboBox1.Text = _reader["Description"].ToString();
                }
                _reader.Close();
            }
        }
    }
}
