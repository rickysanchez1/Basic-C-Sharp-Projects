using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.twentyone;


namespace twentyone
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Guid identifier = Guid.NewGuid();

            // Welcome new player 
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name." + casinoName);
            // create var for new player
            string playerName = Console.ReadLine();
            // call to print out a log of exceptions
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadException();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " ");
                    Console.Write(exception.ExceptionType + " ");
                    Console.Write(exception.TimeStamp + " ");
                    Console.WriteLine();
                }
                Console.ReadLine();
                return;
            }


            // Setting value to false so while statement hits.
            bool validAnswer = false;
            int bank = 0;
            // Validating input are entered as digits
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                {
                    validAnswer = int.TryParse(Console.ReadLine(), out bank);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
                }
            }

            // {0} is a variable placeholder for playerName
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            // if player is actively playing
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                // Create new player using constructor in player class to set the properties
                Player player = new Player(playerName, bank);
                // Created Guid for new player
                player.Id = Guid.NewGuid();
                
                using (StreamWriter file = new StreamWriter(@"C:\Users\sinp3\OneDrive\Documents\GitHub\Basic-C-Sharp-Projects\twentyone\log.txt", true))
                {
                    // Logging player id
                    file.WriteLine(player.Id);
                }
                // create new instance of twentyonegame
                Game game = new TwentyOneGame();
                // Add current player to twentyonegame
                game += player;
                // player is currently playing
                player.isActivelyPlaying = true;
                // while player is actively playing, play game
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
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your system administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");

            
            

           
          

            Console.ReadLine();
        }
        // Creating method to access db
        private static void UpdateDbWithException(Exception ex)
        {
            // Creating string variable to access the database
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            // Creating string var to edit table
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES 
                                (@ExceptionType, @ExceptionMessage, @TimeStamp)";
            // open and closing the sql connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadException()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            // Asking for everything in the tables
            string queryString = @"SELECT Id, ExceptionType, ExceptionMessage, TimeStamp from Exceptions";
            // Creating List to return
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();
            // Open connection by making a new Sqlconnection object and pass in connectionString
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // creating new sqlcommand object and pasing queryString and connection
                SqlCommand command = new SqlCommand(queryString, connection);
                // Open connection
                connection.Open();
                // creating SqlDataReader object. Executing reader and assigning it the reader object
                SqlDataReader reader = command.ExecuteReader();

                // Loop through each record and create new ExceptionEntity object
                while (reader.Read())
                {
                    // Map the information back to our object. convert Id to int/string/DateTime for each object
                    ExceptionEntity exception = new ExceptionEntity();
                    // the reader object maps to the column field.
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    // Add to to list
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            // return exception entites
            return Exceptions;

        }
    }

}
