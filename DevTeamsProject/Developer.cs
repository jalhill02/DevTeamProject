using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    //public enum DevGroup
    //{
    //    DevGroup1 = 1,
    //    DevGroup2,
    //    DevGroup3,
    //    DevGroup4
    //}
    public class Developer
    {
        public string Name { get; set; }
        public string DevID { get; set; }
        public bool PluralSightAccess { get; set; }
    }

    public Developer() { }

    public Developer(string name, string devID, bool pluralSightAccess)
    {
        Name = name;
        DevID - devID;
        PluralSightAccess = pluralSightAccess;
    }

}
