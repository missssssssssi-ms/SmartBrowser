using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msedge
{
  public partial class Form4 : Form
  {
    private string OpenURL;
    string ver=Form1.Version;
    bool uc = Form3.checkver;
    public Form4()
    {
      InitializeComponent();

      
    }
    public Form4(string data)
    {
      InitializeComponent();
      OpenURL = data;
      Task task = InitializeAsync();
    }

    async Task InitializeAsync()
    {
      await webView21.EnsureCoreWebView2Async(null);
      if (uc)
      {
        Ver.Text = "現在のバージョン:" + ver;
        Form3.checkver = false;
      }
      else
      {
        Ver.Visible = false;
      }
      webView21.CoreWebView2.Navigate(OpenURL);
    }
  }
}
