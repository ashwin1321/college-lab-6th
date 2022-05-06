Console.WriteLine(" Enter the number : ");
var min_num = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(" Enter the  2nd number : ");
//var max_num = Convert.ToInt32(Console.ReadLine());

//for (int j = min_num; j < max_num + 1; j++)
//{
//    for (int i = 1; i < 11; i++)
//    {
//        var b = i * j;
//        Console.WriteLine($"{j}*{i} = {b} ");
//    }
//    Console.WriteLine($"{Environment.NewLine}");
//}

//if (min_num < max_num )
//{
//    Console.WriteLine("Min_num smaller than max.");s
//}

//if (min_num < max_num && min_num >= 1 && min_num <= 10 && max_num >= 1 && max_num <= 10)
//{
//    Console.WriteLine("The number is in range and valid.");
//}

////else if(min_num < max_num)
////{
////    Console.WriteLine("Invalid!!!");

////}

//else
//{
//    Console.WriteLine("Invalid!!!");
//}
var num = 1;
for (int i = min_num; i > 1; i--)
{
    //    if (i < 1)
    //    {
    //        Console.WriteLine(1);
    //    }
    num = num * i;

}
Console.WriteLine(num);
    
