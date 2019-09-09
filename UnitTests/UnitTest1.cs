using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPLabUNIT;




namespace OOPLabUNIT
{
    [TestClass]
    public class UnitTest1
    {

        Lab1 lab = new Lab1();
        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(1, lab.Add(1, 0));
            Assert.AreEqual(1, lab.Add(0, 1));
            Assert.AreEqual(-1, lab.Add(-1, 0));

        }
        [TestMethod]
        public void TestSub()
        {
            Assert.AreEqual(1, lab.Subtract(1, 0));
            Assert.AreEqual(-1, lab.Subtract(0, 1));
            Assert.AreEqual(0, lab.Subtract(-1, -1));

        }
        [TestMethod]
        public void TestMult()
        {
            Assert.AreEqual((1*0), lab.Multiply(1, 0));
            Assert.AreEqual((0 * 1), lab.Multiply (0, 1));
            Assert.AreEqual((-1*-1), lab.Multiply(-1, -1));
            Assert.AreEqual((-1 * 1), lab.Multiply(-1, 1));
        }
        [TestMethod]
        public void DivideIntegers()
        {
            Assert.AreEqual((1/1), lab.DivideIntegers(1, 1));
            Assert.AreEqual((1 / 2), lab.DivideIntegers(1, 2));
            Assert.AreEqual((-1 / 1), lab.DivideIntegers(-1, 1));
            Assert.AreEqual((4 / 2), lab.DivideIntegers(4, 2));

        }
        [TestMethod]
        public void Hello_SingleWord()
        {
            Assert.AreEqual("Hello, Superman.", lab.Hello("Superman"));
        }
        [TestMethod]
        public void Hello_MultiWord()
        {
            Assert.AreEqual("Hello, Doktor Glas.", lab.Hello("Doktor Glas"));
        }

        [TestMethod]
        public void Hello_Empty()
        {
            Assert.AreEqual("Hello, Anonymous.", lab.Hello(""));
        }

        [TestMethod]
        public void Hello_Null()
        {
            Assert.AreEqual("Hello, Anonymous.", lab.Hello(null));
        }
        [TestMethod]
        public void And()
        {
            Assert.IsTrue(lab.And(true, true));
            Assert.IsFalse(lab.And(true, false));
            Assert.IsFalse(lab.And(false, true));
            Assert.IsFalse(lab.And(false, false));
        }
        [TestMethod]
        public void Or()
        {
            Assert.IsTrue(lab.Or(false, true));
            Assert.IsTrue(lab.Or(true, false));
            Assert.IsTrue(lab.Or(true, true));
            Assert.IsFalse(lab.Or(false, false)); 
        }
        [TestMethod]
        public void Xor()
        {
            Assert.IsTrue(lab.Xor(true, false));
            Assert.IsTrue(lab.Xor(false, true));
            Assert.IsFalse(lab.Xor(false, false));
            Assert.IsFalse(lab.Xor(true, true));


        }
         [TestMethod]
        public void Not()
        {
            Assert.IsFalse(lab.Not(true));
            Assert.IsTrue(lab.Not(false));   

        }
        [TestMethod]
        public void GreatestOfTwo()
        {

            Assert.AreEqual(1, lab.Greatest(1, 0));
            Assert.AreEqual(1, lab.Greatest(0, 1));
            Assert.AreEqual(4050, lab.Greatest(4050, 3));
            Assert.AreEqual(0, lab.Greatest(-1, 0));
            Assert.AreEqual(-1, lab.Greatest(-1, -2));

        }
        [TestMethod]
        public void GreatestOfThree()
        {
            Assert.AreEqual(1, lab.Greatest(1, 0, 0));
            Assert.AreEqual(1, lab.Greatest(0, 1,0));
            Assert.AreEqual(4670, lab.Greatest(4050, 3, 4670));
            Assert.AreEqual(0, lab.Greatest(-1, 0, 0));
            Assert.AreEqual(-1, lab.Greatest(-1, -2, -1));

        }
        [TestMethod]
        public void GreatestOfFour()
        {
            Assert.AreEqual(1, lab.Greatest(1, 0, 0,0));
            Assert.AreEqual(1, lab.Greatest(0, 1, 0,0));
            Assert.AreEqual(4670, lab.Greatest(4050, 3, 4670, 4050));
            Assert.AreEqual(0, lab.Greatest(-1, 0, 0, 0));
            Assert.AreEqual(-1, lab.Greatest(-1, -2, -1, -1));

        }
        [TestMethod]
        public void IsGreatest()
        {
            Assert.IsTrue(lab.IsGreater(40, 29));
            Assert.IsFalse(lab.IsGreater(29, 40));
        }
        [TestMethod]
        public void IntToString()
        {
            Assert.AreEqual("150430", lab.IntToString(150430));
            Assert.AreEqual("-150430", lab.IntToString(-150430));
        }
        [TestMethod]
        public void StringToInt()
        {
            Assert.AreEqual(150430, lab.StringToInt("150430"));
            Assert.AreEqual(-15, lab.StringToInt("-15"));
        }

