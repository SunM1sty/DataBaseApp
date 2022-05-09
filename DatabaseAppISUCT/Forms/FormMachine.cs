using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DatabaseAppISUCT
{
    public partial class FormMachine : MaterialForm
    {
        #region Fields
        static readonly string _connection = "Data Source=DESKTOP-TT3J386\\SQLEXPRESS;Initial Catalog=machine;Persist Security Info=True;User ID=M1sty;Password=5uJ63SpXER";
        SqlConnection connection = new SqlConnection(_connection);
        private string _commandText;
        private SqlDataReader _reader;
        private int _dateIssue;
        private int _typeMachineID;
        private int _originalMachineID;
        private SqlDataAdapter _adapter;
        #endregion

        public FormMachine()
        {
            InitializeComponent();
            #region UISettings
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            if (FormSettings.ThemeManager.Theme == MaterialSkinManager.Themes.DARK)
            {
                this.machineDataGridView.ForeColor = Color.Black;
            }
            #endregion
            connection.Open();
            _commandText = "SELECT * FROM BasicTypeMachineInformation";
            using (SqlCommand firstCommand = new SqlCommand(_commandText, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(firstCommand);
                adapter.Fill(this.dataSet1.BasicTypeMachineInformation);
                comboBox1.DataSource = this.dataSet1.BasicTypeMachineInformation;
                comboBox1.DisplayMember = "Description";
                comboBox1.ValueMember = "TypeMachineID";
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

        private void FormMachine_Load(object sender, EventArgs e)
        {
            this.machineTableAdapter.Fill(this.dataSet1.Machine);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            machineBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _dateIssue = Convert.ToInt32(dateIssueTextBox.Text);
                _typeMachineID = Convert.ToInt32(comboBox1.SelectedValue);
                this.machineTableAdapter.InsertQuery(_dateIssue, _typeMachineID);
                this.machineTableAdapter.Fill(this.dataSet1.Machine);
            }
            #region CatchExceptions
            catch (SqlException ex)
            {
                if (ex.Message.Contains("R_28"))
                {
                    MessageBox.Show("Создаваемая вами запись отсылается на несуществующую запись в таблице 'Type_Machine'");
                }
                if (ex.Message.Contains("ValidDateIssue"))
                {
                    MessageBox.Show("Вы указали неправильную дату! Отказ в операции");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("TypeMachineID"))
                {
                    MessageBox.Show("Вы не указали тип станка! Отказ в операции");
                }
                if (ex.Message.Contains("DateIssue"))
                {
                    MessageBox.Show("Вы не указали дату! Отказ в операции");
                }
            }
            #endregion
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _dateIssue = Convert.ToInt32(dateIssueTextBox.Text);
                _typeMachineID = Convert.ToInt32(comboBox1.SelectedValue);
                _originalMachineID = Convert.ToInt32(machineIDTextBox.Text);
                _commandText = "UPDATE [dbo].[Machine] SET [DateIssue] = @DateIssue, [TypeMachineID] = @TypeMachineID WHERE [MachineID] = @Original_MachineID";
                using (SqlCommand command = new SqlCommand(_commandText, connection))
                {
                    _adapter = new SqlDataAdapter(command);            
                    command.Parameters.AddWithValue("@DateIssue", _dateIssue);
                    command.Parameters.AddWithValue("@TypeMachineID", _typeMachineID);
                    command.Parameters.AddWithValue("@Original_MachineID", _originalMachineID);
                    _adapter.Fill(this.dataSet1);
                    this.machineTableAdapter.Fill(this.dataSet1.Machine);
                    this.tableAdapterManager.UpdateAll(this.dataSet1);
                }
            }
            #region CatchExceptions
            catch (SqlException ex)
            {
                if (ex.Message.Contains("R_28"))
                {
                    MessageBox.Show("Создаваемая вами запись отсылается на несуществующую запись в таблице 'Type_Machine'");
                }
                if (ex.Message.Contains("ValidDateIssue"))
                {
                    MessageBox.Show("Вы указали неправильную дату! Отказ в операции");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("TypeMachineID"))
                {
                    MessageBox.Show("Вы не указали тип станка! Отказ в операции");
                }
                if (ex.Message.Contains("DateIssue"))
                {
                    MessageBox.Show("Вы не указали дату! Отказ в операции");
                }
            }
            #endregion
        }

        private void bindingNavigator(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.machineBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            #region CatchExceptions
            catch (SqlException)
            {
                MessageBox.Show("Удаляемая вами запись связана с записями в зависимой таблице 'Repair', поэтому удаление невозможно");
                this.machineTableAdapter.Fill(this.dataSet1.Machine);
            }
            #endregion
            _typeMachineID = Convert.ToInt32(typeMachineIDTextBox.Text);
            _commandText = "SELECT Description FROM BasicTypeMachineInformation where TypeMachineID = @TypeMachineID";
            using (SqlCommand thisCommand = connection.CreateCommand())
            {
                thisCommand.CommandText = _commandText;
                thisCommand.Parameters.AddWithValue("@TypeMachineID", _typeMachineID);
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
