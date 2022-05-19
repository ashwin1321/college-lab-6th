
// ================= STRUCT =====================
//class Entry
//{
//    static void Main(String[] args)
//    {
//        //Books[] books =
//        //{
//        //    new Books("title1","author1","subject1"),
//        //    new Books("title2","author2","subject2")
//        //};

//        List<Books> books = new List<Books>();
//        books.Add(new Books("Inheritance", "Rabindra", "C#"));
//        books.Add(new Books("Lexical", "Aayush", "Compiler"));
//        foreach(Books b in books)
//        {
//            Console.WriteLine(b.title);
//        }
//    }



//    public struct Books
//    {
//        public string title;
//        public string author;
//        public string subject;


//        public Books(string t, string a, string s)
//        {
//            title = t; author = a; subject = s;
//        }
//    }

    
//}


// ============== CALCULATOR ==================

class Calcualtor
{
    public int number1, number2;
   

    public Calcualtor(int num1, int num2)
    {
        number1 = num1; number2 = num2;
    }

    public static Calcualtor operator - (Calcualtor c1, Calcualtor c2) 
    { 
    
        c1.number1 = c1.number1 - c2.number1;
        c1.number2 = c1.number2 - c2.number2;
        return c1;
    }

    public void Print()
    {
        Console.WriteLine("Number1 =" + number1);
        Console.WriteLine("Number2 = "+ number2);
    }

    public static void Main(string[] args)
    {
        var rabindra = new Calcualtor(2,3);
        var zaxiya = new Calcualtor(5,7);

        rabindra = rabindra - zaxiya;
        rabindra.Print();

    }

}