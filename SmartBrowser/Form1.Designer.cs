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
            ((System.ComponentModel.ISupportInitialize)(this.Webview)).BeginInit();
            this.SuspendLayout();
            // 
            // Webview
            // 
            this.Webview.AllowExternalDrop = true;
            this.Webview.CreationProperties = null;
            this.Webview.DefaultBackgroundColor = System.Drawing.Color.White;
            this.Webview.Location = new System.Drawing.Point(0, 31);
            this.Webview.Name = "Webview";
            this.Webview.Size = new System.Drawing.Size(1101, 741);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 769);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.Webview);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Webview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 Webview;
        private System.Windows.Forms.TextBox UrlBox;
    }
}

