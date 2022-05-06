using System;
namespace console1
{
    class Student
    {
        private string first_name { get; set; } = " ";
        private string middle_name { get; set; } = " ";
        private string last_name { get; set; } = " ";
        private int roll_no { get; set; } = 0;
        private int id { get; set; } = 0;
        private string address { get; set; } = " ";
        private string district { get; set; } = " ";

        // read only property
        public string full_name
        {
            get
            {
                return $"{first_name} {middle_name} {last_name}";
            }
        }

        public Student(string sFirst_name, string sMiddle_name, string sLast_name, int iRoll_no, int iId, string sAddress, string sDistrict)
        {
            this.first_name = sFirst_name;
            this.middle_name = sMiddle_name;
            this.last_name = sLast_name;
            this.roll_no = iRoll_no;
            this.id = iId;
            this.address = sAddress;
            this.district = sDistrict;}

        public string display()
        {

            return $" The name of the student is {full_name}.\n The Id number is {id}.\n Roll number: {roll_no}.\n Address : {district},{address} ";

        }

        
    }

    public static class Mainrun
    {
        static void Main(string[] args)
        {
            var bidhyarthi = new Student("KP", "Sharma","Oli", 123, 00123453, "Balkot", "Kathmandu");
            Console.WriteLine(bidhyarthi.display());
        }
    }
}
