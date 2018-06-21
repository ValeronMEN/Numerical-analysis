namespace NA2_Lab4
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
            this.labelMain = new System.Windows.Forms.Label();
            this.buttonMiddlePoint = new System.Windows.Forms.Button();
            this.buttonKM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.BackColor = System.Drawing.Color.Transparent;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMain.Location = new System.Drawing.Point(511, 168);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(68, 18);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Lab 9004";
            // 
            // buttonMiddlePoint
            // 
            this.buttonMiddlePoint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMiddlePoint.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMiddlePoint.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.buttonMiddlePoint.FlatAppearance.BorderSize = 10;
            this.buttonMiddlePoint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.buttonMiddlePoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonMiddlePoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMiddlePoint.Location = new System.Drawing.Point(0, 0);
            this.buttonMiddlePoint.Name = "buttonMiddlePoint";
            this.buttonMiddlePoint.Size = new System.Drawing.Size(195, 690);
            this.buttonMiddlePoint.TabIndex = 1;
            this.buttonMiddlePoint.Text = "Midpoint Method";
            this.buttonMiddlePoint.UseVisualStyleBackColor = false;
            this.buttonMiddlePoint.Click += new System.EventHandler(this.buttonMiddlePoint_Click);
            // 
            // buttonKM
            // 
            this.buttonKM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonKM.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonKM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKM.Location = new System.Drawing.Point(892, 0);
            this.buttonKM.Name = "buttonKM";
            this.buttonKM.Size = new System.Drawing.Size(195, 690);
            this.buttonKM.TabIndex = 2;
            this.buttonKM.Text = "Kutta-Merson Method";
            this.buttonKM.UseVisualStyleBackColor = false;
            this.buttonKM.Click += new System.EventHandler(this.buttonKM_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NA2_Lab4.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1087, 690);
            this.Controls.Add(this.buttonKM);
            this.Controls.Add(this.buttonMiddlePoint);
            this.Controls.Add(this.labelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Lab 9004";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Button buttonMiddlePoint;
        private System.Windows.Forms.Button buttonKM;
    }
}

