using log4net;
using log4net.Config;
using System.Reflection;

namespace Exceptions20241123_task1
{
    //Создайте класс «BurgerKing». Опишите необходимый функционал, для работы заведения.
    //В случае возникновения ошибки при валидации свойств или в методах при работе с классом,
    //используйте оператор throw. Все ошибки обрабатывайте в методе Main и записывайте с помощью log4net в файл.
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            try
            {
                BurgerKing bk = new BurgerKing { Name = "Bk1", Staff = -1 };
            }
            catch (OverflowException ex)
            {
                //string value = $"{DateTime.Now.ToShortDateString()} in {DateTime.Now.ToShortTimeString()}\n{ex.Message}\n{ex.StackTrace}\n{ex.InnerException}\n\n";
                //File.AppendAllText("log.txt", value);

                var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
                XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
                log.Error(ex);
            }
            Console.ReadKey();
        }
    }

    public class BurgerKing
    {
        public string Name { get; set; }
        private int staff;

        public int Staff
        {
            get { return staff; }
            set
            { 
                if (value < 0)
                {
                    throw new OverflowException("staff cannot be below zero");
                }
                else
                {
                    staff = value;
                }
            }
        }
    }
}
