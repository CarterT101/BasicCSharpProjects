using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card
    {
        public Suit Suit { get; set; } //the card class has a property of data type 'string' called 'Suit
        //and you can get or set this property, and public means it is accessible to other parts of the program
        public Face Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    //public Card() //constructor (method), if not assigned, these are the default values
    //{
    //    Suit = "Spades";
    //    Face = "Two";
    //}

}
