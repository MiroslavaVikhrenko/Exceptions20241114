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
            string choice = null;
            try
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. cat\n2. dog\n3. bird\n4. fish");
                choice = Console.ReadLine();
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
                if (choice is null)
                {
                    DisplayMenu();
                }
                else
                {
                    if (choice == "cat" || choice == "dog" || choice == "bird" || choice == "fish")
                    {
                        Console.Clear();
                        Console.WriteLine($"You chose {choice}");
                        Console.WriteLine("Mission completed!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrected value entered, please try again.");
                        DisplayMenu();
                    }
                    
                }
            }
        }
    }
}
