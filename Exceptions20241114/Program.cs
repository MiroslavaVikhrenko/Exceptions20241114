namespace Exceptions20241114
{
    internal class Program
    {
        //Используя конструкцию try избежать переполнения диапазона значений, при присваивании значения переменной.
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter x:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y:");
                int y = Convert.ToInt32(Console.ReadLine());
                int c = x / y;
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.ReadLine();
        }
    }
}
