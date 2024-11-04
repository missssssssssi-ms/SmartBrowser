using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msedge
{
  public partial class Form3 : Form
  {
    public Form4 form4;
    public Form3()
    {
      InitializeComponent();
      
    }


    public void OpenUpdate_Click(object sender, EventArgs e)
    {
      string dataToSend = "https://github.com/missssssssssi-ms/SmartBrowser/releases"; // 送信したいデータ
      Form4 form4 = new Form4(dataToSend);
      form4.Show();
    }

    private void OpenGithub_Click(object sender, EventArgs e)
    {
      string dataToSend = "https://github.com/missssssssssi-ms/SmartBrowser"; // 送信したいデータ
      Form4 form4 = new Form4(dataToSend);
      form4.Show();
    }

    private void OpenFeedBack_Click(object sender, EventArgs e)
    {
      string dataToSend = "https://forms.office.com/r/1U8vibYuxn"; // 送信したいデータ
      Form4 form4 = new Form4(dataToSend);
      form4.Show();
    }

    private void Close_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
