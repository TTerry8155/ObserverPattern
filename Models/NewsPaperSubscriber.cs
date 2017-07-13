using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Models
{
    public class NewsPaperSubscriber : INewsPaperSubscriber
    {
        private string _fullName;

        public NewsPaperSubscriber(string fullName)
        {
            _fullName = fullName;
        }

        public void PaymentUpdate(double MonthlyPayment, string NewsPaperName, DateTime deliveryDate, DateTime chargeCostDate)
        {
            string NotificationStatement = "Thanks {0}! We have received your subscription fee of {1} on {2}, and you will recieve a copy of {3} on {4}";
            Console.WriteLine(NotificationStatement, 
                             _fullName, MonthlyPayment, chargeCostDate, NewsPaperName, deliveryDate);
        }
    }
}
