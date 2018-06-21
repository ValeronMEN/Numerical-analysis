namespace NA2_Lab4
{
    partial class MidpointMethod
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
            this.pictureBoxTask = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxResultH = new System.Windows.Forms.TextBox();
            this.textBoxResultY1 = new System.Windows.Forms.TextBox();
            this.textBoxResultX = new System.Windows.Forms.TextBox();
            this.textBoxResultY2 = new System.Windows.Forms.TextBox();
            this.textBoxResultY3 = new System.Windows.Forms.TextBox();
            this.labelY1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxResultY4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTask
            // 
            this.pictureBoxTask.Location = new System.Drawing.Point(246, 70);
            this.pictureBoxTask.Name = "pictureBoxTask";
            this.pictureBoxTask.Size = new System.Drawing.Size(724, 87);
            this.pictureBoxTask.TabIndex = 0;
            this.pictureBoxTask.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(525, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(193, 29);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Midpoint Method";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(550, 163);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(160, 60);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxResultH
            // 
            this.textBoxResultH.Location = new System.Drawing.Point(12, 229);
            this.textBoxResultH.Multiline = true;
            this.textBoxResultH.Name = "textBoxResultH";
            this.textBoxResultH.ReadOnly = true;
            this.textBoxResultH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultH.Size = new System.Drawing.Size(1253, 49);
            this.textBoxResultH.TabIndex = 12;
            // 
            // textBoxResultY1
            // 
            this.textBoxResultY1.Location = new System.Drawing.Point(266, 335);
            this.textBoxResultY1.Multiline = true;
            this.textBoxResultY1.Name = "textBoxResultY1";
            this.textBoxResultY1.ReadOnly = true;
            this.textBoxResultY1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultY1.Size = new System.Drawing.Size(244, 265);
            this.textBoxResultY1.TabIndex = 11;
            // 
            // textBoxResultX
            // 
            this.textBoxResultX.Location = new System.Drawing.Point(9, 335);
            this.textBoxResultX.Multiline = true;
            this.textBoxResultX.Name = "textBoxResultX";
            this.textBoxResultX.ReadOnly = true;
            this.textBoxResultX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultX.Size = new System.Drawing.Size(244, 265);
            this.textBoxResultX.TabIndex = 10;
            // 
            // textBoxResultY2
            // 
            this.textBoxResultY2.Location = new System.Drawing.Point(521, 335);
            this.textBoxResultY2.Multiline = true;
            this.textBoxResultY2.Name = "textBoxResultY2";
            this.textBoxResultY2.ReadOnly = true;
            this.textBoxResultY2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultY2.Size = new System.Drawing.Size(244, 265);
            this.textBoxResultY2.TabIndex = 13;
            // 
            // textBoxResultY3
            // 
            this.textBoxResultY3.Location = new System.Drawing.Point(771, 335);
            this.textBoxResultY3.Multiline = true;
            this.textBoxResultY3.Name = "textBoxResultY3";
            this.textBoxResultY3.ReadOnly = true;
            this.textBoxResultY3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultY3.Size = new System.Drawing.Size(244, 265);
            this.textBoxResultY3.TabIndex = 14;
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY1.Location = new System.Drawing.Point(297, 291);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(151, 24);
            this.labelY1.TabIndex = 15;
            this.labelY1.Text = "Midpoint Method";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(517, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "The Explicit Euler Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(767, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "The Improved Euler Method";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "(for comparison)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(834, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "(for comparison)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1084, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "(for comparison)";
            // 
            // textBoxResultY4
            // 
            this.textBoxResultY4.Location = new System.Drawing.Point(1021, 335);
            this.textBoxResultY4.Multiline = true;
            this.textBoxResultY4.Name = "textBoxResultY4";
            this.textBoxResultY4.ReadOnly = true;
            this.textBoxResultY4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultY4.Size = new System.Drawing.Size(244, 265);
            this.textBoxResultY4.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1068, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Heun\'s Method";
            // 
            // MidpointMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 608);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxResultY4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.textBoxResultY3);
            this.Controls.Add(this.textBoxResultY2);
            this.Controls.Add(this.textBoxResultH);
            this.Controls.Add(this.textBoxResultY1);
            this.Controls.Add(this.textBoxResultX);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MidpointMethod";
            this.Text = "Midpoint Method";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiddlePointMethod_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTask;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxResultH;
        private System.Windows.Forms.TextBox textBoxResultY1;
        private System.Windows.Forms.TextBox textBoxResultX;
        private System.Windows.Forms.TextBox textBoxResultY2;
        private System.Windows.Forms.TextBox textBoxResultY3;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxResultY4;
        private System.Windows.Forms.Label label8;
    }
}