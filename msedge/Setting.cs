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
  public partial class Setting : Form
  {

    public Setting()
    {
      InitializeComponent();
      // 設定==>UIを呼び出し
      LoadSettings();
    }
     private void LoadSettings()
    {
      // 設定==>UIにするコード
      // 例
      //   Checkbox.Checked = Form1.Setting1;
      //   Textbox.Text     = Form1.Setting2.Text;
      NoNewSite.Checked = Form1.NONEWSITE;
      OpenThis.Checked = Form1.OPENTHIS;
      AuteMute.Checked = Form1.AUTOMUTE;
      ChangeTab.Checked = Form1.CHANGETAB;
      NoTaskBar.Checked = Form1.NOTASKBAR;
      Top.Checked = Form1.TOP;
      NoClose.Checked = Form1.NOCLOSE;
      ecm.Checked = Form1.ECM;
      ModeON.Checked = Form1.MODEON;
      DevMode.Checked = Form1.DEVMODE;
    }
    private void CancelButton_Click(object sender, EventArgs e)
    {
      DownBarText.Text = "キャンセルします｡";
      this.Close();
    }

    private void OKButton_Click(object sender, EventArgs e)
    {
      // ここでUI==>設定に保存し閉じる
      // 例
      //  Setting1 = CheckBox.Checked;
      Form1.NONEWSITE = NoNewSite.Checked;
      Form1.OPENTHIS = OpenThis.Checked;
      Form1.AUTOMUTE = AuteMute.Checked;
      Form1.CHANGETAB = ChangeTab.Checked;
      Form1.NOTASKBAR = NoTaskBar.Checked;
      Form1.TOP = Top.Checked;
      Form1.NOCLOSE = NoClose.Checked;
      Form1.ECM = ecm.Checked;
      Form1.MODEON = ModeON.Checked;
      Form1.DEVMODE = DevMode.Checked;
      Close();
    }
  }
}
