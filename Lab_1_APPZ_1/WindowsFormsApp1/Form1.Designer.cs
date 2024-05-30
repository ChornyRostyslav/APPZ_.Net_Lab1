namespace WindowsFormsApp1
{
    partial class Form1
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
            this.labelInstruction = new System.Windows.Forms.Label();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.buttonUpdateFormat = new System.Windows.Forms.Button();
            this.labelCurrentFormat = new System.Windows.Forms.Label();
            this.hexOctDecControl1 = new WindowsFormsControlLibrary1.HexOctDecControl();
            this.SuspendLayout();
            // 
            // labelInstruction
            // 
            this.labelInstruction.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelInstruction.Location = new System.Drawing.Point(12, 255);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(180, 24);
            this.labelInstruction.TabIndex = 1;
            this.labelInstruction.Text = "Change format:";
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxFormat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBoxFormat.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(209, 252);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(184, 32);
            this.comboBoxFormat.TabIndex = 2;
            this.comboBoxFormat.Text = "Decimal";
            // 
            // buttonUpdateFormat
            // 
            this.buttonUpdateFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateFormat.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonUpdateFormat.Location = new System.Drawing.Point(399, 252);
            this.buttonUpdateFormat.Name = "buttonUpdateFormat";
            this.buttonUpdateFormat.Size = new System.Drawing.Size(172, 32);
            this.buttonUpdateFormat.TabIndex = 3;
            this.buttonUpdateFormat.Text = "Apply Format";
            this.buttonUpdateFormat.UseVisualStyleBackColor = true;
            // 
            // labelCurrentFormat
            // 
            this.labelCurrentFormat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCurrentFormat.AutoSize = true;
            this.labelCurrentFormat.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCurrentFormat.Location = new System.Drawing.Point(268, 299);
            this.labelCurrentFormat.Name = "labelCurrentFormat";
            this.labelCurrentFormat.Size = new System.Drawing.Size(280, 24);
            this.labelCurrentFormat.TabIndex = 4;
            this.labelCurrentFormat.Text = "Current Format: Decimal";
            // 
            // hexOctDecControl1
            // 
            this.hexOctDecControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hexOctDecControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hexOctDecControl1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hexOctDecControl1.Format = WindowsFormsControlLibrary1.NumberFormat.Decimal;
            this.hexOctDecControl1.Location = new System.Drawing.Point(0, 0);
            this.hexOctDecControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hexOctDecControl1.Name = "hexOctDecControl1";
            this.hexOctDecControl1.Size = new System.Drawing.Size(800, 199);
            this.hexOctDecControl1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hexOctDecControl1);
            this.Controls.Add(this.labelCurrentFormat);
            this.Controls.Add(this.buttonUpdateFormat);
            this.Controls.Add(this.comboBoxFormat);
            this.Controls.Add(this.labelInstruction);
            this.Name = "Form1";
            this.Text = "Чорний Р.С. 621п";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Button buttonUpdateFormat;
        private System.Windows.Forms.Label labelCurrentFormat;
        private WindowsFormsControlLibrary1.HexOctDecControl hexOctDecControl1;
    }
}

