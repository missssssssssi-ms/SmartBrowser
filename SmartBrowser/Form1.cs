using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UrlBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Webview.Source = new System.Uri(UrlBox.Text);
            }
        }

        private void HyperS_CheckedChanged(object sender, EventArgs e)
        {
            // ハイパーセキュリティモードの有効化､無効化
            if (HyperS.Checked)
            { 
                Webview.CoreWebView2.Settings.IsScriptEnabled = false;
                MessageBox.Show("高度な保護が有効です｡");
            }

            if (!HyperS.Checked)
            {
                Webview.CoreWebView2.Settings.IsScriptEnabled = true ;
                MessageBox.Show("高度な保護が無効です｡");
            }
        }

        private void OpenSettings_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings( this );
            Settings.Show();
        }
        public void OpenDevTool()
        {
            if (Webview.CoreWebView2 != null)
            {
                Webview.CoreWebView2.OpenDevToolsWindow();
            }
        }
        public void TopON()
        {
            this.TopMost = true;
        }
        public void TopOFF()
        {
            this .TopMost = false;
        }
        public async void InitializeAsync()
        {
            await Webview.EnsureCoreWebView2Async(null);
            Webview.CoreWebView2.NewWindowRequested += NewWindowRequested;
        }

        private void NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            //新しいウィンドウを開かなくする
            e.Handled = true;

            //元々のWebView2でリンク先を開く
            Webview.CoreWebView2.Navigate(e.Uri);
        }

    }
}
