using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_6._2_GUI
{
    public partial class SixTwo : Form
    {
        private int N;
        private double[] arr;
        public SixTwo()
        {
            InitializeComponent();
        }

        private void FixArrayButton_Click(object sender, EventArgs e)
        {
            AnswerBox.Text = "";
            if (!int.TryParse(NValueBox.Text, out N) || N <= 0)
            {
                AnswerBox.Text = "В поле N введены недопустимые данные! Введите целое число больше 0!";
                return;
            }
            arr = new double[N];
            try
            {
                var digits = ArrayBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (digits.Length > N)
                {
                    AnswerBox.Text = "Число введенных элементов больше, чем количество элементов массива!";
                    return;
                }
                else if (digits.Length < N)
                {
                    AnswerBox.Text = "Число введенных элементов меньше, чем количество элементов массива!";
                    return;
                }

                AnswerBox.Text += "Изначальный массив: ";
                for (int i = 0; i < N; i++)
                {
                    arr[i] = double.Parse(digits[i]);
                    AnswerBox.Text += arr[i] + " ";
                }
            }
            catch
            {
                AnswerBox.Text = "В поле элементов массива введены неверные значения! Введите заново, используя только цифры, точку и знак \"минус\"";
                return;
            }
            AnswerBox.Text += "\nИзменененный массив: ";
            double min = arr.Min();
            for (int i = 0; i < N; i++)
            {
                if (arr[i] == min) arr[i] *= -1;
                AnswerBox.Text += arr[i] + " ";
            }
        }
    }
}
