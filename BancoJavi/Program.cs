using BancoJavi.Classes;
using System;

namespace BancoJavi
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("ES789" , 1500);
            BankAccount acc2 = new BankAccount("ES125", 850);

            User usuario1 = new User("1234y", "pass");
            User usuario2 = new User("5678z", "passworita");

            Client c1 = new Client("Javi", "Sanudo", "Jose Oto", "12345Y", acc1, usuario1);
            Client c2 = new Client("Pedro", "Pochuelo", "Al Lao Grancasa", "54321Z", acc2, usuario2);

            Console.WriteLine("El cliente " + c1.name + " tiene " + c1.cuenta.money + " euros.");
            Console.WriteLine("El cliente " + c2.name + " tiene " + c2.cuenta.money + " euros.");

            ClientServices Service1 = new ClientServices(1);

            Service1.sendEmail("Javi", "javi@vhot.com");
        }
    }
}
