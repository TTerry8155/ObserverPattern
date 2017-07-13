using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public abstract class NewsPaperOrganization
    {
        private List<INewsPaperSubscriber> _subscribers = new List<INewsPaperSubscriber>();

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
