namespace space
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            space1 = new PictureBox();
            space2 = new PictureBox();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)space1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)space2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // space1
            // 
            space1.BackgroundImage = Properties.Resources.space;
            space1.Location = new Point(0, 0);
            space1.Name = "space1";
            space1.Size = new Size(1280, 720);
            space1.TabIndex = 0;
            space1.TabStop = false;
            // 
            // space2
            // 
            space2.BackgroundImage = Properties.Resources.space;
            space2.Location = new Point(0, -720);
            space2.Name = "space2";
            space2.Size = new Size(1280, 720);
            space2.TabIndex = 1;
            space2.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(574, 484);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 161);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(pictureBox2);
            Controls.Add(space2);
            Controls.Add(space1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)space1).EndInit();
            ((System.ComponentModel.ISupportInitialize)space2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox space1;
        private PictureBox space2;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}
