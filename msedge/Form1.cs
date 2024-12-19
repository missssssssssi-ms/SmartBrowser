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

    // 以下のコードでバージョンを指定
    public static string Version = "1.1.00";

    // 設定の変数
    public static bool NONEWSITE { get; set; }
    public static bool OPENTHIS { get; set; }
    public static bool AUTOMUTE { get; set; }
    public static bool CHANGETAB { get; set; }
    public static bool NOTASKBAR { get; set; } = true;
    public static bool TOP { get; set; }
    public static bool NOCLOSE { get; set; }
    public static bool ECM { get; set; }
    public static bool MODEON { get; set; } = true;


    private NotifyIcon notifyIcon;
    private ContextMenuStrip contextMenu;
    private void LoadSetting()
    {
      if (NOTASKBAR)
      {
        ShowInTaskbar = false;
      }
      else
      {
        ShowInTaskbar = true;
      }
      if (TOP)
      {
        TopMost = true;
      }
      else
      {
        TopMost = false;
      }
    }
    public Form1()
    {
      // 起動
      InitializeComponent();
      this.Text = "Google - 個人 - Microsoft Edge";
      LoadSetting();

      DownBar.Text = "起動中...";


      DevPanel.Visible = false;
      QuickBar.Visible = false;

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
      notifyIcon.Visible = true;

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
        if (CHANGETAB)
        {
          MainTab.SelectedTab = SecretPage;
        }

      }
    }
    // ここからは､設定変更のコード
    /// 最小化時のタブ変更設定

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void Showsidepanel1_Click(object sender, EventArgs e)
    {
      using (var settingsForm = new Setting())
      {
        if (settingsForm.ShowDialog() != DialogResult.OK)
        {
          // 設定が保存された場合の処理
          LoadSetting();
        }
      }
    }

    private void CloseSidepanel1_Click(object sender, EventArgs e)
    {
      SidePanel1.Visible = false;
      Showsidepanel1.Enabled = true;
    }

    private void Exit_Click(object sender, EventArgs e)
    {
      NOCLOSE = false;
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
    private void Form_KeyDown(object sender, KeyEventArgs e)
    {

    }

    private void SettingDev_CheckedChanged(object sender, EventArgs e)
    {
      if (SettingDev.Checked)
      {
        DialogResult dialog = MessageBox.Show("続行しますか?アプリが不安定になる場合があります｡", "名前の変更", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (dialog == DialogResult.Yes)
        {
          // DevModeを有効化
          DevPanel.Visible = true;
          DownBar.Text = "DevModeは有効です｡";

        }
        else if (dialog == DialogResult.No)
        {
          MessageBox.Show("処理はキャンセルされました｡");
          SettingDev.Checked = false;
        }
      }
      else
      {

        DialogResult dialog = MessageBox.Show("続行しますか?一部の機能が制限されます｡", "名前の変更", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (dialog == DialogResult.Yes)
        {
          // DevModeを無効化
          DevPanel.Visible = false;

        }
        else if (dialog == DialogResult.No)
        {
          MessageBox.Show("処理はキャンセルされました｡");
          SettingDev.Checked = true;
        }
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
    private void WebView_CoreWebView2InitializationCompleted(object sender, EventArgs e)
    {
      // 新しいウィンドウリクエストのイベントに登録
      webView2.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
    }

    private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
    {
      if (NONEWSITE)
      {
        e.Handled = true;
        DownBar.Text = "Webサイトを開くのを停止しました。";
      }
      else
      {
        if (OPENTHIS)
        {

          //新しいウィンドウを開かなくする
          e.Handled = true;

          //元々のWebView2でリンク先を開く
          webView2.CoreWebView2.Navigate(e.Uri);
          DownBar.Text = "新しいウィンドウを開くのを停止しました｡";
        }
        else
        {
          if (!ECM)
          {
            e.Handled = true;
            string dataToSend = e.Uri; // 送信したいデータ
            Form4 form4 = new Form4(dataToSend);
            form4.Show();
            DownBar.Text = "新しいウィンドウを開きます｡";
          }
          else
          {
            e.Handled = true;
            string dataToSend = e.Uri; // 送信したいデータ
            Form6 form6 = new Form6(dataToSend);
            form6.Show();
            DownBar.Text = "新しいウィンドウを開きます｡";
          }
        }
      }
    }

    private void VSCode_Click(object sender, EventArgs e)
    {
      string dataToSend = "https://vscode.dev"; // 送信したいデータ
      Form4 form4 = new Form4(dataToSend);
      form4.Show();
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
        if (MODEON)
        {
          if (AUTOMUTE)
          {
            try
            {

              var enumerator = new MMDeviceEnumerator();

              // デフォルトのオーディオ再生デバイスを取得
              var device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

              // 音量を 0 に設定
              device.AudioEndpointVolume.MasterVolumeLevelScalar = 0.0f;
              this.WindowState = FormWindowState.Minimized; // ウィンドウを最小化
              this.ShowInTaskbar = false;
              notifyIcon.Visible = true;
              notifyIcon.Icon = new System.Drawing.Icon("icons\\6.ico");
              notifyIcon.Text = "SmartBrowser - 緊急モード";
            }
            catch
            {
              this.WindowState = FormWindowState.Minimized; // ウィンドウを最小化
              this.ShowInTaskbar = false;
              notifyIcon.Visible = true;
              notifyIcon.Icon = new System.Drawing.Icon("icons\\4.ico");
              notifyIcon.Text = "SmartBrowser - 緊急モード (ミュートに失敗)";
            }
          }
          else
          {
            this.WindowState = FormWindowState.Minimized; // ウィンドウを最小化
            this.ShowInTaskbar = false;
            notifyIcon.Visible = true;
            notifyIcon.Icon = new System.Drawing.Icon("icons\\6.ico");
            notifyIcon.Text = "SmartBrowser - 緊急モード";
          }
        }
      }
    }

    private void OpenLinkYT_Click(object sender, EventArgs e)
    {
      QuickBar.Visible = false;
      webView2.CoreWebView2.Navigate("https://youtube.com/");
    }

    private void OpenLinkGAME_Click(object sender, EventArgs e)
    {
      QuickBar.Visible = false;
      webView2.CoreWebView2.Navigate("https://game16.net/");
    }

    private void OpenGithub_Click(object sender, EventArgs e)
    {
      QuickBar.Visible = false;
      webView2.CoreWebView2.Navigate("https://github.com/missssssssssi-ms");
    }

    private void ToolBtn_Click(object sender, EventArgs e)
    {
      QuickBar.Visible = false;
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
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (NOCLOSE)
      {
        e.Cancel = true;
        DownBar.Text = "設定により、ウィンドウを閉じることはできません。";
      }
    }
  }
}