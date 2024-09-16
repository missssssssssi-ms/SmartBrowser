using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SmartBrowser
{
    public partial class Settings : Form
    {
#pragma warning disable IDE0044 // 読み取り専用修飾子を追加します
        private Form1 _parentForm;
        private Form1 _windowTitle;
#pragma warning restore IDE0044 // 読み取り専用修飾子を追加します
        public Settings(Form1 parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _windowTitle = parentForm;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SmartBrowser ©MS All Rights Reserved.");
        }

        private void Devtool_Click(object sender, EventArgs e)
        {
            _parentForm.OpenDevTool();
        }

        private void TopMain_CheckedChanged(object sender, EventArgs e)
        {
            if (TopMain.Checked)
            {
                _parentForm.TopON();
            }

            if (!TopMain.Checked)
            {
                _parentForm.TopOFF();
            }
        }

        private void TopSab_CheckedChanged(object sender, EventArgs e)
        {
            if (TopSab.Checked)
            {
                this.TopMost = true;
            }

            if (!TopSab.Checked)
            {
                this.TopMost = false;
            }

        }

        private void CustomCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!CustomCheck.Checked)
            {
                _windowTitle.Text = "チャット | Microsoft Teams - 個人 - Microsoft Edge";
            }
            if (CustomCheck.Checked)
            {
                _windowTitle.Text = CustomBox.Text;
            }
        }

        private void CustomOK_Click(object sender, EventArgs e)
        {
            _windowTitle.Text = CustomBox.Text;
        }
    }
}
