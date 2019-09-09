// Labb 1 vecka 44
// Elin Svantesson
// Version 1.0 2017-11-04

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabUNIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab1 lab = new Lab1();

            //Uppgift 1
            int resultat1 = lab.Add(1, 3);
            Console.WriteLine("Uppgift 1 resultat Add (1,3): " + resultat1);

            //Uppgift 2
            int resultat2 = lab.Subtract(10,5);
            Console.WriteLine("Uppgift 2 resultat Subtract (10,5): " + resultat2);

            //Uppgift 3
            int resultat3 = lab.Multiply(2, 3);
            Console.WriteLine("Uppgift 3 resultat Multiply (2,3): " + resultat3);

            //Uppgift 4
            int resultat4 = lab.DivideIntegers(20,2);
            Console.WriteLine("Uppgift 4 resultat DivideIntegers (20,2): " + resultat4);

            //Uppgift 5
            string namn = lab.Hello("Elin");
            Console.WriteLine("Uppgift 5 resultat Hello (Elin): " + namn);
            
            //Uppgift 6
            bool resultat6 = lab.And(true,true);
            Console.WriteLine("Uppgift 6 resultat And (true,true): " + resultat6);

            //Uppgift 7
            bool resultat7 = lab.Or(true, false);
            Console.WriteLine("Uppgift 7 resultat Or (true,false): " + resultat7);

            //Uppgift 8
            bool resultat8 = lab.Xor(false, true);
            Console.WriteLine("Uppgift 8 resultat Xor (false,true): " + resultat8);

            //Uppgift 9
            bool resultat9 = lab.Not(true);
            Console.WriteLine("Uppgift 9 resultat1 Not (true): " + resultat9);

            //Uppgift 10
            int resultat10 = lab.Greatest(10, 20);
            Console.WriteLine("Uppgift 10 resultat Greatest (10,20): " + resultat10);

            //Uppgift 11
            int resultat11 = lab.Greatest(5,7);
            Console.WriteLine("Uppgift 11 resultat Greatest (5,7): " + resultat11);

            //Uppgift 12
            int resultat12 = lab.Greatest(10, 5);
            Console.WriteLine("Uppgift 12 resultat Greatest (10,5): " + resultat12);

            //Uppgift 13
            bool resultat13 = lab.IsGreater(3,5);
            Console.WriteLine("Uppgift 13 resultat IsGreater (3,5): " + resultat13);

            //Uppgift 14
            string resultat14 = lab.IntToString(5);
            Console.WriteLine("Uppgift 14 resultat IntToString (5): " + resultat14);

            //Uppgift 15
            int resultat15 = lab.StringToInt("05");
            Console.WriteLine("Uppgift 15 resultat StringToInt (05): " + resultat15);

            //Uppgift 16
            double resultat16 = lab.DivideExact(20.5, 12.5);
            Console.WriteLine("Uppgift 16 resultat DivideExact (20.5,12.5): " + resultat16);

            //Uppgift 17 
            double resultat17 = lab.DivideExact(20.5, 12.5);
            Console.WriteLine("Uppgift 17 resultat DivideExact (20.5, 12.5): " + resultat17);

            //Uppgift 18
            int resultat18 = lab.DivideAndTruncate(60, 30);
            Console.WriteLine("Uppgift 18 resultat DivideAndTruncate (60,30): " + resultat18);

            //Uppgift 19
            string resultat19 = lab.RequestPony(13, 44);
            Console.WriteLine("Uppgift 19 resultat RequestPony (13,44): " + resultat19);  

            //Uppgift 20
            string resultat20 = lab.WhatIsForLunch("monday");
            Console.WriteLine("Uppgift 20 resultat WhatIsForLunch (monday): " + resultat20);


            //Uppgift 21
            bool resultat21 = lab.IsTheBathReady("YES", 35);
            Console.WriteLine("Uppgift 21 resultat IsTheBathReady (YES, 35): " + resultat21);

            //Uppgift 22
            int resultat22 = lab.DivideAndRound(5, 2);
            Console.WriteLine("Uppgift 22 resultat1 DivideAndRound (20.5, 3.5): " + resultat22);


            //Uppgift 23
            string resultat23 = lab.DivideWithRemainder(20, 2);
            Console.WriteLine ("Uppgift 23 resultat DivideWithRemainder (20,2): " + resultat23);

            //Uppgift 24
            bool resultat24 = lab.CanJoyride(10, 130, false);
            Console.WriteLine("Uppgift 24 resultat CanJoyRide (10, 130, false): " + resultat24);

            //Uppgift 25
            string resultat25 = lab.DateDistance(1996, 02, 25, 1998, 04, 24);
            Console.WriteLine("Uppgift 25 resultat1 DateDistance (1996,02,25,1998,04,24): " + resultat25);


            //Uppgift 26
            bool resultat26 = lab.IsLeapYear(2020);
            Console.WriteLine("Uppgift 26 resultat IsLeapYear (2020): " + resultat26);

            //Uppgift 27
            string resultat27 = lab.RepeatString("Hej", 3);
            Console.WriteLine("Uppgift 27 resultat RepeatString (Hej,3): " + resultat27);

            //Uppgift 28
            string resultat28 = lab.MultiplicationTableSum(2, 3, 6);
            Console.WriteLine("Uppgift 28 resultat1 MultiplicationTableSum (2,3,6): " + resultat28);



            Console.ReadLine();
        }
    }
}
