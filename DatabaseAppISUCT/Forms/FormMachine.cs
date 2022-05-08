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
        static string _connection = "Data Source=DESKTOP-TT3J386\\SQLEXPRESS;Initial Catalog=machine;Persist Security Info=True;User ID=M1sty;Password=5uJ63SpXER";

        public FormMachine()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            if (FormSettings.ThemeManager.Theme == MaterialSkinManager.Themes.DARK)
            {
                this.machineDataGridView.ForeColor = Color.Black;
            }
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                string commText = "SELECT * FROM BasicTypeMachineInformation";
                using (SqlCommand firstCommand = new SqlCommand(commText, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(firstCommand);
                    adapter.Fill(this.dataSet1.BasicTypeMachineInformation);
                    comboBox1.DataSource = this.dataSet1.BasicTypeMachineInformation;
                    comboBox1.DisplayMember = "Description";
                    comboBox1.ValueMember = "TypeMachineID";
                }
            }
        }

        private void machineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.machineBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (SqlException)
            {
            MessageBox.Show("Удаляемая вами запись связана с записями в зависимой таблице 'Repair', поэтому удаление невозможно");
            this.machineTableAdapter.Fill(this.dataSet1.Machine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.machineTableAdapter.Fill(this.dataSet1.Machine);
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

        private void FormMachine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Repair' table. You can move, or remove it, as needed.
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
                var dateIssue = Convert.ToInt32(dateIssueTextBox.Text);
                var typeMachineID = Convert.ToInt32(comboBox1.SelectedValue);
                this.machineTableAdapter.InsertQuery(dateIssue, typeMachineID);
                this.machineTableAdapter.Fill(this.dataSet1.Machine);
            }
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var dateIssue = Convert.ToInt32(dateIssueTextBox.Text);
                var typeMachineID = Convert.ToInt32(comboBox1.SelectedValue);
                var originalMachineID = Convert.ToInt32(machineIDTextBox.Text);
                using (SqlConnection connection = new SqlConnection(_connection))
                {
                    connection.Open();
                    string commText = "UPDATE [dbo].[Machine] SET [DateIssue] = @DateIssue, [TypeMachineID] = @TypeMachineID WHERE [MachineID] = @Original_MachineID";
                    using (SqlCommand command = new SqlCommand(commText, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);            
                        command.Parameters.AddWithValue("@DateIssue",dateIssue);
                        command.Parameters.AddWithValue("@TypeMachineID", typeMachineID);
                        command.Parameters.AddWithValue("@Original_MachineID", originalMachineID);
                        adapter.Fill(this.dataSet1);
                        this.machineTableAdapter.Fill(this.dataSet1.Machine);
                        this.tableAdapterManager.UpdateAll(this.dataSet1);
                    }
                }
            }
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
        }

        private void bindingNavigator(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                var typeMachineID = Convert.ToInt32(typeMachineIDTextBox.Text);
                string commText = "SELECT Description FROM BasicTypeMachineInformation where TypeMachineID = @TypeMachineID";
                using (SqlCommand thisCommand = connection.CreateCommand())
                {
                    thisCommand.CommandText = commText;
                    thisCommand.Parameters.AddWithValue("@TypeMachineID", typeMachineID);
                    SqlDataReader reader = thisCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox1.Text = reader["Description"].ToString();
                    }
                }
            }
        }
    }
}
