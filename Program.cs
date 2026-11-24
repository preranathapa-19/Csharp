
//Operators in C#
// using System.Linq.Expressions;
// using System.Runtime.CompilerServices;

// int a = 10;
// int b = 3;

// Console.WriteLine(a+b);  //sum of two number
// Console.WriteLine(a-b);  //difference of two number
// Console.WriteLine(a*b);  //multiply of two number
// Console.WriteLine(a/b);  //Division of two number

// //Question no 2: Create another method inside the same class

// int p = 4;
// string result = (p % 2 == 0) ? "Even number" : "odd number";
// Console.WriteLine(result);


//Qn:3 call all the methods od the operators class

// Operators obj = new Operators();

// obj.Add(10, 5);
// obj.Subtract(10, 5);
// obj.Multiply(10, 5);
// obj.Divide(10, 5);
// obj.OddEvenFinder(10);


// // Task 2
class NullOperations
{
    public static void PerformNullChecks()
    {
        string? username = null;

        string result = username == null
            ? "Username is not available"
            : username;
        Console.WriteLine(result);

        string result2 = username ?? "Username is not available";
        Console.WriteLine(result2);

        username ??= "balen";
        Console.WriteLine(username);
    }

}

// Console.Write("Enter your age: ");
// int age = Convert.ToInt32(Console.ReadLine());

// if (age < 13)
// {
//     Console.WriteLine("Child");
// }
// else if (age <= 19)
// {
//     Console.WriteLine("Teenager");
// }
// else
// {
//     Console.WriteLine("Adult");
// }


// //Task 4 : if else and swiitch 

// Console.Write("Enter a numer (1-7)");
// int day = Convert.ToInt16(Console.ReadLine());

// switch (day)
// {
//     case 1: 
//         Console.WriteLine("Sunday");
//         break;

//         case 2: 
//         Console.WriteLine("Monday");
//         break;

//         case 3:
//         Console.WriteLine("Tuesday");
//         break;

//         case 4 :
//         Console.WriteLine("Wednesday");
//         break;

//         case 5:
//         Console.WriteLine("Thursday");
//         break;

//          case 6:
//         Console.WriteLine("Friday");
//         break;

//          case 7:
//         Console.WriteLine("Saturday");
//         break;

//     default:
//         Console.WriteLine("Invalid day number");
//         break;

// }

// // Task 5: Loop

// Console.Write("Enter a number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// for (int i = 1; i <= n; i++)
// {
//     sum += i;
// }

// Console.WriteLine("Sum: " + sum);


// //Task 6: Try catch finally 


// try
// {
//     Console.Write("Enter a number: ");
//     int number = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Number: " + number);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Invalid number format");
// }
// finally
// {
//     Console.WriteLine("Program Executed");
// }

   
   


