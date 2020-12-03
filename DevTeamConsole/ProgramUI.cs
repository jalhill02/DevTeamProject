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
                        CreateNewDevID();
                        break;
                    case "3":
                        // Check access to pluralsight
                        ValidatepluralsightAccess();
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
          Developer dev

        }
        private void CreateNewDevTeam()
        {
            DevTeam devTeam
        }
        private void CreateNewDevID()
        {
            CreateNewDevID
        }
        private void ValidatepluralsightAccess()
        {
            Plural

           
        }


    }



}
