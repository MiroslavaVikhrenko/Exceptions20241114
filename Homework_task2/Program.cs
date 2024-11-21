using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Homework_task2
{
    //Создайте класс «Money», предназначенный для хранения денежной суммы (в гривнах и копейках).
    //Для класса реализуйте перегрузку операторов:

// + (сложение денежных сумм) 
//– (вычитание сумм) 
/// (деление суммы на целое число)
//* (умножение суммы на целое число)
//++ (сумма увеличивается на 1 копейку)
//-- (сумма уменьшается на 1 копейку), <, >, ==, !=.


//Класс не может содержать отрицательную сумму.В случае если при исполнении какой-либо операции
//получается отрицательная сумма денег, то класс генерирует исключительную ситуацию «Банкрот».

//Создайте консольное меню, для взаимод
    internal class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money(150);
            Console.WriteLine(m.MoneyInHryvnia);

            Money m2 = new Money(2.5);
            Console.WriteLine(m2.MoneyInKopiyka);

            Money m3 = m + m2;

            while (m3.MoneyInKopiyka >= 0)
            {
                Console.WriteLine($"Your current balance is {m3.MoneyInKopiyka} kopiyka\nEnter number of kop you want to spend:");
                int spend = Convert.ToInt32(Console.ReadLine());
                m3 = m3 - spend;
                Console.WriteLine($"Your balance is {m3.MoneyInKopiyka} kopyika");
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }

    public class Money
    {
        public double MoneyInHryvnia { get; set; }
        public int MoneyInKopiyka { get; set; }

        public Money(int moneyInKopiyka)
        {
            MoneyInKopiyka = moneyInKopiyka;
            MoneyInHryvnia = KopiykaToHryvna(moneyInKopiyka);
        }

        public Money(double moneyInHryvnia)
        {
            MoneyInHryvnia=moneyInHryvnia;
            MoneyInKopiyka = HryvnaToKopiyka(moneyInHryvnia);
        }

        private double KopiykaToHryvna(int kopiyka)
        {
            return ((double)kopiyka / 100);
        }

        private int HryvnaToKopiyka(double hryvna)
        {
            return Convert.ToInt32(hryvna * 100);
        }

        private bool CheckBalance(double balance)
        {
            if (balance < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckBalance(int balance)
        {
            if (balance < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Money operator +(Money m1, Money m2)
        {
            return new Money (m1.MoneyInKopiyka + m2.MoneyInKopiyka);
        }
        public static Money operator -(Money m1, Money m2)
        {
            if ((m1.MoneyInKopiyka - m2.MoneyInKopiyka) < 0)
            {
                Console.WriteLine("Bankrupt alert!");
                throw new Exception("Value cannot be below 0");
            }
            else
            {
                return new Money(m1.MoneyInKopiyka - m2.MoneyInKopiyka);
            }
        }

        public static Money operator +(Money m1, int number)
        {
            return new Money(m1.MoneyInKopiyka + number);
        }
        public static Money operator -(Money m1, int number)
        {
            if ((m1.MoneyInKopiyka - number) < 0)
            {
                Console.WriteLine("Bankrupt alert!");
                throw new Exception("Value cannot be below 0");
            }
            else
            {
                return new Money(m1.MoneyInKopiyka - number);
            }
        }

        public static Money operator *(Money m1, int number)
        {
            return new Money(m1.MoneyInKopiyka * number);
        }
        public static Money operator /(Money m1, int number)
        {
            return new Money(m1.MoneyInKopiyka / number);
        }

        public static Money operator ++(Money m1)
        {
            m1.MoneyInKopiyka += 1;
            return m1;
        }

        public static Money operator --(Money m1)
        {
            if ((m1.MoneyInKopiyka -= 1) < 0)
            {
                Console.WriteLine("Bankrupt alert!");
                throw new Exception("Value cannot be below 0");
            }
            else
            {
                m1.MoneyInKopiyka -= 1;
                return m1;
            }       
        }

        public static bool operator >(Money m1, Money m2)
        {
            return m1.MoneyInKopiyka > m2.MoneyInKopiyka;
        }
        public static bool operator <(Money m1, Money m2)
        {
            return m1.MoneyInKopiyka < m2.MoneyInKopiyka;
        }

    }
}
