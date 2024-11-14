namespace task3
{
    //Организовать ввод 10-ти целочисленных значений в массив.
    //В случае ввода неверного значения, выводить сообщение об ошибке и продолжать ввод значений,
    //не пропуская индекса. В задаче использовать try-catch и рекурсию (циклические конструкции использовать нельзя).
    //По окончанию ввода – вывести все значения массива на экран.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            AssignValue(array, 0);

            Console.WriteLine("Array:\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]} ");
            }
            Console.ReadKey();
        }

        static void AssignValue(int[] array, int count)
        {
            int[] newarray = array;

            int newcount = count;

            try
            {
                Console.WriteLine("Enter a value:");
                int n = Convert.ToInt32(Console.ReadLine());
                array[newcount] = n;
                newcount++;
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (newcount <= newarray.Length - 1)
                {
                    AssignValue(newarray, newcount);
                }
            }

        }
    }
}
