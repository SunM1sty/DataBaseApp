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
                machineBindingSource.EndEdit();
                machineTableAdapter.Update(dataSet1);
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
    }
}
