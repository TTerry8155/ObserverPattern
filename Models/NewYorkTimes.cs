using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Models
{
    public class NewYorkTimes : NewsPaperOrganization
    {
        public NewYorkTimes(string name, double monthlySubscriptionCost, DateTime deliveryDate, DateTime chargeCostDate) 
            : base(name, monthlySubscriptionCost, deliveryDate, chargeCostDate)
        {
           
        }
    }
}
