namespace msedge
{
  partial class Form6
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
      this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
      this.panel1 = new System.Windows.Forms.Panel();
      this.Tool = new System.Windows.Forms.Button();
      this.Inwindow = new System.Windows.Forms.CheckBox();
      this.URL = new System.Windows.Forms.TextBox();
      this.Next = new System.Windows.Forms.Button();
      this.Back = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // webView21
      // 
      this.webView21.AllowExternalDrop = true;
      this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.webView21.CreationProperties = null;
      this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
      this.webView21.Location = new System.Drawing.Point(0, 32);
      this.webView21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.webView21.Name = "webView21";
      this.webView21.Size = new System.Drawing.Size(1067, 530);
      this.webView21.TabIndex = 0;
      this.webView21.ZoomFactor = 1D;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.Tool);
      this.panel1.Controls.Add(this.Inwindow);
      this.panel1.Controls.Add(this.URL);
      this.panel1.Controls.Add(this.Next);
      this.panel1.Controls.Add(this.Back);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1067, 30);
      this.panel1.TabIndex = 1;
      // 
      // Tool
      // 
      this.Tool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.Tool.Location = new System.Drawing.Point(844, 0);
      this.Tool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Tool.Name = "Tool";
      this.Tool.Size = new System.Drawing.Size(60, 29);
      this.Tool.TabIndex = 4;
      this.Tool.Text = "Tool";
      this.Tool.UseVisualStyleBackColor = true;
      this.Tool.Click += new System.EventHandler(this.Tool_Click);
      // 
      // Inwindow
      // 
      this.Inwindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.Inwindow.AutoSize = true;
      this.Inwindow.Location = new System.Drawing.Point(925, 5);
      this.Inwindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Inwindow.Name = "Inwindow";
      this.Inwindow.Size = new System.Drawing.Size(138, 19);
      this.Inwindow.TabIndex = 3;
      this.Inwindow.Text = "このウィンドウで開く";
      this.Inwindow.UseVisualStyleBackColor = true;
      // 
      // URL
      // 
      this.URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.URL.Location = new System.Drawing.Point(77, 2);
      this.URL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.URL.Name = "URL";
      this.URL.Size = new System.Drawing.Size(757, 22);
      this.URL.TabIndex = 2;
      this.URL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URL_KeyDown);
      // 
      // Next
      // 
      this.Next.Location = new System.Drawing.Point(39, 0);
      this.Next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Next.Name = "Next";
      this.Next.Size = new System.Drawing.Size(31, 29);
      this.Next.TabIndex = 1;
      this.Next.Text = ">";
      this.Next.UseVisualStyleBackColor = true;
      this.Next.Click += new System.EventHandler(this.Next_Click);
      // 
      // Back
      // 
      this.Back.Location = new System.Drawing.Point(0, 0);
      this.Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Back.Name = "Back";
      this.Back.Size = new System.Drawing.Size(31, 29);
      this.Back.TabIndex = 0;
      this.Back.Text = "<";
      this.Back.UseVisualStyleBackColor = true;
      this.Back.Click += new System.EventHandler(this.Back_Click);
      // 
      // Form6
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1067, 562);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.webView21);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form6";
      ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.CheckBox Inwindow;
    private System.Windows.Forms.TextBox URL;
    private System.Windows.Forms.Button Next;
    private System.Windows.Forms.Button Back;
    private System.Windows.Forms.Button Tool;
  }
}