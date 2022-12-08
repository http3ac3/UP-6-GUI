namespace UP_6._1_GUI_TwoD
{
    partial class SixOneTwoD
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
            this.NValueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MValueBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeArrayButton = new System.Windows.Forms.Button();
            this.AnswerBox = new System.Windows.Forms.RichTextBox();
            this.CreateArrayButton = new System.Windows.Forms.Button();
            this.ArrayTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NValueBox
            // 
            this.NValueBox.Location = new System.Drawing.Point(81, 6);
            this.NValueBox.Name = "NValueBox";
            this.NValueBox.Size = new System.Drawing.Size(100, 20);
            this.NValueBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите N:";
            // 
            // MValueBox
            // 
            this.MValueBox.Location = new System.Drawing.Point(256, 6);
            this.MValueBox.Name = "MValueBox";
            this.MValueBox.Size = new System.Drawing.Size(100, 20);
            this.MValueBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите M:";
            // 
            // ChangeArrayButton
            // 
            this.ChangeArrayButton.Enabled = false;
            this.ChangeArrayButton.Location = new System.Drawing.Point(362, 42);
            this.ChangeArrayButton.Name = "ChangeArrayButton";
            this.ChangeArrayButton.Size = new System.Drawing.Size(110, 23);
            this.ChangeArrayButton.TabIndex = 9;
            this.ChangeArrayButton.Text = "Изменить массив";
            this.ChangeArrayButton.UseVisualStyleBackColor = true;
            this.ChangeArrayButton.Click += new System.EventHandler(this.ChangeArrayButton_Click);
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location = new System.Drawing.Point(12, 84);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(460, 201);
            this.AnswerBox.TabIndex = 10;
            this.AnswerBox.Text = "";
            // 
            // CreateArrayButton
            // 
            this.CreateArrayButton.Location = new System.Drawing.Point(362, 4);
            this.CreateArrayButton.Name = "CreateArrayButton";
            this.CreateArrayButton.Size = new System.Drawing.Size(110, 23);
            this.CreateArrayButton.TabIndex = 11;
            this.CreateArrayButton.Text = "Создать массив";
            this.CreateArrayButton.UseVisualStyleBackColor = true;
            this.CreateArrayButton.Click += new System.EventHandler(this.CreateArrayButton_Click);
            // 
            // ArrayTextBox
            // 
            this.ArrayTextBox.Location = new System.Drawing.Point(201, 44);
            this.ArrayTextBox.Name = "ArrayTextBox";
            this.ArrayTextBox.Size = new System.Drawing.Size(155, 20);
            this.ArrayTextBox.TabIndex = 12;
            this.ArrayTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArrayTextBox_KeyDown);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 47);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(154, 13);
            this.DescriptionLabel.TabIndex = 13;
            this.DescriptionLabel.Text = "Здесь будет ввод элементов";
            // 
            // SixOneTwoD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 292);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ArrayTextBox);
            this.Controls.Add(this.CreateArrayButton);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.ChangeArrayButton);
            this.Controls.Add(this.MValueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NValueBox);
            this.Controls.Add(this.label1);
            this.Name = "SixOneTwoD";
            this.Text = "6.1 двумерный";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NValueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MValueBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChangeArrayButton;
        private System.Windows.Forms.RichTextBox AnswerBox;
        private System.Windows.Forms.Button CreateArrayButton;
        private System.Windows.Forms.TextBox ArrayTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
    }
}

