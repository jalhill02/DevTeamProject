using DevTeamsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamConsole
{
    class ProgramUI
    {
        // set up fields 


        // the method that starts the DevTeams application
        public void Run()
        {
            Menu();

        }

        // menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                Console.WriteLine("Select a menu option\n" +
                    "1. Create new developer\n" +
                    "2. Create new devteam\n" +
                    "3. Check access to Pluralsight\n" +
                    "4. validate unique devID\n" +
                    "5. Exit");

                //Get the user's input
                string input = Console.ReadLine();

                // Evaluate the user's input and act accordingly
                switch (input)
                {

                    case "1":
                        //Create new developer
                        CreateNewDeveloper();
                        break;

                    case "2":
                        //Create new DevTeam
                        CreateNewDevTeam();
                        break;
                    case "3":
                        // Check access to pluralsight
                        ValidatePluralsightAccess();
                        break;
                    case "4":
                        // Validate DevID
                        CreateNewDevID();
                        break;
                    case "5":
                        // Exit
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

        }
        // Create a new developer
        private void CreateNewDeveloper()
        {
            Developer newDeeloper = new Developer();
            // DevName
            Console.WriteLine("Enter the name of the new develoer.");
            newDeeloper.DevName = Console.ReadLine();

            //DevID
            Console.WriteLine("Enter the name of the unique DevID.");
            newDeeloper.DevID = Console.ReadLine();

            //// Access to pluralsight
            //Console.WriteLine("Has the developer been give pluralsight access? y/n");
            //string pluralsightAccess = Console.ReadLine().ToLower();
            //if(pluralsightAccess =="y")
            //{
            //    newDeeloper.AccessPluralSight = true;
            //}
            //else
            //{
            //    newDeeloper.AccessPluralSight = false;
            //}    

        }
        private void CreateNewDevTeam()
        {
            DevTeam newdevTeam = new DevTeam();
            // TeamName
            Console.WriteLine("Enter the name of the ne development team.");
            newdevTeam.TeamName = Console.ReadLine();

            // NumMembers
            Console.WriteLine("Please enter the number of team members");
            newdevTeam.NumMembers = Console.ReadLine();

            // description
            Console.WriteLine("Please provide a description of the the Development Team.");
            newdevTeam.Description = Console.ReadLine();

            // SecurityGroup
            Console.WriteLine("Please enter the security Group.");
            newdevTeam.SecurityGroup = Console.ReadLine();

        }

        private void ValidatePluralsightAccess()
        {
            Developer newDeeloper = new Developer();
            // Access to pluralsight
            Console.WriteLine("Has the developer been give pluralsight access? y/n");
            string pluralsightAccess = Console.ReadLine().ToLower();
            if (pluralsightAccess == "y")
            {
                newDeeloper.AccessPluralSight = true;
            }
            else
            {
                newDeeloper.AccessPluralSight = false;
            }
        }
        private void CreateNewDevID()

        {
            Developer newDeeloper = new Developer();

            Console.WriteLine("Enter new DevID number");

            string DevID = Console.ReadLine().ToLower();
            foreach (Developer.DevID== "devID")
            {
                newDeeloper.AccessPluralSight = true;
            }
            else
            {
                newDeeloper.AccessPluralSight = false;
            }

        }








    }



}
