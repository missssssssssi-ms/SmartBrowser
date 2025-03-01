namespace msedge
{
  partial class Form5
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.OpenWindow = new System.Windows.Forms.Button();
      this.SettingEC = new System.Windows.Forms.CheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.URLBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.AboutBtn = new System.Windows.Forms.Button();
      this.CloseBtn = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.OpenMainWindow = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.OpenWindow);
      this.groupBox1.Controls.Add(this.SettingEC);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.URLBox);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(16, 85);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Size = new System.Drawing.Size(224, 351);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "アプリモード";
      // 
      // OpenWindow
      // 
      this.OpenWindow.Location = new System.Drawing.Point(11, 224);
      this.OpenWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.OpenWindow.Name = "OpenWindow";
      this.OpenWindow.Size = new System.Drawing.Size(205, 29);
      this.OpenWindow.TabIndex = 4;
      this.OpenWindow.Text = "新しいウィンドウで開く";
      this.OpenWindow.UseVisualStyleBackColor = true;
      this.OpenWindow.Click += new System.EventHandler(this.OpenWindow_Click);
      // 
      // SettingEC
      // 
      this.SettingEC.AutoSize = true;
      this.SettingEC.Location = new System.Drawing.Point(11, 181);
      this.SettingEC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.SettingEC.Name = "SettingEC";
      this.SettingEC.Size = new System.Drawing.Size(155, 34);
      this.SettingEC.TabIndex = 3;
      this.SettingEC.Text = "簡易コントロール\r\nを有効化(試験機能)";
      this.SettingEC.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.SystemColors.Window;
      this.label3.Location = new System.Drawing.Point(8, 154);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(58, 15);
      this.label3.TabIndex = 2;
      this.label3.Text = "https://";
      // 
      // URLBox
      // 
      this.URLBox.Location = new System.Drawing.Point(65, 150);
      this.URLBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.URLBox.Name = "URLBox";
      this.URLBox.Size = new System.Drawing.Size(149, 22);
      this.URLBox.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(8, 19);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(201, 120);
      this.label2.TabIndex = 0;
      this.label2.Text = "指定したページを独立したウィンド\r\nウで開きます｡\r\nこのモードを使用すると､新しい\r\nウィンドウが開き､ウィンドウのすべ\r\nてにサイトを表示します｡\r\n一部の機" +
    "能(ウィンドウタイトルの\r\n変更､新しいウィンドウの防止)は\r\n使用できません｡";
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = global::msedge.Properties.Resources.App;
      this.pictureBox2.Location = new System.Drawing.Point(16, 15);
      this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(67, 62);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 1;
      this.pictureBox2.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.label1.Location = new System.Drawing.Point(91, 18);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(395, 60);
      this.label1.TabIndex = 2;
      this.label1.Text = "SmartBrowser";
      // 
      // AboutBtn
      // 
      this.AboutBtn.Location = new System.Drawing.Point(508, 15);
      this.AboutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.AboutBtn.Name = "AboutBtn";
      this.AboutBtn.Size = new System.Drawing.Size(255, 29);
      this.AboutBtn.TabIndex = 3;
      this.AboutBtn.Text = "このアプリについて";
      this.AboutBtn.UseVisualStyleBackColor = true;
      this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
      // 
      // CloseBtn
      // 
      this.CloseBtn.Location = new System.Drawing.Point(508, 49);
      this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.CloseBtn.Name = "CloseBtn";
      this.CloseBtn.Size = new System.Drawing.Size(255, 29);
      this.CloseBtn.TabIndex = 4;
      this.CloseBtn.Text = "このウィンドウを閉じる";
      this.CloseBtn.UseVisualStyleBackColor = true;
      this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.button1);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Location = new System.Drawing.Point(248, 85);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox2.Size = new System.Drawing.Size(268, 154);
      this.groupBox2.TabIndex = 5;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Wiki";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(11, 98);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(249, 29);
      this.button1.TabIndex = 1;
      this.button1.Text = "新しいウィンドウで開く";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(8, 19);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(238, 75);
      this.label4.TabIndex = 0;
      this.label4.Text = "SmartBrowserのWikiを表示します｡\r\nこのサイトにはSmartBrowserの使い方\r\nや､新機能を紹介しています｡\r\nフィードバックを送信するには" +
    "､\"このアプリ\r\nについて\"をクリックしてください｡";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.OpenMainWindow);
      this.groupBox3.Controls.Add(this.label5);
      this.groupBox3.Location = new System.Drawing.Point(249, 246);
      this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox3.Size = new System.Drawing.Size(267, 190);
      this.groupBox3.TabIndex = 6;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "メインウィンドウ";
      // 
      // OpenMainWindow
      // 
      this.OpenMainWindow.Location = new System.Drawing.Point(8, 111);
      this.OpenMainWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.OpenMainWindow.Name = "OpenMainWindow";
      this.OpenMainWindow.Size = new System.Drawing.Size(251, 29);
      this.OpenMainWindow.TabIndex = 1;
      this.OpenMainWindow.Text = "メインウィンドウを開く";
      this.OpenMainWindow.UseVisualStyleBackColor = true;
      this.OpenMainWindow.Click += new System.EventHandler(this.OpenMainWindow_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(8, 20);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(236, 75);
      this.label5.TabIndex = 0;
      this.label5.Text = "メインウィンドウを表示します｡メインウィン\r\nドウでは､アプリモードとは違い､すべての\r\n機能を使用できます｡\r\nただ､メインウィンドウでは､機能が多い\r\nため､" +
    "最大化することをおすすめします｡";
      // 
      // Form5
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(776, 441);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.CloseBtn);
      this.Controls.Add(this.AboutBtn);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.groupBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MaximumSize = new System.Drawing.Size(794, 488);
      this.MinimumSize = new System.Drawing.Size(794, 488);
      this.Name = "Form5";
      this.TopMost = true;
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button AboutBtn;
    private System.Windows.Forms.Button CloseBtn;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button OpenWindow;
    private System.Windows.Forms.CheckBox SettingEC;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox URLBox;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button OpenMainWindow;
  }
}