using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //File IO TESTING

            //string text = "Here is some text."; //text variable
            //File.WriteAllText(@"C:\Users\hoove\Documents\logs.txt", text); //creating file, or adding to file there and adding the text from variable
            //string text = File.ReadAllText(@"C:\Users\hoove\Documents\logs.txt"); //reads created text

            //DATETIME TESTING

            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth; // timespan gives time in days


            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();

                }
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("and how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank); //tryparse casts from string to int, indicates whether it succeeded, if it doesn't succeed, bank = 0
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\hoove\Documents\players.txt", true))
                {
                    file.WriteLine(playerName + " " + player.Id); //creating unique id
                }
                Game game = new TwentyOneGame(); //polymorphism
                game += player; //adding player to the game
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.Read();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error occured, contact system administrator.");
                        UpdateDbWithException(ex);
                        Console.Read();
                        return;
                    }

                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Bye for now");
            Console.Read();









            






            //EXAMPLES, TESTING, PRACTICE, ETC 



            //Deck deck = new Deck(); //deck object that has property cards should have 52 cards

            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);



            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Carter", "Evan", "Kenn" };
            //game.ListPlayers(); //calling the superclass method 'game'
            //                    //superclass meaning 'a method that has been inherited from another class'

            //List<Game> games = new List<Game>();
            ////Game game = new TwentyOneGame(); //polymorphism
            //TwentyOneGame game = new TwentyOneGame(); 
            //games.Add(game);


            //TwentyOneGame game = new TwentyOneGame(); //testing virtual method
            //game.Players = new List<string>() { "Jesse", "Bill", "Evan" };
            //game.ListPlayers();


            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Carter"; //setting variable Name = Carter
            //game = game + player; //in a way, this is our method
            //game -= player; //same way as writing the operator above just shorter

            //Card card1 = new Card();
            //Card card2 = card1; //sets card2 equal to card1 //we basically just gave card2 the address to card1 for memory
            ////before Card was class, but now that card class is struct, card1 is its on instance not relating to card2. 
            //card1.Face = Face.Eight; //sets card1 to eight
            //card2.Face = Face.King;  //overwrites card1 with card2 face king

            //Console.WriteLine(card1.Face);


            //int counter = 0;
            //foreach (Card card in deck.Cards)
            //{
            //    if (card.Face == Face.Ace)
            //    {
            //        counter++;
            //    }
            //} //this can be translated into lambda function below



            //int count = deck.Cards.Count(x => x.Face == Face.Ace); //Cards is a list, Count() is a lambda function
            ////this is counting how many Ace in it and assigning it to variable int count
            ////x represents each element in list
            //// '=>' basically means evaluate this on each item
            //Console.WriteLine(count);



            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); //where the face = king and map it to new list
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}



            //List<int> numberList = new List<int>() { 1, 2, 3, 5, 6, 8, 123, 7 };
            //int sum = numberList.Sum();
            //Console.WriteLine(sum);


            //Console.Read();

        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                        TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES 
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)"; //the @ in front of table headers is a placeholder for variables so users can't mess up Db
                                                                                      //ADO.NET is helping us
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar); //one parameter which has name @ExceptionType, and this datatype VarChar, helps with sql injection
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString(); //.Value is a property
                command.Parameters["@ExceptioNMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery(); //a query would be a select statement where you are querying database, but this is a nonquery because insert statement
                connection.Close();

            }

        }
        private static List<ExceptionEntity> ReadExceptions() //will call and query the database and get all exceptions and display them
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                        TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp from Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity(); //object
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }

    }
}
