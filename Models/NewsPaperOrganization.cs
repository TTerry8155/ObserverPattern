using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Models
{
    public class NewsPaperOrganization : INewsPaperOrganization
    {
        private string _organizationName;

        public NewsPaperOrganization(string newsPaperName, double monthlySubscriptionCost, 
                                    DateTime deliveryDate, DateTime chargeCostDate, string organizationName) 
                                    : base(newsPaperName, monthlySubscriptionCost, deliveryDate, chargeCostDate)
        {
            _organizationName = organizationName;
        }

    }
}
