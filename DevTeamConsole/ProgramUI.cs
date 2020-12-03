using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamConsole
{
    class ProgramUI
    {   // the method that starts the DevTeams application
        public void Run()
        {
            Menu();
               

        }

        // menu
        private void Menu()
        {
            Console.WriteLine("Select a menu option\n" +
                "1. Create new developer\n" +
                "2. Create new devteam]n" +
                "3. Check access to Pluralsight\n" +
                "4. validate unique devID\n" +
                "5. Exit");

            //Get the user's input
            string input -Console.ReadLine();

            // Evaluate the user's input and act accordingly
            switch ()
        }
    }


}
