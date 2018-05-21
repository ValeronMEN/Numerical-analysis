namespace NA2_Lab3
{
    partial class RecTrap
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
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrecision = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFormula.Location = new System.Drawing.Point(144, 110);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(380, 77);
            this.pictureBoxFormula.TabIndex = 11;
            this.pictureBoxFormula.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Precision:";
            // 
            // textBoxPrecision
            // 
            this.textBoxPrecision.Location = new System.Drawing.Point(90, 66);
            this.textBoxPrecision.Name = "textBoxPrecision";
            this.textBoxPrecision.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrecision.TabIndex = 9;
            this.textBoxPrecision.Text = "0.001";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 289);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(660, 160);
            this.textBoxResult.TabIndex = 8;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(229, 210);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(227, 55);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Program start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(185, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(309, 26);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Rectangle-trapezium algorithm";
            // 
            // RecTrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 464);
            this.Controls.Add(this.pictureBoxFormula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrecision);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTitle);
            this.Name = "RecTrap";
            this.Text = "RecTrap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecTrap_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrecision;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTitle;
    }
}