namespace NA2_Lab2
{
    partial class NSIF
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInputNumbers = new System.Windows.Forms.TextBox();
            this.buttonInterpolNewton = new System.Windows.Forms.Button();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.labelH = new System.Windows.Forms.Label();
            this.labelX0 = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.comboBoxNumberOfExample = new System.Windows.Forms.ComboBox();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxInputTasks = new System.Windows.Forms.TextBox();
            this.labelFunctionWord = new System.Windows.Forms.Label();
            this.textBoxFunction = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInputNumbers
            // 
            this.textBoxInputNumbers.Location = new System.Drawing.Point(83, 67);
            this.textBoxInputNumbers.Name = "textBoxInputNumbers";
            this.textBoxInputNumbers.Size = new System.Drawing.Size(255, 22);
            this.textBoxInputNumbers.TabIndex = 0;
            this.textBoxInputNumbers.TextChanged += new System.EventHandler(this.textBoxInputNumbers_TextChanged);
            // 
            // buttonInterpolNewton
            // 
            this.buttonInterpolNewton.Location = new System.Drawing.Point(368, 238);
            this.buttonInterpolNewton.Name = "buttonInterpolNewton";
            this.buttonInterpolNewton.Size = new System.Drawing.Size(156, 42);
            this.buttonInterpolNewton.TabIndex = 1;
            this.buttonInterpolNewton.Text = "Program start";
            this.buttonInterpolNewton.UseVisualStyleBackColor = true;
            this.buttonInterpolNewton.Click += new System.EventHandler(this.buttonInterpolNewton_Click);
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(140, 173);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(198, 22);
            this.textBoxH.TabIndex = 2;
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(140, 145);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(198, 22);
            this.textBoxX0.TabIndex = 3;
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(9, 173);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(63, 17);
            this.labelH.TabIndex = 4;
            this.labelH.Text = "H (step):";
            // 
            // labelX0
            // 
            this.labelX0.AutoSize = true;
            this.labelX0.Location = new System.Drawing.Point(10, 145);
            this.labelX0.Name = "labelX0";
            this.labelX0.Size = new System.Drawing.Size(125, 17);
            this.labelX0.TabIndex = 5;
            this.labelX0.Text = "X0 (starting point):";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(6, 68);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(74, 17);
            this.labelY.TabIndex = 6;
            this.labelY.Text = "Known Ys:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(9, 295);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(867, 209);
            this.textBoxResult.TabIndex = 7;
            // 
            // comboBoxNumberOfExample
            // 
            this.comboBoxNumberOfExample.FormattingEnabled = true;
            this.comboBoxNumberOfExample.Items.AddRange(new object[] {
            "1;4;9;16;25",
            "-13.021;-13.791;-14.989",
            "Function"});
            this.comboBoxNumberOfExample.Location = new System.Drawing.Point(344, 65);
            this.comboBoxNumberOfExample.Name = "comboBoxNumberOfExample";
            this.comboBoxNumberOfExample.Size = new System.Drawing.Size(180, 24);
            this.comboBoxNumberOfExample.TabIndex = 8;
            this.comboBoxNumberOfExample.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(9, 201);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(81, 17);
            this.labelX.TabIndex = 9;
            this.labelX.Text = "Wanted Xs:";
            // 
            // textBoxInputTasks
            // 
            this.textBoxInputTasks.Location = new System.Drawing.Point(95, 201);
            this.textBoxInputTasks.Name = "textBoxInputTasks";
            this.textBoxInputTasks.Size = new System.Drawing.Size(781, 22);
            this.textBoxInputTasks.TabIndex = 10;
            // 
            // labelFunctionWord
            // 
            this.labelFunctionWord.AutoSize = true;
            this.labelFunctionWord.Location = new System.Drawing.Point(530, 64);
            this.labelFunctionWord.Name = "labelFunctionWord";
            this.labelFunctionWord.Size = new System.Drawing.Size(271, 17);
            this.labelFunctionWord.TabIndex = 11;
            this.labelFunctionWord.Text = "Function: y = x*sin(x) + (x^2)*(e^x)+ln(x^3)";
            // 
            // textBoxFunction
            // 
            this.textBoxFunction.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxFunction.Location = new System.Drawing.Point(807, 61);
            this.textBoxFunction.Name = "textBoxFunction";
            this.textBoxFunction.ReadOnly = true;
            this.textBoxFunction.Size = new System.Drawing.Size(72, 22);
            this.textBoxFunction.TabIndex = 12;
            this.textBoxFunction.Text = "No";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(741, 92);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(60, 17);
            this.labelSize.TabIndex = 13;
            this.labelSize.Text = "Y\'s size:";
            // 
            // textBoxSize
            // 
            this.textBoxSize.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxSize.Location = new System.Drawing.Point(807, 92);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.ReadOnly = true;
            this.textBoxSize.Size = new System.Drawing.Size(69, 22);
            this.textBoxSize.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(257, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Newton\'s second interpolation formula";
            // 
            // NSIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.textBoxFunction);
            this.Controls.Add(this.labelFunctionWord);
            this.Controls.Add(this.textBoxInputTasks);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.comboBoxNumberOfExample);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX0);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.textBoxX0);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.buttonInterpolNewton);
            this.Controls.Add(this.textBoxInputNumbers);
            this.Name = "NSIF";
            this.Text = "Newton\'s second interpolation formula";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NSIF_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputNumbers;
        private System.Windows.Forms.Button buttonInterpolNewton;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelX0;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ComboBox comboBoxNumberOfExample;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxInputTasks;
        private System.Windows.Forms.Label labelFunctionWord;
        private System.Windows.Forms.TextBox textBoxFunction;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label label1;
    }
}

