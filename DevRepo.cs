using System;
using System.Collections.Generic;
using System.Text;

namespace DeveloperRepo
{
    public class DevRepo
    {
        public List<Developer> _listOfDevelopers = new List<Developer>();
        
        //Create
        public void AddDeveloperToList(Developer programmer)
        {
            _listOfDevelopers.Add(programmer);

        }

        //Read
        public List<Developer> GetDeveloperList()
        {
            return _listOfDevelopers;
        }

        //Update
        public bool UpdateExistingDeveloper(int idNumber, Developer newProgrammer)
        {
            // Find the content
            Developer oldProgrammer = GetDeveloperByIDNumber(idNumber);

            // Update the content
            if (oldProgrammer != null)
            {
                oldProgrammer.IDNumber = newProgrammer.IDNumber;
                oldProgrammer.DeveloperFirstName = newProgrammer.DeveloperFirstName;
                oldProgrammer.DeveloperLastName = newProgrammer.DeveloperLastName;
                oldProgrammer.PluralSight = newProgrammer.PluralSight;
                return true;
            }
            else
            {
                return false;
            }

    }

    //Delete
    public bool RemoveDeveloperFromList(int idNumber)
        {
            Developer programmer = GetDeveloperByIDNumber(idNumber);

            if (programmer == null)
            {
                Console.WriteLine("No developer by that DeveloperID.");
                return false;
            }

            int initialCount = _listOfDevelopers.Count;
            _listOfDevelopers.Remove(programmer);

            if (initialCount > _listOfDevelopers.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper method
        public Developer GetDeveloperByIDNumber(int idNumber) 
        { 
            foreach(Developer programmer in _listOfDevelopers)
            {
                if (programmer.IDNumber == idNumber)
                {
                    return programmer;
                }

            }
            // string name = "Eric";
            // foreach(string name in _list)

            return null;
        }
    }
}
