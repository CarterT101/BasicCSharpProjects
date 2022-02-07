using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck() //constructor goes on top, assigns default values, constructor method name always same as class
        {
            Cards = new List<Card>(); //constructor, called as soon as object is created

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i; //casting to face, i since i is an integer
                    card.Suit = (Suit)j; //casting to suit, j
                    Cards.Add(card); //adding card to Cards list
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
