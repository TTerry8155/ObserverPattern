using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface INewsPaperSubscriber
    {
        void Update(double monthlyPayment, string newsPaperName, DateTime deliveryDate);
    }
}
