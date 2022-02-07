using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() //naming convention for private starts with '_'
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand) //passing in hand
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            int[] result = new int[aceCount + 1]; //array
            int value = Hand.Sum(x => _cardValues[x.Face]); //takes each item and looks it up in card values dictionary table and then sum it
            result[0] = value; //first entry in int array
            if (result.Length == 1) return result;
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10); //value is lowest possible value, to create int array of possible values, for each ace we make a separate value 
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value  < 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand) //find value that is less than 22 but also highest value
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max(); //this does exactly what previous comment says
            int dealerScore = dealerResults.Where(x => x < 22).Max();
            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return true;
            else return null;
        }

    }
}
