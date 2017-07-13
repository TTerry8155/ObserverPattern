using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Models
{
    public class NewsPaperOrganization : INewsPaperOrganization
    {
        public NewsPaperOrganization(string newsPaperName, double monthlySubscriptionCost, DateTime deliveryDate, DateTime chargeCostDate) 
                                    : base(newsPaperName, monthlySubscriptionCost, deliveryDate, chargeCostDate)
        {

        }

    }
}
