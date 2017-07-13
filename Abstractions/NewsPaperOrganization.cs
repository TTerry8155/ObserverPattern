using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public abstract class NewsPaperOrganization
    {
        private List<INewsPaperSubscriber> _subscribers = new List<INewsPaperSubscriber>();

        public string OrganizationName { get; set; }

        public double MonthlySubscriptionCost { get; set; }

        public NewsPaperOrganization(string name, double monthlySubscriptionCost)
        {
            OrganizationName = name;
            MonthlySubscriptionCost = monthlySubscriptionCost;
        }

        public void AttachSubscriber(INewsPaperSubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void DetachSubscriber(INewsPaperSubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update();
            }
        }
    }
}
