using System.Xml.Serialization;

namespace Homework_task1
{
    //Создать пользовательское меню на 4 пункта
    //(вывод меню – выбор пункта – вывод сообщения о выбранном пункте).
    //Зациклить. Чтобы пользователь в вашей программе не делал,
    //не дайте программе выбить ошибку
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
            Console.ReadKey();
        }

        static void DisplayMenu()
        {
            Console.Clear();
            int choice = 0;
            try
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1\n2\n3\n4");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            finally
            {
                    if (choice == 1 || choice == 2 || choice == 3 || choice == 4)
                    {
                        Console.Clear();
                        Console.WriteLine($"You chose {choice}");
                        Console.WriteLine("Mission completed!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrected value entered, please try again.");
                        Console.ReadLine();
                        DisplayMenu();
                    }                   
            }
        }
    }
}
