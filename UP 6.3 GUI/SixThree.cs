using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_6._3_GUI
{
    public partial class SixThree : Form
    {
        private int N, i = 0, j = 0;
        private double[,] arr;
        public SixThree()
        {
            InitializeComponent();
            ArrayTextBox.Enabled = false;
        }

        private void CreateArrayButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(NValueBox.Text, out N) || N <= 0)
            {
                AnswerBox.Text = "Введено неверное значение в поле N! Введите целое число больше 0!";
                return;
            }
            
            arr = new double[N, N];

            ArrayTextBox.Enabled = true;
            DescriptionLabel.Text = $"Введите [{i}, {j}] элемент массива -> ";
            CreateArrayButton.Enabled = false;
        }

        private void ArrayTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!double.TryParse(ArrayTextBox.Text, out arr[i, j]))
                {
                    MessageBox.Show("Введено неверное значение! Введите массив заново!");
                    i = 0; j = 0;
                    DescriptionLabel.Text = $"Введите [{i},{j}] элемент массива => ";
                    return;
                }
                ArrayTextBox.Text = "";
                j++;

                if (j == N)
                {
                    j = 0; i++;
                }

                if (i == N)
                {

                    ArrayTextBox.Enabled = false;
                    i = 0;
                    j = 0;
                    PrintAnswer();
                }
                DescriptionLabel.Text = $"Введите [{i}, {j}] элемент массива => ";
            }
        }

        private void PrintAnswer()
        {
            AnswerBox.Text = "Изначальный массив: \n";

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    AnswerBox.Text += arr[i, j] + "\t";
                }
                AnswerBox.Text += '\n';
            }

            double s = 0;
            double count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - i - 1; j++)
                {
                    if (arr[i, j] != 0)
                    {
                        s += arr[i, j];
                        count++;
                    }
                }
            }

            AnswerBox.Text += $"\nСреднее арфиметическое ненулевых элементов массива над побочной диагональю: {s / count}";

            CreateArrayButton.Enabled = true;

            i = 0; j = 0;
        }
    }
}
