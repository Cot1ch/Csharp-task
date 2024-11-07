using System;
using System.Threading;

namespace dz
{
    internal class Program
    {
        static void Main()
        {
            // 1 номер. Вывести число е

            Console.WriteLine("1 номер");

            Console.WriteLine($"{Math.Round(Math.Exp(1), 1)}");

            Console.WriteLine("\n");
            //2 номер
            // Вывод 50 и 10 в столбик

            Console.WriteLine("2 номер");

            Console.WriteLine(50);
            Console.WriteLine(10);

            Console.WriteLine("\n");
            //3 номер
            // Вывод 4 чисел в столбик

            Console.WriteLine("3 номер");

            int a3 = 10;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(a3 * 2);
                a3 += 12;
            }

            Console.WriteLine("\n");
            //4 номер
            // Пользователь вводит число. Выведите на экран число + 10

            Console.WriteLine("4 номер");

            Console.WriteLine("Введите число");
            double num4 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Новое число равно {num4 + 10}");

            Console.WriteLine("\n");
            //5 номер
            // Дана сторона квадрата. Найти его периметр.

            Console.WriteLine("5 номер");

            Console.WriteLine("Введите длину стороны квадрата");
            int side5 = int.Parse(Console.ReadLine());
            if (side5 > 0)
            {
                Console.WriteLine($"Периметр равен {side5 * 4}");
            }
            else if (side5 == 0)
            {
                Console.WriteLine("Мощно; Квадрат со стороной 0 имеет периметр 0");
            }
            else
            {
                Console.WriteLine($"Квадрат с отрицательной стороной не существует в моём понимании, но если он есть в вашем, то его периметр равен {4 * side5}");
            }

            Console.WriteLine("\n");
            //6
            // Дан радиус окружности. Найти длину окружности и площадь круга.

            Console.WriteLine("6 номер");

            Console.WriteLine("Введите радиус окружности");
            double radius6 = double.Parse(Console.ReadLine());
            if (radius6 > 0)
            {
                Console.WriteLine($"Длина окружности: {Math.PI * 2 * radius6}");
                Console.WriteLine($"Площадь круга: {Math.PI * radius6 * radius6}");
            }
            else
            {
                Console.WriteLine("Отрицательный радиус - это как?");
            }

            Console.WriteLine("\n");
            //7
            // Найти значение y=cos(x)

            Console.WriteLine("7 номер");

            Console.WriteLine("Введите значение x");
            double x7 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Косинус {x7} = {Math.Cos(x7)}");

            Console.WriteLine("\n");
            //8
            // Даны основания и высота равнобедренной трапеции. Найти ее периметр.

            Console.WriteLine("8 номер");

            Console.WriteLine("Введите длину первого основания");
            double fir_side = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину второго основания");
            double sec_side = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту трапеции");
            double height = double.Parse(Console.ReadLine());
            if (height <= 0 | fir_side <= 0 | sec_side <= 0)
            {
                Console.WriteLine("Все числа должны быть положительными");
            }
            else
            {
                double delta8 = Math.Abs(fir_side - sec_side) / 2;
                double lat_side = Math.Sqrt(delta8 * delta8 + height * height);
                Console.WriteLine($"Периметр р/б трапеции равен {2 * lat_side + fir_side + sec_side}");
            }

            Console.WriteLine("\n");
            //9
            // Известна стоимость 1 кг конфет, печенья и яблок.
            // Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.

            Console.WriteLine("9 номер");

            Console.WriteLine("Введите стоимость одного килограмма конфет");
            double candy_kilo_cost = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость одного килограмма печенья");
            double cookies_kilo_cost = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость одного килограмма яблок");
            double apples_kilo_cost = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите массу конфет");
            double x9 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу печенья");
            double y9 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу яблок");
            double z9 = double.Parse(Console.ReadLine());

            if (x9 < 0 | y9 < 0 | z9 < 0 | candy_kilo_cost < 0 | cookies_kilo_cost < 0 | apples_kilo_cost < 0)
            {
                Console.WriteLine("Все числа должны быть неотрицательными");
            }
            else
            {
                Console.WriteLine($"Общая сумма покупки равна {x9 * candy_kilo_cost + y9 * cookies_kilo_cost + z9 * apples_kilo_cost}");
            }

            Console.WriteLine("\n");
            //10
            // Вывести Мир Труд Май 2 способами

