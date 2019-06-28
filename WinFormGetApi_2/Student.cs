using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormGetApi_2
{
    class Student
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public bool isMale { get; set; }

        public List<string> friends = new List<string>();

    }
}
