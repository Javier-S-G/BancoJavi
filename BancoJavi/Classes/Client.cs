using System;
using System.Collections.Generic;
using System.Text;

namespace BancoJavi.Classes
{
    class Client : People //Cliente hereda de People para usar sus atributos
    {
        public BankAccount cuenta { get; protected set; }
        public User usuario { get; protected set; }
        public Client(string name, string lastName, string address, 
            string phoneNumber, BankAccount cuenta, User usuario)
        {
            this.name = name;
            this.lastName = lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.cuenta = cuenta;
            this.usuario = usuario;
        }
    }
}
