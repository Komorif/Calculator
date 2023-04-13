using System.Windows.Forms;
using System;

namespace calculator
{
    public partial class Form1 : Form
    {
        // Переменные для выполнений операций

        // строковая переменная - operation (действие операции (+, -, ×, ÷ ...))
        string operation;

        // строковая переменная - firstNumberIsMemorized (первое число запоминаемое)
        string firstNumberIsMemorized;

        // Булевая переменная - secondNumberIsMemorized (2 число)
        public bool secondNumberIsMemorized;

        // Объявляем публичные переменные (double)
        public double numberOne, numberTwo, result;

        // Конец операции
        public string EndOfOperation = "no";



        // Начало

        public Form1()
        {
            InitializeComponent();
        }



        // Числа 0 - 9

        // Цифра - 9
        private void button14_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForNumbers) (Шаблон для всех цифр) (С выбором цифры 9)
            TemplateForNumbers(number: 9);
        }


        // Цифра - 8
        private void button23_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForNumbers) (Шаблон для всех цифр) (С выбором цифры 8)
            TemplateForNumbers(number: 8);
        }


        // Цифра - 7
        private void button17_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForNumbers) (Шаблон для всех цифр) (С выбором цифры 7)
            TemplateForNumbers(number: 7);
        }


        // Цифра - 6
        private void button15_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForNumbers) (Шаблон для всех цифр) (С выбором цифры 6)
            TemplateForNumbers(number: 6);
        }


        // Цифра - 5
        private void button25_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForNumbers) (Шаблон для всех цифр) (С выбором цифры 5)
            TemplateForNumbers(number: 5);
        }


        // Цифра - 4
        private void button21_Click_1(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForNumbers) (Шаблон для всех цифр) (С выбором цифры 4)
            TemplateForNumbers(number: 4);
        }


        // Цифра - 3
        private void button16_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForNumbers) (Шаблон для всех цифр) (С выбором цифры 3)
            TemplateForNumbers(number: 3);
        }


        // Цифра - 2
        private void button24_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForNumbers) (Шаблон для всех цифр) (С выбором цифры 2)
            TemplateForNumbers(number: 2);
        }


        // Цифра - 1
        private void button22_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForNumbers) (Шаблон для всех цифр) (С выбором цифры 1)
            TemplateForNumbers(number: 1);
        }


        // Цифра - 0
        private void button21_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForNumbers) (Шаблон для всех цифр) (С выбором цифры 0)
            TemplateForNumbers(number: 0);
        }



        // Операциии (+, -, × ...)

        // Сложение - +
        private void button2_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForOperations) (Шаблон для всех операций) (С выбором операции +)
            TemplateForOperations(FundsEntryOperation: " + ");
        }


        // Вычитание - -
        private void button1_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForOperations) (Шаблон для всех операций) (С выбором операции -)
            TemplateForOperations(FundsEntryOperation: " - ");
        }


        // Умножение - ×
        private void button9_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForOperations) (Шаблон для всех операций) (С выбором операции ×)
            TemplateForOperations(FundsEntryOperation: " × ");
        }


        // Деление - ÷
        private void button13_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForOperations) (Шаблон для всех операций) (С выбором операции ÷)
            TemplateForOperations(FundsEntryOperation: " ÷ ");
        }


        // Нужно только "одно" число

        // Процент - %
        private void button26_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForOperations) (Шаблон для всех операций) (С выбором операции %)
            // (один пробел перед % для избежания лишних пробелов)
            TemplateForOperations(FundsEntryOperation: " %");

            // Конвертируем первое число ToDouble в firstNumberIsMemorized
            numberOne = Convert.ToDouble(firstNumberIsMemorized);

            // Операция (%) с одним числом
            result = numberOne / 100;

            // secondNumberIsMemorized = правда
            secondNumberIsMemorized = true;

            // Конвертируем наш результат в строку и выводим в первый текст бокс
            textBox1.Text = result.ToString();

            // Записываем наш результат во втророй текст бокс
            textBox2.Text = textBox2.Text + " = " + result;

            // Переменной (EndOfOperation) типа string присваиваем строку yes
            // (мы посчитали нашу операцию => конец операции равен строке да)
            // (это нужно для будущей проверки)
            EndOfOperation = "yes";
        }


        // √ - Корень
        private void button4_Click(object sender, EventArgs e)
        {
            // Очищаем предыдущее число во втором текст боксе
            textBox2.Clear();

            // Используем созданную функцию (TemplateForOperations) (Шаблон для всех операций) (С выбором операции √)
            TemplateForOperations(FundsEntryOperation: "√");

            // Конвертируем первое число ToDouble в firstNumberIsMemorized
            numberOne = Convert.ToDouble(firstNumberIsMemorized);

            // Операция (√) с одним числом
            result = Math.Sqrt(numberOne);

            // secondNumberIsMemorized = правда
            secondNumberIsMemorized = true;

            // Конвертируем наш результат в строку и выводим в первый текст бокс
            textBox1.Text = result.ToString();

            // Записываем наш результат во втророй текст бокс
            textBox2.Text = textBox2.Text + numberOne + " = " + result;

            // Переменной (EndOfOperation) типа string присваиваем строку yes
            // (мы посчитали нашу операцию => конец операции равен строке да)
            // (это нужно для будущей проверки)
            EndOfOperation = "yes";
        }



        // Логика для калькулятора прописанная в кнопке равно

        // Равно - =
        private void button18_Click(object sender, EventArgs e)
        {
            // Конвертируем первое число ToDouble в firstNumberIsMemorized
            numberOne = Convert.ToDouble(firstNumberIsMemorized);

            // Необходимое объявление результата
            result = 0;

            // Второе число делаем true
            secondNumberIsMemorized = true;


            // Условия для операций

            // Сложение - +
            if (operation == " + ")
            {
                // Конвертируем второе число ToDouble в текстовое поле с цифрами
                // Только для операций с двумя числами
                numberTwo = Convert.ToDouble(textBox1.Text);

                // Операция (сложения) первого и второго числа
                result = numberOne + numberTwo;
            }


            // Вычитание - -
            else if (operation == " - ")
            {
                // Конвертируем второе число ToDouble в текстовое поле с цифрами
                // Только для операций с двумя числами
                numberTwo = Convert.ToDouble(textBox1.Text);

                // Операция (вычитания) первого и второго числа
                result = numberOne - numberTwo;
            }


            // Умножение - ×
            else if (operation == " × ")
            {
                // Конвертируем второе число ToDouble в текстовое поле с цифрами
                // Только для операций с двумя числами
                numberTwo = Convert.ToDouble(textBox1.Text);

                // Операция (умножения) первого и второго числа
                result = numberOne * numberTwo;
            }


            // Деление - ÷
            else if (operation == " ÷ ")
            {
                // Конвертируем второе число ToDouble в текстовое поле с цифрами
                // Только для операций с двумя числами
                numberTwo = Convert.ToDouble(textBox1.Text);

                // Операция (деления) первого и второго числа
                result = numberOne / numberTwo;
            }


            // Пользователь нажимает на =
            operation = " = ";

            // secondNumberIsMemorized = правда
            secondNumberIsMemorized = true;

            // Конвертируем наш результат в строку и выводим в первый текст бокс
            textBox1.Text = result.ToString();

            // Записываем наш результат во втророй текст бокс
            textBox2.Text = textBox2.Text + operation + result;

            // Переменной (EndOfOperation) типа string присваиваем строку yes
            // (мы посчитали нашу операцию => конец операции равен строке да)
            // (это нужно для будущей проверки)
            EndOfOperation = "yes";
        }



        // Функции для кнопок (операций и цифр)

        // Функция (TemplateForOperations) (Шаблон для всех операций)
        private void TemplateForOperations(string FundsEntryOperation)
        {
            // Проверка переменной (EndOfOperation) типа string (если yes)
            // (то есть если мы нажали на операцию после = будет это)
            if (EndOfOperation == "yes")
            {
                // Очищаем второй текст бокс от предыдущих вычислений
                textBox2.Clear();
                textBox1.Clear();

                // Переменной (EndOfOperation) типа string присваиваем строку no (прошлая операция закончилась поэтому мы меняем yes --> no)
                EndOfOperation = "no";

                // Добавляем предыдущий результат во второй текст бокс
                textBox2.Text = textBox2.Text + result;

                // Операция которую при вызове этой функции
                operation = FundsEntryOperation;

                // Запомнили действие
                firstNumberIsMemorized = result + textBox1.Text;

                secondNumberIsMemorized = true;

                // Вызов функции (TemplateForOperationsFromAbove) (показывание опериции сверху с первым числом)
                textBox2.Text = textBox2.Text + FundsEntryOperation;
            }


            // Проверка переменной (EndOfOperation) типа string (если no)
            // (то есть если мы нажали на операцию но еще не нажали на = будет это)
            else if (EndOfOperation == "no")
            {
                // Операция которую при вызове этой функции
                operation = FundsEntryOperation;

                // Запомнили действие
                firstNumberIsMemorized = textBox1.Text;

                secondNumberIsMemorized = true;

                // Очищение консоли
                textBox1.Clear();

                // Вызов функции (TemplateForOperationsFromAbove) (показывание опериции сверху с первым числом)
                textBox2.Text = textBox2.Text + FundsEntryOperation;
            }
        }


        // Функция (TemplateForNumbers) (Шаблон для всех цифр)
        private void TemplateForNumbers(int number)
        {
            // Проверка переменной (EndOfOperation) типа string (если yes)
            // (то есть если мы нажали на цифру после = будет это)
            if (EndOfOperation == "yes")
            {
                // Очищаем второй текст бокс от предыдущих вычислений
                textBox2.Clear();
                textBox1.Clear();

                // Переменной (EndOfOperation) типа string присваиваем строку no (прошлая операция закончилась поэтому мы меняем yes --> no)
                EndOfOperation = "no";

                // Добавляем предыдущий результат во второй текст бокс
                textBox2.Text = textBox2.Text + result;

                // Добавляем в консоль цифру number
                textBox1.Text = textBox1.Text + number;

                // Добавляем во второй текст бокс цифру number
                textBox2.Text = textBox2.Text + number;
            }


            // Проверка переменной (EndOfOperation) типа string (если no)
            // (то есть если мы нажали на цифру но еще не нажали на = будет это)
            else if (EndOfOperation == "no")
            {
                // Добавляем в консоль цифру number
                textBox1.Text = textBox1.Text + number;

                // Добавляем во второй текст бокс цифру number
                textBox2.Text = textBox2.Text + number;
            }
        }



        // Вторичные кнопки

        // Очистить текстовое поле - C
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            // Очищаем (textBox2) (опериции сверху с первым числом)
            textBox2.Clear();
        }


        // Точка - .
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            textBox2.Text = textBox2.Text + ".";
        }


        // Удаление - <--
        private void button5_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            textBox2.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
                textBox2.Text = textBox2.Text + text[i];
            }
        }



        // Кнопки с ссылками

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


        // ВизитЛинк - VisitLink (функция) (ссылка изменяемая для удобства)
        private void VisitLink(string url) // string url это переменная для ссылки на ютуб, телеграмм и прочее
        {
            linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start(url);
        }
    }
}
