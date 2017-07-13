using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface INewsPaperSubscriber
    {
        void PaymentUpdate(double monthlyPayment, string newsPaperName, 
                    DateTime deliveryDate, DateTime chargeCostDate);
    }
}
