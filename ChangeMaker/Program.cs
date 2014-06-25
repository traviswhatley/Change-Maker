using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeMaker(3.18);
            ChangeMaker(0.99);
            ChangeMaker(12.93);
            //EC
            ChangeMaker(8975.56);

            //keep the console open
            Console.ReadKey();
        }
        //creating ChangeMaker function
        static void ChangeMaker(double amount)
        {
            //declaring variables for # of coins
            double i = amount;
            //number of hundreds
            int hundred = 0;
            //number of fifties
            int fifty = 0;
            //number of twenties
            int twenty = 0;
            //number of tens
            int ten = 0;
            //number of fives
            int five = 0;
            //number of singles
            int one = 0;
            //number of quarters
            int quarter = 0;
            //number of dimes
            int dime = 0;
            //number of nickels
            int nickel = 0;
            //number of pennies
            int penny = 0;

            //while amount is greater than 100 add a benjamin
            while (i > 100)
            {
                //amount - 100 until false
                i = i - 100;
                //add a hundred
                hundred++;
            }
            //while amount is greater than 50 add a fifty
            while (i > 50)
            {
                //amount - 50 until false
                i = i - 50;
                //add a fifty
                fifty++;
            }
            //while amount is greater than 20 
            while (i > 20)
            {
                i = i - 20;
                twenty++;
            }

            while (i > 10)
            {
                i = i - 10;
                ten++;
            }

            while (i > 5)
            {
                i = i - 5;
                five++;
            }

            while (i > 1)
            {
                i = i - 1;
                one++;
            }
            //while amount is greater than .25 add a quarter
            while (i > .25d)
            {
                //amount - .25 until false
                i = i - .25d;
                //count up quarters used
                quarter++;
            }
            //then while amount is greater than .10 add a dime
            while (i > .10d)
            {
                //amount - .10 until false
                i = i - .10d;
                //count up dimes used
                dime++;
            }
            //then while amount is greater than .05 add a nickel
            while (i > .05d)
            {
                //amount - .05 until false
                i = i - .05d;
                //count up nickels used
                nickel++;
            }
            //then while amount is great than 0 add a penny
            while (Math.Round(i,2) > .00d)
            {
                //amount - .01 until false
                i = i - .01d;
                //count up pennies used
                penny++;
            }

            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Hundreds: " + hundred);
            Console.WriteLine("Fifties: " + fifty);
            Console.WriteLine("Twenties: " + twenty);
            Console.WriteLine("Tens: " + ten);
            Console.WriteLine("Fives: " + five);
            Console.WriteLine("Ones: " + one);
            Console.WriteLine("Quarters: " + quarter);
            Console.WriteLine("Dimes: " + dime);
            Console.WriteLine("Nickels: " + nickel);
            Console.WriteLine("Pennies: " + penny);
            Console.WriteLine();
        }
    }
}
