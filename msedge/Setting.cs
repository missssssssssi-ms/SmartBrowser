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

    // 以降のコードで,設定項目を追加
    // 例
    //   public static bool <NAME> { get; set; }
    // テーマタブ
    public static bool NONEWSITE { get; set; }
    public static bool OPENTHIS {  get; set; }
    public static bool AUTOMUTE { get; set; }
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
      //   Checkbox.Checked = Setting1;
      //   Textbox.Text     = Setting2.Text;
      NoNewSite.Checked = NONEWSITE;
      OpenThis.Checked = OPENTHIS;
      AuteMute.Checked = AUTOMUTE;
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
      NONEWSITE = NoNewSite.Checked;
      OPENTHIS = OpenThis.Checked;
      AUTOMUTE = AuteMute.Checked;
      Close();
    }
  }
}
