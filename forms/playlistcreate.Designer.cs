namespace mediaplayer.forms
{
    partial class playlistcreate
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
            this.playlist_textBox = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playlist_textBox
            // 
            this.playlist_textBox.Location = new System.Drawing.Point(11, 46);
            this.playlist_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.playlist_textBox.Name = "playlist_textBox";
            this.playlist_textBox.Size = new System.Drawing.Size(233, 20);
            this.playlist_textBox.TabIndex = 18;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(11, 71);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 19;
            this.create.Text = "создать";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(169, 71);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 20;
            this.open.Text = "открыть";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Введите имя плейлиста:";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(88, 71);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 22;
            this.delete.Text = "удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // playlistcreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 124);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.open);
            this.Controls.Add(this.create);
            this.Controls.Add(this.playlist_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "playlistcreate";
            this.Text = "playlistcreate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.playlistcreate_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playlist_textBox;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete;
    }
}