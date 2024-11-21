namespace Homework_task3
{
    internal class Program
    {
        //Есть массив целых чисел размером 10. С клавиатуры вводится два числа - порядковые номера
        //элементов массива, которые необходимо суммировать. Например, если ввели 3 и 5 -
        //суммируются 3-й и 5-й элементы. Предусмотрите все случаи, когда были введены не числа,
        //и когда одно из чисел, или оба - больше размера массива.
        static void Main(string[] args)
        {
            uint[] array = { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            Console.WriteLine("Array:");
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write($"{array[i]} | ");
                }
            }

            Console.WriteLine();

            try
            {
                Console.WriteLine("\nEnter first element (0-9):");
                uint n1 = Convert.ToUInt32(Console.ReadLine());

                if (n1 > array.Length - 1)
                {
                    Console.WriteLine("Value cannot be more than 9");
                }
                else
                {
                    Console.WriteLine("Enter second element (0-9):");
                    uint n2 = Convert.ToUInt32(Console.ReadLine());
                    if (n2 > array.Length - 1)
                    {
                        Console.WriteLine("Value cannot be more than 9");
                    }
                    else
                    {
                        Console.WriteLine($"Element {n1} is {array[n1 - 1]}\nElement {n2} is {array[n2 - 1]}\nsum is {array[n1 - 1] + array[n2 - 1]}");
                    }
                }
            }
            catch(FormatException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
