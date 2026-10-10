using System;
using System.Threading;
namespace Exercise
{
    class Program
    {
        static void Main()
        { 
            while (true)
            {
                Console.WriteLine("Введите номер задания (8-20):");
                int task = int.Parse(Console.ReadLine());
                switch (task)
                {
                    case 8:
                        Console.Write("Введите a: ");
                        double first = double.Parse(Console.ReadLine());
                        Console.Write("Введите b: ");
                        double second = double.Parse(Console.ReadLine());
                        (first, second) = (second, first);
                        Console.WriteLine($"a = {first}, b = {second}");
                        break;

                    case 9:
                        Console.Write("Введите число: ");
                        double number = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Вы ввели число {number}");
                        break;

                    case 10:
                        Console.Write("Введите a: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Введите b: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Введите c: ");
                        double c = double.Parse(Console.ReadLine());

                        if (a == 0)
                        {
                            Console.WriteLine("Это не квадратное уравнение.");
                            return;
                        }
                        double d = b * b - 4 * a * c;
                        Console.WriteLine($"Дискриминант D = {d}");
                        if (d > 0)
                        {
                            double xFirst = (-b + Math.Sqrt(d)) / (2 * a);
                            double xSecond = (-b - Math.Sqrt(d)) / (2 * a);
                            Console.WriteLine($"x1 = {xFirst}, x2 = {xSecond}");
                        }
                        else if (d == 0)
                        {
                            double x = -b / (2 * a);
                            Console.WriteLine($"x = {x}");
                        }
                        else
                        {
                            Console.WriteLine("Действительных корней нет.");
                        }
                        break;
                    case 11:
                        Console.Write("Введите целое a: ");
                        int firstNumber = int.Parse(Console.ReadLine());
                        Console.Write("Введите целое b: ");
                        int secondNumber = int.Parse(Console.ReadLine());

                        double arith = (firstNumber + secondNumber) / 2.0;
                        double geom = Math.Sqrt((double)firstNumber * secondNumber);
                        Console.WriteLine($"Среднее арифметическое: {arith}");
                        Console.WriteLine($"Среднее геометрическое: {geom}");
                        break;
                    case 12:
                        Console.Write("x1: ");
                        double x1 = double.Parse(Console.ReadLine());
                        Console.Write("y1: ");
                        double y1 = double.Parse(Console.ReadLine());
                        Console.Write("x2: ");
                        double x2 = double.Parse(Console.ReadLine());
                        Console.Write("y2: ");
                        double y2 = double.Parse(Console.ReadLine());
                        double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                        Console.WriteLine($"Расстояние = {dist}");
                        break;
                    case 13:
                        Console.Write("Введите a: "); int firstInt = int.Parse(Console.ReadLine());
                        Console.Write("Введите b: "); int secondInt = int.Parse(Console.ReadLine());
                        Console.Write("Введите c: "); int thirdInt = int.Parse(Console.ReadLine());

                        Console.WriteLine("Схема а): b = c, a = b, c = a");
                        {
                            int A = firstInt, B = secondInt, C = thirdInt;
                            B = C; A = B; C = A;
                            Console.WriteLine($"a = {A}, b = {B}, c = {C}");
                        }

                        Console.WriteLine("Схема б): b = a, c = b, a = c");
                        {
                            int A = firstInt, B = secondInt, C = thirdInt;
                            B = A; C = B; A = C;
                            Console.WriteLine($"a = {A}, b = {B}, c = {C}");
                        }
                        break;
                    case 14:
                        Console.Write("Введите количество секунд с начала суток: ");
                        int n = int.Parse(Console.ReadLine());
                        int hours = n / 3600;
                        int minutes = (n % 3600) / 60;
                        int seconds = n % 60;
                        Console.WriteLine($"Полных часов: {hours}");
                        Console.WriteLine($"Полных минут с начала очередного часа: {minutes}");
                        Console.WriteLine($"Полных секунд с начала очередной минуты: {seconds}");
                        break;
                    case 15:
                        int width = 543, height = 130, side = 130;
                        int count = (width / side) * (height / side);
                        Console.WriteLine($"Можно отрезать квадратов: {count}");
                        break;
                    case 16:
                        Console.Write("Введите трёхзначное число: ");
                        int numberInt = int.Parse(Console.ReadLine());
                        int last = numberInt % 10;
                        int rest = numberInt / 10;
                        int result = last * 100 + rest;
                        Console.WriteLine($"Полученное число: {result}");
                        break;
                    case 17:
                        Console.Write("Введите n (> 999): ");
                        int input = int.Parse(Console.ReadLine());
                        int hundreds = (input / 100) % 10;
                        int thousands = (input / 1000) % 10;
                        Console.WriteLine($"Число сотен: {hundreds}");
                        Console.WriteLine($"Число тысяч: {thousands}");
                        break;
                    case 18:
                        Console.WriteLine("а) Просто повтор имени:");
                        Console.Write("Введите имя: ");
                        string name1 = Console.ReadLine();
                        Console.WriteLine(name1);

                        Console.WriteLine("б) С приветствием:");
                        Console.Write("Введите имя: ");
                        string name2 = Console.ReadLine();
                        Console.WriteLine($"Привет, {name2}!");
                        break;
                    case 19:
                        Console.Write("Поздоровайтесь с консолью: ");
                        Console.ReadLine();
                        Console.Write("Как вас зовут? ");
                        string name = Console.ReadLine();
                        Console.WriteLine($"Привет, {name}");

                        Console.Write("Знаешь ли ты что-то о тайной комнате? ");
                        Console.ReadLine();
                        Console.WriteLine("Да");

                        Console.Write("Можешь рассказать? ");
                        Console.ReadLine();
                        Console.WriteLine("Нет");
                        Thread.Sleep(5000);
                        Console.WriteLine("но могу показать");

                        Random rnd = new Random();
                        Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                        Console.WriteLine("(Цвет изменён!)");
                        Console.ResetColor();
                        break;
                    case 20:

                        string digits;
                        Console.WriteLine("Выберите способ ввода:");
                        Console.WriteLine("a) случайные 12 цифр");
                        Console.WriteLine("b) ввести 12 цифр");
                        Console.Write("Ваш выбор: ");
                        string choice = Console.ReadLine();

                        if (choice == "a")
                        {
                            Random rand = new Random();
                            char[] arr = new char[12];
                            for (int i = 0; i < 12; i++) arr[i] = (char)('0' + rand.Next(0, 10));
                            digits = new string(arr);
                            Console.WriteLine($"Сгенерированные цифры: {digits}");
                        }
                        else
                        {
                            Console.Write("Введите 12 цифр: ");
                            digits = Console.ReadLine();
                            if (digits.Length != 12)
                            {
                                Console.WriteLine("Нужно ровно 12 цифр!");
                                return;
                            }
                        }

                        int sum = 0;
                        for (int i = 0; i < 12; i++)
                        {
                            int dig = digits[i] - '0';
                            sum += (i % 2 == 0) ? dig : dig * 3;
                        }
                        int check = (10 - sum % 10) % 10;
                        Console.WriteLine($"Контрольная цифра: {check}");
                        Console.WriteLine($"Полный штрихкод: {digits}{check}");
                        break;
                    default: Console.WriteLine("Нет такого задания"); break;
                }
            }
        }
    }
}