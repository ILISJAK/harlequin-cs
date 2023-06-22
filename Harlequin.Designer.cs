namespace harlequin_cs
{
    partial class harlequinForm
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
            this.components = new System.ComponentModel.Container();
            this.characterPictureBox = new System.Windows.Forms.PictureBox();
            this.gameLoopTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // characterPictureBox
            // 
            this.characterPictureBox.Image = global::harlequin_cs.Properties.Resources.warlord_helmet;
            this.characterPictureBox.ImageLocation = "";
            this.characterPictureBox.Location = new System.Drawing.Point(436, 138);
            this.characterPictureBox.Name = "characterPictureBox";
            this.characterPictureBox.Size = new System.Drawing.Size(512, 512);
            this.characterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.characterPictureBox.TabIndex = 0;
            this.characterPictureBox.TabStop = false;
            // 
            // harlequinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 794);
            this.Controls.Add(this.characterPictureBox);
            this.Name = "harlequinForm";
            this.Text = "Harlequin";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.harlequinForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.harlequinForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox characterPictureBox;
        private System.Windows.Forms.Timer gameLoopTimer;
    }
}

