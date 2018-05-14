namespace NA2_Lab2
{
    partial class Main
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
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonNFIF = new System.Windows.Forms.Button();
            this.buttonNSIF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(240, 32);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(203, 25);
            this.labelHello.TabIndex = 5;
            this.labelHello.Text = "Welcome to Lab 9001";
            // 
            // buttonNFIF
            // 
            this.buttonNFIF.Location = new System.Drawing.Point(350, 123);
            this.buttonNFIF.Name = "buttonNFIF";
            this.buttonNFIF.Size = new System.Drawing.Size(315, 81);
            this.buttonNFIF.TabIndex = 4;
            this.buttonNFIF.Text = "Newton\'s first interpolation formula for non-equidistant nodes";
            this.buttonNFIF.UseVisualStyleBackColor = true;
            this.buttonNFIF.Click += new System.EventHandler(this.buttonNFIF_Click);
            // 
            // buttonNSIF
            // 
            this.buttonNSIF.Location = new System.Drawing.Point(12, 123);
            this.buttonNSIF.Name = "buttonNSIF";
            this.buttonNSIF.Size = new System.Drawing.Size(320, 81);
            this.buttonNSIF.TabIndex = 3;
            this.buttonNSIF.Text = "Newton\'s second interpolation formula";
            this.buttonNSIF.UseVisualStyleBackColor = true;
            this.buttonNSIF.Click += new System.EventHandler(this.buttonNSIF_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 216);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonNFIF);
            this.Controls.Add(this.buttonNSIF);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonNFIF;
        private System.Windows.Forms.Button buttonNSIF;
    }
}