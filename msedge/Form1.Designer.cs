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
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.SidePanel1 = new System.Windows.Forms.GroupBox();
            this.SettingAutomute = new System.Windows.Forms.CheckBox();
            this.SettingOpenthis = new System.Windows.Forms.CheckBox();
            this.NotX = new System.Windows.Forms.CheckBox();
            this.Settingkeymode = new System.Windows.Forms.CheckBox();
            this.SettingTop = new System.Windows.Forms.CheckBox();
            this.SettingNoshowtaskber = new System.Windows.Forms.CheckBox();
            this.CloseSidepanel1 = new System.Windows.Forms.Button();
            this.SettingCangetab = new System.Windows.Forms.CheckBox();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.MainPege = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.QuickBar = new System.Windows.Forms.Panel();
            this.DevPanel = new System.Windows.Forms.GroupBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGo = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SecretPage = new System.Windows.Forms.TabPage();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.SidePanel1.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.MainPege.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.webView2.Size = new System.Drawing.Size(390, 319);
            this.webView2.TabIndex = 0;
            this.webView2.ZoomFactor = 1D;
            this.webView2.Click += new System.EventHandler(this.WebView2_Click);
            this.webView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.webView2_MouseClick);
            // 
            // SidePanel1
            // 
            this.SidePanel1.Controls.Add(this.SettingAutomute);
            this.SidePanel1.Controls.Add(this.SettingOpenthis);
            this.SidePanel1.Controls.Add(this.NotX);
            this.SidePanel1.Controls.Add(this.Settingkeymode);
            this.SidePanel1.Controls.Add(this.SettingTop);
            this.SidePanel1.Controls.Add(this.SettingNoshowtaskber);
            this.SidePanel1.Controls.Add(this.CloseSidepanel1);
            this.SidePanel1.Controls.Add(this.SettingCangetab);
            this.SidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.SidePanel1.Location = new System.Drawing.Point(490, 2);
            this.SidePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.SidePanel1.Name = "SidePanel1";
            this.SidePanel1.Padding = new System.Windows.Forms.Padding(2);
            this.SidePanel1.Size = new System.Drawing.Size(156, 369);
            this.SidePanel1.TabIndex = 2;
            this.SidePanel1.TabStop = false;
            this.SidePanel1.Text = "高度な設定";
            this.SidePanel1.Visible = false;
            // 
            // SettingAutomute
            // 
            this.SettingAutomute.AutoSize = true;
            this.SettingAutomute.Checked = true;
            this.SettingAutomute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SettingAutomute.Location = new System.Drawing.Point(4, 156);
            this.SettingAutomute.Name = "SettingAutomute";
            this.SettingAutomute.Size = new System.Drawing.Size(82, 16);
            this.SettingAutomute.TabIndex = 9;
            this.SettingAutomute.Text = "自動で消音";
            this.SettingAutomute.UseVisualStyleBackColor = true;
            // 
            // SettingOpenthis
            // 
            this.SettingOpenthis.AutoSize = true;
            this.SettingOpenthis.Location = new System.Drawing.Point(4, 133);
            this.SettingOpenthis.Name = "SettingOpenthis";
            this.SettingOpenthis.Size = new System.Drawing.Size(134, 16);
            this.SettingOpenthis.TabIndex = 8;
            this.SettingOpenthis.Text = "常にこのウィンドウで開く";
            this.SettingOpenthis.UseVisualStyleBackColor = true;
            this.SettingOpenthis.CheckedChanged += new System.EventHandler(this.SettingOpenthis_CheckedChanged);
            // 
            // NotX
            // 
            this.NotX.AutoSize = true;
            this.NotX.Location = new System.Drawing.Point(4, 111);
            this.NotX.Name = "NotX";
            this.NotX.Size = new System.Drawing.Size(126, 16);
            this.NotX.TabIndex = 7;
            this.NotX.Text = "閉じるボタンを非表示";
            this.NotX.UseVisualStyleBackColor = true;
            this.NotX.CheckedChanged += new System.EventHandler(this.NotX_CheckedChanged);
            // 
            // Settingkeymode
            // 
            this.Settingkeymode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Settingkeymode.AutoSize = true;
            this.Settingkeymode.Checked = true;
            this.Settingkeymode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Settingkeymode.Location = new System.Drawing.Point(5, 352);
            this.Settingkeymode.Margin = new System.Windows.Forms.Padding(2);
            this.Settingkeymode.Name = "Settingkeymode";
            this.Settingkeymode.Size = new System.Drawing.Size(153, 16);
            this.Settingkeymode.TabIndex = 6;
            this.Settingkeymode.Text = "緊急モードを有効化(推奨)";
            this.Settingkeymode.UseVisualStyleBackColor = true;
            this.Settingkeymode.CheckedChanged += new System.EventHandler(this.SettingKyemode_CheckedChanged);
            // 
            // SettingTop
            // 
            this.SettingTop.AutoSize = true;
            this.SettingTop.Location = new System.Drawing.Point(4, 88);
            this.SettingTop.Name = "SettingTop";
            this.SettingTop.Size = new System.Drawing.Size(102, 16);
            this.SettingTop.TabIndex = 5;
            this.SettingTop.Text = "常に手前に表示";
            this.SettingTop.UseVisualStyleBackColor = true;
            this.SettingTop.CheckedChanged += new System.EventHandler(this.SettingTop_CheckedChanged);
            // 
            // SettingNoshowtaskber
            // 
            this.SettingNoshowtaskber.AutoSize = true;
            this.SettingNoshowtaskber.Location = new System.Drawing.Point(4, 66);
            this.SettingNoshowtaskber.Name = "SettingNoshowtaskber";
            this.SettingNoshowtaskber.Size = new System.Drawing.Size(131, 16);
            this.SettingNoshowtaskber.TabIndex = 2;
            this.SettingNoshowtaskber.Text = "タスクバーに表示しない";
            this.SettingNoshowtaskber.UseVisualStyleBackColor = true;
            this.SettingNoshowtaskber.CheckedChanged += new System.EventHandler(this.SettingNoshowtaskber_CheckedChanged);
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
            // SettingCangetab
            // 
            this.SettingCangetab.AutoSize = true;
            this.SettingCangetab.Location = new System.Drawing.Point(4, 45);
            this.SettingCangetab.Margin = new System.Windows.Forms.Padding(2);
            this.SettingCangetab.Name = "SettingCangetab";
            this.SettingCangetab.Size = new System.Drawing.Size(103, 16);
            this.SettingCangetab.TabIndex = 0;
            this.SettingCangetab.Text = "最小化時に隠す";
            this.SettingCangetab.UseVisualStyleBackColor = true;
            this.SettingCangetab.CheckedChanged += new System.EventHandler(this.SettingCangetab_CheckedChanged);
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
            this.MainTab.Size = new System.Drawing.Size(656, 399);
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
            this.MainPege.Size = new System.Drawing.Size(648, 373);
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
            this.panel2.Size = new System.Drawing.Size(390, 319);
            this.panel2.TabIndex = 6;
            // 
            // QuickBar
            // 
            this.QuickBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuickBar.Location = new System.Drawing.Point(0, 0);
            this.QuickBar.Name = "QuickBar";
            this.QuickBar.Size = new System.Drawing.Size(390, 23);
            this.QuickBar.TabIndex = 1;
            // 
            // DevPanel
            // 
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
            this.DevPanel.Size = new System.Drawing.Size(98, 319);
            this.DevPanel.TabIndex = 5;
            this.DevPanel.TabStop = false;
            this.DevPanel.Text = "デベロッパー向け";
            // 
            // Reboot
            // 
            this.Reboot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Reboot.Location = new System.Drawing.Point(6, 268);
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
            this.VSCode.Text = "VSCode.dev";
            this.VSCode.UseVisualStyleBackColor = true;
            this.VSCode.Click += new System.EventHandler(this.VSCode_Click);
            // 
            // AlwaysDev
            // 
            this.AlwaysDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AlwaysDev.AutoSize = true;
            this.AlwaysDev.Location = new System.Drawing.Point(2, 297);
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
            this.Bottombar.Location = new System.Drawing.Point(2, 346);
            this.Bottombar.Margin = new System.Windows.Forms.Padding(2);
            this.Bottombar.Name = "Bottombar";
            this.Bottombar.Size = new System.Drawing.Size(488, 25);
            this.Bottombar.TabIndex = 4;
            // 
            // DownButton
            // 
            this.DownButton.Controls.Add(this.OpenQuickBar);
            this.DownButton.Controls.Add(this.Showsidepanel1);
            this.DownButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DownButton.Location = new System.Drawing.Point(323, 0);
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
            this.panel1.Size = new System.Drawing.Size(488, 25);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.URL);
            this.panel3.Controls.Add(this.BtnNext);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.BtnGo);
            this.panel3.Controls.Add(this.BtnBack);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 23);
            this.panel3.TabIndex = 5;
            // 
            // URL
            // 
            this.URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URL.Location = new System.Drawing.Point(106, 2);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(342, 19);
            this.URL.TabIndex = 0;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGo
            // 
            this.BtnGo.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnGo.Location = new System.Drawing.Point(454, 0);
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
            this.SecretPage.Size = new System.Drawing.Size(648, 373);
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
            this.ClientSize = new System.Drawing.Size(656, 399);
            this.Controls.Add(this.MainTab);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.SidePanel1.ResumeLayout(false);
            this.SidePanel1.PerformLayout();
            this.MainTab.ResumeLayout(false);
            this.MainPege.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox SettingCangetab;
        private System.Windows.Forms.Button Showsidepanel1;
        private System.Windows.Forms.Button CloseSidepanel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox SettingNoshowtaskber;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.GroupBox DevPanel;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button DevStop;
        private System.Windows.Forms.Button DevReload;
        private System.Windows.Forms.CheckBox SettingDev;
        private System.Windows.Forms.CheckBox SettingTop;
        private System.Windows.Forms.CheckBox Settingkeymode;
        private System.Windows.Forms.CheckBox AlwaysDev;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox NotX;
        private System.Windows.Forms.CheckBox SettingOpenthis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label DownBar;
        private System.Windows.Forms.Button HtmlBuild;
        private System.Windows.Forms.Button Htmltest;
        private System.Windows.Forms.Button VSCode;
        private System.Windows.Forms.CheckBox SettingAutomute;
        private System.Windows.Forms.Button Reboot;
        private System.Windows.Forms.Panel QuickBar;
        private System.Windows.Forms.Button OpenQuickBar;
        private System.Windows.Forms.Panel DownButton;
    }
}

