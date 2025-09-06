using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDShared
{
    public class DVLDShared
    {
        public enum Gender : byte
        {
            Male = 0,
            Female = 1
        }
        public enum ActiveStatus : byte
        { Yes = 0,
            No = 1 };
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };



    }
}
