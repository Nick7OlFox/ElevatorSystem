namespace Assignment1
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
            this.LogTxt = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.UpdateLogBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogTxt
            // 
            resources.ApplyResources(this.LogTxt, "LogTxt");
            this.LogTxt.Name = "LogTxt";
            this.LogTxt.ReadOnly = true;
            // 
            // vScrollBar1
            // 
            resources.ApplyResources(this.vScrollBar1, "vScrollBar1");
            this.vScrollBar1.Name = "vScrollBar1";
            // 
            // UpdateLogBtn
            // 
            resources.ApplyResources(this.UpdateLogBtn, "UpdateLogBtn");
            this.UpdateLogBtn.Name = "UpdateLogBtn";
            this.UpdateLogBtn.UseVisualStyleBackColor = true;
            this.UpdateLogBtn.Click += new System.EventHandler(this.DeleteLogBtn_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdateLogBtn);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.LogTxt);
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox LogTxt;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button UpdateLogBtn;
    }
}