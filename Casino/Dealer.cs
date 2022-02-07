using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand) //adding card to hand that is passed in
        {
            Hand.Add(Deck.Cards.First()); //Hand is a list (built in method 'Add()'), 'Deck' is composed of cards,
                                          //First() is a method, available to a list that takes first item from that list
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\hoove\Documents\log.txt", true)) //true tells it to append stuff to file
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);

            }
            Deck.Cards.RemoveAt(0); //RemoveAt() built in list method that removes at the index 
            
        }
    }
}
