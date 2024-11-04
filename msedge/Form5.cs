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
  public partial class Form5 : Form
  {
    public Form4 form4;
    public Form5()
    {
      InitializeComponent();
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void AboutBtn_Click(object sender, EventArgs e)
    {
      Form3 form3 = new Form3();
      form3.Show();
    }

    private void OpenWindow_Click(object sender, EventArgs e)
    {
      string dataToSend = "https://" + URLBox.Text; // 送信したいデータ
      Form4 form4 = new Form4(dataToSend);
      form4.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string dataToSend = "https://github.com/missssssssssi-ms/SmartBrowser/wiki"; // 送信したいデータ
      Form4 form4 = new Form4(dataToSend);
      form4.Show();
    }
  }
}
