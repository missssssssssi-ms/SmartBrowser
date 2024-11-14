using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msedge
{
  public partial class Form1 : Form
  {

    // 初期設定の反映
    private bool SettingsChangetab = true;
    private bool SettingsKeymode = true;
    private bool? AppRun = null;
    private bool DevMode = false;
    private bool AlwaysDevMode = false;

    // 以下のコードでバージョンを指定
    public static string Version = "1.0.02";


    private NotifyIcon notifyIcon;
    private ContextMenuStrip contextMenu;


    public Form1()
    {
      // 起動
      InitializeComponent();
      this.Text = "Google - 個人 - Microsoft Edge";

      DownBar.Text = "起動中...";


      DevPanel.Visible = false;
      QuickBar.Visible = false;
      SettingTitle.Checked = true;


      contextMenu = new ContextMenuStrip();
      contextMenu.Items.Add("表示", null, Open_Click);
      contextMenu.Items.Add("終了", null, Exit_Click);

      this.KeyPreview = true;
      this.KeyDown += new KeyEventHandler(Form_KeyDown);


      notifyIcon = new NotifyIcon
      {
        Icon = new System.Drawing.Icon("icons\\4.ico"), // アイコンファイルを指定
        Text = "SmartBrowser - 起動中",
        ContextMenuStrip = contextMenu
      };

      webView2.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;


      Task task = InitializeAsync();

      DownBar.Text = "アプリの起動に成功｡";
      notifyIcon.Icon = new System.Drawing.Icon("icons\\2.ico");
      notifyIcon.Text = "SmartBrowser - 通常モード";

    }
    async Task InitializeAsync()
    {
      await webView2.EnsureCoreWebView2Async(null);
      webView2.CoreWebView2.SetVirtualHostNameToFolderMapping("start.pege", "pege", CoreWebView2HostResourceAccessKind.Allow);
      StartOpen();
    }
    private void StartOpen()
    {
      webView2.CoreWebView2.Navigate("https://start.pege/index.html");
      DownBar.Text = "webView2の起動に成功しました｡";
    }
    void Form1_Resize(object sender, EventArgs e)
    {
      if (this.WindowState == FormWindowState.Minimized)
      {
        if (SettingsChangetab)
        {
          MainTab.SelectedTab = SecretPage;
        }

      }
    }
    // ここからは､設定変更のコード
    /// 最小化時のタブ変更設定
    private void SettingCangetab_CheckedChanged(object sender, EventArgs e)
    {
      notifyIcon.Visible = true;
      if (SettingCangetab.Checked)
      {
        SettingsChangetab = true;
      }
      else
      {
        SettingsChangetab = false;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      SettingCangetab.Checked = true;
    }

    private void Showsidepanel1_Click(object sender, EventArgs e)
    {
      SidePanel1.Visible = true;
      Showsidepanel1.Enabled = false;
    }

    private void CloseSidepanel1_Click(object sender, EventArgs e)
    {
      SidePanel1.Visible = false;
      Showsidepanel1.Enabled = true;
    }

    private void Exit_Click(object sender, EventArgs e)
    {
      notifyIcon.Visible = false; // トレイアイコンを非表示にする
      Application.Exit(); // アプリケーションを終了

    }
    private void Open_Click(object sender, EventArgs e)
    {
      this.Show();
      this.WindowState = FormWindowState.Normal;
      notifyIcon.Text = "SmartBrowser - 実行中";
      this.ShowInTaskbar = true;
    }

    private void SettingNoshowtaskber_CheckedChanged(object sender, EventArgs e)
    {
      if (SettingNoshowtaskber.Checked)
      {
        this.ShowInTaskbar = false;
        notifyIcon.Visible = true;
        contextMenu.Items.Add("タスクバーに表示する", null, ShowTaskbar_Click);
        notifyIcon.Icon = new System.Drawing.Icon("icons\\7.ico");
        notifyIcon.Text = "SmartBrowser - 通常モード(タスクバー非表示)";
      }
      else
      {
        this.ShowInTaskbar = true;
        foreach (ToolStripItem item in contextMenu.Items)
        {
          if (item.Text == "タスクバーに表示する")
          {
            contextMenu.Items.Remove(item);
            break; // 削除後、ループを抜ける
          }
        }
        notifyIcon.Icon = new System.Drawing.Icon("icons\\2.ico");
        notifyIcon.Text = "SmartBrowser - 通常モード";
      }
    }
    private void ShowTaskbar_Click(object sender, EventArgs e)
    {
      this.ShowInTaskbar = true;
      SettingNoshowtaskber.Checked = false;
      foreach (ToolStripItem item in contextMenu.Items)
      {
        if (item.Text == "タスクバーに表示する")
        {
          contextMenu.Items.Remove(item);
          break; // 削除後、ループを抜ける
        }
      }
      notifyIcon.Icon = new System.Drawing.Icon("icons\\2.ico");
      notifyIcon.Text = "SmartBrowser - 通常モード";
    }

    private void SettingTop_CheckedChanged(object sender, EventArgs e)
    {
      if (SettingTop.Checked)
      {
        this.TopMost = true;
      }
      else
      {
        this.TopMost = false;
      }
    }

    private void SettingKyemode_CheckedChanged(object sender, EventArgs e)
    {
      if (Settingkeymode.Checked)
      {
        SettingsKeymode = true;
        MessageBox.Show("Escキーで最小化にできます｡");
      }
      else
      {
        DialogResult dialog = MessageBox.Show("続行しますか?", "名前の変更", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (dialog == DialogResult.Yes)
        {
          // キーボードショートカットを無効化
          SettingsKeymode = false;

        }
        else if (dialog == DialogResult.No)
        {

          Settingkeymode.Checked = true;
          MessageBox.Show("処理はキャンセルされました｡");
        }
      }
    }
    private void Form_KeyDown(object sender, KeyEventArgs e)
    {
      // メニューキーが押されたか確認

    }

    private void SettingDev_CheckedChanged(object sender, EventArgs e)
    {
      if (SettingDev.Checked)
      {
        if (AlwaysDevMode)
        {
          DevPanel.Visible = true;
        }
        else
        {
          DialogResult dialog = MessageBox.Show("続行しますか?アプリが不安定になる場合があります｡", "名前の変更", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

          if (dialog == DialogResult.Yes)
          {
            // DevModeを有効化
            DevPanel.Visible = true;
            DevMode = true;
            DownBar.Text = "DevModeは有効です｡";

          }
          else if (dialog == DialogResult.No)
          {

            Settingkeymode.Checked = true;
            MessageBox.Show("処理はキャンセルされました｡");
          }
        }
      }
      else
      {
        if (AlwaysDevMode)
        {
          DevPanel.Visible = false;
        }
        else
        {
          DialogResult dialog = MessageBox.Show("続行しますか?一部の機能が制限されます｡", "名前の変更", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

          if (dialog == DialogResult.Yes)
          {
            // DevModeを有効化
            DevPanel.Visible = false;
            DevMode = false;

          }
          else if (dialog == DialogResult.No)
          {

            Settingkeymode.Checked = true;
            MessageBox.Show("処理はキャンセルされました｡");
          }
        }
      }
    }

    private void AlwaysDev_CheckedChanged(object sender, EventArgs e)
    {
      if (AlwaysDev.Checked)
      {
        AlwaysDevMode = true;
        DownBar.Text = "AlwaysDevModeが有効です｡";
      }
      else
      {
        AlwaysDevMode = false;
      }
    }

    private void BtnGo_Click(object sender, EventArgs e)
    {
      try
      {
        this.webView2.Source = new System.Uri(URL.Text);
        DownBar.Text = "フルURLモードで開きます｡";
      }
      catch
      {
        if (!URL.Text.Contains(".co") && !URL.Text.Contains(".org") && !URL.Text.Contains(".jp") && !URL.Text.Contains(".net") && !URL.Text.Contains("http"))
        {
          this.webView2.Source = new System.Uri("https://www.google.com/search?q=" + URL.Text);
          DownBar.Text = "Google検索モードで開きます｡";
        }
        else
        {
          this.webView2.Source = new System.Uri("https://" + URL.Text);
          DownBar.Text = "簡易URLモードで開きます｡";
        }
      }
    }

    private void NotX_CheckedChanged(object sender, EventArgs e)
    {
      if (NotX.Checked)
      {
        this.ControlBox = false;

      }
      else
      {
        this.ControlBox = true;
      }
    }

    private void SettingOpenthis_CheckedChanged(object sender, EventArgs e)
    {
      if (!SettingOpenthis.Checked)
      {
        DialogResult dialog = MessageBox.Show("新しいウィンドウで開くと､タイトルを変更できません｡", "名前の変更", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (dialog == DialogResult.No)
        {
          SettingOpenthis.Checked = true;
        }
      }
    }
    private void WebView_CoreWebView2InitializationCompleted(object sender, EventArgs e)
    {
      // 新しいウィンドウリクエストのイベントに登録
      webView2.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
    }

    private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
    {
      if (SettingOpenthis.Checked)
      {

        //新しいウィンドウを開かなくする
        e.Handled = true;

        //元々のWebView2でリンク先を開く
        webView2.CoreWebView2.Navigate(e.Uri);
        DownBar.Text = "新しいウィンドウを開くのを停止しました｡";
      }
      else
      {
        e.Handled = false;
        DownBar.Text = "新しいウィンドウを開きます｡";
      }
    }

    private void VSCode_Click(object sender, EventArgs e)
    {
      Form2 form2 = new Form2();
      form2.Show();
    }

    private void Htmltest_Click(object sender, EventArgs e)
    {
      this.webView2.Source = new System.Uri("https://web.biz-prog.net/test/testpage.html");
    }

    private void BtnBack_Click(object sender, EventArgs e)
    {
      try
      {
        this.webView2.GoBack();
      }
      catch
      {
        DownBar.Text = "ERROR:元に戻れませんでした｡";
      }
    }

    private void BtnNext_Click(object sender, EventArgs e)
    {
      try
      {
        this.webView2.GoForward();
      }
      catch
      {
        DownBar.Text = "ERROR:進めませんでした｡";
      }
    }

    private void Reboot_Click(object sender, EventArgs e)
    {
      notifyIcon.Icon = new System.Drawing.Icon("icons\\3.ico");
      notifyIcon.Text = "SmartBrowser - 再起動中...";
      Application.Restart();  // アプリを再起動
      Application.Exit();      // 現在のアプリを終了
    }

    private void DevReload_Click(object sender, EventArgs e)
    {
      this.webView2.Reload();
    }

    private void DevStop_Click(object sender, EventArgs e)
    {
      this.webView2.Stop();

    }

    private void OpenQuickBar_Click(object sender, EventArgs e)
    {
      if (!QuickBar.Visible)
      {
        QuickBar.Visible = true;
      }
      else
      {
        QuickBar.Visible = false;
      }
    }

    private void WebView2_Click(object sender, EventArgs e)
    {
      if (QuickBar.Visible)
      {
        QuickBar.Visible = false;
      }
    }

    private void webView2_MouseClick(object sender, MouseEventArgs e)
    {
      if (QuickBar.Visible)
      {
        QuickBar.Visible = false;
      }
    }

    private void Home_Click(object sender, EventArgs e)
    {
      webView2.CoreWebView2.Navigate("https://www.google.com/");
    }

    private void SettingTitle_CheckedChanged(object sender, EventArgs e)
    {
      if (SettingTitle.Checked)
      {
        TitleOption.Visible = true;
      }
      else
      {
        TitleOption.Visible = false;
      }
    }


    private void TitleSys_CheckedChanged(object sender, EventArgs e)
    {
      if (TitleUser.Checked)
      {
        TitleUser.Checked = false;
      }
      // 以降は､繰り返し実行されるコード｡条件によって変化する｡

    }

    private void TitleUser_CheckedChanged(object sender, EventArgs e)
    {
      if (TitleSys.Checked)
      {
        TitleSys.Checked = false;
      }

    }

    private void About_Click(object sender, EventArgs e)
    {
      Form3 form3 = new Form3();
      form3.Show();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        e.SuppressKeyPress = true;
        if (SettingsKeymode)
        {
          if (SettingAutomute.Checked)
          {
            var enumerator = new MMDeviceEnumerator();

            // デフォルトのオーディオ再生デバイスを取得
            var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

            // 音量を 0 に設定
            device.AudioEndpointVolume.MasterVolumeLevelScalar = 0.0f;
          }
          this.WindowState = FormWindowState.Minimized; // ウィンドウを最小化
          this.ShowInTaskbar = false;
          notifyIcon.Visible = true;
          notifyIcon.Icon = new System.Drawing.Icon("icons\\6.ico");
          notifyIcon.Text = "SmartBrowser - 緊急モード";
        }
      }
    }

    private void OpenLinkYT_Click(object sender, EventArgs e)
    {
      webView2.CoreWebView2.Navigate("https://youtube.com/");
    }

    private void OpenLinkGAME_Click(object sender, EventArgs e)
    {
      webView2.CoreWebView2.Navigate("https://game16.net/");
    }

    private void OpenGithub_Click(object sender, EventArgs e)
    {
      webView2.CoreWebView2.Navigate("https://github.com/missssssssssi-ms");
    }

    private void ToolBtn_Click(object sender, EventArgs e)
    {
      Form5 form5 = new Form5();
      form5.Show();
    }

    private void URL_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        try
        {
          this.webView2.Source = new System.Uri(URL.Text);
          DownBar.Text = "フルURLモードで開きます｡";
        }
        catch
        {
          if (!URL.Text.Contains(".co") && !URL.Text.Contains(".org") && !URL.Text.Contains(".jp") && !URL.Text.Contains(".net") && !URL.Text.Contains("http"))
          {
            this.webView2.Source = new System.Uri("https://www.google.com/search?q=" + URL.Text);
            DownBar.Text = "Google検索モードで開きます｡";
          }
          else
          {
            this.webView2.Source = new System.Uri("https://" + URL.Text);
            DownBar.Text = "簡易URLモードで開きます｡";
          }
        }
      }
    }
  }
}