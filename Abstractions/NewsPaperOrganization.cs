using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public abstract class NewsPaperOrganization
    {
        private List<INewsPaperSubscriber> _subscribers = new List<INewsPaperSubscriber>();

        private string _newsPaperName;

        private double _monthlySubscriptionCost;

        private DateTime _deliveryDate;

        public NewsPaperOrganization(string name, double monthlySubscriptionCost, DateTime deliveryDate)
        {
            _newsPaperName = name;
            _monthlySubscriptionCost = monthlySubscriptionCost;
            _deliveryDate = deliveryDate;
        }

        public string GetNewsPaperName()
        {
            return _newsPaperName;
        }

        public double GetMonthlySubscriptionCost()
        {
            return _monthlySubscriptionCost;
        }

        public DateTime GetDeliveryDate()
        {
            return _deliveryDate;
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
                subscriber.Update(GetMonthlySubscriptionCost(), GetNewsPaperName(), GetDeliveryDate());
            }

            Console.WriteLine("Subscribers Notified!");
        }
    }
}
