namespace task4
{
    //Создать метод, который принимает консольный ввод в переменную типа decimal.
    //В случае неверного ввода – метод возвращает соответствующую ошибку. Обработать ошибку в методе Main.
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                decimal d = GetDecimal();
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }

            Console.ReadKey();
        }

        static decimal GetDecimal()
        {
            Console.WriteLine("Enter a decimal value:");
            decimal d = Convert.ToDecimal(Console.ReadLine());
            return d;
        }
    }
}
