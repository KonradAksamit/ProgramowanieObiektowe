using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {

        }
        override public string ToString()
        {
            return "Teacher: " + base.ToString() + "\n";
        }
    }
}