namespace POVWinForm
{
    partial class POVWinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POVWinForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.stringBox = new System.Windows.Forms.TextBox();
            this.fpsBox = new System.Windows.Forms.TextBox();
            this.redBox = new System.Windows.Forms.TextBox();
            this.greenBox = new System.Windows.Forms.TextBox();
            this.blueBox = new System.Windows.Forms.TextBox();
            this.mainButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.manualButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.exitManualButton = new System.Windows.Forms.Button();
            this.manualPictureBox = new System.Windows.Forms.PictureBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.btHelpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 19F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(336, 242);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1227, 838);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // stringBox
            // 
            this.stringBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stringBox.BackColor = System.Drawing.Color.White;
            this.stringBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stringBox.Font = new System.Drawing.Font("Comic Sans MS", 19F);
            this.stringBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.stringBox.Location = new System.Drawing.Point(631, 875);
            this.stringBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stringBox.MaxLength = 20;
            this.stringBox.Name = "stringBox";
            this.stringBox.Size = new System.Drawing.Size(334, 53);
            this.stringBox.TabIndex = 5;
            this.stringBox.Click += new System.EventHandler(this.stringBox_Click);
            // 
            // fpsBox
            // 
            this.fpsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsBox.BackColor = System.Drawing.Color.White;
            this.fpsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fpsBox.Font = new System.Drawing.Font("Comic Sans MS", 19F);
            this.fpsBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fpsBox.Location = new System.Drawing.Point(768, 459);
            this.fpsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fpsBox.MaxLength = 3;
            this.fpsBox.Name = "fpsBox";
            this.fpsBox.Size = new System.Drawing.Size(84, 53);
            this.fpsBox.TabIndex = 1;
            this.fpsBox.Click += new System.EventHandler(this.fpsBox_Click);
            // 
            // redBox
            // 
            this.redBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redBox.BackColor = System.Drawing.Color.White;
            this.redBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.redBox.Font = new System.Drawing.Font("Comic Sans MS", 19F);
            this.redBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.redBox.Location = new System.Drawing.Point(631, 665);
            this.redBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redBox.MaxLength = 3;
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(73, 53);
            this.redBox.TabIndex = 2;
            this.redBox.Click += new System.EventHandler(this.redBox_Click);
            // 
            // greenBox
            // 
            this.greenBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.greenBox.BackColor = System.Drawing.Color.White;
            this.greenBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.greenBox.Font = new System.Drawing.Font("Comic Sans MS", 19F);
            this.greenBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.greenBox.Location = new System.Drawing.Point(726, 665);
            this.greenBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.greenBox.MaxLength = 3;
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(73, 53);
            this.greenBox.TabIndex = 3;
            this.greenBox.Click += new System.EventHandler(this.greenBox_Click);
            // 
            // blueBox
            // 
            this.blueBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blueBox.BackColor = System.Drawing.Color.White;
            this.blueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blueBox.Font = new System.Drawing.Font("Comic Sans MS", 19F);
            this.blueBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.blueBox.Location = new System.Drawing.Point(819, 665);
            this.blueBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blueBox.MaxLength = 3;
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(78, 53);
            this.blueBox.TabIndex = 4;
            this.blueBox.Click += new System.EventHandler(this.blueBox_Click);
            // 
            // mainButton
            // 
            this.mainButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainButton.BackColor = System.Drawing.Color.Firebrick;
            this.mainButton.Font = new System.Drawing.Font("Comic Sans MS", 31F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.ForeColor = System.Drawing.Color.White;
            this.mainButton.Location = new System.Drawing.Point(14, 414);
            this.mainButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(310, 466);
            this.mainButton.TabIndex = 6;
            this.mainButton.Text = "UPDATE";
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(336, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1225, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.BackColor = System.Drawing.Color.Firebrick;
            this.resetButton.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(14, 242);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(310, 165);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // manualButton
            // 
            this.manualButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manualButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.manualButton.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualButton.ForeColor = System.Drawing.Color.White;
            this.manualButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.manualButton.Location = new System.Drawing.Point(14, 888);
            this.manualButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(310, 192);
            this.manualButton.TabIndex = 8;
            this.manualButton.Text = "ABOUT";
            this.manualButton.UseVisualStyleBackColor = false;
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.BackColor = System.Drawing.Color.PaleGreen;
            this.rightButton.Font = new System.Drawing.Font("Comic Sans MS", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.Location = new System.Drawing.Point(1281, 1098);
            this.rightButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(284, 134);
            this.rightButton.TabIndex = 117;
            this.rightButton.Text = ">>";
            this.rightButton.UseVisualStyleBackColor = false;
            this.rightButton.Visible = false;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.BackColor = System.Drawing.Color.PaleGreen;
            this.leftButton.Font = new System.Drawing.Font("Comic Sans MS", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(336, 1098);
            this.leftButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(284, 134);
            this.leftButton.TabIndex = 118;
            this.leftButton.Text = "<<";
            this.leftButton.UseVisualStyleBackColor = false;
            this.leftButton.Visible = false;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // exitManualButton
            // 
            this.exitManualButton.BackColor = System.Drawing.Color.PaleGreen;
            this.exitManualButton.Font = new System.Drawing.Font("Comic Sans MS", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitManualButton.Location = new System.Drawing.Point(629, 1098);
            this.exitManualButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitManualButton.Name = "exitManualButton";
            this.exitManualButton.Size = new System.Drawing.Size(644, 134);
            this.exitManualButton.TabIndex = 119;
            this.exitManualButton.Text = "EXIT";
            this.exitManualButton.UseVisualStyleBackColor = false;
            this.exitManualButton.Visible = false;
            this.exitManualButton.Click += new System.EventHandler(this.exitManualButton_Click);
            // 
            // manualPictureBox
            // 
            this.manualPictureBox.Location = new System.Drawing.Point(336, 239);
            this.manualPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manualPictureBox.Name = "manualPictureBox";
            this.manualPictureBox.Size = new System.Drawing.Size(1228, 849);
            this.manualPictureBox.TabIndex = 0;
            this.manualPictureBox.TabStop = false;
            this.manualPictureBox.Visible = false;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(327, 1098);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(1077, 135);
            this.authorLabel.TabIndex = 120;
            this.authorLabel.Text = "Authors:\r\nBrannon Henderson; Raman Krishan; Noomar Naina; Saugat Khadka\r\nSpring 2" +
    "019";
            // 
            // btHelpButton
            // 
            this.btHelpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btHelpButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.btHelpButton.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelpButton.ForeColor = System.Drawing.Color.White;
            this.btHelpButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btHelpButton.Location = new System.Drawing.Point(14, 1087);
            this.btHelpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btHelpButton.Name = "btHelpButton";
            this.btHelpButton.Size = new System.Drawing.Size(310, 148);
            this.btHelpButton.TabIndex = 121;
            this.btHelpButton.Text = "BLUETOOTH PAIRING\r\nFOR DUMMIES";
            this.btHelpButton.UseVisualStyleBackColor = false;
            this.btHelpButton.Click += new System.EventHandler(this.btHelpButton_Click);
            // 
            // POVWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1575, 1249);
            this.Controls.Add(this.btHelpButton);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.manualPictureBox);
            this.Controls.Add(this.exitManualButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.manualButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.blueBox);
            this.Controls.Add(this.greenBox);
            this.Controls.Add(this.redBox);
            this.Controls.Add(this.fpsBox);
            this.Controls.Add(this.stringBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "POVWinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POVWinForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualPictureBox)).EndInit();
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
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button exitManualButton;
        private System.Windows.Forms.PictureBox manualPictureBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Button btHelpButton;
    }
}

