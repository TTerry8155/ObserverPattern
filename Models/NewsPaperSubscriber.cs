using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Models
{
    public class NewsPaperSubscriber : INewsPaperSubscriber
    {
        private string _name;

        public void Update(double MonthlyPayment, string NewsPaperName)
        {
            Console.WriteLine("We have received your subscription fee of {0}, and you will recieve a copy of {2} on the 15th of every month");
        }
    }
}
