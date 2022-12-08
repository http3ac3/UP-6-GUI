using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_6._1_GUI_TwoD
{
    public partial class SixOneTwoD : Form
    {
        private int N, M, i = 0, j = 0;
        private int[,] arr;
        public SixOneTwoD()
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
            if (!int.TryParse(MValueBox.Text, out M) || M <= 0)
            {
                AnswerBox.Text = "Введено неверное значение в поле M! Введите целое число больше 0!";
                return;
            }
            arr = new int[N, M]; 

            ArrayTextBox.Enabled = true;
            DescriptionLabel.Text = $"Введите [{i}, {j}] элемент массива -> ";
            CreateArrayButton.Enabled = false;
        }

        private void ArrayTextBox_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Enter)
            {
                
                if (!int.TryParse(ArrayTextBox.Text, out arr[i,j]))
                {
                    MessageBox.Show("Введено неверное значение! Введите массив заново!");
                    i = 0; j = 0;
                    DescriptionLabel.Text = $"Введите [{i}, {j}] элемент массива => ";
                    return;
                }
                ArrayTextBox.Text = "";
                j++;

                if (j == M)
                {
                    j = 0; i++;
                }

                if (i == N)
                {
                    ChangeArrayButton.Enabled = true;
                    ArrayTextBox.Enabled = false;
                    i = 0;
                    j = 0;
                    ChangeArrayButton_Click(sender, e);
                }
                DescriptionLabel.Text = $"Введите [{i}, {j}] элемент массива => ";
            }
        }

        private void ChangeArrayButton_Click(object sender, EventArgs e)
        {
            AnswerBox.Text = "Изначальный массив: \n";
            
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    AnswerBox.Text += arr[i, j] + "\t";
                }
                AnswerBox.Text += '\n';
            }

            AnswerBox.Text += "\nИзмененный массив: \n";

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    if (arr[i, j] < 0 && arr[i, j] % 3 != 0) arr[i, j] *= -1;
                    AnswerBox.Text += arr[i, j] + "\t";
                }
                AnswerBox.Text += '\n';
            }

            CreateArrayButton.Enabled = true;
            ChangeArrayButton.Enabled = false;

            i = 0; j = 0;
        }
    }
}
