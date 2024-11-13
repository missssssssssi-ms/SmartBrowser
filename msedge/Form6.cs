using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msedge
{
  public partial class Form6 : Form
  {
    private string OpenURL;
    public Form6()
    {
      InitializeComponent();
    }
    public Form6(string data)
    {
      InitializeComponent();
      OpenURL = data;
      Task task = InitializeAsync();
      webView21.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
    }
    async Task InitializeAsync()
    {
      await webView21.EnsureCoreWebView2Async(null);
      webView21.CoreWebView2.Navigate(OpenURL);
    }

    private void URL_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        try
        {
          this.webView21.Source = new System.Uri(URL.Text);
        }
        catch
        {
          if (!URL.Text.Contains(".co") && !URL.Text.Contains(".org") && !URL.Text.Contains(".jp") && !URL.Text.Contains(".net") && !URL.Text.Contains("http"))
          {
            this.webView21.Source = new System.Uri("https://www.google.com/search?q=" + URL.Text);
          }
          else
          {
            this.webView21.Source = new System.Uri("https://" + URL.Text);
          }
        }
      }
    }
    private void WebView_CoreWebView2InitializationCompleted(object sender, EventArgs e)
    {
      // 新しいウィンドウリクエストのイベントに登録
      webView21.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
    }
    private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
    {
      if (Inwindow.Checked)
      {

        //新しいウィンドウを開かなくする
        e.Handled = true;

        //元々のWebView2でリンク先を開く
        webView21.CoreWebView2.Navigate(e.Uri);
      }
      else
      {
        e.Handled = false;
      }
    }

    private void Tool_Click(object sender, EventArgs e)
    {
      Form5 form5 = new Form5();
      form5.Show();
    }

    private void Back_Click(object sender, EventArgs e)
    {
      webView21.GoBack();
    }

    private void Next_Click(object sender, EventArgs e)
    {
      webView21.GoForward();
    }
  }
}
