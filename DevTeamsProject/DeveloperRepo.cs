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
        public void AddContentToList(Developer developerDirectory)
        {
            _developerDirectory.Add(developerDirectory);

        }
        //Developer Read    
        public List<Developer> GetContentList()
        {
            return _developerDirectory;
        }
        //Developer Update

        public void updateExistingContent(string originalJD, Developer newContent)
        {

            //Find the Developer
            Developer oldContent = GetContentByDevName(originalName);

            //Update the Developer
            if (oldContent != null)
            {
                oldContent.DevName = newContent.DevName;
                oldContent.DevID = newContent.DevID;
                oldContent.AccessPluralSight = newContent.AccessPluralSight;

            }

            //Developer Delete
            public bool RemoveContentFromList(string devID)
            {
                
                Developer content = GetContentByDevID (devID);
                

                    if (content == null)
                    {
                        return false;
                    }
                    int initialCount = _developerDirectory.Count;
                    _developerDirectory.Remove(content);

                    if (initialCount > _developerDirectory.Count)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
               

            }

            //Developer Helper (Get Developer by ID)


            private Developer GetContentBy(string devID)
            {
                foreach (Developer content in _developerDirectory) 
                    if (content.DevID == devID)
                    {
                        return content;
                    }

                {
                    return null;
                }


            }
        }
