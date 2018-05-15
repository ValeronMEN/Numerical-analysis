namespace NA2_Lab3
{
    partial class Trap
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxGapsSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(116, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(443, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Composite quadrature formula of trapeziums";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(229, 201);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(227, 55);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Program start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 280);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(660, 160);
            this.textBoxResult.TabIndex = 2;
            // 
            // textBoxGapsSize
            // 
            this.textBoxGapsSize.Location = new System.Drawing.Point(121, 57);
            this.textBoxGapsSize.Name = "textBoxGapsSize";
            this.textBoxGapsSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxGapsSize.TabIndex = 3;
            this.textBoxGapsSize.Text = "4000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "The gaps size:";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFormula.Location = new System.Drawing.Point(144, 101);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(380, 77);
            this.pictureBoxFormula.TabIndex = 5;
            this.pictureBoxFormula.TabStop = false;
            // 
            // Trap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 452);
            this.Controls.Add(this.pictureBoxFormula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGapsSize);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTitle);
            this.Name = "Trap";
            this.Text = "Trap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Trap_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxGapsSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
    }
}