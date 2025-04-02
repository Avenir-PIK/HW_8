namespace _8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                ValidateAge(age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nПроверка возраста завершена");
            }
            Console.WriteLine("\nPress any key to contunue");
            Console.ReadKey();
        }
        static void ValidateAge(int x)
        {
            if (x < 0) throw new ArgumentException("\nВозраст не может быть отрицательным");
            if (x > 150) throw new ArgumentException("\nСлишком большой возраст");
        }
    }
}
