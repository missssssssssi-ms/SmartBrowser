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
      this.SidePanel1 = new System.Windows.Forms.GroupBox();
      this.CloseSidepanel1 = new System.Windows.Forms.Button();
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
      this.AlwaysDev = new System.Windows.Forms.CheckBox();
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
      this.SecretPage = new System.Windows.Forms.TabPage();
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
      this.SidePanel1.SuspendLayout();
      this.MainTab.SuspendLayout();
      this.MainPege.SuspendLayout();
      this.panel2.SuspendLayout();
      this.QuickBar.SuspendLayout();
      this.DevPanel.SuspendLayout();
      this.Bottombar.SuspendLayout();
      this.DownButton.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // webView2
      // 
      this.webView2.AllowExternalDrop = true;
      this.webView2.CreationProperties = null;
      this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
      this.webView2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.webView2.Location = new System.Drawing.Point(0, 0);
      this.webView2.Margin = new System.Windows.Forms.Padding(2);
      this.webView2.Name = "webView2";
      this.webView2.Size = new System.Drawing.Size(469, 351);
      this.webView2.TabIndex = 0;
      this.webView2.ZoomFactor = 1D;
      this.webView2.Click += new System.EventHandler(this.WebView2_Click);
      this.webView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.webView2_MouseClick);
      // 
      // SidePanel1
      // 
      this.SidePanel1.Controls.Add(this.CloseSidepanel1);
      this.SidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.SidePanel1.Location = new System.Drawing.Point(569, 2);
      this.SidePanel1.Margin = new System.Windows.Forms.Padding(2);
      this.SidePanel1.Name = "SidePanel1";
      this.SidePanel1.Padding = new System.Windows.Forms.Padding(2);
      this.SidePanel1.Size = new System.Drawing.Size(156, 401);
      this.SidePanel1.TabIndex = 2;
      this.SidePanel1.TabStop = false;
      this.SidePanel1.Text = "高度な設定";
      this.SidePanel1.Visible = false;
      // 
      // CloseSidepanel1
      // 
      this.CloseSidepanel1.Location = new System.Drawing.Point(4, 17);
      this.CloseSidepanel1.Name = "CloseSidepanel1";
      this.CloseSidepanel1.Size = new System.Drawing.Size(75, 23);
      this.CloseSidepanel1.TabIndex = 1;
      this.CloseSidepanel1.Text = "閉じる";
      this.CloseSidepanel1.UseVisualStyleBackColor = true;
      this.CloseSidepanel1.Click += new System.EventHandler(this.CloseSidepanel1_Click);
      // 
      // MainTab
      // 
      this.MainTab.Controls.Add(this.MainPege);
      this.MainTab.Controls.Add(this.SecretPage);
      this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainTab.Location = new System.Drawing.Point(0, 0);
      this.MainTab.Margin = new System.Windows.Forms.Padding(2);
      this.MainTab.Name = "MainTab";
      this.MainTab.SelectedIndex = 0;
      this.MainTab.Size = new System.Drawing.Size(735, 431);
      this.MainTab.TabIndex = 3;
      // 
      // MainPege
      // 
      this.MainPege.Controls.Add(this.panel2);
      this.MainPege.Controls.Add(this.DevPanel);
      this.MainPege.Controls.Add(this.Bottombar);
      this.MainPege.Controls.Add(this.panel1);
      this.MainPege.Controls.Add(this.SidePanel1);
      this.MainPege.Location = new System.Drawing.Point(4, 22);
      this.MainPege.Margin = new System.Windows.Forms.Padding(2);
      this.MainPege.Name = "MainPege";
      this.MainPege.Padding = new System.Windows.Forms.Padding(2);
      this.MainPege.Size = new System.Drawing.Size(727, 405);
      this.MainPege.TabIndex = 0;
      this.MainPege.Text = "Webページ";
      this.MainPege.UseVisualStyleBackColor = true;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.QuickBar);
      this.panel2.Controls.Add(this.webView2);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(100, 27);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(469, 351);
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
      this.QuickBar.Name = "QuickBar";
      this.QuickBar.Size = new System.Drawing.Size(469, 23);
      this.QuickBar.TabIndex = 1;
      // 
      // ToolBtn
      // 
      this.ToolBtn.Dock = System.Windows.Forms.DockStyle.Right;
      this.ToolBtn.Location = new System.Drawing.Point(409, 0);
      this.ToolBtn.Name = "ToolBtn";
      this.ToolBtn.Size = new System.Drawing.Size(60, 23);
      this.ToolBtn.TabIndex = 4;
      this.ToolBtn.Text = "ツール";
      this.ToolBtn.UseVisualStyleBackColor = true;
      this.ToolBtn.Click += new System.EventHandler(this.ToolBtn_Click);
      // 
      // OpenGithub
      // 
      this.OpenGithub.Location = new System.Drawing.Point(132, 0);
      this.OpenGithub.Name = "OpenGithub";
      this.OpenGithub.Size = new System.Drawing.Size(60, 23);
      this.OpenGithub.TabIndex = 3;
      this.OpenGithub.Text = "GitHub";
      this.OpenGithub.UseVisualStyleBackColor = true;
      this.OpenGithub.Click += new System.EventHandler(this.OpenGithub_Click);
      // 
      // OpenLinkGAME
      // 
      this.OpenLinkGAME.Location = new System.Drawing.Point(66, 0);
      this.OpenLinkGAME.Name = "OpenLinkGAME";
      this.OpenLinkGAME.Size = new System.Drawing.Size(60, 23);
      this.OpenLinkGAME.TabIndex = 2;
      this.OpenLinkGAME.Text = "GAME";
      this.OpenLinkGAME.UseVisualStyleBackColor = true;
      this.OpenLinkGAME.Click += new System.EventHandler(this.OpenLinkGAME_Click);
      // 
      // OpenLinkYT
      // 
      this.OpenLinkYT.Location = new System.Drawing.Point(0, 0);
      this.OpenLinkYT.Name = "OpenLinkYT";
      this.OpenLinkYT.Size = new System.Drawing.Size(60, 23);
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
      this.DevPanel.Controls.Add(this.AlwaysDev);
      this.DevPanel.Controls.Add(this.DevStop);
      this.DevPanel.Controls.Add(this.DevReload);
      this.DevPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.DevPanel.Location = new System.Drawing.Point(2, 27);
      this.DevPanel.Name = "DevPanel";
      this.DevPanel.Size = new System.Drawing.Size(98, 351);
      this.DevPanel.TabIndex = 5;
      this.DevPanel.TabStop = false;
      this.DevPanel.Text = "デベロッパー向け";
      // 
      // About
      // 
      this.About.Location = new System.Drawing.Point(6, 243);
      this.About.Name = "About";
      this.About.Size = new System.Drawing.Size(75, 23);
      this.About.TabIndex = 8;
      this.About.Text = "About";
      this.About.UseVisualStyleBackColor = true;
      this.About.Click += new System.EventHandler(this.About_Click);
      // 
      // Reboot
      // 
      this.Reboot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Reboot.Location = new System.Drawing.Point(6, 300);
      this.Reboot.Name = "Reboot";
      this.Reboot.Size = new System.Drawing.Size(75, 23);
      this.Reboot.TabIndex = 7;
      this.Reboot.Text = "ReBoot";
      this.Reboot.UseVisualStyleBackColor = true;
      this.Reboot.Click += new System.EventHandler(this.Reboot_Click);
      // 
      // HtmlBuild
      // 
      this.HtmlBuild.Location = new System.Drawing.Point(6, 151);
      this.HtmlBuild.Name = "HtmlBuild";
      this.HtmlBuild.Size = new System.Drawing.Size(75, 23);
      this.HtmlBuild.TabIndex = 6;
      this.HtmlBuild.Text = "HTMLBuild";
      this.HtmlBuild.UseVisualStyleBackColor = true;
      // 
      // Htmltest
      // 
      this.Htmltest.Location = new System.Drawing.Point(6, 122);
      this.Htmltest.Name = "Htmltest";
      this.Htmltest.Size = new System.Drawing.Size(75, 23);
      this.Htmltest.TabIndex = 5;
      this.Htmltest.Text = "HTMLTest";
      this.Htmltest.UseVisualStyleBackColor = true;
      this.Htmltest.Click += new System.EventHandler(this.Htmltest_Click);
      // 
      // VSCode
      // 
      this.VSCode.Location = new System.Drawing.Point(6, 93);
      this.VSCode.Name = "VSCode";
      this.VSCode.Size = new System.Drawing.Size(75, 23);
      this.VSCode.TabIndex = 4;
      this.VSCode.Text = "VSCode";
      this.VSCode.UseVisualStyleBackColor = true;
      this.VSCode.Click += new System.EventHandler(this.VSCode_Click);
      // 
      // AlwaysDev
      // 
      this.AlwaysDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.AlwaysDev.AutoSize = true;
      this.AlwaysDev.Location = new System.Drawing.Point(2, 329);
      this.AlwaysDev.Name = "AlwaysDev";
      this.AlwaysDev.Size = new System.Drawing.Size(61, 16);
      this.AlwaysDev.TabIndex = 3;
      this.AlwaysDev.Text = "Always";
      this.AlwaysDev.UseVisualStyleBackColor = true;
      this.AlwaysDev.CheckedChanged += new System.EventHandler(this.AlwaysDev_CheckedChanged);
      // 
      // DevStop
      // 
      this.DevStop.Location = new System.Drawing.Point(6, 47);
      this.DevStop.Name = "DevStop";
      this.DevStop.Size = new System.Drawing.Size(75, 23);
      this.DevStop.TabIndex = 1;
      this.DevStop.Text = "Stop";
      this.DevStop.UseVisualStyleBackColor = true;
      this.DevStop.Click += new System.EventHandler(this.DevStop_Click);
      // 
      // DevReload
      // 
      this.DevReload.Location = new System.Drawing.Point(6, 18);
      this.DevReload.Name = "DevReload";
      this.DevReload.Size = new System.Drawing.Size(75, 23);
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
      this.Bottombar.Location = new System.Drawing.Point(2, 378);
      this.Bottombar.Margin = new System.Windows.Forms.Padding(2);
      this.Bottombar.Name = "Bottombar";
      this.Bottombar.Size = new System.Drawing.Size(567, 25);
      this.Bottombar.TabIndex = 4;
      // 
      // DownButton
      // 
      this.DownButton.Controls.Add(this.OpenQuickBar);
      this.DownButton.Controls.Add(this.Showsidepanel1);
      this.DownButton.Dock = System.Windows.Forms.DockStyle.Right;
      this.DownButton.Location = new System.Drawing.Point(402, 0);
      this.DownButton.Name = "DownButton";
      this.DownButton.Size = new System.Drawing.Size(165, 25);
      this.DownButton.TabIndex = 4;
      // 
      // OpenQuickBar
      // 
      this.OpenQuickBar.Dock = System.Windows.Forms.DockStyle.Left;
      this.OpenQuickBar.Location = new System.Drawing.Point(0, 0);
      this.OpenQuickBar.Name = "OpenQuickBar";
      this.OpenQuickBar.Size = new System.Drawing.Size(75, 25);
      this.OpenQuickBar.TabIndex = 3;
      this.OpenQuickBar.Text = "クイックバー";
      this.OpenQuickBar.UseVisualStyleBackColor = true;
      this.OpenQuickBar.Click += new System.EventHandler(this.OpenQuickBar_Click);
      // 
      // Showsidepanel1
      // 
      this.Showsidepanel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.Showsidepanel1.Location = new System.Drawing.Point(90, 0);
      this.Showsidepanel1.Name = "Showsidepanel1";
      this.Showsidepanel1.Size = new System.Drawing.Size(75, 25);
      this.Showsidepanel1.TabIndex = 0;
      this.Showsidepanel1.Text = "クイック設定";
      this.Showsidepanel1.UseVisualStyleBackColor = true;
      this.Showsidepanel1.Click += new System.EventHandler(this.Showsidepanel1_Click);
      // 
      // DownBar
      // 
      this.DownBar.AutoSize = true;
      this.DownBar.Location = new System.Drawing.Point(96, 7);
      this.DownBar.Name = "DownBar";
      this.DownBar.Size = new System.Drawing.Size(50, 12);
      this.DownBar.TabIndex = 2;
      this.DownBar.Text = "ERROR!!";
      // 
      // SettingDev
      // 
      this.SettingDev.AutoSize = true;
      this.SettingDev.Location = new System.Drawing.Point(6, 6);
      this.SettingDev.Name = "SettingDev";
      this.SettingDev.Size = new System.Drawing.Size(71, 16);
      this.SettingDev.TabIndex = 1;
      this.SettingDev.Text = "DevMode";
      this.SettingDev.UseVisualStyleBackColor = true;
      this.SettingDev.CheckedChanged += new System.EventHandler(this.SettingDev_CheckedChanged);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(2, 2);
      this.panel1.Margin = new System.Windows.Forms.Padding(2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(567, 25);
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
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(567, 23);
      this.panel3.TabIndex = 5;
      // 
      // URL
      // 
      this.URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.URL.Location = new System.Drawing.Point(106, 2);
      this.URL.Name = "URL";
      this.URL.Size = new System.Drawing.Size(421, 19);
      this.URL.TabIndex = 0;
      this.URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URL_KeyDown);
      // 
      // BtnNext
      // 
      this.BtnNext.Location = new System.Drawing.Point(79, 0);
      this.BtnNext.Name = "BtnNext";
      this.BtnNext.Size = new System.Drawing.Size(21, 23);
      this.BtnNext.TabIndex = 4;
      this.BtnNext.Text = ">";
      this.BtnNext.UseVisualStyleBackColor = true;
      this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
      // 
      // Home
      // 
      this.Home.Location = new System.Drawing.Point(28, 0);
      this.Home.Name = "Home";
      this.Home.Size = new System.Drawing.Size(45, 23);
      this.Home.TabIndex = 3;
      this.Home.Text = "HOME";
      this.Home.UseVisualStyleBackColor = true;
      this.Home.Click += new System.EventHandler(this.Home_Click);
      // 
      // BtnGo
      // 
      this.BtnGo.Dock = System.Windows.Forms.DockStyle.Right;
      this.BtnGo.Location = new System.Drawing.Point(533, 0);
      this.BtnGo.Name = "BtnGo";
      this.BtnGo.Size = new System.Drawing.Size(34, 23);
      this.BtnGo.TabIndex = 1;
      this.BtnGo.Text = "Go";
      this.BtnGo.UseVisualStyleBackColor = true;
      this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
      // 
      // BtnBack
      // 
      this.BtnBack.Location = new System.Drawing.Point(1, 0);
      this.BtnBack.Name = "BtnBack";
      this.BtnBack.Size = new System.Drawing.Size(21, 23);
      this.BtnBack.TabIndex = 2;
      this.BtnBack.Text = "<";
      this.BtnBack.UseVisualStyleBackColor = true;
      this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
      // 
      // SecretPage
      // 
      this.SecretPage.Location = new System.Drawing.Point(4, 22);
      this.SecretPage.Margin = new System.Windows.Forms.Padding(2);
      this.SecretPage.Name = "SecretPage";
      this.SecretPage.Padding = new System.Windows.Forms.Padding(2);
      this.SecretPage.Size = new System.Drawing.Size(727, 405);
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
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(735, 431);
      this.Controls.Add(this.MainTab);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Form1";
      this.Text = "SmartBrowser";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.Resize += new System.EventHandler(this.Form1_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
      this.SidePanel1.ResumeLayout(false);
      this.MainTab.ResumeLayout(false);
      this.MainPege.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.QuickBar.ResumeLayout(false);
      this.DevPanel.ResumeLayout(false);
      this.DevPanel.PerformLayout();
      this.Bottombar.ResumeLayout(false);
      this.Bottombar.PerformLayout();
      this.DownButton.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
    private System.Windows.Forms.GroupBox SidePanel1;
    private System.Windows.Forms.TabControl MainTab;
    private System.Windows.Forms.TabPage MainPege;
    private System.Windows.Forms.TabPage SecretPage;
    private System.Windows.Forms.Panel Bottombar;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button Showsidepanel1;
    private System.Windows.Forms.Button CloseSidepanel1;
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
    private System.Windows.Forms.CheckBox AlwaysDev;
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
  }
}