        [TestMethod]
        public void DivideExaktDoubleToDouble()
        {
            Assert.AreEqual((double)425.4 / (double)8, lab.DivideExact(425.4, 8));
            Assert.AreEqual((double)4.5 / (double)-2.4, lab.DivideExact(4.5, -2.4));
        }
        [TestMethod]
        public void DivideExaktIntsToDouble()
        {
            Assert.AreEqual((int) (425.4/8), lab.DivideAndTruncate(425.4, 8));
            Assert.AreEqual((int)(4.5 / -2.4), lab.DivideAndTruncate(4.5, -2.4));
        }
        [TestMethod]
        public void RequestPony()
        {
            Assert.AreEqual("Too young to compete.", lab.RequestPony(11,66));
            Assert.AreEqual("Class A pony", lab.RequestPony(12, 30));
            Assert.AreEqual("Class B pony", lab.RequestPony(12, 50));
            Assert.AreEqual("Class C pony", lab.RequestPony(12, 65));
            Assert.AreEqual("Class B pony", lab.RequestPony(12, 50));
            Assert.AreEqual("No ponies available for the given weight class.", lab.RequestPony(12, 66));

        }
        [TestMethod]
        public void WhatIsItForLunch()
        {
            Assert.AreEqual("Incorrect input", lab.WhatIsForLunch(null));
            Assert.AreEqual("Incorrect input", lab.WhatIsForLunch(""));
            Assert.AreEqual("Incorrect input", lab.WhatIsForLunch("0"));
            Assert.AreEqual("Incorrect input", lab.WhatIsForLunch("8"));
            Assert.AreEqual("Incorrect input", lab.WhatIsForLunch("asd"));
            Assert.AreEqual("Incorrect input", lab.WhatIsForLunch("asdh KJFDGGDHJKASDFGKJHDS sdga fgs"));
            Assert.AreEqual("Incorrect input", lab.WhatIsForLunch("&(%(&€askghd"));

            Assert.AreEqual("Ratatouille", lab.WhatIsForLunch("MONDAY"));
            Assert.AreEqual("Ratatouille", lab.WhatIsForLunch("Monday"));
            Assert.AreEqual("Ratatouille", lab.WhatIsForLunch("monday"));
            Assert.AreEqual("Ratatouille", lab.WhatIsForLunch("mon"));
            Assert.AreEqual("Ratatouille", lab.WhatIsForLunch("1"));

            Assert.AreEqual("Pancakes and pea soup", lab.WhatIsForLunch("TUESDAY"));
            Assert.AreEqual("Pancakes and pea soup", lab.WhatIsForLunch("Tuesday"));
            Assert.AreEqual("Pancakes and pea soup", lab.WhatIsForLunch("tuesday"));
            Assert.AreEqual("Pancakes and pea soup", lab.WhatIsForLunch("tue"));
            Assert.AreEqual("Pancakes and pea soup", lab.WhatIsForLunch("2"));

            Assert.AreEqual("Winter vegetable stew", lab.WhatIsForLunch("WEDNESDAY"));
            Assert.AreEqual("Winter vegetable stew", lab.WhatIsForLunch("Wednesday"));
            Assert.AreEqual("Winter vegetable stew", lab.WhatIsForLunch("wednesday"));
            Assert.AreEqual("Winter vegetable stew", lab.WhatIsForLunch("wed"));
            Assert.AreEqual("Winter vegetable stew", lab.WhatIsForLunch("3"));

            Assert.AreEqual("Spinach and garlic pasta", lab.WhatIsForLunch("THURSDAY"));
            Assert.AreEqual("Spinach and garlic pasta", lab.WhatIsForLunch("Thursday"));
            Assert.AreEqual("Spinach and garlic pasta", lab.WhatIsForLunch("thursday"));
            Assert.AreEqual("Spinach and garlic pasta", lab.WhatIsForLunch("thu"));
            Assert.AreEqual("Spinach and garlic pasta", lab.WhatIsForLunch("4"));

            Assert.AreEqual("Sliders", lab.WhatIsForLunch("FRIDAY"));
            Assert.AreEqual("Sliders", lab.WhatIsForLunch("Friday"));
            Assert.AreEqual("Sliders", lab.WhatIsForLunch("friday"));
            Assert.AreEqual("Sliders", lab.WhatIsForLunch("fri"));
            Assert.AreEqual("Sliders", lab.WhatIsForLunch("5"));

            Assert.AreEqual("Black bean quesadillas", lab.WhatIsForLunch("SATURDAY"));
            Assert.AreEqual("Black bean quesadillas", lab.WhatIsForLunch("Saturday"));
            Assert.AreEqual("Black bean quesadillas", lab.WhatIsForLunch("saturday"));
            Assert.AreEqual("Black bean quesadillas", lab.WhatIsForLunch("sat"));
            Assert.AreEqual("Black bean quesadillas", lab.WhatIsForLunch("6"));

            Assert.AreEqual("Raw food salad", lab.WhatIsForLunch("SUNDAY"));
            Assert.AreEqual("Raw food salad", lab.WhatIsForLunch("Sunday"));
            Assert.AreEqual("Raw food salad", lab.WhatIsForLunch("sunday"));
            Assert.AreEqual("Raw food salad", lab.WhatIsForLunch("sun"));
            Assert.AreEqual("Raw food salad", lab.WhatIsForLunch("7"));


        }

