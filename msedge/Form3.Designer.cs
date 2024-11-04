namespace msedge
{
  partial class Form3
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.OpenUpdate = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.OpenGithub = new System.Windows.Forms.Button();
      this.Close = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.OpenFeedBack = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.Icon = new System.Windows.Forms.PictureBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.OpenUpdate);
      this.groupBox1.Controls.Add(this.label4);
      resources.ApplyResources(this.groupBox1, "groupBox1");
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.TabStop = false;
      // 
      // OpenUpdate
      // 
      resources.ApplyResources(this.OpenUpdate, "OpenUpdate");
      this.OpenUpdate.Name = "OpenUpdate";
      this.OpenUpdate.UseVisualStyleBackColor = true;
      this.OpenUpdate.Click += new System.EventHandler(this.OpenUpdate_Click);
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.Name = "label4";
      // 
      // OpenGithub
      // 
      resources.ApplyResources(this.OpenGithub, "OpenGithub");
      this.OpenGithub.Name = "OpenGithub";
      this.OpenGithub.UseVisualStyleBackColor = true;
      this.OpenGithub.Click += new System.EventHandler(this.OpenGithub_Click);
      // 
      // Close
      // 
      resources.ApplyResources(this.Close, "Close");
      this.Close.Name = "Close";
      this.Close.UseVisualStyleBackColor = true;
      this.Close.Click += new System.EventHandler(this.Close_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.OpenFeedBack);
      this.groupBox2.Controls.Add(this.label5);
      resources.ApplyResources(this.groupBox2, "groupBox2");
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.TabStop = false;
      // 
      // OpenFeedBack
      // 
      resources.ApplyResources(this.OpenFeedBack, "OpenFeedBack");
      this.OpenFeedBack.Name = "OpenFeedBack";
      this.OpenFeedBack.UseVisualStyleBackColor = true;
      this.OpenFeedBack.Click += new System.EventHandler(this.OpenFeedBack_Click);
      // 
      // label5
      // 
      resources.ApplyResources(this.label5, "label5");
      this.label5.Name = "label5";
      // 
      // Icon
      // 
      this.Icon.ErrorImage = global::msedge.Properties.Resources.App;
      this.Icon.Image = global::msedge.Properties.Resources.App;
      resources.ApplyResources(this.Icon, "Icon");
      this.Icon.Name = "Icon";
      this.Icon.TabStop = false;
      // 
      // Form3
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.Close);
      this.Controls.Add(this.OpenGithub);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Icon);
      this.Name = "Form3";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox Icon;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button OpenUpdate;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button OpenGithub;
    private System.Windows.Forms.Button Close;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button OpenFeedBack;
    private System.Windows.Forms.Label label5;
  }
}