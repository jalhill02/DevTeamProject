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
        //POCO
        public string DevName { get; set; }
        public string DevID { get; set; }
        public bool AccessPluralSight { get; set; }

        public Developer() { }

        public Developer(string devname, string devID, bool accessPlurlSight)
        {
            DevName = devname;
            DevID = devID;
            AccessPluralSight = accessPlurlSight;

        }

    }

}
