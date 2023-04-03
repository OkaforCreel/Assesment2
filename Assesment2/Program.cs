using System;

namespace Assesment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] accounts = new int[2, 3];
            for( i=0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Input values for accounts");
                    accounts[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
        Richestcustomer(accounts);
        }
        

        //Create method

        static int Richestcustomer (int[,] accounts)
        {
            //Create and declared MaxAccount,Made use of a for loop to iterate through the number of customers

            int MaxAccount = 0;
            for (int i = 0; i < accounts.GetLength(0); i++)
            {
                //Create and declared sum, made use of a for loop to iterate through the inner elements
                int sum = 0;
                for (int j = 0; j < accounts.GetLength(1); j++)
                {
                    //Made use of Math function to get the maximum value
                    sum = sum + accounts[i, j];
                    MaxAccount = Math.Max(sum, MaxAccount);
                }
            }
            Console.WriteLine("This is the worth of the richest customer =" + MaxAccount);
            return MaxAccount;        
        }
    }
}