            Console.WriteLine("10 номер");

            string a10 = "Мир";
            string b10 = "Труд";
            string c10 = "Май";

            Console.WriteLine(a10 + " " + b10 + " " + c10);
            Console.WriteLine($"{a10}");
            Console.WriteLine($"{b10,10}");
            Console.WriteLine($"{c10,15}");

            Console.WriteLine("\n");
            //11
            // Вводятся 2 числа на разных строках
            // Если это числа, то при выводе они меняются местами

            Console.WriteLine("11 номер");

            try
            {
                Console.WriteLine("Введите первое число");
                double a11 = double.Parse(Console.ReadLine().Replace(",", "."));
                Console.WriteLine("Введите второе число");
                double b11 = double.Parse(Console.ReadLine().Replace(",", "."));

                Console.WriteLine($"{b11} {a11}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ввод некорректен, нужны два числа ->\n{e.Message}");
            }

            Console.WriteLine("\n");
            //12 
            // Пользователь выбирает фигуру; указывает, что программа
            // будет считать – площадь или периметр.
            // Задаётся все необходимые значения, а на основе полученных результатов
            // программа должна подсчитать, какими могли бы быть
            // периметры или площади остальных фигур.

            Console.WriteLine("12 номер");

            Console.WriteLine("Выберите фигуру и впишите её номер в консоль:\n1 - треугольник (равносторонний); \n2 - четырёхугольник (квадрат)'\n3 - круг.");
            int figure = int.Parse(Console.ReadLine());

            switch (figure)
            {
                case 1:
                    Console.WriteLine("Что нужно вычислить? Площадь - 1 - или периметр - 2?");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 2:
                            Console.WriteLine("Введите сторону треугольника");
                            double side = double.Parse(Console.ReadLine());
                            if (side <= 0)
                            {
                                Console.WriteLine("Нужно положительное число");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Периметр равен {3 * side}");
                                Console.WriteLine($"Квадрат со стороной {side} имел бы периметр {side * 4};\nДлина окружности круга с радиусом {side} = {side * 2 * Math.PI}");
                                break;
                            }
                        case 1:
                            Console.WriteLine("Введите сторону треугольника");
                            double tr_side = double.Parse(Console.ReadLine());
                            if (tr_side <= 0)
                            {
                                Console.WriteLine("Нужно положительное число");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"{tr_side * tr_side * Math.Sqrt(3) / 4}");
                                Console.WriteLine($"Квадрат со стороной {tr_side} имел бы площадь {tr_side * tr_side};\nПлощадь круга радиуса {tr_side} = {tr_side * tr_side * Math.Sqrt(3) / 4}");
                                break;
                            }
                        default:
                            Console.WriteLine("Ну там два слова, третьего не дано");
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("Что нужно подсчитать? Площадь - 1 - или длина окружности - 2?");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 2:
                            Console.WriteLine("Введите радиус");
                            double rad = double.Parse(Console.ReadLine());
                            if (rad <= 0)
                            {
                                Console.WriteLine("Нужно положительное число");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Длина окружности равна {2 * Math.PI * rad}");
                                Console.WriteLine($"Квадрат со стороной {rad} имел бы периметр {rad * 4};\nтреугольник - {rad * 3}");
                                break;
                            }
                        case 1:
                            Console.WriteLine("Введите радиус");
                            double radius = double.Parse(Console.ReadLine());
                            if (radius <= 0)
                            {
                                Console.WriteLine("Нужно положительное число");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Площадь равна {Math.PI * radius * radius}");
                                Console.WriteLine($"Квадрат со стороной {radius} имел бы площадь {radius * radius};\nТреугольник со стороной {radius} имел бы площадь {radius * radius * Math.Sqrt(3) / 4}");
                                break;
                            }
                        default:
                            Console.WriteLine("Ну там два слова, третьего не дано");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Что считать? Площадь - 1 - или периметр - 2?");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 2:
                            Console.WriteLine("Введите сторону квадрата");
                            double a = double.Parse(Console.ReadLine());
                            if (a <= 0)
                            {
                                Console.WriteLine("Нужно положительное число");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Периметр равен {a * 4}");
                                Console.WriteLine($"Круг с радиусом {a} имел бы длину окружности {Math.PI * 2 * a};\nТреугольник со стороной {a} имел бы периметр {a * 3}");
                                break;
                            }
                        case 1:
                            Console.WriteLine("Введите сторону квадрата");
                            double i = double.Parse(Console.ReadLine());
                            if (i <= 0)
                            {
                                Console.WriteLine("Нужно положительное число");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Площадь равна {i * i}");
                                Console.WriteLine($"Круг с радиусом {i} имел бы площадь {Math.PI * i * i};\nПлощадь треугольника со стороной {i} равна {i * i * Math.Sqrt(3) / 4}");
                                break;
                            }
                        default:
                            Console.WriteLine("Ну там два слова, третьего не дано");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Такой фигуры пока нет...");
                    break;
            }

