namespace NA2_Lab3
{
    partial class Main
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
            this.buttonTrap = new System.Windows.Forms.Button();
            this.buttonRecTrap = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTrap
            // 
            this.buttonTrap.Location = new System.Drawing.Point(12, 84);
            this.buttonTrap.Name = "buttonTrap";
            this.buttonTrap.Size = new System.Drawing.Size(453, 87);
            this.buttonTrap.TabIndex = 0;
            this.buttonTrap.Text = "Composite quadrature formula of trapeziums";
            this.buttonTrap.UseVisualStyleBackColor = true;
            this.buttonTrap.Click += new System.EventHandler(this.buttonTrap_Click);
            // 
            // buttonRecTrap
            // 
            this.buttonRecTrap.Location = new System.Drawing.Point(488, 84);
            this.buttonRecTrap.Name = "buttonRecTrap";
            this.buttonRecTrap.Size = new System.Drawing.Size(456, 87);
            this.buttonRecTrap.TabIndex = 1;
            this.buttonRecTrap.Text = "Rectangle-trapezium algorithm";
            this.buttonRecTrap.UseVisualStyleBackColor = true;
            this.buttonRecTrap.Click += new System.EventHandler(this.buttonRecTrap_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome.Location = new System.Drawing.Point(361, 28);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(224, 26);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Welcome to Lab 9002";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 182);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonRecTrap);
            this.Controls.Add(this.buttonTrap);
            this.Name = "Main";
            this.Text = "Lab 9002";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTrap;
        private System.Windows.Forms.Button buttonRecTrap;
        private System.Windows.Forms.Label labelWelcome;
    }
}

