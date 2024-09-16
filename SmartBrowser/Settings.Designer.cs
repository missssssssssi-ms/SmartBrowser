namespace SmartBrowser
{
    partial class Settings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tools = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomOK = new System.Windows.Forms.Button();
            this.CustomBox = new System.Windows.Forms.TextBox();
            this.CustomCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TopSab = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TopMain = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Devtool = new System.Windows.Forms.Button();
            this.Sets = new System.Windows.Forms.TabPage();
            this.About = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Tools.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.About.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tools);
            this.tabControl1.Controls.Add(this.Sets);
            this.tabControl1.Controls.Add(this.About);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 744);
            this.tabControl1.TabIndex = 0;
            // 
            // Tools
            // 
            this.Tools.Controls.Add(this.groupBox4);
            this.Tools.Controls.Add(this.groupBox2);
            this.Tools.Location = new System.Drawing.Point(4, 28);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(470, 712);
            this.Tools.TabIndex = 0;
            this.Tools.Text = "機能";
            this.Tools.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(454, 282);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ウィンドウ管理";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.CustomOK);
            this.groupBox6.Controls.Add(this.CustomBox);
            this.groupBox6.Controls.Add(this.CustomCheck);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(6, 136);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(442, 140);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "カスタムウィンドウタイトル";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 104);
            this.label6.MaximumSize = new System.Drawing.Size(445, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(426, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "設定は､すべてのメインウィンドウで適用され､一部のウィンドウは､変更できません｡";
            // 
            // CustomOK
            // 
            this.CustomOK.Location = new System.Drawing.Point(355, 67);
            this.CustomOK.Name = "CustomOK";
            this.CustomOK.Size = new System.Drawing.Size(87, 35);
            this.CustomOK.TabIndex = 3;
            this.CustomOK.Text = "適用";
            this.CustomOK.UseVisualStyleBackColor = true;
            this.CustomOK.Click += new System.EventHandler(this.CustomOK_Click);
            // 
            // CustomBox
            // 
            this.CustomBox.Location = new System.Drawing.Point(10, 72);
            this.CustomBox.Name = "CustomBox";
            this.CustomBox.Size = new System.Drawing.Size(339, 25);
            this.CustomBox.TabIndex = 2;
            // 
            // CustomCheck
            // 
            this.CustomCheck.AutoSize = true;
            this.CustomCheck.Location = new System.Drawing.Point(10, 43);
            this.CustomCheck.Name = "CustomCheck";
            this.CustomCheck.Size = new System.Drawing.Size(139, 22);
            this.CustomCheck.TabIndex = 1;
            this.CustomCheck.Text = "機能の有効化";
            this.CustomCheck.UseVisualStyleBackColor = true;
            this.CustomCheck.CheckedChanged += new System.EventHandler(this.CustomCheck_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(342, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "メインウィンドウのタイトルを自由に変更できます｡";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TopSab);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.TopMain);
            this.groupBox5.Location = new System.Drawing.Point(6, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(442, 106);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "常に手前に表示";
            // 
            // TopSab
            // 
            this.TopSab.AutoSize = true;
            this.TopSab.Location = new System.Drawing.Point(10, 70);
            this.TopSab.Name = "TopSab";
            this.TopSab.Size = new System.Drawing.Size(260, 22);
            this.TopSab.TabIndex = 4;
            this.TopSab.Text = "オプションウィンドウ(このウィンドウ)";
            this.TopSab.UseVisualStyleBackColor = true;
            this.TopSab.CheckedChanged += new System.EventHandler(this.TopSab_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "指定したウィンドウを常に手前に表示します｡";
            // 
            // TopMain
            // 
            this.TopMain.AutoSize = true;
            this.TopMain.Location = new System.Drawing.Point(10, 42);
            this.TopMain.Name = "TopMain";
            this.TopMain.Size = new System.Drawing.Size(134, 22);
            this.TopMain.TabIndex = 3;
            this.TopMain.Text = "メインウィンドウ";
            this.TopMain.UseVisualStyleBackColor = true;
            this.TopMain.CheckedChanged += new System.EventHandler(this.TopMain_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Devtool);
            this.groupBox2.Location = new System.Drawing.Point(8, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 197);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "開発者向け機能";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 73);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DevToolの注意点";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "DevToolは､新しいウィンドウで実行されます｡\r\nSmartBrowser内蔵のウィンドウ管理機能は､使用できません｡";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "DevToolを開きます｡";
            // 
            // Devtool
            // 
            this.Devtool.Location = new System.Drawing.Point(6, 24);
            this.Devtool.Name = "Devtool";
            this.Devtool.Size = new System.Drawing.Size(88, 34);
            this.Devtool.TabIndex = 0;
            this.Devtool.Text = "DevTool";
            this.Devtool.UseVisualStyleBackColor = true;
            this.Devtool.Click += new System.EventHandler(this.Devtool_Click);
            // 
            // Sets
            // 
            this.Sets.Location = new System.Drawing.Point(4, 28);
            this.Sets.Name = "Sets";
            this.Sets.Size = new System.Drawing.Size(470, 712);
            this.Sets.TabIndex = 1;
            this.Sets.Text = "詳細設定";
            this.Sets.UseVisualStyleBackColor = true;
            // 
            // About
            // 
            this.About.Controls.Add(this.groupBox1);
            this.About.Location = new System.Drawing.Point(4, 28);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(470, 712);
            this.About.TabIndex = 2;
            this.About.Text = "情報";
            this.About.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AboutButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "このプログラムについて";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "このプログラムの詳細情報を入手できます｡";
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(6, 23);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 31);
            this.AboutButton.TabIndex = 0;
            this.AboutButton.Text = "情報";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 744);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(500, 800);
            this.MinimumSize = new System.Drawing.Size(500, 800);
            this.Name = "Settings";
            this.Text = "Google - 個人 - Microsoft Edge";
            this.tabControl1.ResumeLayout(false);
            this.Tools.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.About.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tools;
        private System.Windows.Forms.TabPage Sets;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Devtool;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox TopMain;
        private System.Windows.Forms.CheckBox TopSab;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button CustomOK;
        private System.Windows.Forms.TextBox CustomBox;
        private System.Windows.Forms.CheckBox CustomCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}