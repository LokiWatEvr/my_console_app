using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleColors
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka = "Тут могла быть ваша реклама";
            char symbol = 'A';


            /* string s1 = "ghbdtn, ";
            string s2 = "vbh!";
            string s3 = s1 + s2;
           
            Console.WriteLine("Кол-во символов: " + s3.Length);
            Console.WriteLine(s3.ToUpper());
            Console.WriteLine(s3.ToLower());
            Console.WriteLine(s3.Replace("ghbdtn, vbh!", "Привет, мир!"));
            

            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Вам " + age + " лет");

            Console.Write("Введите ваше ФИО: ");
            string name = (Console.ReadLine());

            Console.Write("Введите год рождения в формате(год-месяц-день): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите город в котором вы сейчас находитесь: ");
            string city = Console.ReadLine();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Разыскивается!");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("ФИО: " + name);
            Console.WriteLine("Дата рождения: " + birthDate.ToShortDateString());
            Console.WriteLine("Находится в городе:\f " + city); 
            

            Console.ReadLine();
            

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\tНевероятный диалог:\n");
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("\t-А ты научился использовать \"Управляющие символы\"?\n\t-Да");
            Console.WriteLine("\n\n\tНевероятный переход на следующую строчку: \n\t-Вжууух");
            
                        
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Регистрация карточки банка! Всё честно, честно!\n\t-Не Фишинговая программа");

            string email = "kolobokiztesta@mail.ru";
            string password = "anonim123";
            int pincode = 123;

            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("\n\n\nВаш зашифрованный пароль: " + password.Replace('a', 'y') + "\n\nВаш пинкод: " + pincode + "\n\nВаша почта: " + email + "\n\tСпасибо что доверяете нашему сайту!");
            */
            /*
            Console.Write("Введите число, для которого будет выведена таблица умножения: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)

            {
                Console.WriteLine(i + " * " + n + " = " + (n * i));
            }

            Console.ReadLine();
            */
            Console.Write("Напишите предложение: ");
            string str = Console.ReadLine(); 
            Console.WriteLine(str.Replace(' ', '_'));

            Console.ReadLine();
            /*
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  Добро пожаловать в расширенный ");
            Console.WriteLine("        Консольный Калькулятор   ");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();

            while (true)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Выберите операцию:");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Сложение (+) ");
                Console.WriteLine("2. Вычитание (-) ");
                Console.WriteLine("3. Умножение (*) ");
                Console.WriteLine("4. Деление (/) ");
                Console.WriteLine("5. Возведение в степень (^) ");
                Console.WriteLine("6. Квадратный корень (√) ");
                Console.WriteLine("7. Модуль (остаток от деления) (%) ");
                Console.WriteLine("8. Синус (sin) ");
                Console.WriteLine("9. Косинус (cos) ");
                Console.WriteLine("10. Тангенс (tan) ");
                Console.WriteLine("11. Логарифм (log) ");
                Console.WriteLine("12. Выход");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Введите номер операции: ");
                Console.ResetColor();

                if (!int.TryParse(Console.ReadLine(), out int operation) || operation < 1 || operation > 12)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный ввод! Попробуйте снова.");
                    Console.ResetColor();
                    continue;
                }

                if (operation == 12)
                {
                    break;
                }

                double num1, num2, result = 0;

                if (operation == 6) // Квадратный корень
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Введите число для извлечения квадратного корня: ");
                    Console.ResetColor();

                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный ввод! Попробуйте снова.");
                        Console.ResetColor();
                        continue;
                    }

                    if (num1 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Квадратный корень из отрицательного числа не определен!");
                        Console.ResetColor();
                        continue;
                    }

                    result = Math.Sqrt(num1);
                }
                else if (operation >= 8 && operation <= 11) // Тригонометрические функции и логарифм
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Введите число: ");
                    Console.ResetColor();

                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный ввод! Попробуйте снова.");
                        Console.ResetColor();
                        continue;
                    }

                    switch (operation)
                    {
                        case 8:
                            result = Math.Sin(num1);
                            break;
                        case 9:
                            result = Math.Cos(num1);
                            break;
                        case 10:
                            result = Math.Tan(num1);
                            break;
                        case 11:
                            if (num1 <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Логарифм от не положительного числа не определен!");
                                Console.ResetColor();
                                continue;
                            }
                            result = Math.Log10(num1);
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Введите первое число: ");
                    Console.ResetColor();

                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный ввод! Попробуйте снова.");
                        Console.ResetColor();
                        continue;
                    }

                    if (operation != 7) // Не нужно второе число для модуля
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Введите второе число: ");
                        Console.ResetColor();

                        if (!double.TryParse(Console.ReadLine(), out num2))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Некорректный ввод! Попробуйте снова.");
                            Console.ResetColor();
                            continue;
                        }
                    }
                }

                try
                {
                    switch (operation)
                    {
                        case 1: // Сложение
                            result = num1 + num2;
                            break;
                        case 2: // Вычитание
                            result = num1 - num2;
                            break;
                        case 3: // Умножение
                            result = num1 * num2;
                            break;
                        case 4: // Деление
                            if (num2 == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            result = num1 / num2;
                            break;
                        case 5: // Возведение в степень
                            result = Math.Pow(num1, num2);
                            break;
                        case 7: // Модуль
                            if (num2 != 0) // Проверка на ненулевое значение num2
                            {
                                result = num1 % num2;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Невозможно вычислить остаток от деления на ноль!");
                                Console.ResetColor();
                            }
                            break;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Результат: {result:F3}");
                    Console.ResetColor();
                }
                catch (DivideByZeroException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Деление на ноль невозможно!");
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("       До свидания!               ");
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
            */
        }
    }
}