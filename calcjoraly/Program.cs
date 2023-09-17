internal class Program
{
    static double a, b;
    static double answer;
    private static int i;
    private static string temp;
    private static long aa;

    private static void Main(string[] args)
    {
        Console.WriteLine("мяу мяу мяу калькулятор от артема из п50-5");
        while (true)
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1. Сложить 2 числа(+)\r\n2. Вычесть первое из второго(-)\r\n3. Перемножить два числа(*)\r\n4. Разделить первое на второе(/)\r\n5. Возвести в степень N первое число(pow)\r\n6. Найти квадратный корень из числа(sqrt)\r\n7. Найти 1 процент от числа(%)\r\n8. Найти факториал из числа(!)\r\n9. Выйти из программы(q)");
            string oper = Console.ReadLine();
            if (oper == "9") 
                return;
            Console.WriteLine("Введите первое число");
            var a = Convert.ToDouble(Console.ReadLine());
            switch (oper)
            {
                case "1":
                    Console.WriteLine("Введите второе число");
                    b = Convert.ToDouble(Console.ReadLine());
                    answer = a + b;
                    Console.WriteLine("Вывод: " + answer);
                    break;
                case "2":
                    Console.WriteLine("Введите второе число");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Вывод: " + (a - b));
                    break;
                case "3":
                    Console.WriteLine("Введите второе число");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Вывод: " + (a * b));
                    break;
                case "4":
                    Console.WriteLine("Введите второе число");
                    b = Convert.ToDouble(Console.ReadLine());
                    if(b != 0)
                        Console.WriteLine("Вывод: " + (a / b));
                    else
                        Console.WriteLine("Делить на ноль нельзя!");
                    break;
                case "5":
                    Console.WriteLine("Введите степень");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Вывод: " + Math.Pow(a, b));
                    break;
                case "6":
                    Console.WriteLine("Вывод: " + Math.Sqrt(a));
                    break;
                case "7":
                    Console.WriteLine("Вывод: " + 0.01 * a);
                    break;
                case "8":
                    static long factorial(long temp1)
                    {
                        if (temp1 == 1 || temp1 == 0)
                            return 1;
                        else
                        {
                            long r = 1;
                            for (int i = 1; i <= temp1; i++)
                            {
                                r *= i;
                            }
                            return r;
                        }
                    }
                    aa = Convert.ToInt64(a);
                    Console.WriteLine("Вывод: " + factorial(aa));
                    break;
                default:
                    Console.WriteLine("Неправильный ответ!");
                    break;
            }
        }
    }
}