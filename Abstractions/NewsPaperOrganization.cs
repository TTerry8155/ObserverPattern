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

        private DateTime _chargeCostDate;

        public NewsPaperOrganization(string name, double monthlySubscriptionCost, DateTime deliveryDate, DateTime chargeCostDate)
        {
            _newsPaperName = name;
            _monthlySubscriptionCost = monthlySubscriptionCost;
            _deliveryDate = deliveryDate;
            _chargeCostDate = chargeCostDate;
        }

        public void AttachSubscriber(INewsPaperSubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void DetachSubscriber(INewsPaperSubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        private void PaymentNotification()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.PaymentUpdate(_monthlySubscriptionCost, _newsPaperName, _deliveryDate, _chargeCostDate);
            }

            Console.WriteLine("Subscribers Notified!");
        }
    }
}
