using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        //the more generic you make your code the more features you can add to it later

        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); //abstract method can only exist inside abstract class, has no implementation
                                     //it states that any class inheriting this class must impliment this method

        public virtual void ListPlayers() //virtual method inside abstract class, means this method gets inherited
                                          //by inheriting class but it has ability to override it
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }

    }
}
