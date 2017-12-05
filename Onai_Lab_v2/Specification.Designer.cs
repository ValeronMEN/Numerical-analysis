namespace Onai_Lab_v2
{
    partial class Specification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Specification));
            this.label2 = new System.Windows.Forms.Label();
            this.equation = new System.Windows.Forms.TextBox();
            this.comboBoxNumberOfExample = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.method = new System.Windows.Forms.Label();
            this.textBoxMethod = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "equation:";
            // 
            // equation
            // 
            this.equation.Location = new System.Drawing.Point(425, 120);
            this.equation.Name = "equation";
            this.equation.ReadOnly = true;
            this.equation.Size = new System.Drawing.Size(318, 22);
            this.equation.TabIndex = 13;
            // 
            // comboBoxNumberOfExample
            // 
            this.comboBoxNumberOfExample.FormattingEnabled = true;
            this.comboBoxNumberOfExample.Items.AddRange(new object[] {
            "24 - метод хорд",
            "16 - метод простых итераций",
            "16 - упрощенный метод ньютона"});
            this.comboBoxNumberOfExample.Location = new System.Drawing.Point(21, 48);
            this.comboBoxNumberOfExample.Name = "comboBoxNumberOfExample";
            this.comboBoxNumberOfExample.Size = new System.Drawing.Size(259, 24);
            this.comboBoxNumberOfExample.TabIndex = 12;
            this.comboBoxNumberOfExample.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "e =";
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(56, 89);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(100, 22);
            this.textBoxE.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(21, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(726, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Solve!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "(a =";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(242, 87);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(63, 22);
            this.textBoxA.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "; b =";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(354, 86);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(61, 22);
            this.textBoxB.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = ")";
            // 
            // method
            // 
            this.method.AutoSize = true;
            this.method.Location = new System.Drawing.Point(356, 151);
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(59, 17);
            this.method.TabIndex = 21;
            this.method.Text = "method:";
            // 
            // textBoxMethod
            // 
            this.textBoxMethod.Location = new System.Drawing.Point(425, 148);
            this.textBoxMethod.Name = "textBoxMethod";
            this.textBoxMethod.ReadOnly = true;
            this.textBoxMethod.Size = new System.Drawing.Size(318, 22);
            this.textBoxMethod.TabIndex = 20;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(356, 179);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(50, 17);
            this.errorLabel.TabIndex = 23;
            this.errorLabel.Text = "errors:";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxError
            // 
            this.textBoxError.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxError.ForeColor = System.Drawing.Color.Red;
            this.textBoxError.Location = new System.Drawing.Point(425, 176);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.ReadOnly = true;
            this.textBoxError.Size = new System.Drawing.Size(318, 22);
            this.textBoxError.TabIndex = 22;
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResultBox.Location = new System.Drawing.Point(21, 270);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultBox.Size = new System.Drawing.Size(726, 214);
            this.ResultBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Choose method and example to solve:";
            // 
            // Specification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 496);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.textBoxError);
            this.Controls.Add(this.method);
            this.Controls.Add(this.textBoxMethod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.comboBoxNumberOfExample);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Specification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Specification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Specification_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox equation;
        private System.Windows.Forms.ComboBox comboBoxNumberOfExample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label method;
        private System.Windows.Forms.TextBox textBoxMethod;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label label6;
    }
}