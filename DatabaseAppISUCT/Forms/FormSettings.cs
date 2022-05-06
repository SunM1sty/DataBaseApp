using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace DatabaseAppISUCT
{
    public partial class FormSettings : MaterialForm
    {
        static MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        public FormSettings()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked)
            {
                if(ThemeManager.Theme == MaterialSkinManager.Themes.LIGHT)
                {
                    ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
                }
                else
                {
                    ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
                }
            }
            else
            {
                if (ThemeManager.Theme == MaterialSkinManager.Themes.LIGHT)
                {
                    ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
                }
                else
                {
                    ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
                }
            }
        }
    }
}
