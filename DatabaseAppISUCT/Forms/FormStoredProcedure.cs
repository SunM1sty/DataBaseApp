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
        public FormStoredProcedure()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
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
                var machineId = Convert.ToInt32(machineIDTextBox.Text);
                var typeMachineId = Convert.ToInt32(typeRepairIDTextBox.Text);
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
    }
}
