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
        static string _connection = "Data Source=DESKTOP-TT3J386\\SQLEXPRESS;Initial Catalog=machine;Persist Security Info=True;User ID=M1sty;Password=5uJ63SpXER";

        public FormRepair()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            if (FormSettings.ThemeManager.Theme == MaterialSkinManager.Themes.DARK)
            {
                this.repairDataGridView.ForeColor = Color.Black;
            }
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                string commText = "SELECT * FROM BasicTypeRepairInformation";
                using (SqlCommand firstCommand = new SqlCommand(commText, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(firstCommand);
                    adapter.Fill(this.dataSet1.BasicTypeRepairInformation);
                    comboBox1.DataSource = this.dataSet1.BasicTypeRepairInformation;
                    comboBox1.DisplayMember = "Description";
                    comboBox1.ValueMember = "TypeRepairID";
                }
                string anotherCommand = "Select * from AllMachineData";
                using (SqlCommand secondCommand = new SqlCommand(anotherCommand, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(secondCommand);
                    adapter.Fill(this.dataSet1.AllMachineData);
                    comboBox2.DataSource = this.dataSet1.AllMachineData;
                    comboBox2.DisplayMember = "Description";
                    comboBox2.ValueMember = "MachineID";
                }
            }
        }

        private void repairBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.repairBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.repairTableAdapter.Fill(this.dataSet1.Repair);
            }
        }
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
                var dateStart = Convert.ToDateTime(dateStartDateTimePicker.Text);
                var dateEnd = Convert.ToDateTime(endDateDateTimePicker.Text);
                var typeRepairID = Convert.ToInt32(comboBox1.SelectedValue);
                var machineID = Convert.ToInt32(comboBox2.SelectedValue);
                this.repairTableAdapter.InsertQuery(dateStart, typeRepairID, machineID, dateEnd);
                this.repairTableAdapter.Fill(this.dataSet1.Repair);
            }
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
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                var dateStart = Convert.ToDateTime(dateStartDateTimePicker.Text);
                var dateEnd = Convert.ToDateTime(endDateDateTimePicker.Text);
                var typeRepairID = Convert.ToInt32(comboBox1.SelectedValue);
                var machineID = Convert.ToInt32(comboBox2.SelectedValue);
                var repairID = Convert.ToInt32(repairIDTextBox.Text);
                using (SqlConnection connection = new SqlConnection(_connection))
                {
                    connection.Open();
                    string commText = "UPDATE [dbo].[Repair] SET [DateStart] = @DateStart, [TypeRepairID] = @TypeRepairID, [MachineID] = @MachineID, [EndDate] = @EndDate WHERE [RepairID] = @Original_RepairID";
                    using (SqlCommand command = new SqlCommand(commText, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        command.Parameters.AddWithValue("@DateStart", dateStart);
                        command.Parameters.AddWithValue("@TypeRepairID", typeRepairID);
                        command.Parameters.AddWithValue("@Original_RepairID", repairID);
                        command.Parameters.AddWithValue("@MachineID", machineID);
                        command.Parameters.AddWithValue("@EndDate", dateEnd);
                        adapter.Fill(this.dataSet1.Repair);
                        this.repairTableAdapter.Fill(this.dataSet1.Repair);
                    }
                }
            }
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
        }

        private void bindingNavigator(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                var machineID = Convert.ToInt32(machineIDTextBox.Text);
                string commText = "SELECT Description FROM AllMachineData where MachineID = @MachineID";
                using (SqlCommand thisCommand = connection.CreateCommand())
                {
                    thisCommand.CommandText = commText;
                    thisCommand.Parameters.AddWithValue("@MachineID", machineID);
                    SqlDataReader reader = thisCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox2.Text = reader["Description"].ToString();
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                var typeRepairID = Convert.ToInt32(typeRepairIDTextBox.Text);
                string commText = "SELECT Description FROM BasicTypeRepairInformation where TypeRepairID = @TypeRepairID";
                using (SqlCommand thisCommand = connection.CreateCommand())
                {
                    thisCommand.CommandText = commText;
                    thisCommand.Parameters.AddWithValue("@TypeRepairID", typeRepairID);
                    SqlDataReader reader = thisCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox1.Text = reader["Description"].ToString();
                    }
                }
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            bindingNavigator(sender, e);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            bindingNavigator(sender, e);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            bindingNavigator(sender, e);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            bindingNavigator(sender, e);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bindingNavigator(sender, e);
        }
    }
}
