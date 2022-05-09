using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DatabaseAppISUCT
{
    public partial class FormTypeMachine : MaterialForm
    { 
        public FormTypeMachine()
        {
            InitializeComponent();
            #region UISettings
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            if (FormSettings.ThemeManager.Theme == MaterialSkinManager.Themes.DARK)
            {
                this.type_MachineDataGridView.ForeColor = Color.Black;
            }
            #endregion
        }

        private void type_MachineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.type_MachineBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            #region CatchingExceptions
            catch (SqlException)
            {
                MessageBox.Show("Удаляемая вами запись связана с записями в зависимой таблице 'Machine', поэтому удаление невозможно");
                this.type_MachineTableAdapter.Fill(this.dataSet1.Type_Machine);
            }
            #endregion
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

        private void FormTypeMachine_Load(object sender, EventArgs e)
        {
            this.type_MachineTableAdapter.Fill(this.dataSet1.Type_Machine);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            type_MachineBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                type_MachineBindingSource.EndEdit();
                type_MachineTableAdapter.Update(dataSet1);
            }
            #region CatchingExceptions
            catch (Exception ex)
            {
                if (ex.Message.Contains("Brand"))
                {
                    MessageBox.Show("Необходимо указывать Бренд, Nulls не разрешены");
                }
            }
            #endregion
        }
    }
}
