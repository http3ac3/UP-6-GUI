namespace UP_6_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.NValueBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ArrayBox = new System.Windows.Forms.TextBox();
            this.AnswerBox = new System.Windows.Forms.RichTextBox();
            this.FixArrayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите N:";
            // 
            // NValueBox
            // 
            this.NValueBox.Location = new System.Drawing.Point(82, 10);
            this.NValueBox.Name = "NValueBox";
            this.NValueBox.Size = new System.Drawing.Size(100, 20);
            this.NValueBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите элементы массива через пробел:";
            // 
            // ArrayBox
            // 
            this.ArrayBox.Location = new System.Drawing.Point(243, 40);
            this.ArrayBox.Name = "ArrayBox";
            this.ArrayBox.Size = new System.Drawing.Size(258, 20);
            this.ArrayBox.TabIndex = 3;
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location = new System.Drawing.Point(16, 101);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(485, 96);
            this.AnswerBox.TabIndex = 4;
            this.AnswerBox.Text = "";
            // 
            // FixArrayButton
            // 
            this.FixArrayButton.Location = new System.Drawing.Point(166, 66);
            this.FixArrayButton.Name = "FixArrayButton";
            this.FixArrayButton.Size = new System.Drawing.Size(207, 29);
            this.FixArrayButton.TabIndex = 5;
            this.FixArrayButton.Text = "Изменить массив";
            this.FixArrayButton.UseVisualStyleBackColor = true;
            this.FixArrayButton.Click += new System.EventHandler(this.FixArrayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 206);
            this.Controls.Add(this.FixArrayButton);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.ArrayBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NValueBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "6.1 Одномерный";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NValueBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ArrayBox;
        private System.Windows.Forms.RichTextBox AnswerBox;
        private System.Windows.Forms.Button FixArrayButton;
    }
}

