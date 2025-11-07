using System.Text;

namespace Telecommunication01
{
    public enum callType
    {
        Sity,
        Mobile
    }

    public struct Customer
    {
        public string name;
        public double balance;
        public callType callTypeCust;
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // имя и баланс счета
            string name = "Иван Петров";
            double balance = 100;

            Customer cust;
            cust.name = "Другой Иван Петров";
            cust.balance = 250;
            cust.callTypeCust = callType.Sity;

            // действие клиента
           // char callType = 'Г';
           // callType callTypeCust = callType.Sity;
            int minutes = 1;

            // изменение баланса в зависимости от типа звонка и длительности разговора
            balance -= minutes * 5;
            cust.balance -= minutes * 8;

            // вывод результата
            Console.WriteLine("Клиент: {0} имеет баланс: {1}", name, balance);

            // Выполняется пополнение баланса 
            double amountPaid = 10;
            balance += amountPaid;
            cust.balance += amountPaid;
            
            // вывод результата
            Console.WriteLine($"Клиент: {name} имеет баланс: {balance}");

            Console.WriteLine("Hello, telecommunication!");

            // вывод результата клиента как объекта
            Console.WriteLine($"Клиент: {cust.name} имеет баланс: {cust.balance}");
        }
    }
}
