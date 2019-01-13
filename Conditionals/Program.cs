using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{



    class Program
    {
        static void Main(string[] args)
        {

            //regular if/then/else

            int hour = 19;

            if (hour > 0 && hour < 12)
            {
  
             //   Console.WriteLine("It's Morning");
            }
            else if (hour > 12 && hour < 18)
            {
               // Console.WriteLine("It's Afternoon");
            }
            else {
               // Console.WriteLine("It's Evening");
            } // It's Evening

            // ternary

            bool isGoldCustomer = false;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;

           // Console.WriteLine(price); // 29.95


            //switch case

            // you can stack them like this:
            //case Season.spring:
            //case Season.Summer:
            //   do stuff
            //break;

            var season = Season.Winter;

            switch (season) {

                case Season.Autumn:
                   // Console.WriteLine("Pretty Leaves");
                    break;
                case Season.Spring:
                   // Console.WriteLine("Spring has Sprung");
                    break;
                case Season.Summer:
                   // Console.WriteLine("Beach Weather!");
                    break;
                case Season.Winter:
                   // Console.WriteLine("It's beginning to look a lot like Christmas");
                    break;
                default:
                   // Console.WriteLine("Invalid Season");
                    break;

            }

            var number = 5;

            if (number <= 10 && number >= 1)
            {
                Console.WriteLine("valid");
            }

            else {
                Console.WriteLine("invalid");
            }


            var a = 15;
            var b = 6;

            var greaterNumber = (a > b) ? a : b;

            Console.WriteLine(greaterNumber);


            var height = 25;
            var width = 10;

            var orientation = (height > width) ? "portrait" : "Landscape";

            Console.WriteLine(orientation);


            var speedLimit = 65;

            var currSpeed = 70;

            var speedDiff = currSpeed - speedLimit;


            if (currSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (currSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }



        }

    }
}