        [TestMethod]
        public void IsBathReady()
        {
            Assert.IsTrue(lab.IsTheBathReady("YES", 37));
            Assert.IsTrue(lab.IsTheBathReady("Yes", 37));
            Assert.IsTrue(lab.IsTheBathReady("yes", 37));
            Assert.IsTrue(lab.IsTheBathReady("y", 37));
            Assert.IsTrue(lab.IsTheBathReady("Y", 37));

            Assert.IsFalse(lab.IsTheBathReady("NO", 37));
            Assert.IsFalse(lab.IsTheBathReady("No", 37));
            Assert.IsFalse(lab.IsTheBathReady("N", 37));
            Assert.IsFalse(lab.IsTheBathReady("no", 37));
            Assert.IsFalse(lab.IsTheBathReady("n", 37));

            Assert.IsFalse(lab.IsTheBathReady("YES", 29));
            Assert.IsFalse(lab.IsTheBathReady("YES", 49));
        }

        [TestMethod]
        public void DivideAndRound()
        {
            Assert.AreEqual((4 / 2), lab.DivideAndRound(4, 2));
            Assert.AreEqual(Math.Ceiling(1 / 1.9), lab.DivideAndRound(1, 1.9));
            Assert.AreEqual(Math.Floor(1/2.5), lab.DivideAndRound(1, 2.5));
            Assert.AreEqual(Math.Ceiling(25.0 / 10), lab.DivideAndRound(25, 10));

        }
        [TestMethod]
        public void DivideWithReminder()
        {
            Assert.AreEqual("5 divided by 2 gives 2, remainder 1.", lab.DivideWithRemainder(5, 2));
            Assert.AreEqual("424 divided by 8 gives 53, remainder 0.", lab.DivideWithRemainder(424, 8));
            Assert.AreEqual("424 divided by 8 gives 53, remainder 0.", lab.DivideWithRemainder(424, 8));

        }
        [TestMethod]
        public void CanJoyRide()
        {
            Assert.IsFalse(lab.CanJoyride(18, 128, true));
            Assert.IsTrue(lab.CanJoyride(12, 150, false));
            Assert.IsTrue(lab.CanJoyride(80, 210, false));
            Assert.IsTrue(lab.CanJoyride(30, 170, false));

            Assert.IsTrue(lab.CanJoyride(18, 149, false));
            Assert.IsTrue(lab.CanJoyride(25, 130, false));

            Assert.IsFalse(lab.CanJoyride(7, 149, false));
            Assert.IsFalse(lab.CanJoyride(11, 130, false));
            Assert.IsFalse(lab.CanJoyride(8, 80, true));

            Assert.IsFalse(lab.CanJoyride(18, 211, false));
            Assert.IsFalse(lab.CanJoyride(32, 220, true));
            Assert.IsFalse(lab.CanJoyride(72, 240, false));

            Assert.IsFalse(lab.CanJoyride(18, 129, false));
            Assert.IsFalse(lab.CanJoyride(25, 100, true));

        }

        [TestMethod]
        public void DateDistance()
        {

            Assert.AreEqual("1 year(s), 1 month(s), and 1 day(s).", lab.DateDistance(2, 2, 2, 1, 1, 1));
            Assert.AreEqual("2 year(s), 10 month(s), and 5 day(s).", lab.DateDistance(2030, 20, 20, 2028, 10, 15));

            Assert.AreEqual("1 year(s), 1 month(s), and 1 day(s).", lab.DateDistance(0, 0, 0, 1, 1, 1));
            Assert.AreEqual("2645 year(s), 4 month(s), and 7 day(s).", lab.DateDistance(400, 4, 0, 3045, 8, 7));

            Assert.AreEqual("0 year(s), 0 month(s), and 0 day(s).", lab.DateDistance(1, 1, 1, 1, 1,1 ));
            Assert.AreEqual("0 year(s), 0 month(s), and 0 day(s).", lab.DateDistance(540, 3, 13, 540, 3, 13));

            Assert.AreEqual("1 year(s), 1 month(s), and 0 day(s).", lab.DateDistance(1, 0, 0, 0, 1, 0));
            Assert.AreEqual("1 year(s), 1 month(s), and 0 day(s).", lab.DateDistance(0, 1, 0, 1, 0, 0));
            Assert.AreEqual("1 year(s), 0 month(s), and 1 day(s).", lab.DateDistance(0, 0, 1, 1, 0, 0));
            Assert.AreEqual("3030 year(s), 7 month(s), and 4 day(s).", lab.DateDistance(4030, 5, 20, 1000, 12, 16));


        }

