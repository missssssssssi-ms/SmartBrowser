namespace msedge
{
  partial class Form1
  {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
      this.MainTab = new System.Windows.Forms.TabControl();
      this.MainPege = new System.Windows.Forms.TabPage();
      this.panel2 = new System.Windows.Forms.Panel();
      this.QuickBar = new System.Windows.Forms.Panel();
      this.ToolBtn = new System.Windows.Forms.Button();
      this.OpenGithub = new System.Windows.Forms.Button();
      this.OpenLinkGAME = new System.Windows.Forms.Button();
      this.OpenLinkYT = new System.Windows.Forms.Button();
      this.DevPanel = new System.Windows.Forms.GroupBox();
      this.About = new System.Windows.Forms.Button();
      this.Reboot = new System.Windows.Forms.Button();
      this.HtmlBuild = new System.Windows.Forms.Button();
      this.Htmltest = new System.Windows.Forms.Button();
      this.VSCode = new System.Windows.Forms.Button();
      this.DevStop = new System.Windows.Forms.Button();
      this.DevReload = new System.Windows.Forms.Button();
      this.Bottombar = new System.Windows.Forms.Panel();
      this.DownButton = new System.Windows.Forms.Panel();
      this.OpenQuickBar = new System.Windows.Forms.Button();
      this.Showsidepanel1 = new System.Windows.Forms.Button();
      this.DownBar = new System.Windows.Forms.Label();
      this.SettingDev = new System.Windows.Forms.CheckBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.URL = new System.Windows.Forms.TextBox();
      this.BtnNext = new System.Windows.Forms.Button();
      this.Home = new System.Windows.Forms.Button();
      this.BtnGo = new System.Windows.Forms.Button();
      this.BtnBack = new System.Windows.Forms.Button();
      this.SidePanel1 = new System.Windows.Forms.GroupBox();
      this.CloseSidepanel1 = new System.Windows.Forms.Button();
      this.SecretPage = new System.Windows.Forms.TabPage();
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
      this.MainTab.SuspendLayout();
      this.MainPege.SuspendLayout();
      this.panel2.SuspendLayout();
      this.QuickBar.SuspendLayout();
      this.DevPanel.SuspendLayout();
      this.Bottombar.SuspendLayout();
      this.DownButton.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SidePanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // webView2
      // 
      this.webView2.AllowExternalDrop = true;
      this.webView2.CreationProperties = null;
      this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
      this.webView2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.webView2.Location = new System.Drawing.Point(0, 0);
      this.webView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.webView2.Name = "webView2";
      this.webView2.Size = new System.Drawing.Size(627, 444);
      this.webView2.TabIndex = 0;
      this.webView2.ZoomFactor = 1D;
      this.webView2.Click += new System.EventHandler(this.WebView2_Click);
      this.webView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.webView2_MouseClick);
      // 
      // MainTab
      // 
      this.MainTab.Controls.Add(this.MainPege);
      this.MainTab.Controls.Add(this.SecretPage);
      this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainTab.Location = new System.Drawing.Point(0, 0);
      this.MainTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MainTab.Name = "MainTab";
      this.MainTab.SelectedIndex = 0;
      this.MainTab.Size = new System.Drawing.Size(980, 539);
      this.MainTab.TabIndex = 3;
      // 
      // MainPege
      // 
      this.MainPege.Controls.Add(this.panel2);
      this.MainPege.Controls.Add(this.DevPanel);
      this.MainPege.Controls.Add(this.Bottombar);
      this.MainPege.Controls.Add(this.panel1);
      this.MainPege.Controls.Add(this.SidePanel1);
      this.MainPege.Location = new System.Drawing.Point(4, 25);
      this.MainPege.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MainPege.Name = "MainPege";
      this.MainPege.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MainPege.Size = new System.Drawing.Size(972, 510);
      this.MainPege.TabIndex = 0;
      this.MainPege.Text = "Webページ";
      this.MainPege.UseVisualStyleBackColor = true;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.QuickBar);
      this.panel2.Controls.Add(this.webView2);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(134, 33);
      this.panel2.Margin = new System.Windows.Forms.Padding(4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(627, 444);
      this.panel2.TabIndex = 6;
      // 
      // QuickBar
      // 
      this.QuickBar.Controls.Add(this.ToolBtn);
      this.QuickBar.Controls.Add(this.OpenGithub);
      this.QuickBar.Controls.Add(this.OpenLinkGAME);
      this.QuickBar.Controls.Add(this.OpenLinkYT);
      this.QuickBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.QuickBar.Location = new System.Drawing.Point(0, 0);
      this.QuickBar.Margin = new System.Windows.Forms.Padding(4);
      this.QuickBar.Name = "QuickBar";
      this.QuickBar.Size = new System.Drawing.Size(627, 29);
      this.QuickBar.TabIndex = 1;
      // 
      // ToolBtn
      // 
      this.ToolBtn.Dock = System.Windows.Forms.DockStyle.Right;
      this.ToolBtn.Location = new System.Drawing.Point(547, 0);
      this.ToolBtn.Margin = new System.Windows.Forms.Padding(4);
      this.ToolBtn.Name = "ToolBtn";
      this.ToolBtn.Size = new System.Drawing.Size(80, 29);
      this.ToolBtn.TabIndex = 4;
      this.ToolBtn.Text = "ツール";
      this.ToolBtn.UseVisualStyleBackColor = true;
      this.ToolBtn.Click += new System.EventHandler(this.ToolBtn_Click);
      // 
      // OpenGithub
      // 
      this.OpenGithub.Location = new System.Drawing.Point(176, 0);
      this.OpenGithub.Margin = new System.Windows.Forms.Padding(4);
      this.OpenGithub.Name = "OpenGithub";
      this.OpenGithub.Size = new System.Drawing.Size(80, 29);
      this.OpenGithub.TabIndex = 3;
      this.OpenGithub.Text = "GitHub";
      this.OpenGithub.UseVisualStyleBackColor = true;
      this.OpenGithub.Click += new System.EventHandler(this.OpenGithub_Click);
      // 
      // OpenLinkGAME
      // 
      this.OpenLinkGAME.Location = new System.Drawing.Point(88, 0);
      this.OpenLinkGAME.Margin = new System.Windows.Forms.Padding(4);
      this.OpenLinkGAME.Name = "OpenLinkGAME";
      this.OpenLinkGAME.Size = new System.Drawing.Size(80, 29);
      this.OpenLinkGAME.TabIndex = 2;
      this.OpenLinkGAME.Text = "GAME";
      this.OpenLinkGAME.UseVisualStyleBackColor = true;
      this.OpenLinkGAME.Click += new System.EventHandler(this.OpenLinkGAME_Click);
      // 
      // OpenLinkYT
      // 
      this.OpenLinkYT.Location = new System.Drawing.Point(0, 0);
      this.OpenLinkYT.Margin = new System.Windows.Forms.Padding(4);
      this.OpenLinkYT.Name = "OpenLinkYT";
      this.OpenLinkYT.Size = new System.Drawing.Size(80, 29);
      this.OpenLinkYT.TabIndex = 0;
      this.OpenLinkYT.Text = "YouTube";
      this.OpenLinkYT.UseVisualStyleBackColor = true;
      this.OpenLinkYT.Click += new System.EventHandler(this.OpenLinkYT_Click);
      // 
      // DevPanel
      // 
      this.DevPanel.Controls.Add(this.About);
      this.DevPanel.Controls.Add(this.Reboot);
      this.DevPanel.Controls.Add(this.HtmlBuild);
      this.DevPanel.Controls.Add(this.Htmltest);
      this.DevPanel.Controls.Add(this.VSCode);
      this.DevPanel.Controls.Add(this.DevStop);
      this.DevPanel.Controls.Add(this.DevReload);
      this.DevPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.DevPanel.Location = new System.Drawing.Point(3, 33);
      this.DevPanel.Margin = new System.Windows.Forms.Padding(4);
      this.DevPanel.Name = "DevPanel";
      this.DevPanel.Padding = new System.Windows.Forms.Padding(4);
      this.DevPanel.Size = new System.Drawing.Size(131, 444);
      this.DevPanel.TabIndex = 5;
      this.DevPanel.TabStop = false;
      this.DevPanel.Text = "デベロッパー向け";
      // 
      // About
      // 
      this.About.Location = new System.Drawing.Point(8, 304);
      this.About.Margin = new System.Windows.Forms.Padding(4);
      this.About.Name = "About";
      this.About.Size = new System.Drawing.Size(100, 29);
      this.About.TabIndex = 8;
      this.About.Text = "About";
      this.About.UseVisualStyleBackColor = true;
      this.About.Click += new System.EventHandler(this.About_Click);
      // 
      // Reboot
      // 
      this.Reboot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Reboot.Location = new System.Drawing.Point(8, 380);
      this.Reboot.Margin = new System.Windows.Forms.Padding(4);
      this.Reboot.Name = "Reboot";
      this.Reboot.Size = new System.Drawing.Size(100, 29);
      this.Reboot.TabIndex = 7;
      this.Reboot.Text = "ReBoot";
      this.Reboot.UseVisualStyleBackColor = true;
      this.Reboot.Click += new System.EventHandler(this.Reboot_Click);
      // 
      // HtmlBuild
      // 
      this.HtmlBuild.Location = new System.Drawing.Point(8, 189);
      this.HtmlBuild.Margin = new System.Windows.Forms.Padding(4);
      this.HtmlBuild.Name = "HtmlBuild";
      this.HtmlBuild.Size = new System.Drawing.Size(100, 29);
      this.HtmlBuild.TabIndex = 6;
      this.HtmlBuild.Text = "HTMLBuild";
      this.HtmlBuild.UseVisualStyleBackColor = true;
      // 
      // Htmltest
      // 
      this.Htmltest.Location = new System.Drawing.Point(8, 152);
      this.Htmltest.Margin = new System.Windows.Forms.Padding(4);
      this.Htmltest.Name = "Htmltest";
      this.Htmltest.Size = new System.Drawing.Size(100, 29);
      this.Htmltest.TabIndex = 5;
      this.Htmltest.Text = "HTMLTest";
      this.Htmltest.UseVisualStyleBackColor = true;
      this.Htmltest.Click += new System.EventHandler(this.Htmltest_Click);
      // 
      // VSCode
      // 
      this.VSCode.Location = new System.Drawing.Point(8, 116);
      this.VSCode.Margin = new System.Windows.Forms.Padding(4);
      this.VSCode.Name = "VSCode";
      this.VSCode.Size = new System.Drawing.Size(100, 29);
      this.VSCode.TabIndex = 4;
      this.VSCode.Text = "VSCode";
      this.VSCode.UseVisualStyleBackColor = true;
      this.VSCode.Click += new System.EventHandler(this.VSCode_Click);
      // 
      // DevStop
      // 
      this.DevStop.Location = new System.Drawing.Point(8, 59);
      this.DevStop.Margin = new System.Windows.Forms.Padding(4);
      this.DevStop.Name = "DevStop";
      this.DevStop.Size = new System.Drawing.Size(100, 29);
      this.DevStop.TabIndex = 1;
      this.DevStop.Text = "Stop";
      this.DevStop.UseVisualStyleBackColor = true;
      this.DevStop.Click += new System.EventHandler(this.DevStop_Click);
      // 
      // DevReload
      // 
      this.DevReload.Location = new System.Drawing.Point(8, 22);
      this.DevReload.Margin = new System.Windows.Forms.Padding(4);
      this.DevReload.Name = "DevReload";
      this.DevReload.Size = new System.Drawing.Size(100, 29);
      this.DevReload.TabIndex = 0;
      this.DevReload.Text = "Reload";
      this.DevReload.UseVisualStyleBackColor = true;
      this.DevReload.Click += new System.EventHandler(this.DevReload_Click);
      // 
      // Bottombar
      // 
      this.Bottombar.Controls.Add(this.DownButton);
      this.Bottombar.Controls.Add(this.DownBar);
      this.Bottombar.Controls.Add(this.SettingDev);
      this.Bottombar.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.Bottombar.Location = new System.Drawing.Point(3, 477);
      this.Bottombar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Bottombar.Name = "Bottombar";
      this.Bottombar.Size = new System.Drawing.Size(758, 31);
      this.Bottombar.TabIndex = 4;
      // 
      // DownButton
      // 
      this.DownButton.Controls.Add(this.OpenQuickBar);
      this.DownButton.Controls.Add(this.Showsidepanel1);
      this.DownButton.Dock = System.Windows.Forms.DockStyle.Right;
      this.DownButton.Location = new System.Drawing.Point(538, 0);
      this.DownButton.Margin = new System.Windows.Forms.Padding(4);
      this.DownButton.Name = "DownButton";
      this.DownButton.Size = new System.Drawing.Size(220, 31);
      this.DownButton.TabIndex = 4;
      // 
      // OpenQuickBar
      // 
      this.OpenQuickBar.Dock = System.Windows.Forms.DockStyle.Left;
      this.OpenQuickBar.Location = new System.Drawing.Point(0, 0);
      this.OpenQuickBar.Margin = new System.Windows.Forms.Padding(4);
      this.OpenQuickBar.Name = "OpenQuickBar";
      this.OpenQuickBar.Size = new System.Drawing.Size(100, 31);
      this.OpenQuickBar.TabIndex = 3;
      this.OpenQuickBar.Text = "クイックバー";
      this.OpenQuickBar.UseVisualStyleBackColor = true;
      this.OpenQuickBar.Click += new System.EventHandler(this.OpenQuickBar_Click);
      // 
      // Showsidepanel1
      // 
      this.Showsidepanel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.Showsidepanel1.Location = new System.Drawing.Point(120, 0);
      this.Showsidepanel1.Margin = new System.Windows.Forms.Padding(4);
      this.Showsidepanel1.Name = "Showsidepanel1";
      this.Showsidepanel1.Size = new System.Drawing.Size(100, 31);
      this.Showsidepanel1.TabIndex = 0;
      this.Showsidepanel1.Text = "クイック設定";
      this.Showsidepanel1.UseVisualStyleBackColor = true;
      this.Showsidepanel1.Click += new System.EventHandler(this.Showsidepanel1_Click);
      // 
      // DownBar
      // 
      this.DownBar.AutoSize = true;
      this.DownBar.Location = new System.Drawing.Point(128, 9);
      this.DownBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.DownBar.Name = "DownBar";
      this.DownBar.Size = new System.Drawing.Size(59, 15);
      this.DownBar.TabIndex = 2;
      this.DownBar.Text = "ERROR!!";
      // 
      // SettingDev
      // 
      this.SettingDev.AutoSize = true;
      this.SettingDev.Location = new System.Drawing.Point(8, 8);
      this.SettingDev.Margin = new System.Windows.Forms.Padding(4);
      this.SettingDev.Name = "SettingDev";
      this.SettingDev.Size = new System.Drawing.Size(88, 19);
      this.SettingDev.TabIndex = 1;
      this.SettingDev.Text = "DevMode";
      this.SettingDev.UseVisualStyleBackColor = true;
      this.SettingDev.CheckedChanged += new System.EventHandler(this.SettingDev_CheckedChanged);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 2);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(758, 31);
      this.panel1.TabIndex = 3;
      // 
      // panel3
      // 
      this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.panel3.Controls.Add(this.URL);
      this.panel3.Controls.Add(this.BtnNext);
      this.panel3.Controls.Add(this.Home);
      this.panel3.Controls.Add(this.BtnGo);
      this.panel3.Controls.Add(this.BtnBack);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Margin = new System.Windows.Forms.Padding(4);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(758, 29);
      this.panel3.TabIndex = 5;
      // 
      // URL
      // 
      this.URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.URL.Location = new System.Drawing.Point(141, 2);
      this.URL.Margin = new System.Windows.Forms.Padding(4);
      this.URL.Name = "URL";
      this.URL.Size = new System.Drawing.Size(562, 22);
      this.URL.TabIndex = 0;
      this.URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URL_KeyDown);
      // 
      // BtnNext
      // 
      this.BtnNext.Location = new System.Drawing.Point(105, 0);
      this.BtnNext.Margin = new System.Windows.Forms.Padding(4);
      this.BtnNext.Name = "BtnNext";
      this.BtnNext.Size = new System.Drawing.Size(28, 29);
      this.BtnNext.TabIndex = 4;
      this.BtnNext.Text = ">";
      this.BtnNext.UseVisualStyleBackColor = true;
      this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
      // 
      // Home
      // 
      this.Home.Location = new System.Drawing.Point(37, 0);
      this.Home.Margin = new System.Windows.Forms.Padding(4);
      this.Home.Name = "Home";
      this.Home.Size = new System.Drawing.Size(60, 29);
      this.Home.TabIndex = 3;
      this.Home.Text = "HOME";
      this.Home.UseVisualStyleBackColor = true;
      this.Home.Click += new System.EventHandler(this.Home_Click);
      // 
      // BtnGo
      // 
      this.BtnGo.Dock = System.Windows.Forms.DockStyle.Right;
      this.BtnGo.Location = new System.Drawing.Point(713, 0);
      this.BtnGo.Margin = new System.Windows.Forms.Padding(4);
      this.BtnGo.Name = "BtnGo";
      this.BtnGo.Size = new System.Drawing.Size(45, 29);
      this.BtnGo.TabIndex = 1;
      this.BtnGo.Text = "Go";
      this.BtnGo.UseVisualStyleBackColor = true;
      this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
      // 
      // BtnBack
      // 
      this.BtnBack.Location = new System.Drawing.Point(1, 0);
      this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
      this.BtnBack.Name = "BtnBack";
      this.BtnBack.Size = new System.Drawing.Size(28, 29);
      this.BtnBack.TabIndex = 2;
      this.BtnBack.Text = "<";
      this.BtnBack.UseVisualStyleBackColor = true;
      this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
      // 
      // SidePanel1
      // 
      this.SidePanel1.Controls.Add(this.CloseSidepanel1);
      this.SidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.SidePanel1.Location = new System.Drawing.Point(761, 2);
      this.SidePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.SidePanel1.Name = "SidePanel1";
      this.SidePanel1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.SidePanel1.Size = new System.Drawing.Size(208, 506);
      this.SidePanel1.TabIndex = 2;
      this.SidePanel1.TabStop = false;
      this.SidePanel1.Text = "高度な設定";
      this.SidePanel1.Visible = false;
      // 
      // CloseSidepanel1
      // 
      this.CloseSidepanel1.Location = new System.Drawing.Point(5, 21);
      this.CloseSidepanel1.Margin = new System.Windows.Forms.Padding(4);
      this.CloseSidepanel1.Name = "CloseSidepanel1";
      this.CloseSidepanel1.Size = new System.Drawing.Size(100, 29);
      this.CloseSidepanel1.TabIndex = 1;
      this.CloseSidepanel1.Text = "閉じる";
      this.CloseSidepanel1.UseVisualStyleBackColor = true;
      this.CloseSidepanel1.Click += new System.EventHandler(this.CloseSidepanel1_Click);
      // 
      // SecretPage
      // 
      this.SecretPage.Location = new System.Drawing.Point(4, 25);
      this.SecretPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.SecretPage.Name = "SecretPage";
      this.SecretPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.SecretPage.Size = new System.Drawing.Size(972, 510);
      this.SecretPage.TabIndex = 1;
      this.SecretPage.Text = "シークレットページ";
      this.SecretPage.UseVisualStyleBackColor = true;
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.Text = "notifyIcon1";
      this.notifyIcon1.Visible = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(980, 539);
      this.Controls.Add(this.MainTab);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "Form1";
      this.Text = "SmartBrowser";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.Resize += new System.EventHandler(this.Form1_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
      this.MainTab.ResumeLayout(false);
      this.MainPege.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.QuickBar.ResumeLayout(false);
      this.DevPanel.ResumeLayout(false);
      this.Bottombar.ResumeLayout(false);
      this.Bottombar.PerformLayout();
      this.DownButton.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.SidePanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
    private System.Windows.Forms.TabControl MainTab;
    private System.Windows.Forms.TabPage MainPege;
    private System.Windows.Forms.TabPage SecretPage;
    private System.Windows.Forms.Panel Bottombar;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button Showsidepanel1;
    private System.Windows.Forms.NotifyIcon notifyIcon1;
    private System.Windows.Forms.Button BtnGo;
    private System.Windows.Forms.TextBox URL;
    private System.Windows.Forms.GroupBox DevPanel;
    private System.Windows.Forms.Button BtnNext;
    private System.Windows.Forms.Button Home;
    private System.Windows.Forms.Button BtnBack;
    private System.Windows.Forms.Button DevStop;
    private System.Windows.Forms.Button DevReload;
    private System.Windows.Forms.CheckBox SettingDev;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label DownBar;
    private System.Windows.Forms.Button HtmlBuild;
    private System.Windows.Forms.Button Htmltest;
    private System.Windows.Forms.Button VSCode;
    private System.Windows.Forms.Button Reboot;
    private System.Windows.Forms.Panel QuickBar;
    private System.Windows.Forms.Button OpenQuickBar;
    private System.Windows.Forms.Panel DownButton;
    private System.Windows.Forms.Button OpenLinkGAME;
    private System.Windows.Forms.Button OpenLinkYT;
    private System.Windows.Forms.Button About;
    private System.Windows.Forms.Button OpenGithub;
    private System.Windows.Forms.Button ToolBtn;
    private System.Windows.Forms.GroupBox SidePanel1;
    private System.Windows.Forms.Button CloseSidepanel1;
  }
}

