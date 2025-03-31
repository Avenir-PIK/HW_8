using System.Reflection.Metadata;

namespace _8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, opreation;
            double result;
            string znak = string.Empty;
            try
            {
                Console.WriteLine("Введите первое целое число: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе целое число: ");
                b = Convert.ToInt32(Console.ReadLine());
                do
                {
                    Console.WriteLine("Введите код операции : \n1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное");
                    opreation = Convert.ToInt32(Console.ReadLine());
                }
                while (opreation<=1 || opreation>=5);

                switch (opreation)
                {
                    case 1:
                        result = a + b;
                        znak = "+";
                        break;
                    case 2:
                        result = a - b;
                        znak = "-";
                        break;
                    case 3:
                        result = a * b;
                        znak = "*";
                        break;
                    case 4: //конвертил в дабл, но как ловить исключение при делении на ноль даблов (NaN), так что оставил частное от деления
                        result = a / b;
                        znak = "/";
                        break;
                    default:
                        result = 0;
                        break;
                }
                Console.WriteLine($"{a}{znak}{b}={result:N2}");
                Console.WriteLine("\nPress any key to quit..");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода!\nДопустим ввод только целых чисел!");
                Console.WriteLine("\nPress any key to quit..");
                Console.ReadKey();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nНа текущем уровне развития цивилизации\nДеление на ноль невозможно =(");
                Console.WriteLine("\nPress any key to quit..");
                Console.ReadKey();
            }
        }
    }
}
