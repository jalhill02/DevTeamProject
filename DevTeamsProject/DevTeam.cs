using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DevTeam
    {
        //POCO
        public string TeamName { get; set; }
        public string NumMembers { get; set; }
        public string Description { get; set; }
        public string SecurityGroup { get; set; }

        public DevTeam() { }

        public DevTeam(string teamName, string numMembers, string description, string securityGroup) 
        {
            TeamName = teamName;
            NumMembers = numMembers;
            Description = description;
            SecurityGroup = securityGroup;
        }

    }
}
