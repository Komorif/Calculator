using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace calculator
{
    public partial class Form1 : Form
    {
        // Переменные для выполнения операций

        // строковая переменная - operation (действие операции (+, -, ×, ÷ ...))
        string operation;

        // строковая переменная - firstNumberIsMemorized (первое число запоминаемое)
        string firstNumberIsMemorized;

        // Булевая переменная - secondNumberIsMemorized (2 число)
        public bool secondNumberIsMemorized;



        // Начало

        public Form1()
        {
            InitializeComponent();
        }



        // Операциии

        // Сложение - +
        private void button2_Click(object sender, EventArgs e)
        {
            // Операция +
            operation = "+";

            // Запомнили действие
            firstNumberIsMemorized = textBox1.Text;

            secondNumberIsMemorized = true;

            // Вызов функции (textBox2WindowOperation) -  (показывание опериции сверху с первым числом)
            textBox2WindowOperation(OperationTextBox2: "+");

            // Очищение консоли
            textBox1.Clear();
        }


        // Вычитание - -
        private void button1_Click(object sender, EventArgs e)
        {
            // Операция -
            operation = "-";

            // Запомнили действие
            firstNumberIsMemorized = textBox1.Text;

            secondNumberIsMemorized = true;

            // Вызов функции (textBox2WindowOperation) -  (показывание опериции сверху с первым числом)
            textBox2WindowOperation(OperationTextBox2: "-");

            // Очищение консоли
            textBox1.Clear();
        }


        // Умножение - ×
        private void button9_Click(object sender, EventArgs e)
        {
            // Операция - ×
            operation = "×";

            // Запомнили действие
            firstNumberIsMemorized = textBox1.Text;

            secondNumberIsMemorized = true;

            // Вызов функции (textBox2WindowOperation) -  (показывание опериции сверху с первым числом)
            textBox2WindowOperation(OperationTextBox2: "×");

            // Очищение консоли
            textBox1.Clear();
        }


        // Деление - ÷
        private void button13_Click(object sender, EventArgs e)
        {
            // Операция - ÷
            operation = "÷";

            // Запомнили действие
            firstNumberIsMemorized = textBox1.Text;

            secondNumberIsMemorized = true;

            // Вызов функции (textBox2WindowOperation) -  (показывание опериции сверху с первым числом)
            textBox2WindowOperation(OperationTextBox2: "÷");

            // Очищение консоли
            textBox1.Clear();
        }


        // Процент - %
        private void button26_Click(object sender, EventArgs e)
        {
            // Операция - %
            operation = "%";

            // Запомнили действие
            firstNumberIsMemorized = textBox1.Text;

            secondNumberIsMemorized = true;

            // Вызов функции (textBox2WindowOperation) -  (показывание опериции сверху с первым числом)
            textBox2WindowOperation(OperationTextBox2: "%");

            // Очищение консоли
            textBox1.Clear();
        }



        // Нужно только 'одно' число

        // √ - Корень
        private void button4_Click(object sender, EventArgs e)
        {
            // Операция - √
            operation = "√";

            // Запомнили действие
            firstNumberIsMemorized = textBox1.Text;

            secondNumberIsMemorized = true;

            // Вызов функции (textBox2WindowOperation) -  (показывание опериции сверху с первым числом)
            textBox2WindowOperation(OperationTextBox2: "√");

            // Очищение консоли
            textBox1.Clear();
        }

        // Функция (textBox2WindowOperation) (для показывание опериции сверху с первым числом)
        private void textBox2WindowOperation(string OperationTextBox2)
        {
            // Показывание опериции сверху с первым числом
            textBox2.Text = textBox2.Text + firstNumberIsMemorized;
            textBox2.Text = textBox2.Text + OperationTextBox2;
        }



        // Числа 0 - 9

        // Цифра - 0
        private void button21_Click(object sender, EventArgs e)
        {
            // Добавляем в консоль цифру 0
            textBox1.Text = textBox1.Text + 0;
        }


        // Цифра - 9
        private void button14_Click(object sender, EventArgs e)
        {
            // Добавляем в консоль цифру 9
            textBox1.Text = textBox1.Text + 9;
        }


        // Цифра - 8
        private void button23_Click(object sender, EventArgs e)
        {
            // Добавляем в консоль цифру 8
            textBox1.Text = textBox1.Text + 8;
        }


        // Цифра - 7
        private void button17_Click(object sender, EventArgs e)
        {
            // Добавляем в консоль цифру 7
            textBox1.Text = textBox1.Text + 7;
        }


        // Цифра - 6
        private void button15_Click(object sender, EventArgs e)
        {
            // Добавляем в консоль цифру 6
            textBox1.Text = textBox1.Text + 6;
        }


        // Цифра - 5
        private void button25_Click(object sender, EventArgs e)
        {
            // Добавляем в консоль цифру 5
            textBox1.Text = textBox1.Text + 5;
        }


        // Цифра - 4
        private void button21_Click_1(object sender, EventArgs e)
        {
            // Добавляем в консоль цифру 4
            textBox1.Text = textBox1.Text + 4;
        }


        // Цифра - 3
        private void button16_Click(object sender, EventArgs e)
        {
            // Добавляем в консоль цифру 3
            textBox1.Text = textBox1.Text + 3;
        }


        // Цифра - 2
        private void button24_Click(object sender, EventArgs e)
        {
            // Добавляем в консоль цифру 2
            textBox1.Text = textBox1.Text + 2;

        }


        // Цифра - 1
        private void button22_Click(object sender, EventArgs e)
        {
            // Добавляем в консоль цифру 1
            textBox1.Text = textBox1.Text + 1;
        }



        // Логика для калькулятора прописанная в равно

        // Равно - =
        private void button18_Click(object sender, EventArgs e)
        {
            // Объявляем локальные переменные
            double numberOne, numberTwo, result;

            // Конвертируем первое число ToDouble в firstNumberIsMemorized
            numberOne = Convert.ToDouble(firstNumberIsMemorized);

            // Необходимое объявление результата
            result = 0;

            // Второе число делаем true
            secondNumberIsMemorized = true;



            // Условия для операций

            // Сложение - +
            if (operation == "+")
            {
                // Конвертируем второе число ToDouble в текстовое поле с цифрами
                // Только для операций с двумя числами
                numberTwo = Convert.ToDouble(textBox1.Text);

                // Как то неализовать
                // условие для не вылета после того как нажали пробел


                // Операция (сложения) первого и второго числа
                result = numberOne + numberTwo;
            }


            // Вычитание - -
            else if (operation == "-")
            {
                // Конвертируем второе число ToDouble в текстовое поле с цифрами
                // Только для операций с двумя числами
                numberTwo = Convert.ToDouble(textBox1.Text);

                // Операция (вычитания) первого и второго числа
                result = numberOne - numberTwo;
            }


            // Умножение - ×
            else if (operation == "×")
            {
                // Конвертируем второе число ToDouble в текстовое поле с цифрами
                // Только для операций с двумя числами
                numberTwo = Convert.ToDouble(textBox1.Text);

                // Операция (умножения) первого и второго числа
                result = numberOne * numberTwo;
            }


            // Деление - ÷
            else if (operation == "÷")
            {
                // Конвертируем второе число ToDouble в текстовое поле с цифрами
                // Только для операций с двумя числами
                numberTwo = Convert.ToDouble(textBox1.Text);

                // Операция (деления) первого и второго числа
                result = numberOne / numberTwo;
            }


            //  Процент - %
            else if (operation == "%")
            {
                // Конвертируем второе число ToDouble в текстовое поле с цифрами
                // Только для операций с двумя числами
                numberTwo = Convert.ToDouble(textBox1.Text);

                // Операция (%) первого и второго числа
                result = numberOne / numberTwo * 100;
            }


            // Корень - √
            else if (operation == "√")
            {
                // Операция (√) с одним числом
                result = Math.Sqrt(numberOne);
            }


            // Пользователь нажимает на =
            operation = "=";

            // secondNumberIsMemorized = правда
            secondNumberIsMemorized = true;

            // Конвертируем наш результат в строку и выводим в текст бокс
            textBox1.Text = result.ToString();

            // Очищаем (textBox2) (опериции сверху с первым числом)
            textBox2.Clear();
        }



        // Вторичные кнопки

        // Очистить текстовое поле - C
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }


        // Точка - .
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }


        // Удаление - <--
        private void button5_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }



        // Создание ссылки в кнопке (с помощью link)

        // Ютуб - Youtube
        private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink("https://www.youtube.com/channel/UCb2GlPOgqB_VpWTvQM_dzKg");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }


        // Телеграмм - Telegram
        private void linkLabel1_LinkClicked_1(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink("https://t.me/New_Vision_rus_en_bot");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }

        }


        // Гитхаб - Github
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink("https://github.com/Komorif");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }


        // ВизитЛинк - VisitLink (ссылка изменяемая для удобства)
        private void VisitLink(string url) // string url это переменная для ссылки на ютуба, телеграмма и прочего
        {
            linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start(url);
        }
    }
}
