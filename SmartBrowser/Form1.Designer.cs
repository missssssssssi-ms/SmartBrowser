namespace SmartBrowser
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
            this.Webview = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.HyperS = new System.Windows.Forms.CheckBox();
            this.OpenSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Webview)).BeginInit();
            this.SuspendLayout();
            // 
            // Webview
            // 
            this.Webview.AllowExternalDrop = true;
            this.Webview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Webview.CreationProperties = null;
            this.Webview.DefaultBackgroundColor = System.Drawing.Color.White;
            this.Webview.Location = new System.Drawing.Point(0, 31);
            this.Webview.Name = "Webview";
            this.Webview.Size = new System.Drawing.Size(1101, 699);
            this.Webview.TabIndex = 0;
            this.Webview.ZoomFactor = 1D;
            // 
            // UrlBox
            // 
            this.UrlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlBox.Location = new System.Drawing.Point(0, 0);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(1101, 25);
            this.UrlBox.TabIndex = 1;
            this.UrlBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlBox_KeyDown);
            // 
            // HyperS
            // 
            this.HyperS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HyperS.AutoSize = true;
            this.HyperS.Location = new System.Drawing.Point(12, 736);
            this.HyperS.Name = "HyperS";
            this.HyperS.Size = new System.Drawing.Size(189, 22);
            this.HyperS.TabIndex = 2;
            this.HyperS.Text = "高度な保護を有効化";
            this.HyperS.UseVisualStyleBackColor = true;
            this.HyperS.CheckedChanged += new System.EventHandler(this.HyperS_CheckedChanged);
            // 
            // OpenSettings
            // 
            this.OpenSettings.Location = new System.Drawing.Point(664, 729);
            this.OpenSettings.Name = "OpenSettings";
            this.OpenSettings.Size = new System.Drawing.Size(97, 35);
            this.OpenSettings.TabIndex = 3;
            this.OpenSettings.Text = "オプション";
            this.OpenSettings.UseVisualStyleBackColor = true;
            this.OpenSettings.Click += new System.EventHandler(this.OpenSettings_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Webview2は実行されていません｡";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 769);
            this.Controls.Add(this.OpenSettings);
            this.Controls.Add(this.HyperS);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.Webview);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "チャット | Microsoft Teams - 個人 - Microsoft Edge";
            ((System.ComponentModel.ISupportInitialize)(this.Webview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 Webview;
        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.CheckBox HyperS;
        private System.Windows.Forms.Button OpenSettings;
        private System.Windows.Forms.Label label1;
    }
}

