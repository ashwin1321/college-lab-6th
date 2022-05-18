
// ======================== ARRAY ===========================   
//string[] s = { "anb", "xyz" };         
//foreach (var i in s)
//{
//    Console.WriteLine(i);
//}


// ================  LIST  ================
//List<string> s2 = new List<string>();
//s2.Add("a");
//s2.Add("b");
//s2.Add("c");

//foreach (var i in s2)
//{
//Console.WriteLine(i);
//}


// ================ EXCEPTION HANDLING ==================
//try
//{
//    List<string> s2 = new List<string>();
//    s2.Add("a");
//    s2.Add("b");
//    s2.Add("c");
//    var s3 = "0/0";
//    Console.WriteLine(Convert.ToInt32(s3));
//    foreach (var i in s2)
//    {
//        Console.WriteLine(i);
//    }   
//}

//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//finally
//{
//    Console.WriteLine("Program Complete.....");
//}



// ================= FOR LOOP ==================
//for (int i = 0; i < 5; i++) {
//    Console.WriteLine(i);
//        }



// ================ JAGGED ARRAY ===================

// jagged array
//int[][] jArray = new int[2][]
//{
//    new int[3]{1,2,3},
//    new int[4]{4,5,6,7}
//};
//Console.WriteLine(jArray[0][1]);               // return 2
//Console.WriteLine(jArray[1][0]);               // returns 4

//// 2d Array nbbbbbbbbb
//int[,] jArray2 = new int[3, 2]
//{
//    {1,2 },
//    {3,4 },
//    {5,6 }
//};
//Console.WriteLine(jArray2[0,1]);


// ============= OUT PARAMETERS ==========
//public class Program {
//    public static int Multiply(int x, out int y, out int z)
//    {
//        y = x*3 ; z = x*3;
//        return x * 2;
//    }

//    public static void Multiply2(ref int tap)
//    {
//        tap = tap * 2;
//    }
//    public static void Main(string[] args)
//    {
//        int x, y, z;
//        Console.WriteLine(Multiply(4, out x, out y));
//        Console.WriteLine(x);

//        int aa = 3;
//        Multiply2(ref aa);
//        Console.WriteLine(aa);
//    }
//}

