using ClassLibrary;
using System.Collections.Generic;

namespace Testing5
{
    public class clsStaffCollection
    {
        public List<clsStaff> StaffList { get; internal set; }
        public int Count { get; internal set; }
        public clsStaff ThisStaff { get; internal set; }
    }
}