namespace BasicFacebookFeatures
{
    partial class NewPostForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPostForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sendNewPostButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 189);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.sendNewPostButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(641, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 403);
            this.panel2.TabIndex = 0;
            // 
            // sendNewPostButton
            // 
            this.sendNewPostButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendNewPostButton.Image = ((System.Drawing.Image)(resources.GetObject("sendNewPostButton.Image")));
            this.sendNewPostButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendNewPostButton.Location = new System.Drawing.Point(0, 354);
            this.sendNewPostButton.Name = "sendNewPostButton";
            this.sendNewPostButton.Size = new System.Drawing.Size(314, 49);
            this.sendNewPostButton.TabIndex = 0;
            this.sendNewPostButton.Text = "Send";
            this.sendNewPostButton.UseVisualStyleBackColor = true;
            this.sendNewPostButton.Click += new System.EventHandler(this.SendNewPostButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(641, 403);
            this.textBox1.TabIndex = 1;
            // 
            // NewPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NewPostForm";
            this.Size = new System.Drawing.Size(955, 592);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sendNewPostButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}
