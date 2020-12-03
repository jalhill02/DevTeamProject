using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DevTeamRepo
    {
        private readonly DeveloperRepo _developerRepo = new DeveloperRepo(); // this gives you access to the _developerDirectory so you can access existing Developers and add them to a team
        private readonly List<DevTeam> _devTeams = new List<DevTeam>();

        //DevTeam Create
        public void addContentToList(DevTeam devTeams)
        {
            _devTeams.Add (devTeams);

        }
        //DevTeam Read
        public List<DevTeam> GetContentList()
        {
            return _devTeams;
        }
        //DevTeam Update
        public void updateExistingContent(string originalTeam, DevTeam newContent)
        {

            //Find the team
            DevTeam oldContent = GetContentByTeamName(originalTeam);

            //Update the content
            if (oldContent != null)
            {
                oldContent.TeamName = newContent.TeamName;
                oldContent.NumMembers = newContent. NumMembers;
                oldContent.Description = newContent.Description;
                oldContent.SecurityGroup = newContent.SecurityGroup;
            }
        }





        //DevTeam Delete
        public bool RemoveContentFromList(string teamName)
        {
            DevTeam content = GetContentByTeamName(teamName);
            if (content == null)
            {
                return false;
            }
            int initialCount = _devTeams.Count;
            _devTeams.Remove(content);
            if (initialCount > _devTeams.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //DevTeam Helper (Get Team by ID)
        private DevTeam GetContentByTeamName(string TeamName)
        {

            foreach (DevTeam content in _devTeams)
            {
                if (content.TeamName == TeamName)
                {
                    return content;
                }
            }
            return null;
        }

        

    }
}
