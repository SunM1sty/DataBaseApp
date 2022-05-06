using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatabaseAppISUCT
{
    public partial class FormTypeRepair : MaterialForm
    {
        public FormTypeRepair()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        private void type_RepairBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.type_RepairBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (Exception)
            {
                MessageBox.Show("Удаляемая вами запись связана с записями в зависимой таблице 'Repair', поэтому удаление невозможно");
                this.type_RepairTableAdapter.Fill(this.dataSet1.Type_Repair);
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

        private void FormTypeRepair_Load(object sender, EventArgs e)
        {
            this.type_RepairTableAdapter.Fill(this.dataSet1.Type_Repair);
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            type_RepairBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                type_RepairBindingSource.EndEdit();
                type_RepairTableAdapter.Update(dataSet1);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Name"))
                {
                    MessageBox.Show("Необходимо указывать Название, Nulls не разрешены");
                }
            }
        }
    }
}
