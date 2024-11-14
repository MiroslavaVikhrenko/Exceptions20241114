namespace task2
{
    internal class Program
    {
        //Организовать ввод 10-ти целочисленных значений в массив. В случае ввода неверного значения,
        //выводить сообщение об ошибке и продолжать ввод значений,
        //не пропуская индекса. В задаче использовать try-catch или условную конструкцию.
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int count = -1;
            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    Console.WriteLine("Please enter a value: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                    count++;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (count != i)
                    {
                        i--;
                    }
                }
            }


            for (int i = 0; i < array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}
