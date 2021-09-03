using System;
using System.Collections.Generic;
using System.Text;

namespace BancoJavi.Interfaces
{
    /// <summary>
    /// Servicio de email, envío, se implementa en BankAccountServices
    /// </summary>
    interface IEmailServices
    {
        public void sendEmail();
    }
}
