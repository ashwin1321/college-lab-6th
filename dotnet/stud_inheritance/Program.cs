
namespace School
{

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hey hey!!");

            Person[] person =
            {
                new Student( "Prasmit" ," Neupane", "Male", 24,"A",17),
                new Student("Rabindra","Baisnab","Male",22,"E" ,19)

            };

            foreach (var p in person)
            {

                if (p is Student s)
                {
                    Console.WriteLine(s.GetInfo());
                    continue;
                }

                Console.WriteLine(p.GetInfo());
            }
        }



    }
}