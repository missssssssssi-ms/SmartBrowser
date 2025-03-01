namespace msedge
{
    partial class Form2
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
      this.Vscode = new Microsoft.Web.WebView2.WinForms.WebView2();
      ((System.ComponentModel.ISupportInitialize)(this.Vscode)).BeginInit();
      this.SuspendLayout();
      // 
      // Vscode
      // 
      this.Vscode.AllowExternalDrop = true;
      this.Vscode.CreationProperties = null;
      this.Vscode.DefaultBackgroundColor = System.Drawing.Color.White;
      this.Vscode.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Vscode.Location = new System.Drawing.Point(0, 0);
      this.Vscode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Vscode.Name = "Vscode";
      this.Vscode.Size = new System.Drawing.Size(1067, 562);
      this.Vscode.TabIndex = 0;
      this.Vscode.ZoomFactor = 1D;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1067, 562);
      this.Controls.Add(this.Vscode);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form2";
      ((System.ComponentModel.ISupportInitialize)(this.Vscode)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 Vscode;
    }
}