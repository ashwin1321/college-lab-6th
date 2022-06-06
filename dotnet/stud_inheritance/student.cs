
namespace School
{
    public class Student : Person
    {

        public string grade { get; set; } = "";
        public int roll_no { get; set; } = 0;

        public Student(string sFname, string Lname, string sGender, int iAge, string iGrade, int iRollno)
        {
            f_name = sFname; l_name = Lname; gender = sGender; age = iAge; grade = iGrade; roll_no = iRollno;
        }

        public string GetInfo()
        {
            string s = base.GetInfo();
            s += "Grade : " + grade + Environment.NewLine;
            s += "Roll No : " + roll_no + Environment.NewLine;
            s += Environment.NewLine;
            return s;
        }
    }

}
