using BancoJavi.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoJavi.Classes
{
    /// <summary>
    /// Servicio de enviar Email al Cliente cuando se registre por primera vez
    /// </summary>
    class ClientServices : IEmailServices
    {
        int IdService;

        public ClientServices(int idService)
        {
            this.IdService = idService;
        }
        public String sendEmail(string nombreUser, string email)
        {
            return "Email enviado a " + nombreUser + " con el E-mail " + email;

        }

        public void sendEmail()
        {
            throw new NotImplementedException();
        }
    }
}
