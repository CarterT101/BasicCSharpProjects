using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck() //constructor goes on top, assigns default values, constructor method name always same as class
        {

            Cards = new List<Card>(); //constructor, called as soon as object is creaded,
                                      //instantiate its property 'Cards' as an empty list of 'Cards'
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits) //nested foreach loop
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);


                }
            }

        }


        public List<Card> Cards { get; set; }
    }
}
