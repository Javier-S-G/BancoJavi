using System;
using System.Collections.Generic;
using System.Text;

namespace BancoJavi.Classes
{
    class Employee : People //Cliente hereda de User para usar sus atributos
    {

        public Employee(string name, string lastName, string address, 
            string phoneNumber, string iban)
        {
            this.name = name;
            this.lastName = lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }
    }
}
