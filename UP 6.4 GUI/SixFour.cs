using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_6._4_GUI
{
    public partial class SixFour : Form
    {
        private int N, i = 0, j = 0;
        private int[][] arr;
        private int[] vector;
        public SixFour()
        {
            InitializeComponent();
            ArrayTextBox.Enabled = false;
            VectorTextBox.Enabled = false;
        }

        void PrintOneDArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                AnswerBox.Text += arr[i] + "\t";
            AnswerBox.Text += "\n";
        }

        private void CreateArrayButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(NValueBox.Text, out N) || N <= 0)
            {
                AnswerBox.Text = "Введено неверное значение в поле N! Введите целое число больше 0!";
                return;
            }

            arr = new int[N][];

            ArrayTextBox.Enabled = true;
            DescriptionLabel.Text = $"Введите [{i}, {j}] элемент массива -> ";
            CreateArrayButton.Enabled = false;

            for (i = 0; i < N; i++)
            {
                arr[i] = new int[N];
            }
            i = 0;
        }

        private void VectorTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                VectorTextBox.Enabled = false;
                try
                {
                    var digits = VectorTextBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    vector = new int[digits.Length];

                    
                    for (int i = 0; i < vector.Length; i++)
                    {
                        vector[i] = int.Parse(digits[i]);
                    }
                }
                catch
                {
                    AnswerBox.Text = "В поле элементов массива введены неверные значения! Введите заново, используя только цифры, точку и знак \"минус\"";
                    return;
                }


                PrintAnswer();
            }
        }

        private void ArrayTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!int.TryParse(ArrayTextBox.Text, out arr[i][j]))
                {
                    MessageBox.Show("Введено неверное значение! Введите массив заново!");
                    i = 0; j = 0;
                    DescriptionLabel.Text = $"Введите [{i}][{j}] элемент массива => ";
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
                    VectorTextBox.Enabled = true;
                    i = 0;
                    j = 0;
                    
                }
                DescriptionLabel.Text = $"Введите [{i}][{j}] элемент массива => ";
            }
        }

        private void PrintAnswer()
        {
            AnswerBox.Text = "Изначальный массив: \n";

            for (i = 0; i < N; i++)
            {
                PrintOneDArray(arr[i]);
            }

            AnswerBox.Text += "\nИзмененный массив: \n";
            
            for (i = 0; i < N; i++)
            {
                if ((i + 1) % 2 != 0) arr[i] = vector; 
            }

            for (i = 0; i < N; i++)
            {
                PrintOneDArray(arr[i]);
            }

            CreateArrayButton.Enabled = true;

            i = 0; j = 0;
        }
    }
}
