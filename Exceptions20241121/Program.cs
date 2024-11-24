namespace Exceptions20241121
{
    //Создайте метод, принимающий консольный ввод. В случае неправильного ввода – выбрасывать ошибку. Ошибку обрабатывать в методе Main.
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EnterMessage();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("main finally");
            }

            Console.ReadLine();
        }

        static void EnterMessage()
        {
            Console.WriteLine("Enter a number");
            
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("method finally");
            }
        }
    }
}
