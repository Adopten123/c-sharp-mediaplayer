namespace mediaplayer.forms
{
    partial class deletevideo
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
            this.pathRichTextBox = new System.Windows.Forms.RichTextBox();
            this.delete_textbox = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathRichTextBox
            // 
            this.pathRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.pathRichTextBox.Name = "pathRichTextBox";
            this.pathRichTextBox.Size = new System.Drawing.Size(776, 279);
            this.pathRichTextBox.TabIndex = 18;
            this.pathRichTextBox.Text = "";
            // 
            // delete_textbox
            // 
            this.delete_textbox.Location = new System.Drawing.Point(221, 295);
            this.delete_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.delete_textbox.Name = "delete_textbox";
            this.delete_textbox.Size = new System.Drawing.Size(133, 20);
            this.delete_textbox.TabIndex = 17;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(359, 293);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(82, 23);
            this.delete.TabIndex = 19;
            this.delete.Text = "удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // deletevideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.pathRichTextBox);
            this.Controls.Add(this.delete_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "deletevideo";
            this.Text = "deletevideo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.deletevideo_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox pathRichTextBox;
        private System.Windows.Forms.TextBox delete_textbox;
        private System.Windows.Forms.Button delete;
    }
}