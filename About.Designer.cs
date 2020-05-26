namespace CODEVEINPianoHelper
{
    partial class Form_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
            this.RichTextBox_About = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RichTextBox_About
            // 
            this.RichTextBox_About.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox_About.Location = new System.Drawing.Point(0, 0);
            this.RichTextBox_About.Name = "RichTextBox_About";
            this.RichTextBox_About.ReadOnly = true;
            this.RichTextBox_About.Size = new System.Drawing.Size(484, 361);
            this.RichTextBox_About.TabIndex = 0;
            this.RichTextBox_About.Text = resources.GetString("RichTextBox_About.Text");
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.RichTextBox_About);
            this.Name = "Form_About";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBox_About;
    }
}