//using System;

//namespace hello
//{
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            int number = 371;
//            int NumberClone = number;
//            int rem;
//            int cube;
//            int result = 0;

//            while (number != 0)
//                {

//                rem = number % 10;
//                cube = rem * rem * rem;
//                result = result + cube;
//                number = number / 10;
//            }

//            if (NumberClone == result ) {
//                Console.WriteLine("It is a amstrong number!");
//            }
//            else
//            {
//                Console.WriteLine("This number is not a amstrong number!");
//            }
//            Console.ReadLine();

//        }
//    }
//}
//using System;
//using System.Runtime.ConstrainedExecution;

//namespace hello
//{
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number");
//            string number = Console.ReadLine();
//            int num = Convert.ToInt32(number);
//            int clone = num;
//            int rem;
//            int cube = 0;
//            int result = 0;

//            while ( num != 0) {
//                rem = num % 10;
//                cube = rem * rem * rem;
//                result= result + cube;
//                num= num / 10;
//            }
//            if (result == clone)
//            {
//                Console.WriteLine("the number is amstrong number");
//            }
//            else
//            {
//                Console.WriteLine("this number is not a amstrong number!");
//            }
//            Console.ReadLine();
//        }
//    }
//}
//using System;

//namespace hello
//{
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("enter the number: ");
//            string number = Console.ReadLine();
//            int num = Convert.ToInt32(number);
//            int rev = 0;
//            while (num > 0)
//            {
//                {
//                    rev = (rev * 10) + num % 10;

//                    num = num / 10;
//                }

//            }
//            Console.WriteLine(rev);
//            Console.ReadLine();
//        }
//    }
//}
//using System;
//using System.Runtime.Remoting.Services;

//namespace hello
//{
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("ENTER THE NUMBER");
//            String number = Console.ReadLine();
//            int num = Convert.ToInt32(number);
//            int clone = num;
//            int rev = 0;
//            while (num > 0)
//            {
//                rev = (rev*10)+num%10;
//                num = num / 10;

//            }
//            if (clone == rev)
//            {
//                Console.WriteLine("this number is plondrom!");
//            }
//            else
//            {
//                Console.WriteLine(" number i not plindrom");
//            }
//            Console.ReadLine();
//        }
//    }
//}

//using System;

//namespace hello
//{
//    class program
//    {
//        public static void Main(string[] args)
//        {
//            int 

//        }
//    }
//}
using System;

namespace calculator
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second nukmber: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please chose the operator: if you want to addition press 'a', if you want to subtraction press 's', if you want to multiplication press 'm', if you want to division press 'd'");
            string result = Console.ReadLine();
            switch (result)
            {
                case "a":
                    int A = num1 + num2;
                    Console.WriteLine("your result: " +A);
                    break;
                case "s":
                     int S= num1 - num2;
                    Console.WriteLine("your Result: " + S);
                    break;
                case "m":
                    int M = num1 * num2;
                    Console.WriteLine("Your Result: " +  M);
                    break;
                case "d":
                    int D = num1 / num2;
                    Console.WriteLine("your result: " +  D);
                    break;
                
                default:
                    Console.WriteLine("you enter wrong key! please check the operator, & Retry ");
                    break;
            }
            Console.WriteLine("Thnk You For using Our Calculator");
            Console.ReadLine();
        }
    }
}




