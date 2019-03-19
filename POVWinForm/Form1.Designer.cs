namespace POVWinForm
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.stringBox = new System.Windows.Forms.TextBox();
            this.fpsBox = new System.Windows.Forms.TextBox();
            this.redBox = new System.Windows.Forms.TextBox();
            this.greenBox = new System.Windows.Forms.TextBox();
            this.blueBox = new System.Windows.Forms.TextBox();
            this.mainButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(521, 176);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(417, 427);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "\r\ndef displayOnGlobe():\r\n\r\n\r\n     updateRefreshRate(        )\r\n\r\n\r\n     updateCol" +
    "or(255,255,255)\r\n\r\n\r\n     updateText(stringmaxlength30)";
            // 
            // stringBox
            // 
            this.stringBox.BackColor = System.Drawing.SystemColors.Control;
            this.stringBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.stringBox.Location = new System.Drawing.Point(702, 513);
            this.stringBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stringBox.Name = "stringBox";
            this.stringBox.Size = new System.Drawing.Size(211, 35);
            this.stringBox.TabIndex = 1;
            // 
            // fpsBox
            // 
            this.fpsBox.BackColor = System.Drawing.SystemColors.Control;
            this.fpsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpsBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fpsBox.Location = new System.Drawing.Point(789, 313);
            this.fpsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fpsBox.Name = "fpsBox";
            this.fpsBox.Size = new System.Drawing.Size(56, 35);
            this.fpsBox.TabIndex = 5;
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.SystemColors.Control;
            this.redBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.redBox.Location = new System.Drawing.Point(708, 408);
            this.redBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(42, 35);
            this.redBox.TabIndex = 2;
            // 
            // greenBox
            // 
            this.greenBox.BackColor = System.Drawing.SystemColors.Control;
            this.greenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.greenBox.Location = new System.Drawing.Point(763, 408);
            this.greenBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(44, 35);
            this.greenBox.TabIndex = 3;
            // 
            // blueBox
            // 
            this.blueBox.BackColor = System.Drawing.SystemColors.Control;
            this.blueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.blueBox.Location = new System.Drawing.Point(813, 408);
            this.blueBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(43, 35);
            this.blueBox.TabIndex = 4;
            // 
            // mainButton
            // 
            this.mainButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainButton.BackColor = System.Drawing.Color.DarkRed;
            this.mainButton.BackgroundImage = global::POVWinForm.Properties.Resources.mainButtonLogo;
            this.mainButton.Location = new System.Drawing.Point(115, 254);
            this.mainButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(272, 219);
            this.mainButton.TabIndex = 6;
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::POVWinForm.Properties.Resources.CSELogo;
            this.pictureBox2.Location = new System.Drawing.Point(148, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(792, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::POVWinForm.Properties.Resources.tempLogo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 612);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.blueBox);
            this.Controls.Add(this.greenBox);
            this.Controls.Add(this.redBox);
            this.Controls.Add(this.fpsBox);
            this.Controls.Add(this.stringBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox stringBox;
        private System.Windows.Forms.TextBox fpsBox;
        private System.Windows.Forms.TextBox redBox;
        private System.Windows.Forms.TextBox greenBox;
        private System.Windows.Forms.TextBox blueBox;
        private System.Windows.Forms.Button mainButton;
    }
}

