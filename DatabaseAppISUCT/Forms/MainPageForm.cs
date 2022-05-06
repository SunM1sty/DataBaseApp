using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatabaseAppISUCT
{
    public partial class MainPageForm : Form
    {
        #region Fields
        private Button _currentButton;
        private Random _random = new Random();
        private int _tempIndex;
        private Form _activeForm;
        #endregion

        public MainPageForm()
        {
            InitializeComponent();
            btnCloseChildeForm.Visible = false;
        }

        private Color SelectThemeColor()
        {
            int index = _random.Next(ThemeColor.ColorsList.Count);
            while (_tempIndex == index)
            {
                index = _random.Next(ThemeColor.ColorsList.Count);
            }
            _tempIndex = index;
            string color = ThemeColor.ColorsList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    _currentButton = (Button)btnSender;
                    _currentButton.BackColor = color;
                    _currentButton.ForeColor = Color.White;
                    _currentButton.Font = new Font("Leelawadee UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelTopMenu.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildeForm.Visible = true;

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildeForm(Form childeForm, object btnSender)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            ActivateButton(btnSender);
            _activeForm = childeForm;
            childeForm.TopLevel = false;
            childeForm.FormBorderStyle = FormBorderStyle.None;
            childeForm.Dock = DockStyle.Fill;
            this.panelChilde.Controls.Add(childeForm);
            this.panelChilde.Tag = childeForm;
            childeForm.BringToFront();
            childeForm.Show();
            labelTopicTilte.Text = childeForm.Text;
        }


        private void btnMachine_Click(object sender, EventArgs e)
        {
            OpenChildeForm(new FormMachine(), sender);
        }

        private void btnTypeMachine_Click(object sender, EventArgs e)
        {
            OpenChildeForm(new FormTypeMachine(), sender);
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            OpenChildeForm(new FormRepair(), sender);
        }

        private void btnTypeRepair_Click(object sender, EventArgs e)
        {
            OpenChildeForm(new FormTypeRepair(), sender);
        }

        private void btnStoredProcedure_Click(object sender, EventArgs e)
        {
            OpenChildeForm(new FormStoredProcedure(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildeForm(new FormSettings(), sender);
        }

        private void btnCloseChildeForm_Click(object sender, EventArgs e)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            labelTopicTilte.Text = "Home";
            panelTitleBar.BackColor = Color.FromArgb(39, 39, 58);
            panelTopMenu.BackColor = Color.FromArgb(39, 39, 58);
            _currentButton = null;
            btnCloseChildeForm.Visible = false;
        }
    }
}

