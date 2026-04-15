using System.ComponentModel.Design;
using System.Transactions;

namespace project_solution04
{
    internal class Program
    {
        static void Main(string[] args)


        {
            //Positive,Negative or Zero

            //Console.WriteLine("enter your number");

            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number > 0)
            //{
            //    Console.WriteLine("positive");
            //}

            //else if (number < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("zero");
            //}

            //Even or Odd

            //Console.WriteLine("entre your number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("even number");
            //}
            //else if (number % 2== 1) 
            //{
            //    Console.WriteLine("odd number");
            //}
            //else
            //{
            //    Console.WriteLine("enter valid number");
            //}

            //student grade system

            //Console.WriteLine("enter a student score from 0 to 100");

            //int score = Convert.ToInt32(Console.ReadLine());

            //if (score >= 90 && score <= 100)
            //{
            //    Console.WriteLine("excellent");
            //}
            //else if (score >= 75 && score <= 89)
            //{
            //    Console.WriteLine("good");
            //}
            //else if (score >= 50 && score <= 59)
            //{
            //    Console.WriteLine("pass");
            //}
            //else if (score >=0 &&  score <=50)
            //{
            //    Console.WriteLine("fail");
            //}
            //else { Console.WriteLine("enter valid score" ); }


            // simple login syste

            //    Console.WriteLine("enter your username");

            //    string username = (Console.ReadLine());

            //    Console.WriteLine("enter your password");
            //    string password = (Console.ReadLine());

            //    if (username == "admin" && password == "1234") 
            //    {
            //        Console.WriteLine("login successful");
            //    }

            //else {
            //        Console.WriteLine("invalid username or password");
            //    }

            //simple ATM system

            int balance = 1000;

            Console.WriteLine("enter withdrawal amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount <= 0)
            {
                Console.WriteLine("invalid amount");
            }
            else if (amount > balance)
            {
                Console.WriteLine("insufficient balance");
            }


            else 
            {
                balance = amount - balance;
                Console.WriteLine("withdrawal successful");
                Console.WriteLine("remaining balance" + balance);
            }

          
                }
    }
}