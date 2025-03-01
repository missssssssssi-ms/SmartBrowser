namespace msedge
{
  partial class Setting
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
      this.DownBar = new System.Windows.Forms.Panel();
      this.DownBarText = new System.Windows.Forms.Label();
      this.CancelButton = new System.Windows.Forms.Button();
      this.OKButton = new System.Windows.Forms.Button();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.WindowPege = new System.Windows.Forms.TabPage();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.NoClose = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.ChangeTab = new System.Windows.Forms.CheckBox();
      this.NoTaskBar = new System.Windows.Forms.CheckBox();
      this.Top = new System.Windows.Forms.CheckBox();
      this.WebPege = new System.Windows.Forms.TabPage();
      this.NoNewSite = new System.Windows.Forms.CheckBox();
      this.ecm = new System.Windows.Forms.CheckBox();
      this.label5 = new System.Windows.Forms.Label();
      this.OpenThis = new System.Windows.Forms.CheckBox();
      this.KModePege = new System.Windows.Forms.TabPage();
      this.label7 = new System.Windows.Forms.Label();
      this.AuteMute = new System.Windows.Forms.CheckBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label6 = new System.Windows.Forms.Label();
      this.ModeON = new System.Windows.Forms.CheckBox();
      this.DevPege = new System.Windows.Forms.TabPage();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label9 = new System.Windows.Forms.Label();
      this.DevMode = new System.Windows.Forms.CheckBox();
      this.label8 = new System.Windows.Forms.Label();
      this.DownBar.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.WindowPege.SuspendLayout();
      this.WebPege.SuspendLayout();
      this.KModePege.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.DevPege.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // DownBar
      // 
      this.DownBar.Controls.Add(this.DownBarText);
      this.DownBar.Controls.Add(this.CancelButton);
      this.DownBar.Controls.Add(this.OKButton);
      this.DownBar.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.DownBar.Location = new System.Drawing.Point(0, 524);
      this.DownBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.DownBar.Name = "DownBar";
      this.DownBar.Size = new System.Drawing.Size(389, 38);
      this.DownBar.TabIndex = 0;
      // 
      // DownBarText
      // 
      this.DownBarText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.DownBarText.AutoSize = true;
      this.DownBarText.Location = new System.Drawing.Point(3, 11);
      this.DownBarText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.DownBarText.Name = "DownBarText";
      this.DownBarText.Size = new System.Drawing.Size(137, 15);
      this.DownBarText.TabIndex = 2;
      this.DownBarText.Text = "ウィンドウを開きました｡";
      // 
      // CancelButton
      // 
      this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.CancelButton.Location = new System.Drawing.Point(284, 5);
      this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.CancelButton.Name = "CancelButton";
      this.CancelButton.Size = new System.Drawing.Size(100, 29);
      this.CancelButton.TabIndex = 1;
      this.CancelButton.Text = "キャンセル";
      this.CancelButton.UseVisualStyleBackColor = true;
      this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
      // 
      // OKButton
      // 
      this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.OKButton.Location = new System.Drawing.Point(176, 4);
      this.OKButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.OKButton.Name = "OKButton";
      this.OKButton.Size = new System.Drawing.Size(100, 29);
      this.OKButton.TabIndex = 0;
      this.OKButton.Text = "OK";
      this.OKButton.UseVisualStyleBackColor = true;
      this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.WindowPege);
      this.tabControl1.Controls.Add(this.WebPege);
      this.tabControl1.Controls.Add(this.KModePege);
      this.tabControl1.Controls.Add(this.DevPege);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(389, 524);
      this.tabControl1.TabIndex = 1;
      // 
      // WindowPege
      // 
      this.WindowPege.Controls.Add(this.label4);
      this.WindowPege.Controls.Add(this.label3);
      this.WindowPege.Controls.Add(this.label2);
      this.WindowPege.Controls.Add(this.NoClose);
      this.WindowPege.Controls.Add(this.label1);
      this.WindowPege.Controls.Add(this.ChangeTab);
      this.WindowPege.Controls.Add(this.NoTaskBar);
      this.WindowPege.Controls.Add(this.Top);
      this.WindowPege.Location = new System.Drawing.Point(4, 25);
      this.WindowPege.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.WindowPege.Name = "WindowPege";
      this.WindowPege.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.WindowPege.Size = new System.Drawing.Size(381, 495);
      this.WindowPege.TabIndex = 0;
      this.WindowPege.Text = "ウィンドウ";
      this.WindowPege.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.Location = new System.Drawing.Point(11, 232);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(364, 35);
      this.label4.TabIndex = 8;
      this.label4.Text = "タイトルバーに表示されているボタン (-□X) を非表示にします｡";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.Location = new System.Drawing.Point(11, 172);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(364, 32);
      this.label3.TabIndex = 6;
      this.label3.Text = "メインウィンドウを常に手前に表示させます｡";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.Location = new System.Drawing.Point(11, 110);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(364, 35);
      this.label2.TabIndex = 3;
      this.label2.Text = "このアプリがタスクバーに表示されなくなります｡";
      // 
      // NoClose
      // 
      this.NoClose.AutoSize = true;
      this.NoClose.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.NoClose.Location = new System.Drawing.Point(3, 209);
      this.NoClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.NoClose.Name = "NoClose";
      this.NoClose.Size = new System.Drawing.Size(165, 19);
      this.NoClose.TabIndex = 7;
      this.NoClose.Text = "閉じるボタンを非表示";
      this.NoClose.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.Location = new System.Drawing.Point(11, 29);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(364, 35);
      this.label1.TabIndex = 1;
      this.label1.Text = "ウィンドウを最小化したときにシークレットページに自動で切り替えます｡緊急モードでも､同様に変更されます｡";
      // 
      // ChangeTab
      // 
      this.ChangeTab.AutoSize = true;
      this.ChangeTab.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.ChangeTab.Location = new System.Drawing.Point(3, 6);
      this.ChangeTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.ChangeTab.Name = "ChangeTab";
      this.ChangeTab.Size = new System.Drawing.Size(136, 19);
      this.ChangeTab.TabIndex = 0;
      this.ChangeTab.Text = "最小化時に隠す";
      this.ChangeTab.UseVisualStyleBackColor = true;
      // 
      // NoTaskBar
      // 
      this.NoTaskBar.AutoSize = true;
      this.NoTaskBar.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.NoTaskBar.Location = new System.Drawing.Point(3, 86);
      this.NoTaskBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.NoTaskBar.Name = "NoTaskBar";
      this.NoTaskBar.Size = new System.Drawing.Size(174, 19);
      this.NoTaskBar.TabIndex = 2;
      this.NoTaskBar.Text = "タスクバーに表示しない";
      this.NoTaskBar.UseVisualStyleBackColor = true;
      // 
      // Top
      // 
      this.Top.AutoSize = true;
      this.Top.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.Top.Location = new System.Drawing.Point(3, 149);
      this.Top.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Top.Name = "Top";
      this.Top.Size = new System.Drawing.Size(135, 19);
      this.Top.TabIndex = 5;
      this.Top.Text = "常に手前に表示";
      this.Top.UseVisualStyleBackColor = true;
      // 
      // WebPege
      // 
      this.WebPege.Controls.Add(this.NoNewSite);
      this.WebPege.Controls.Add(this.ecm);
      this.WebPege.Controls.Add(this.label5);
      this.WebPege.Controls.Add(this.OpenThis);
      this.WebPege.Location = new System.Drawing.Point(4, 25);
      this.WebPege.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.WebPege.Name = "WebPege";
      this.WebPege.Size = new System.Drawing.Size(381, 496);
      this.WebPege.TabIndex = 1;
      this.WebPege.Text = "Web設定";
      this.WebPege.UseVisualStyleBackColor = true;
      // 
      // NoNewSite
      // 
      this.NoNewSite.AutoSize = true;
      this.NoNewSite.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.NoNewSite.Location = new System.Drawing.Point(13, 139);
      this.NoNewSite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.NoNewSite.Name = "NoNewSite";
      this.NoNewSite.Size = new System.Drawing.Size(164, 19);
      this.NoNewSite.TabIndex = 11;
      this.NoNewSite.Text = "新しいサイトをブロック";
      this.NoNewSite.UseVisualStyleBackColor = true;
      // 
      // ecm
      // 
      this.ecm.AutoSize = true;
      this.ecm.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.ecm.Location = new System.Drawing.Point(13, 110);
      this.ecm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.ecm.Name = "ecm";
      this.ecm.Size = new System.Drawing.Size(302, 19);
      this.ecm.TabIndex = 10;
      this.ecm.Text = "簡易コントロール機能を有効化(試験機能)";
      this.ecm.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label5.Location = new System.Drawing.Point(11, 28);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(364, 79);
      this.label5.TabIndex = 9;
      this.label5.Text = "常にこのウィンドウを使用して開くと､ウィンドウのタイトルを制御することができます｡\r\n新しいウィンドウを使用する場合は､簡易コントロール機能を有効にするかを選択で" +
    "きます｡(タイトルは｡空白で変更できません｡)\r\n";
      // 
      // OpenThis
      // 
      this.OpenThis.AutoSize = true;
      this.OpenThis.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.OpenThis.Location = new System.Drawing.Point(4, 4);
      this.OpenThis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.OpenThis.Name = "OpenThis";
      this.OpenThis.Size = new System.Drawing.Size(177, 19);
      this.OpenThis.TabIndex = 8;
      this.OpenThis.Text = "常にこのウィンドウで開く";
      this.OpenThis.UseVisualStyleBackColor = true;
      // 
      // KModePege
      // 
      this.KModePege.Controls.Add(this.label7);
      this.KModePege.Controls.Add(this.AuteMute);
      this.KModePege.Controls.Add(this.groupBox1);
      this.KModePege.Controls.Add(this.ModeON);
      this.KModePege.Location = new System.Drawing.Point(4, 25);
      this.KModePege.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.KModePege.Name = "KModePege";
      this.KModePege.Size = new System.Drawing.Size(381, 496);
      this.KModePege.TabIndex = 2;
      this.KModePege.Text = "緊急モード";
      this.KModePege.UseVisualStyleBackColor = true;
      // 
      // label7
      // 
      this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label7.Location = new System.Drawing.Point(11, 188);
      this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(364, 58);
      this.label7.TabIndex = 10;
      this.label7.Text = "一部のデバイスでは使用できませんが通常の緊急モードは使用できます・";
      // 
      // AuteMute
      // 
      this.AuteMute.AutoSize = true;
      this.AuteMute.Checked = true;
      this.AuteMute.CheckState = System.Windows.Forms.CheckState.Checked;
      this.AuteMute.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.AuteMute.Location = new System.Drawing.Point(11, 164);
      this.AuteMute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.AuteMute.Name = "AuteMute";
      this.AuteMute.Size = new System.Drawing.Size(106, 19);
      this.AuteMute.TabIndex = 9;
      this.AuteMute.Text = "自動で消音";
      this.AuteMute.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.AutoSize = true;
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Location = new System.Drawing.Point(4, 4);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Size = new System.Drawing.Size(371, 135);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "このモードについて";
      // 
      // label6
      // 
      this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label6.Location = new System.Drawing.Point(4, 19);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(363, 112);
      this.label6.TabIndex = 0;
      this.label6.Text = "緊急モードを使用すると､メインウィンドウを開いている時に､\"Escキー\"を押すとウィンドウを最小化します｡更に､タスクバーからも非表示にします｡また可能な場合は､" +
    "PCをミュートにします｡このモードはメインウィンドウが選択されているときのみのに有効で､再度ウィンドウを表示するには､システムトレイアイコンを使用するか､\"Al" +
    "t+Tabキー\"を使用します｡";
      // 
      // ModeON
      // 
      this.ModeON.AutoSize = true;
      this.ModeON.Checked = true;
      this.ModeON.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ModeON.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.ModeON.Location = new System.Drawing.Point(0, 139);
      this.ModeON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.ModeON.Name = "ModeON";
      this.ModeON.Size = new System.Drawing.Size(202, 19);
      this.ModeON.TabIndex = 6;
      this.ModeON.Text = "緊急モードを有効化(推奨)";
      this.ModeON.UseVisualStyleBackColor = true;
      // 
      // DevPege
      // 
      this.DevPege.Controls.Add(this.groupBox2);
      this.DevPege.Location = new System.Drawing.Point(4, 25);
      this.DevPege.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.DevPege.Name = "DevPege";
      this.DevPege.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.DevPege.Size = new System.Drawing.Size(381, 496);
      this.DevPege.TabIndex = 3;
      this.DevPege.Text = "上級者向け";
      this.DevPege.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.label9);
      this.groupBox2.Controls.Add(this.DevMode);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Location = new System.Drawing.Point(4, 8);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox2.Size = new System.Drawing.Size(364, 175);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "注意";
      // 
      // label9
      // 
      this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label9.Location = new System.Drawing.Point(21, 102);
      this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(335, 60);
      this.label9.TabIndex = 2;
      this.label9.Text = "DevModeを有効にすることで、開発段階の機能を利用できるようになります。利用しない場合は、この設定を無効にしてください。";
      // 
      // DevMode
      // 
      this.DevMode.AutoSize = true;
      this.DevMode.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.DevMode.Location = new System.Drawing.Point(3, 79);
      this.DevMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.DevMode.Name = "DevMode";
      this.DevMode.Size = new System.Drawing.Size(155, 19);
      this.DevMode.TabIndex = 1;
      this.DevMode.Text = "DevModeを有効化";
      this.DevMode.UseVisualStyleBackColor = true;
      // 
      // label8
      // 
      this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label8.Location = new System.Drawing.Point(0, 19);
      this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(356, 55);
      this.label8.TabIndex = 0;
      this.label8.Text = "これらの機能や設定は、現在開発中のものなどがあります。発生した不具合はフィードバックで報告してください。";
      // 
      // Setting
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(389, 562);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.DownBar);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Setting";
      this.DownBar.ResumeLayout(false);
      this.DownBar.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.WindowPege.ResumeLayout(false);
      this.WindowPege.PerformLayout();
      this.WebPege.ResumeLayout(false);
      this.WebPege.PerformLayout();
      this.KModePege.ResumeLayout(false);
      this.KModePege.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.DevPege.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel DownBar;
    private System.Windows.Forms.Label DownBarText;
    private new System.Windows.Forms.Button CancelButton;
    private System.Windows.Forms.Button OKButton;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage WindowPege;
    private System.Windows.Forms.TabPage WebPege;
    private System.Windows.Forms.TabPage KModePege;
    private System.Windows.Forms.CheckBox ChangeTab;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox NoTaskBar;
    private new System.Windows.Forms.CheckBox Top;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox NoClose;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.CheckBox OpenThis;
    private System.Windows.Forms.CheckBox ecm;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.CheckBox ModeON;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.CheckBox AuteMute;
    private System.Windows.Forms.CheckBox NoNewSite;
    private System.Windows.Forms.TabPage DevPege;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.CheckBox DevMode;
  }
}