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
                repairBindingSource.EndEdit();
                repairTableAdapter.Update(dataSet1);
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
    }
}