        [TestMethod]
        public void IsLapYear()
        {

            Assert.IsFalse(lab.IsLeapYear(750));
            Assert.IsFalse(lab.IsLeapYear(93));
            Assert.IsFalse(lab.IsLeapYear(14523));

            Assert.IsTrue(lab.IsLeapYear(80));
            Assert.IsTrue(lab.IsLeapYear(1220));

            Assert.IsFalse(lab.IsLeapYear(1300));
            Assert.IsFalse(lab.IsLeapYear(80200));

            Assert.IsTrue(lab.IsLeapYear(400));
            Assert.IsTrue(lab.IsLeapYear(4800));
            Assert.IsTrue(lab.IsLeapYear(52400));
        }

        [TestMethod]
        public void RepeatString()
        {

            Assert.AreEqual("", lab.RepeatString("", 0));
            Assert.AreEqual("", lab.RepeatString("", 4));
            Assert.AreEqual("", lab.RepeatString("", -2));

            Assert.AreEqual("Only once please ", lab.RepeatString("Only once please ", 1));
            Assert.AreEqual("someone someone someone ", lab.RepeatString("someone ", 3));
        }

        [TestMethod]
        public void MultiplicationSum()
        {

            Assert.AreEqual("0", lab.MultiplicationTableSum(0, 0, 0));
            Assert.AreEqual("0", lab.MultiplicationTableSum(1, 0, 0));
            Assert.AreEqual("0", lab.MultiplicationTableSum(-1, 1, 1));

            Assert.AreEqual("(1*0)+(1*1) = 0+1 = 1", lab.MultiplicationTableSum(1, 0, 1));
            Assert.AreEqual("(1*1)+(1*2) = 1+2 = 3", lab.MultiplicationTableSum(1, 1, 2));
            Assert.AreEqual("(2*0)+(2*1)+(2*2)+(2*3) = 0+2+4+6 = 12", lab.MultiplicationTableSum(2, 0, 3));

            Assert.AreEqual("(1*1)+(1*0) = 1+0 = 1", lab.MultiplicationTableSum(1, 1, 0));
            Assert.AreEqual("(1*2)+(1*1) = 2+1 = 3", lab.MultiplicationTableSum(1,2, 1));
            Assert.AreEqual("(2*3)+(2*2)+(2*1)+(2*0) = 6+4+2+0 = 12", lab.MultiplicationTableSum(2, 3, 0));
            Assert.AreEqual("(2*4)+(2*3)+(2*2)+(2*1) = 8+6+4+2 = 20", lab.MultiplicationTableSum(2, 4, 1));
            Assert.AreEqual("(2*6)+(2*5)+(2*4)+(2*3) = 12+10+8+6 = 36", lab.MultiplicationTableSum(2, 6, 3));

            Assert.AreEqual("(3*-2)+(3*-1)+(3*0)+(3*1)+(3*2) = -6+-3+0+3+6 = 0", lab.MultiplicationTableSum(3, -2, 2));
            Assert.AreEqual("(10*-1)+(10*0)+(10*1)+(10*2) = -10+0+10+20 = 20", lab.MultiplicationTableSum(10, -1, 2));

            Assert.AreEqual("(3*2)+(3*1)+(3*0)+(3*-1)+(3*-2) = 6+3+0+-3+-6 = 0", lab.MultiplicationTableSum(3, 2, -2));
            Assert.AreEqual("(10*1)+(10*0)+(10*-1)+(10*-2) = 10+0+-10+-20 = -20", lab.MultiplicationTableSum(10, 1, -2));


            Assert.AreEqual("(5*-4)+(5*-3)+(5*-2) = -20+-15+-10 = -45", lab.MultiplicationTableSum(5,-4,-2));
            Assert.AreEqual("(2*-10)+(2*-9) = -20+-18 = -38", lab.MultiplicationTableSum(2,-10,-9));

            Assert.AreEqual("(5*-2)+(5*-3)+(5*-4) = -10+-15+-20 = -45", lab.MultiplicationTableSum(5,-2,-4));
            Assert.AreEqual("(2*-9)+(2*-10) = -18+-20 = -38", lab.MultiplicationTableSum(2,-9,-10));







        }




    }
}
