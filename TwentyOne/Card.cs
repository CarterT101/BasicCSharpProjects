using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card() //constructor (method), if not assigned, these are the default values
        {
            Suit = "Spades";
            Face = "Two";
        }

        public string Suit { get; set; } //the card class has a property of data type 'string' called 'Suit
        //and you can get or set this property, and public means it is accessible to other parts of the program

        public string Face { get; set; }






    }
}
