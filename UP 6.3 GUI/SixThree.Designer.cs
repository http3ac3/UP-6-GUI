namespace UP_6._3_GUI
{
    partial class SixThree
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
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ArrayTextBox = new System.Windows.Forms.TextBox();
            this.CreateArrayButton = new System.Windows.Forms.Button();
            this.AnswerBox = new System.Windows.Forms.RichTextBox();
            this.NValueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 47);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(154, 13);
            this.DescriptionLabel.TabIndex = 22;
            this.DescriptionLabel.Text = "Здесь будет ввод элементов";
            // 
            // ArrayTextBox
            // 
            this.ArrayTextBox.Location = new System.Drawing.Point(201, 44);
            this.ArrayTextBox.Name = "ArrayTextBox";
            this.ArrayTextBox.Size = new System.Drawing.Size(207, 20);
            this.ArrayTextBox.TabIndex = 21;
            this.ArrayTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArrayTextBox_KeyDown);
            // 
            // CreateArrayButton
            // 
            this.CreateArrayButton.Location = new System.Drawing.Point(201, 6);
            this.CreateArrayButton.Name = "CreateArrayButton";
            this.CreateArrayButton.Size = new System.Drawing.Size(110, 23);
            this.CreateArrayButton.TabIndex = 20;
            this.CreateArrayButton.Text = "Создать массив";
            this.CreateArrayButton.UseVisualStyleBackColor = true;
            this.CreateArrayButton.Click += new System.EventHandler(this.CreateArrayButton_Click);
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location = new System.Drawing.Point(15, 81);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(393, 201);
            this.AnswerBox.TabIndex = 19;
            this.AnswerBox.Text = "";
            // 
            // NValueBox
            // 
            this.NValueBox.Location = new System.Drawing.Point(81, 6);
            this.NValueBox.Name = "NValueBox";
            this.NValueBox.Size = new System.Drawing.Size(100, 20);
            this.NValueBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введите N:";
            // 
            // SixThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 294);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ArrayTextBox);
            this.Controls.Add(this.CreateArrayButton);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.NValueBox);
            this.Controls.Add(this.label1);
            this.Name = "SixThree";
            this.Text = "6.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox ArrayTextBox;
        private System.Windows.Forms.Button CreateArrayButton;
        private System.Windows.Forms.RichTextBox AnswerBox;
        private System.Windows.Forms.TextBox NValueBox;
        private System.Windows.Forms.Label label1;
    }
}

