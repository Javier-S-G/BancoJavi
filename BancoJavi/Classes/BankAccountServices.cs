using BancoJavi.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoJavi.Classes
{
    /// <summary>
    /// Servicios de la cuenta bancaria, como transferir dinero y mandar SMS
    /// </summary>
    class BankAccountServices : IWireTransferable, ISendSms
    {
        
        public void ISendSms()
        {
            throw new NotImplementedException();
        }

        public void IWireTransferable()
        {
            if (cliente1 money > cantidadQuieroTransferir)
            {
                cliente2 sendMoney;
                cliente1 sendSms
                cliente2 sendSms
            }else
            {
                return "No hay dinero suficiente." + moneyActual
            }
            throw new NotImplementedException();
        }

    }

}
