namespace msedge
{
  partial class Form4
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
      this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
      this.Ver = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
      this.SuspendLayout();
      // 
      // webView21
      // 
      this.webView21.AllowExternalDrop = true;
      this.webView21.CreationProperties = null;
      this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
      this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
      this.webView21.Location = new System.Drawing.Point(0, 0);
      this.webView21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.webView21.Name = "webView21";
      this.webView21.Size = new System.Drawing.Size(1067, 562);
      this.webView21.TabIndex = 0;
      this.webView21.ZoomFactor = 1D;
      // 
      // Ver
      // 
      this.Ver.AutoSize = true;
      this.Ver.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.Ver.Location = new System.Drawing.Point(16, 11);
      this.Ver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Ver.Name = "Ver";
      this.Ver.Size = new System.Drawing.Size(0, 25);
      this.Ver.TabIndex = 1;
      // 
      // Form4
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1067, 562);
      this.Controls.Add(this.Ver);
      this.Controls.Add(this.webView21);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form4";
      ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    private System.Windows.Forms.Label Ver;
  }
}