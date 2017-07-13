using ObserverPattern.Models;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mimic Simple Subscribers
            NewsPaperSubscriber TomHanks = new NewsPaperSubscriber("Tom Hanks");
            NewsPaperSubscriber JohnnyBravo = new NewsPaperSubscriber("Johnny Bravo");
            NewsPaperSubscriber TheHamburglar = new NewsPaperSubscriber("Hamburglar");
            NewsPaperSubscriber JackThePumpkinKing = new NewsPaperSubscriber("Jack The Pumpkin King");

            //Mimic Simple News Organization
            int Month = DateTime.Now.Month;
            int Year = DateTime.Now.Year;

            DateTime FirstOfTheMonth = new DateTime(Year, Month, 1);
            DateTime FifteenthOfTheMonth = new DateTime(Year, Month, 15);

            NewsPaperOrganization newYorkTimes = new NewsPaperOrganization("New York Times", 8.00, FifteenthOfTheMonth, FirstOfTheMonth);
            NewsPaperOrganization chicagoTribune = new NewsPaperOrganization("Chicago Tribune", 6.00, FifteenthOfTheMonth, FirstOfTheMonth);

            //Mimic Adding subscribers
            newYorkTimes.AttachSubscriber(TomHanks);
            newYorkTimes.AttachSubscriber(JohnnyBravo);

            chicagoTribune.AttachSubscriber(TheHamburglar);
            chicagoTribune.AttachSubscriber(JackThePumpkinKing);

            //Simulate First of the Month
            newYorkTimes.PaymentNotification();
            chicagoTribune.PaymentNotification();

            //Simulate Unsatisfied Customer
            newYorkTimes.DetachSubscriber(JohnnyBravo);
            chicagoTribune.DetachSubscriber(JackThePumpkinKing);

            //Pause between Months
            Console.WriteLine("The first month has passed, you had some unsatisfied customers. \n Press any key to forward thru the next month and see who gets notified now!");
            //Wait User
            Console.ReadKey();

            //Simulate First of the Next Month After Subscribers Leave
            newYorkTimes.PaymentNotification();
            chicagoTribune.PaymentNotification();

            //Wait User
            Console.ReadKey();
        }
    }
}