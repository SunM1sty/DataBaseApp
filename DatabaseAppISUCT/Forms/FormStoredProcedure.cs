using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;

namespace DatabaseAppISUCT
{
    public partial class FormStoredProcedure : MaterialForm
    {
        static string _connection = "Data Source=DESKTOP-TT3J386\\SQLEXPRESS;Initial Catalog=machine;Persist Security Info=True;User ID=M1sty;Password=5uJ63SpXER";

        public FormStoredProcedure()
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
                    comboBox2.DataSource = this.dataSet1.BasicTypeRepairInformation;
                    comboBox2.DisplayMember = "Description";
                    comboBox2.ValueMember = "TypeRepairID";
                }
                string anotherCommand = "Select * from AllMachineData";
                using (SqlCommand secondCommand = new SqlCommand(anotherCommand, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(secondCommand);
                    adapter.Fill(this.dataSet1.AllMachineData);
                    comboBox1.DataSource = this.dataSet1.AllMachineData;
                    comboBox1.DisplayMember = "Description";
                    comboBox1.ValueMember = "MachineID";
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
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Number}");
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
        private void FormStoredProcedure_Load(object sender, EventArgs e)
        {
            this.repairTableAdapter.Fill(this.dataSet1.Repair);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var machineId = Convert.ToInt32(comboBox2.SelectedValue);
                var typeMachineId = Convert.ToInt32(comboBox1.SelectedValue);
                var dateStartId = Convert.ToDateTime(dateStartDateTimePicker.Text);
                this.repairTableAdapter.FillBy(this.dataSet1.Repair, machineId, typeMachineId, dateStartId);
                this.repairTableAdapter.Fill(this.dataSet1.Repair);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("R_26"))
                {
                    MessageBox.Show("Вы указали неверные данные в поле 'TypeRepairID' - такой записи не существует!");
                }
                if (ex.Message.Contains("R_27"))
                {
                    MessageBox.Show("Вы указали неверные данные в поле 'MachineID' - такой записи не существует!");
                }
                this.repairTableAdapter.Fill(this.dataSet1.Repair);
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

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            bindingNavigator(sender, e);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            bindingNavigator(sender, e);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            bindingNavigator(sender, e);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            bindingNavigator(sender, e);
        }
    }
}
