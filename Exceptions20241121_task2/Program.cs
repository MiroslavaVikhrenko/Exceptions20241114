namespace Exceptions20241121_task2
{
    //Описать класс «Phone»,для добавления телефонов.
    //При добавлении телефона, принимать поля: марка, модель, цена, год, количество. 
    //В случае ввода некорректных данных, выбросить исключение и передать его в метод Main.
    //Данные могут быть не корректными в случае: цена и количество меньше нуля, поле модель и марка пустые, год ниже 1960 и старше текущего.
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Phone p = new Phone()
                {
                    Brand = "",
                    Model = "m",
                    Price = 100.0m,
                    Quantity = 1,
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("main finally");
            }

            Console.ReadKey();
        }
    }

    public class Phone
    {
        private string brand;
        private string model;
        private decimal price;
        private DateTime year;
        private int quantity;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (brand.Length == 0)
                {                  
                    throw new Exception("brand cannot be empty");
                }
                else
                {
                    brand = value;
                }
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (model.Length == 0)
                {
                    throw new Exception("model cannot be empty");
                }
                else
                {
                    model = value;
                }
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (price < 0)
                {
                    throw new Exception("price cannot be below zero");
                }
                else
                {
                    price = value;
                }
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity < 0)
                {
                    throw new Exception("quantity cannot be below zero");
                }
                else
                {
                    quantity = value;
                }
            }
        }
    }
}
