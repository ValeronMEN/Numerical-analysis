namespace NA2_Lab2
{
    partial class NFIF
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInputTasks = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.comboBoxNumberOfExample = new System.Windows.Forms.ComboBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.buttonNFIF = new System.Windows.Forms.Button();
            this.textBoxInputYs = new System.Windows.Forms.TextBox();
            this.labelKnownXs = new System.Windows.Forms.Label();
            this.textBoxInputXs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(364, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Newton\'s first interpolation formula for non-equidistant nodes";
            // 
            // textBoxInputTasks
            // 
            this.textBoxInputTasks.Location = new System.Drawing.Point(93, 142);
            this.textBoxInputTasks.Name = "textBoxInputTasks";
            this.textBoxInputTasks.Size = new System.Drawing.Size(900, 22);
            this.textBoxInputTasks.TabIndex = 26;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(7, 142);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(81, 17);
            this.labelX.TabIndex = 25;
            this.labelX.Text = "Wanted Xs:";
            // 
            // comboBoxNumberOfExample
            // 
            this.comboBoxNumberOfExample.FormattingEnabled = true;
            this.comboBoxNumberOfExample.Items.AddRange(new object[] {
            "1;9;25;36",
            "28.599;12.64;5.627;4.786;7.187..."});
            this.comboBoxNumberOfExample.Location = new System.Drawing.Point(999, 65);
            this.comboBoxNumberOfExample.Name = "comboBoxNumberOfExample";
            this.comboBoxNumberOfExample.Size = new System.Drawing.Size(180, 24);
            this.comboBoxNumberOfExample.TabIndex = 24;
            this.comboBoxNumberOfExample.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumberOfExample_SelectedIndexChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(15, 247);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(1161, 262);
            this.textBoxResult.TabIndex = 23;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(9, 65);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(74, 17);
            this.labelY.TabIndex = 22;
            this.labelY.Text = "Known Ys:";
            // 
            // buttonNFIF
            // 
            this.buttonNFIF.Location = new System.Drawing.Point(543, 181);
            this.buttonNFIF.Name = "buttonNFIF";
            this.buttonNFIF.Size = new System.Drawing.Size(161, 51);
            this.buttonNFIF.TabIndex = 17;
            this.buttonNFIF.Text = "Program start";
            this.buttonNFIF.UseVisualStyleBackColor = true;
            this.buttonNFIF.Click += new System.EventHandler(this.buttonNFIF_Click);
            // 
            // textBoxInputYs
            // 
            this.textBoxInputYs.Location = new System.Drawing.Point(93, 65);
            this.textBoxInputYs.Name = "textBoxInputYs";
            this.textBoxInputYs.Size = new System.Drawing.Size(900, 22);
            this.textBoxInputYs.TabIndex = 16;
            // 
            // labelKnownXs
            // 
            this.labelKnownXs.AutoSize = true;
            this.labelKnownXs.Location = new System.Drawing.Point(9, 104);
            this.labelKnownXs.Name = "labelKnownXs";
            this.labelKnownXs.Size = new System.Drawing.Size(74, 17);
            this.labelKnownXs.TabIndex = 29;
            this.labelKnownXs.Text = "Known Xs:";
            // 
            // textBoxInputXs
            // 
            this.textBoxInputXs.Location = new System.Drawing.Point(93, 104);
            this.textBoxInputXs.Name = "textBoxInputXs";
            this.textBoxInputXs.Size = new System.Drawing.Size(900, 22);
            this.textBoxInputXs.TabIndex = 28;
            // 
            // NFIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 524);
            this.Controls.Add(this.labelKnownXs);
            this.Controls.Add(this.textBoxInputXs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInputTasks);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.comboBoxNumberOfExample);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.buttonNFIF);
            this.Controls.Add(this.textBoxInputYs);
            this.Name = "NFIF";
            this.Text = "NFIF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NFIF_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInputTasks;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.ComboBox comboBoxNumberOfExample;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button buttonNFIF;
        private System.Windows.Forms.TextBox textBoxInputYs;
        private System.Windows.Forms.Label labelKnownXs;
        private System.Windows.Forms.TextBox textBoxInputXs;
    }
}