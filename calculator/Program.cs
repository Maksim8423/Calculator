using System.Runtime.InteropServices;

namespace calculator
{

    class Program
    {
        static void Main(string[] args)
        {
            
            double a,b;
            double choose;
            Console.WriteLine("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите действие:" +
                "[0]Выход " +
                "[1] Сложение " +
                "[2] Вычитание " +
                "[3] Умножение " +
                "[4] Деление");
            choose = Convert.ToInt32(Console.ReadLine());
            Calculator calc = new Calculator(a,b);
            switch (choose)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine($"Результат: {calc.Plus()}");  break;
                case 2:
                    Console.WriteLine($"Результат: {calc.Minus()}"); break;
                case 3:
                    Console.WriteLine($"Результат: {calc.Multiplication()}"); break;
                case 4:
                    Console.WriteLine($"Результат: {calc.Division()}"); break;
            }
        }
    }
}