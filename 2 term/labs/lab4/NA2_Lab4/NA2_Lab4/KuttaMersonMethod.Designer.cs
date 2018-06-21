namespace NA2_Lab4
{
    partial class KuttaMersonMethod
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxResultX = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxTask = new System.Windows.Forms.PictureBox();
            this.textBoxResultY = new System.Windows.Forms.TextBox();
            this.textBoxResultH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEps = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(286, 203);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(160, 60);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxResultX
            // 
            this.textBoxResultX.Location = new System.Drawing.Point(10, 325);
            this.textBoxResultX.Multiline = true;
            this.textBoxResultX.Name = "textBoxResultX";
            this.textBoxResultX.ReadOnly = true;
            this.textBoxResultX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultX.Size = new System.Drawing.Size(360, 265);
            this.textBoxResultX.TabIndex = 6;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(249, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(243, 29);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Kutta-Merson Method";
            // 
            // pictureBoxTask
            // 
            this.pictureBoxTask.Location = new System.Drawing.Point(12, 65);
            this.pictureBoxTask.Name = "pictureBoxTask";
            this.pictureBoxTask.Size = new System.Drawing.Size(724, 87);
            this.pictureBoxTask.TabIndex = 4;
            this.pictureBoxTask.TabStop = false;
            // 
            // textBoxResultY
            // 
            this.textBoxResultY.Location = new System.Drawing.Point(376, 325);
            this.textBoxResultY.Multiline = true;
            this.textBoxResultY.Name = "textBoxResultY";
            this.textBoxResultY.ReadOnly = true;
            this.textBoxResultY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultY.Size = new System.Drawing.Size(360, 265);
            this.textBoxResultY.TabIndex = 8;
            // 
            // textBoxResultH
            // 
            this.textBoxResultH.Location = new System.Drawing.Point(10, 269);
            this.textBoxResultH.Multiline = true;
            this.textBoxResultH.Name = "textBoxResultH";
            this.textBoxResultH.ReadOnly = true;
            this.textBoxResultH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultH.Size = new System.Drawing.Size(726, 49);
            this.textBoxResultH.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(250, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Epsilon:";
            // 
            // textBoxEps
            // 
            this.textBoxEps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEps.Location = new System.Drawing.Point(325, 167);
            this.textBoxEps.Name = "textBoxEps";
            this.textBoxEps.Size = new System.Drawing.Size(147, 26);
            this.textBoxEps.TabIndex = 11;
            this.textBoxEps.Text = "0.00001";
            // 
            // KuttaMersonMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 602);
            this.Controls.Add(this.textBoxEps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResultH);
            this.Controls.Add(this.textBoxResultY);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxResultX);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "KuttaMersonMethod";
            this.Text = "Kutta-Merson Method";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KutteMersonMethod_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxResultX;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxTask;
        private System.Windows.Forms.TextBox textBoxResultY;
        private System.Windows.Forms.TextBox textBoxResultH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEps;
    }
}