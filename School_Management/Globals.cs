using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    public static class Globals
    {
        public static int GlobalsUserID { get; set; }
        public static void SetGlobalsUserid(int userid)
        {
            GlobalsUserID = userid;
        }
    }
}