            Console.WriteLine("\n");
            //13
            //Составить программу вывода на экран числа, вводимого с клавиатуры.
            //Вводимому числу должно предшествовать сообщение «Вы ввели число».

            Console.WriteLine("13 номер");

            Console.WriteLine("Введите число");

            double num13 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Вы ввели число {num13}");

            Console.WriteLine("\n");
            //14
            //Составить программу вывода на экран следующей информации:
            //2 кг
            //13 17

            Console.WriteLine("14 номер");

            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");

            Console.WriteLine("\n");
            //15
            // Вывести 4 случайных числа

            Console.WriteLine("15 номер");

            Random rando = new Random();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{rando.Next(1000)}");
            }

            Console.WriteLine("\n");
            //16
            // Даны коэффициенты квадратного уравнения, вывести корни

            Console.WriteLine("16 номер");

            Console.WriteLine("Введите коэффициент перед х в квадрате");
            double a16 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент перед х в первой");
            double b16 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите свободный коэффициент");
            double c16 = double.Parse(Console.ReadLine());
            double discrim = b16 * b16 - 4 * a16 * c16;
            if (discrim < 0)
            {
                Console.WriteLine("Дискриминант меньше нуля, в действит. числах решений нет");
            }
            else
            {
                if (discrim == 0)
                {
                    Console.WriteLine($"Один корень: {-b16 / (2 * a16)}");
                }
                else
                {
                    Console.WriteLine($"Первый корень: {(-b16 - Math.Pow(discrim, 0.5)) / (2 * a16)}, второй корень: {(-b16 + Math.Pow(discrim, 0.5)) / (2 * a16)}");
                }
            }

            Console.WriteLine("\n");
            //17
            // Даны 2 натуральных числа
            // Выводятся средние арифметическое и геометрическое

            Console.WriteLine("17 номер");
            try
            {
                Console.WriteLine("Введите первое натуральное число");
                int a17 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе натуральное число");
                int b17 = int.Parse(Console.ReadLine());

                if ((a17 < 0) | (b17 < 0))
                {
                    Console.WriteLine("Оба числа должны быть больше нуля");
                }
                else
                {
                    Console.WriteLine($"Среднее арифметическое равно {(double)(a17 + b17) / 2}");
                    Console.WriteLine($"Среднее геометрическое равно {Math.Sqrt(a17 * b17)}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Числа должны быть натуральными: {e.Message}");
            }

            Console.WriteLine("\n");
            //18
            // В двух строках через пробел вводятся координаты 2 точек
            // На выходе расстояние между ними

            Console.WriteLine("18 номер");
            try
            {
                Console.WriteLine("Введите координаты первой точки");
                string[] first_dot = Console.ReadLine().Split();
                Console.WriteLine("Введите координаты второй точки");
                string[] second_dot = Console.ReadLine().Split();

                double x1 = double.Parse(first_dot[0]);
                double y1 = double.Parse(first_dot[1]);
                double x2 = double.Parse(second_dot[0]);
                double y2 = double.Parse(second_dot[1]);

                Console.WriteLine($"{Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Некорректный ввод, нужны два числа в одной строке через пробел (и так два раза)", e);
            }


            Console.WriteLine("\n");
            //19 
            // Поменять значения переменных 2 способами

            Console.WriteLine("19 номер");

            int a19 = 1;
            int b19 = 2;
            int c19 = 3;

            (a19, b19, c19) = (b19, c19, a19);
            Console.WriteLine($"1 способ: {a19} {b19} {c19}");

            a19 = 1;
            b19 = 2;
            c19 = 3;

            int dop = a19;
            a19 = c19;
            c19 = b19;
            b19 = dop;
            Console.WriteLine($"2 способ: {a19} {b19} {c19}");

            Console.WriteLine("\n");
            //20
            // Дано количество секунд с 00:00.
            // Вывести количество полных часов, минут с начала последнего часа и секунд с последней минуты

            Console.WriteLine("20 номер");

            Console.WriteLine("Введите количество секунд, прошедших с 00:00");
            int n20 = int.Parse(Console.ReadLine());

            int hour = n20 / 3600;
            int minute = n20 % 3600 / 60;
            int second = n20 % 60;

            Console.WriteLine($"Время - {hour} ч:{minute} мин:{second} сек");

            Console.WriteLine("\n");
            //21
            // Дан прямоугольник с размерами 543 х 130 мм.
            // Сколько квадратов со стороной 130 мм можно отрезать от него?

            Console.WriteLine("21 номер");

            int area = 543 * 130;
            int count = 0;

            while (area > 130 * 130)
            {
                area -= 130 * 130;
                count += 1;
            }
            Console.WriteLine(count);

            Console.WriteLine("\n");
            //22
            // Дано трехзначное число. В нем зачеркнули последнюю справа цифру
            // и приписали ее в начале.Найти полученное число.

            Console.WriteLine("22 номер");

            Console.WriteLine("Введите трехзначное число");
            int n22 = int.Parse(Console.ReadLine());
            if (100 <= n22 & n22 <= 999)
            {
                Console.WriteLine($"{n22 % 10 * 100 + (int)n22 / 10}");
            }
            else
            {
                Console.WriteLine("Это не трехзначное число");
            }

            Console.WriteLine("\n");
            //23
            // Дано число, вывести количество сотен и тысяч в нём

            Console.WriteLine("23 номер");

            Console.WriteLine("Введите четырехзначное число");
            int n23 = int.Parse(Console.ReadLine());
            if (1000 <= n23 & n23 <= 9999)
            {
                Console.WriteLine($"В числе {(n23 / 100) % 10} сотен и {n23 / 1000} тысяч");
            }
            else
            {
                Console.WriteLine("Это не четырехзначное число");
            }

            Console.WriteLine("\n");
            //24
            // Дано четырехзначное число.  Вернуть
            //а) число, полученное при прочтении его цифр справа налево;
            //б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр;            
            //в) число, образуемое при перестановке второй и третьей цифр;
            //г) число, образуемое при перестановке двух первых и двух последних цифр;

            Console.WriteLine("24 номер");

            Console.WriteLine("Введите четырехзначное число");
            string n = Console.ReadLine();

            if (int.TryParse(n, out _))
            {
                Console.WriteLine($"1) {int.Parse(n[3].ToString() + n[2].ToString() + n[1].ToString() + n[0].ToString())}");

                Console.WriteLine($"2) {int.Parse(n[1].ToString() + n[0].ToString() + n[3].ToString() + n[2].ToString())}");

                Console.WriteLine($"3) {int.Parse(n[0].ToString() + n[2].ToString() + n[1].ToString() + n[3].ToString())}");

                Console.WriteLine($"4) {int.Parse(n[2].ToString() + n[3].ToString() + n[0].ToString() + n[1].ToString())}");
            }
            else
            {
                Console.WriteLine("Нужно четырехзначное число");
            }

            Console.WriteLine("\n");
            //25
            // Из трехзначного числа x вычли его последнюю цифру.
            // Pезультат разделили на 10, и слева приписали ту цифру числа x.
            // Получилось число n. Найти число x.

            Console.WriteLine("25 номер");

            Console.WriteLine("Введите трехзначное число");
            string n25 = Console.ReadLine();

            if (int.TryParse(n25, out _) & n25.Length == 3)
            {
                int x25 = int.Parse($"{n25[1]}{n25[2]}{n25[0]}");
                Console.WriteLine($"x = {x25}");
            }
            else
            {
                Console.WriteLine("Нужно трехзначное число");
            }


            Console.WriteLine("\n");
            //26
            // Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59),
            // указывающие момент времени: «h часов, m минут, s секунд».
            // Определить угол(в градусах) между
            // положением часовой стрелки в начале суток и в указанный момент времени.

            Console.WriteLine("26 номер");

            Console.WriteLine("Введите количество часов");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество минут");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввдите количсетво секунд");
            int s = int.Parse(Console.ReadLine());

            int tot_sec = h * 3600 + m * 6 + s;
            double grad = tot_sec / 43200.0 * 360 % 360;

            Console.WriteLine($"Угол равен {grad:F1} градусов");

            Console.WriteLine("\n");
            //27
            // Дан угол часовой стрелки, вывести время и угол минутной

            Console.WriteLine("27 номер");

            Console.WriteLine("Введите угол часовой стрелки (в радианах)");
            double y27 = double.Parse(Console.ReadLine());

            double hours = Math.Floor(6 * y27);
            double minutes = (180 * y27 - 30 * hours) * 2;
            double minutes_ancor = minutes / 30;

            Console.WriteLine($"Угол минутной стрелки равен {minutes_ancor:F1} радиан; время - {hours:F0}:{minutes:F0}");

            Console.WriteLine("\n");
            //28 
            // Вывести наименьшее по модулю из 3 введенных

            Console.WriteLine("28 номер");

            Console.WriteLine("Введите первое число");
            double a28 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b28 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            double c28 = double.Parse(Console.ReadLine());

            if (Math.Abs(a28) <= Math.Abs(b28))
            {
                if (Math.Abs(a28) <= Math.Abs(c28))
                {
                    Console.WriteLine($"{a28}");
                }
            }
            else
            {
                if (Math.Abs(b28) <= Math.Abs(c28))
                {
                    Console.WriteLine($"{b28}");
                }
                else
                {
                    Console.WriteLine($"{c28}");
                }
            }

            Console.WriteLine("\n");
            //29 
            // Найти сумму наибольшего и наименьшего из 3 введенных чисел

            Console.WriteLine("29 номер");

            Console.WriteLine("Введите первое число");
            double a29 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b29 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            double c29 = double.Parse(Console.ReadLine());
            double min29 = 10000000;
            double max29 = 0;

            double[] array = new double[] { a29, b29, c29 };

            foreach (double i29 in array)
            {
                if (i29 < min29)
                {
                    min29 = i29;
                }
                if (i29 > max29)
                {
                    max29 = i29;
                }
            }

            Console.WriteLine($"Сумма равна {min29 + max29}");

            Console.WriteLine("\n");
            //30
            // Подсчитать количество делителей вводимого числа

            Console.WriteLine("30 номер");

            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());

            int sumDel = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    sumDel++;
                }
            }
            Console.WriteLine($"{sumDel}");

            Console.WriteLine("\n");
            //31
            // Вводятся коэффициенты кубического уравнения, выводятся корни уравнения, если они есть

            Console.WriteLine("31 номер");

            Console.WriteLine("Введите коэффициент перед х в кубе");
            double a31 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент перед х в квадрате");
            double b31 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент перед х в первой степени");
            double c31 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите свободный коэффициент");
            double d31 = double.Parse(Console.ReadLine());

            if (a31 == 0)
            {
                Console.WriteLine("Это не кубическое уравнение! Завершаю решение!");
            }
            else
            {
                for (int x = -100; x <= 100; x++)
                {
                    if (a31 * Math.Pow(x, 3) + b31 * Math.Pow(x, 2) + c31 * x + d31 == 0)
                    {
                        Console.WriteLine($"{x}");
                    }
                }
            }

            Console.WriteLine("\n");
            //32
            // Даны 1 и 2 элементы арифм. прогрессии, найти и вывести n-ный

            Console.WriteLine("32 номер");

            Console.WriteLine("Введите 1 элемент арифметической прогрессии");
            double a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 элемент арифметической прогрессии");
            double a2 = int.Parse(Console.ReadLine());

            double delta = a2 - a1;

            Console.WriteLine("Введите число n");
            int n32 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a1 + delta * (n32 - 1)}");

            Console.WriteLine("\n");
            //33
            // Ввод профессии, пенсионер или нет, трудоустроен ли
            // Если (пенсионер или студент) и не трудоустроен, то получаю кредит
            // И пенсионер, и студент - нет
            // В неоговоренных случаях в кредите отказать

            Console.WriteLine("33 номер");

            Console.WriteLine("Кто вы? Студент или другая форма жизни? Впишите в консоль");
            string prof = Console.ReadLine().ToLower();

            Console.WriteLine("А вы пенсионер? Да/Нет");
            string age = Console.ReadLine().ToLower();

            Console.WriteLine("Спасибо за ваш... Извините, записано. Вы трудоустроены? Да/Нет");
            string stat = Console.ReadLine().ToLower();
            Console.WriteLine("Принято");

            if (prof == "студент")
            {
                if (age == "да")
                {
                    Console.WriteLine("В кредите отказано");
                }

                else
                {
                    if (stat == "нет")
                    {
                        Console.WriteLine("Так себе приз, если честно. Кредит одобрен");
                    }
                    else
                    {
                        Console.WriteLine("В кредите отказано");
                    }
                }
            }
            else if (age == "да")
            {
                if (stat == "нет")
                {
                    Console.WriteLine("Так себе приз, если честно. Кредит одобрен");
                }
                else
                {
                    Console.WriteLine("В кредите отказано");
                }
            }
            else
            {
                Console.WriteLine("В кредите отказано");
            }

            Console.WriteLine("\n");
            //34
            // 1) Спросить имя и вывести его 
            // 2) Спросить имя и вывести его с приветствием

            Console.WriteLine("34 номер");

            Console.WriteLine("Нам нужно твое имя, <<тут должно быть ваше имя>>");

            string name = Console.ReadLine();

            Console.WriteLine($"{name}");

            Console.WriteLine($"Снова нужно твое имя, {name}");

            string name34 = Console.ReadLine();

            Console.WriteLine($"Привет, {name34}!");

            Console.WriteLine("\n");
            //35 
            // Воспроизвести разговор Гарри и дневника Тома Реддла.
            // Пользователь здоровается с консолью.
            // Консоль спрашивает, как зовут пользователя.
            // Пользователь называет имя.
            // Консоль пишет: привет, < имя пользователя >.
            // После этого пользователь спрашивает, знает ли консоль что-то о тайной комнате.
            // Консоль отвечает «Да».
            // После этого пользователь спрашивает, может ли рассказать.
            // Консоль отвечает «Нет».
            // Спустя 5 секунд консоль дополняет «но могу показать».
            // Консоль меняет
            // цвет на любой случайный цвет.

            Console.WriteLine("35 номер");
            Console.ReadLine(); //Пользователь здоровается с консолью???

            Console.WriteLine("Ваше имя?");
            string nameAgain = Console.ReadLine();
            Console.WriteLine($"Привет, {nameAgain}");

            if (Console.ReadLine().ToLower() == "ты знаешь что-то о тайной комнате?")
            {
                Console.WriteLine("Да");

                if (Console.ReadLine().ToLower() == "можешь рассказать?")
                {
                    Console.WriteLine("Нет");
                    Thread.Sleep(5000);
                    Console.WriteLine("...но могу показать");
                    string[] colors = { "red", "yellow", "cyan", "green" };

                    Random rnd = new Random();

                    switch (colors[rnd.Next(colors.Length)])
                    {
                        case "red":
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        case "yellow":
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        case "cyan":
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        case "green":
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                    }
                }
            }

            Console.WriteLine("\n");
            //36
            // Вычислить контрольную цифру штрихкода (EAN13).
            // 1) 12 цифр определяются случайным образом. 
            // 2) 12 цифр вводит пользователь

            Console.WriteLine("36 номер");

            Console.WriteLine("1) Введите 12 цифр кода");
            string nums = Console.ReadLine();
            if (nums.Length != 12)
            {
                Console.WriteLine("Нужно 12 цифр");
            }
            else
            {
                Console.WriteLine($"Контрольная цифра равна{Code(nums)}");
            }

            nums = "";
            Random rand = new Random();
            for (int i = 0; i < 11; i++)
            {
                nums += rand.Next(10).ToString();
            }
            Console.WriteLine($"2) Сгенерированная строка равна {nums}");
            Console.WriteLine($"Контрольная цифра равна{Code(nums)}");

            int Code(string str)
            {
                int nechet = 0;
                int chet = 0;
                for (int k = 0; k < 12; k++)
                {
                    if (k % 2 == 0)
                    {
                        chet += str[k] - '0';
                    }
                    else
                    {
                        nechet += str[k] - '0';
                    }
                }
                int answer = (1000 - chet - 3 * nechet) % 10;
                return answer;
            }
            Console.WriteLine("Да здравствуют костыли.\nВведите что-нибудь для выхода, а то у меня консоль сразу закрывалась");
            Console.ReadLine();
        }
    }
}
