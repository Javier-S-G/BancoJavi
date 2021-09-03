using BancoJavi.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoJavi.Classes
{
    /// <summary>
    /// Creo la clase BankAccount y le implemento una interfaz con la acción
    /// de transferir dinero
    /// </summary>
    public class BankAccount
    {
        public string iban;
        public decimal money;

        public BankAccount(string iban, decimal money)
        {
            this.iban = iban;
            this.money = money;
        }

    }
}
