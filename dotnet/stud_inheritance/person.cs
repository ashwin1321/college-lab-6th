using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit2
{
    internal class person
    {
    }
}

namespace School
{

    public class Person
    {
        public string f_name { get; set; } = " ";
        public int age { get; set; } = 0;
        public string l_name { get; set; } = " ";
        public string gender { get; set; } = " ";

        public string full_name
        {
            get { return f_name + " " + l_name; }
        }

        public string GetInfo()
        {
            string s = "Full Name : " + full_name + Environment.NewLine;
            s += "Gender : " + gender + Environment.NewLine;
            s += "Age : " + age + Environment.NewLine;
            return s;
        }
    }

}
