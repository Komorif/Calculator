using System.Windows.Forms;
using System;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator
{
    public partial class Form1 : Form
    {
        // Переменные для выполнений операций

        // строковая переменная - operation (действие операции (+, -, ×, ÷ ...))
        string operation;

        // строковая переменная - firstNumberIsMemorized (первое число запоминаемое)
        string firstNumberIsMemorized = "";

        // Объявляем публичные переменные (double)
        public double numberOne = double.MinValue, numberTwo = double.MinValue, result = double.MinValue;

        // Конец операции
        public string EndOfOperation = "no";

        // Переменная для кнопки удаления
        public string EditRes = "";

        // Переменная для редактирования второго номера
        public string EditNumberTwo = "";

        public double res = double.MinValue;

        public double zero = 0;


        public Form1()
        {
            InitializeComponent();
            textBox1.Text = textBox1.Text + zero;
        }



        // Числа 0 - 9

        // Цифра - 9
        private void button14_Click(object sender, EventArgs e)
        {
            TemplateForNumbers(number: 9);
        }


        // Цифра - 8
        private void button23_Click(object sender, EventArgs e)
        {
            TemplateForNumbers(number: 8);
        }


        // Цифра - 7
        private void button17_Click(object sender, EventArgs e)
        {
            TemplateForNumbers(number: 7);
        }


        // Цифра - 6
        private void button15_Click(object sender, EventArgs e)
        {
            TemplateForNumbers(number: 6);
        }


        // Цифра - 5
        private void button25_Click(object sender, EventArgs e)
        {
            TemplateForNumbers(number: 5);
        }


        // Цифра - 4
        private void button21_Click_1(object sender, EventArgs e)
        {
            TemplateForNumbers(number: 4);
        }


        // Цифра - 3
        private void button16_Click(object sender, EventArgs e)
        {
            TemplateForNumbers(number: 3);
        }


        // Цифра - 2
        private void button24_Click(object sender, EventArgs e)
        {
            TemplateForNumbers(number: 2);
        }


        // Цифра - 1
        private void button22_Click(object sender, EventArgs e)
        {
            TemplateForNumbers(number: 1);
        }


        // Цифра - 0
        private void button21_Click(object sender, EventArgs e)
        {
            TemplateForNumbers(number: 0);
        }



        // Операциии (+, -, × ...)

        // Сложение - +
        private void button2_Click(object sender, EventArgs e)
        {
            TemplateForOperations(FundsEntryOperation: " + ");
        }


        // Вычитание - -
        private void button1_Click(object sender, EventArgs e)
        {
            TemplateForOperations(FundsEntryOperation: " - ");
        }


        // Умножение - ×
        private void button9_Click(object sender, EventArgs e)
        {
            TemplateForOperations(FundsEntryOperation: " × ");
        }


        // Деление - ÷
        private void button13_Click(object sender, EventArgs e)
        {
            TemplateForOperations(FundsEntryOperation: " ÷ ");
        }




        // Запятая - ,
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Проверяем, есть ли уже запятая в числовом вводе
            if (!textBox1.Text.Contains(","))
            {
                // Если запятой еще нет, добавляем ее
                if (EndOfOperation == "yes")
                {
                    textBox2.Clear();
                    textBox1.Clear();

                    EndOfOperation = "no";
                        
                    result = 0;

                    result = numberOne;

                    textBox1.Text = textBox1.Text + "0,";
                    textBox2.Text = textBox2.Text + "0,";
                }
                else if (EndOfOperation == "no")
                {
                    // Если вводить число еще не начали, добавляем 0 перед запятой
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "0,";
                        textBox2.Text = textBox2.Text + "0,";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + ",";
                        textBox2.Text = textBox2.Text + ",";
                    }
                }
                else if (EndOfOperation == "error")
                {
                    textBox2.Clear();
                    textBox1.Clear();

                    EndOfOperation = "no";

                    textBox1.Text = textBox1.Text + "0,";
                    textBox2.Text = textBox2.Text + "0,";
                }
            }
        }

        


        // Нужно только "одно" число

        // Процент - %
        private void button26_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForOperations) (Шаблон для всех операций) (С выбором операции √)
            TemplateForOperations(FundsEntryOperation: " %");

            if (operation == " %" & firstNumberIsMemorized != "")
            {
                numberOne = Convert.ToDouble(firstNumberIsMemorized);

                if (numberOne != 0)
                {
                    result = numberOne / 100;

                    textBox1.Text = result.ToString();

                    textBox2.Text = textBox2.Text + " = " + result;

                    EndOfOperation = "yes";
                }

                else
                {
                    Error();
                }
            }

            else
            {
                Error();
            }
        }


        // √ - Корень
        private void button4_Click(object sender, EventArgs e)
        {
            // Используем созданную функцию (TemplateForOperations) (Шаблон для всех операций) (С выбором операции √)
            TemplateForOperations(FundsEntryOperation: "√");

            if (operation == "√" & firstNumberIsMemorized != "")
            {
                numberOne = Convert.ToDouble(firstNumberIsMemorized);

                if (numberOne != 0)
                {
                    textBox2.Clear();

                    result = Math.Sqrt(numberOne);

                    textBox1.Text = result.ToString();

                    textBox2.Text = textBox2.Text + operation + numberOne + " = " + result;

                    EndOfOperation = "yes";
                }

                else
                {
                    Error();
                }
            }

            else
            {
                Error();
            }
        }



        // Логика для калькулятора прописанная в кнопке равно

        // Равно - =
        private void button18_Click(object sender, EventArgs e)
        {
            result = 0;

            // Условия для операций

            // Сложение - +
            if (operation == " + " & firstNumberIsMemorized != "")
            {
                numberOne = Convert.ToDouble(firstNumberIsMemorized);
                numberTwo = Convert.ToDouble(textBox1.Text);

                if (numberTwo != double.MinValue & numberOne != double.MinValue)
                {
                    result = numberOne + numberTwo;
                    operation = " = ";
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox2.Text + operation + result;
                    EndOfOperation = "yes";
                }

                else
                {
                    Error();
                }
            }


            // Вычитание - -
            else if (operation == " - " & firstNumberIsMemorized != "")
            {
                numberOne = Convert.ToDouble(firstNumberIsMemorized);
                numberTwo = Convert.ToDouble(textBox1.Text);

                if (numberTwo != double.MinValue & numberOne != double.MinValue)
                {
                    result = numberOne - numberTwo;
                    operation = " = ";
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox2.Text + operation + result;
                    EndOfOperation = "yes";
                }

                else
                {
                    Error();
                }
            }


            // Умножение - ×
            else if (operation == " × " & firstNumberIsMemorized != "" || operation == " × " & numberOne != 0)
            {
                numberOne = Convert.ToDouble(firstNumberIsMemorized);
                numberTwo = Convert.ToDouble(textBox1.Text);

                if (numberTwo != double.MinValue & numberOne != double.MinValue)
                {
                    result = numberOne * numberTwo;
                    operation = " = ";
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox2.Text + operation + result;
                    EndOfOperation = "yes";
                }

                else
                {
                    Error();
                }
            }


            // Деление - ÷
            else if (operation == " ÷ " & firstNumberIsMemorized != "")
            {
                numberOne = Convert.ToDouble(firstNumberIsMemorized);
                numberTwo = Convert.ToDouble(textBox1.Text);

                if (numberTwo != double.MinValue & numberOne != double.MinValue)
                {
                    result = numberOne / numberTwo;
                    operation = " = ";
                    textBox1.Text = result.ToString();
                    textBox2.Text = textBox2.Text + operation + result;
                    EndOfOperation = "yes";
                }

                else
                {
                    Error();
                }
            }


            // В ином случае ошибка
            else
            {
                Error();
            }

            // Присваиваем минимальное значение первому и второму число после подсчёта
            numberOne = double.MinValue;
            numberTwo = double.MinValue;
        }



        // Вторичные кнопки

        // Очистить текстовое поле - C
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            zero = 0;
            textBox1.Text = textBox1.Text + zero;
        }


        // Очистить текстовое поле при втором числе - CE
        private void button3_Click_1(object sender, EventArgs e)
        {
            // Если указываем второе число
            if (firstNumberIsMemorized != "" & result == double.MinValue || EditNumberTwo != "" & result == double.MinValue || numberOne != double.MinValue & result != double.MinValue)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox2.Text = textBox1.Text + firstNumberIsMemorized + operation;
            }

            // Полное очищение
            else
            {
                textBox1.Text = "";
                textBox2.Clear();
                zero = 0;
                textBox1.Text = textBox1.Text + zero;
            }
        }


        // Удаление - <--
        private void button5_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;


            // Если редактируем первое число
            if (firstNumberIsMemorized == "" & EditRes == "" & EditNumberTwo == "" & res == 0)
            {
                textBox1.Clear();
                textBox2.Clear();

                for (int i = 0; i < lenght; i++)
                {
                    textBox1.Text = textBox1.Text + text[i];
                    textBox2.Text = textBox2.Text + text[i];
                }
            }


            // Если редактируем второе число
            else if (firstNumberIsMemorized != "" & result == double.MinValue || EditNumberTwo != "" & result == double.MinValue || numberOne != double.MinValue & result != double.MinValue) // Обычная ситуация если первый номер известен и результат неизвестен => 0 => вводим второе число
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox2.Text = firstNumberIsMemorized + operation;

                for (int i = 0; i < lenght; i++)
                {
                    textBox1.Text = textBox1.Text + text[i];
                    textBox2.Text = textBox2.Text + text[i];
                }
            }


            // Если редактируем результат
            else
            {
                textBox1.Clear();
                textBox2.Clear();

                for (int i = 0; i < lenght; i++)
                {
                    EditRes = textBox2.Text + text[i];
                    EditRes = textBox1.Text + text[i];

                    textBox1.Text = EditRes;
                    textBox2.Text = EditRes;
                }
            }
        }



        // Кнопки с ссылками

        // YouTube
        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitLink("https://www.youtube.com/channel/UCb2GlPOgqB_VpWTvQM_dzKg");
        }


        // Telegram
        private void telegramBotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitLink("https://t.me/New_Vision_rus_en_bot");
        }


        // Git Hub
        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitLink("https://github.com/Komorif");
        }



        // Функции

        // Функция (TemplateForOperations) (Шаблон для всех операций)
        private void TemplateForOperations(string FundsEntryOperation)
        {
            if (EndOfOperation == "yes")
            {
                // Если произошло редактирование результата
                if (EditRes != "")
                {
                    numberTwo = double.MinValue;

                    textBox2.Clear();
                    textBox1.Clear();

                    EndOfOperation = "no";

                    textBox2.Text = textBox2.Text + EditRes;
                    textBox1.Text = textBox1.Text + EditRes;

                    operation = FundsEntryOperation;

                    double res = Convert.ToDouble(EditRes);
                    EditRes = "";
                    numberOne = res;
                    result = numberOne;

                    firstNumberIsMemorized = textBox1.Text;

                    textBox1.Clear();

                    textBox2.Text = textBox2.Text + FundsEntryOperation;
                }

                else if (EditRes == "")
                {
                    numberTwo = double.MinValue;

                    textBox2.Clear();
                    textBox1.Clear();

                    EndOfOperation = "no";

                    textBox2.Text = textBox2.Text + result;
                    textBox1.Text = textBox1.Text + result;

                    operation = FundsEntryOperation;

                    result = numberOne;

                    firstNumberIsMemorized = textBox1.Text;
                    textBox1.Clear();
                    textBox2.Text = textBox2.Text + FundsEntryOperation;
                }
            }

            else if (EndOfOperation == "no")
            {
                operation = FundsEntryOperation;

                firstNumberIsMemorized = textBox1.Text;
                textBox1.Clear();

                textBox2.Text = textBox2.Text + FundsEntryOperation;
            }

            else if (EndOfOperation == "error")
            {
                Error();
            }
        }


        // Функция (TemplateForNumbers) (Шаблон для всех цифр)
        private void TemplateForNumbers(int number)
        {
            if (zero == 0)
            {
                textBox1.Clear();
                zero = 1;
            }

            if (EndOfOperation == "yes")
            {
                textBox2.Clear();
                textBox1.Clear();

                EndOfOperation = "no";

                result = 0;

                result = numberOne;

                textBox1.Text = textBox1.Text + number;
                textBox2.Text = textBox2.Text + number;
            }

            else if (EndOfOperation == "no")
            {
                textBox1.Text = textBox1.Text + number;
                textBox2.Text = textBox2.Text + number;
            }

            else if (EndOfOperation == "error")
            {
                textBox2.Clear();
                textBox1.Clear();

                EndOfOperation = "no";

                textBox1.Text = textBox1.Text + number;
                textBox2.Text = textBox2.Text + number;
            }
        }





        // Функция Error (для ошибок)
        private void Error()
        {
            textBox2.Clear();
            textBox1.Clear();

            textBox1.Text = textBox1.Text + "error208";
            textBox2.Text = textBox2.Text + "error208";

            EndOfOperation = "error";
        }


        // Функция VisitLink (создана для кнопок с ссылками) (ссылка изменяемая для удобства)
        private void VisitLink(string url)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}