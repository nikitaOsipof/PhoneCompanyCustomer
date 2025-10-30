using System.Text;

namespace Telecommunication01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // имя и баланс счета
            string name = "Иван Петров";
            double balance = 100;

            // действие клиента
            char callType = 'Г';
            int minutes = 1;

            // изменение баланса в зависимости от типа звонка и длительности разговора
            balance -= minutes * 5;

            // вывод результата
            Console.WriteLine("Клиент: {0} имеет баланс: {1}", name, balance);

            // Выполняется пополнение баланса 
            double amountPaid = 10;
            balance += amountPaid;
            
            // вывод результата
            Console.WriteLine($"Клиент: {name} имеет баланс: {balance}");

            Console.WriteLine("Hello, telecommunication!");
        }
    }
}
