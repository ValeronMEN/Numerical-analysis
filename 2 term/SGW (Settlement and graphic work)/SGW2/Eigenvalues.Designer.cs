namespace SGW2
{
    partial class Eigenvalues
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
            this.matrixLabelA = new System.Windows.Forms.Label();
            this.matrixLabelB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // matrixLabelA
            // 
            this.matrixLabelA.AutoSize = true;
            this.matrixLabelA.Location = new System.Drawing.Point(45, 45);
            this.matrixLabelA.Name = "matrixLabelA";
            this.matrixLabelA.Size = new System.Drawing.Size(46, 17);
            this.matrixLabelA.TabIndex = 0;
            this.matrixLabelA.Text = "label1";
            // 
            // matrixLabelB
            // 
            this.matrixLabelB.AutoSize = true;
            this.matrixLabelB.Location = new System.Drawing.Point(343, 45);
            this.matrixLabelB.Name = "matrixLabelB";
            this.matrixLabelB.Size = new System.Drawing.Size(46, 17);
            this.matrixLabelB.TabIndex = 1;
            this.matrixLabelB.Text = "label1";
            // 
            // Eigenvalues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 352);
            this.Controls.Add(this.matrixLabelB);
            this.Controls.Add(this.matrixLabelA);
            this.Name = "Eigenvalues";
            this.Text = "Eigenvalues";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Eigenvalues_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matrixLabelA;
        private System.Windows.Forms.Label matrixLabelB;
    }
}