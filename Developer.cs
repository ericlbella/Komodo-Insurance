using System;

namespace DeveloperRepo
{
    public class Developer
    {
        public string DeveloperFirstName { get; set; }
        public string DeveloperLastName { get; set; }
        public int IDNumber { get; set; }
        public bool PluralSight { get; set; }

        public Developer(string developerFirstName, string developerLastName, int idNumber, bool pluralSight)
        {
            DeveloperFirstName = developerFirstName;
            DeveloperLastName = developerLastName;
            IDNumber = idNumber;
            PluralSight = pluralSight;
        }

        public Developer() { }

    }
    
}
