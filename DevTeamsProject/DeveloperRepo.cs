using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _developerDirectory = new List<Developer>();

        //Developer Create
        public void AddContentToList(Developer.content)
        {
            _developerDirectory.Add(AddContent);
        }
        //Developer Read    
        public List<Developer> GetContentList()
        {
            return _developerDirectory;
        }
        //Developer Update
        public void updateExistingContent(String originaDevID, DeveloperRepo newContent)

        // Find the Content
        Developer oldContent = GetContentByDevID(originalDevID);

        // Update the content
        if (oldContent != null)
           {
            oldContent.Name = newContent.Name;
            oldContent.DevID = newContent.DevID;
            oldContent.PluralSightAccess = newCotent.PluralSightAccess;
            }
        //Developer Delete
        pulic bool RemoveContentFromList(string devID)
        {
            Developer content = GetContentByDevID(devID)
                if (content == null)
            {
                return false;
            }
            int initialCount = +_developerDirectory.content;
            _listofContent.Remove(content);

            if (initialCount > _listOfContent.count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Developer Helper (Get Developer by ID)
        private Developer GetContentby(string devID)
        {
            for each(Developer content in _developerDirectory)
                if (content.DevID == devID)
                {
                    return GetContent;
                }
        }

        return null;
    }
}
