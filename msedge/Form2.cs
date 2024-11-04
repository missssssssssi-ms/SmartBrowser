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
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
      Task task = InitializeAsync();

    }
    async Task InitializeAsync()
    {
      await Vscode.EnsureCoreWebView2Async(null);
      Vscode.CoreWebView2.Navigate("https://vscode.dev");
    }
  }
}
