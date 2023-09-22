namespace BasicFacebookFeatures
{
    partial class ListForm
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
            this.ListBoxInsideForm = new System.Windows.Forms.ListBox();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxInsideForm
            // 
            this.ListBoxInsideForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxInsideForm.FormattingEnabled = true;
            this.ListBoxInsideForm.ItemHeight = 20;
            this.ListBoxInsideForm.Location = new System.Drawing.Point(0, 0);
            this.ListBoxInsideForm.Name = "ListBoxInsideForm";
            this.ListBoxInsideForm.Size = new System.Drawing.Size(967, 563);
            this.ListBoxInsideForm.TabIndex = 0;
            this.ListBoxInsideForm.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.pictureBoxEvent.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxEvent.Location = new System.Drawing.Point(753, 0);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(214, 563);
            this.pictureBoxEvent.TabIndex = 1;
            this.pictureBoxEvent.TabStop = false;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.ListBoxInsideForm);
            this.Name = "ListForm";
            this.Size = new System.Drawing.Size(967, 563);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxInsideForm;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
    }
}
