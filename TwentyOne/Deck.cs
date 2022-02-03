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

        public void Shuffle(int times = 1) //public (accessible anywhere), static (dont want to create object program before calling), deck (type of data returning),
                                                                                    //shuffle (name of function), parameter of type 'Deck' and variable name 'deck' when you want to refer to it inside method
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random(); //object 'random' has some methods associated with it

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                this.Cards = TempList;
            }
        }
    }
}
