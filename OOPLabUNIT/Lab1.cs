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
    public class Lab1
    {
        /// <summary> 1
        /// Metoden tar emot värdena på 2st. heltal, "x" och "y" och adderar dessa.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Returnerar summan ax "x" och "y"</returns>
        public int Add(int x, int y)
        {
            return x + y; 
        }

        /// <summary> 2
        /// Metoden tar emot värdena, i heltal, på "x" och "y" - subtraherar sedan "y" från "x".
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Returnerar resultatet av uträkningen "x" - "y"</returns>
        public int Subtract(int x, int y)
        {
            return x - y;
        }

        /// <summary> 3
        /// Metoden tar emot heltalsvärdena på "x" och "y" och multiplicerar dessa med varandra.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Returnerar resultat av uträkningen "x" * "y"</returns>
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        /// <summary> 4
        /// Metoden tar emot värdena på "numerator" och "denominator" och dividerar det förstnämnda med det andra.
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns>Returnerar resultatet av uträkningen "numerator" / "denominator"</returns>
        public int DivideIntegers(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        /// <summary> 5 
        /// Medtoden tar användarens input, i strängform, lägger till en en hälsningsfras och returnerar denna tillsammans med input.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string Hello(string name)
        {
            if (name !=null && name.Length > 0) 
            {
               return "Hello, " + name + ".";
            }
            else
            {
               return "Hello, Anonymous.";
            }
        }

        /// <summary> 6
        /// Metoden tar in 2st. bool. Ifall båda är 'true' returneras 'true' - annars returneras 'false'.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool And(bool a, bool b)
        {
            if (a && b == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary> 7
        /// Metoden tar in 2st. bool. Ifall en av dem är 'true' returneras 'true' - annars returneras 'false'.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Or(bool a, bool b)
        {
            if (a || b == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary> 8
        /// Metoden tar in 2st. bool. Ifall den ena är 'true' och den andra 'false' returneras 'true'. Är båda, eller ingen av dem, 'true' returneras 'false'.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Xor(bool a, bool b)
        {
           if (!a==b || !b==a)
           {
               return true;
           }

           else
           {
               return false;
           }
        }

        //summary NOT 9

        public bool Not(bool a)
        {
            if (a==true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //summary 10
        public int Greatest(int x, int y)
        {
            if (x>y)
            {
               return x;
            }
            else 
            {
               return y;
            }                
        }

        /// <summary> 11
        /// Metoden bestämmer vilken av 3 st. variabler som är den största och returnerar denna.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns>Returnerar den integer som är störst av "x", "y" och "z"</returns>
        public int Greatest(int x, int y, int z)
        {
            return (Math.Max(Math.Max(x, y), z));
        }

        /// <summary> 12
        /// Metoden bestämmer vilken av 4 st. variabler som är den största och returnerar denna.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        /// <returns>Returnerar den integer som är störst av "x", "y", "z" och "w"</returns>
        public int Greatest(int x, int y, int z, int w)
        {
            return ((Math.Max(Math.Max(Math.Max(x, y), z), w)));
        }

        /// <summary> 13
        /// Metoden tar 2 st. integer för att bedömma vilken som är störst. En bool matas ut, som är true ifall "x" är större än "y" och false när fallet är det omvända.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Returnerar i bool-form true eller false.</returns>
        public bool IsGreater(int x, int y)
        {
           if (x>y)
           {
              return true;
           }
           else
           {
              return false;
           }

        }

        /// <summary> 14
        /// Metoden tar emot en integer och konverterar denna till en sträng.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>En sträng returneras innehållande siffran från "number" konverterad till text-form.</returns>
        public string IntToString(int number)
        {
            return Convert.ToString(number);
        }

        /// <summary> 15
        /// Metoden tar emot en sträng och konverterar denna till en integer.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returnerar en integer innehållande den siffra som angavs i "number", koverterad. </returns>
        public int StringToInt(string number)
        {
            return Convert.ToInt32(number);
        }

        /// <summary> 16
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public double DivideExact(double numerator, double denominator)
        {
            return numerator / denominator; 
        }

        /// <summary> 17
        /// Metoden tar emot 2 st. integer, koverterar dessa till double och utför sedan mer "exakt" division på dessa. 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns>Returnerar en double innehållande ett mer exakt värde av "numerator" dividerat på "denominator".</returns>
        public double DivideExact(int numerator, int denominator)
        {
            return (double)numerator / denominator;
        }

        /// <summary> 18
        /// Metoden dividerar double "numerator" på "denominator" och trunkerar dessa vid "return".
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns>Returnerar en trunkerad (kapad, utan decimaler) version av divisionen som utförs. </returns>
        public int DivideAndTruncate(double numerator, double denominator)
        {
           double doubleTal =  Math.Truncate(numerator / denominator);
           return Convert.ToInt32(doubleTal);

        }

        /// <summary> 19
        /// Metoden tar emot två st. integer; en som beskriver ryttarens ålder och en som anger dennes vikt. Beroende på vikt och ålder tas antingen en lämplig pony-klass fram, eller ett meddelande som beskriver det faktum att den person som avses inte kan delta.
        /// </summary>
        /// <param name="age"></param>
        /// <param name="weight"></param>
        /// <returns>Ifall åldern är tillräckligt hög och vikten tillräckligt låg returneras en lämplig Pony-klass i sträng form. Ifall ryttaren är för ung eller för tung meddelas detta i strängen istället för Pony-klass-info</returns>
        public string RequestPony(int age, int weight)
        {

            if (age < 12)
            {
                return "Too young to compete.";
            }
            else if (weight > 65)
            {
                return "No ponies available for the given weight class.";
            }
            else if (weight <=30)
            {
                return "Class A pony";
            }
            else if (weight >30 && weight <=50)
            {
                return "Class B pony";
            }
            else if (weight >50 && weight <= 65)
            {
                return "Class C pony";
            } 
            else
            {
                return "error";
            }

       }
        

        /// <summary> 20
        /// Metoden tar basserat på användarens input om veckodag fram information om aktuell lunch.
        /// </summary>
        /// <param name="weekday"></param>
        /// <returns>Retrunerar en sträng som beskriver måltiden vilken serveras den angivna dagen.</returns>
        public string WhatIsForLunch(string weekday)
        {
           if (weekday == "MONDAY" || weekday == "Monday" || weekday == "monday" || weekday == "mon" || weekday == "1" )
           {
               return "Ratatouille";
           }
           else if  (weekday == "TUESDAY" || weekday == "Tuesday" || weekday == "tuesday" || weekday == "tue" || weekday == "2")
           {
               return "Pancakes and pea soup";
           }
           else if (weekday == "WEDNESDAY" || weekday == "Wednesday" || weekday == "wednesday" || weekday == "wed" ||weekday == "3")
           {
               return "Winter vegetable stew";
           }
           else if (weekday == "THURSDAY" || weekday == "Thursday" || weekday == "thursday" || weekday == "thu" ||weekday == "4")
           {
               return "Spinach and garlic pasta";
           }
           else if (weekday == "FRIDAY" || weekday == "Friday" || weekday == "friday" || weekday == "fri" ||weekday == "5")
           {
               return "Sliders";
           }
           else if (weekday == "SATURDAY" || weekday == "Saturday" || weekday == "saturday" || weekday == "sat" ||weekday == "6")
           {
               return "Black bean quesadillas";
           }
           else if  (weekday == "SUNDAY" || weekday == "Sunday" || weekday == "sunday" || weekday == "sun" ||weekday == "7")
           {
               return "Raw food salad";
           }
           else
           {
               return "Incorrect input";
           }
        }

        /// <summary> 21
        /// Metoden tar emot en sträng som anger om det finns vatten i badkaret samt en integer som anger temperaturen på eventuellt vatten. Ifall det finns vatten och detta är större eller lika med 30 samt mindre eller lika med 48 returneras true, i bool-form. I annat fall returneras det omvända.
        /// </summary>
        /// <param name="hasWater"></param>
        /// <param name="degrees"></param>
        /// <returns>Returnerar en str</returns>
        public bool IsTheBathReady(string hasWater, int degrees)
        {
            if (degrees >30 && degrees <48 && hasWater == "YES" || hasWater == "Yes" || hasWater == "yes" || hasWater == "y" || hasWater == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // summary 22
        public int DivideAndRound(double numerator, double denominator)
        {
            double kvot = numerator / denominator;
            kvot = kvot + 0.5;
            return Convert.ToInt32(Math.Floor(kvot));
        }
         
        /// <summary> 23
        /// Metoden utför modulo och division på på 2 st. integer.
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns>Returnerar resultatet, i strängform, av divisionen samt modulo (resten). </returns>
        public string DivideWithRemainder(int numerator, int denominator)
        {
            int kvot = numerator / denominator;
            int modulo = numerator % denominator;
            return numerator + " divided by " + denominator + " gives " + kvot + ", remainder " + modulo + ".";
        }

        /// <summary> 24
        /// Metoden bestämmer - från en integer med angiven ålder, en integer med angiven längd och en bool som beskriver huruvida det finns hjärtproblem eller eller ej - om angiven person skall få åka karusell.
        /// </summary>
        /// <param name="age"></param>
        /// <param name="cm"></param>
        /// <param name="hasHeartCondition"></param>
        /// <returns>Returnerar false ifall "hasHeartCondition" är true. Returnerar true ifall ålder och längdparametrar uppfyller kraven. </returns>
        public bool CanJoyride(int age, int cm, bool hasHeartCondition)
        {
            if (age >=12 && cm >=130 && cm <=210 && hasHeartCondition == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary> 25
        /// Metoden tar, utan att bedömma validitet, emot två datum och presenterar differens mellan dessa nummer. Tar ej hänsyn till mängden dagar per månad o.s.v.
        /// </summary>
        /// <param name="y1"></param>
        /// <param name="m1"></param>
        /// <param name="d1"></param>
        /// <param name="y2"></param>
        /// <param name="m2"></param>
        /// <param name="d2"></param>
        /// <returns>Returnerar i stängform differensen mellan "y1" - "y2", "m1" - "m2", samt "d1" - "d2". </returns>
        public string DateDistance(int y1, int m1, int d1, int y2, int m2, int d2)
        {
            int differensY = 0;
            int differensM = 0;
            int differensD = 0;

            if (y1 > y2)
            {
                differensY = y1 - y2;
            }
            else
            {
                differensY = y2 - y1;
            }            
            if (m1 > m2)
            {
                differensM = m1 - m2;
            }
            else
            {
                differensM = m2 - m1;
            }
            if (d1 > d2)
            {
                differensD = d1 - d2;
            }
            else
            {
                differensD = d2 - d1;
            }

            return differensY + " year(s), " + differensM + " month(s), and " + differensD + " day(s).";
        }

        /// <summary> 26
        /// Metoden tar emot ett årtal i integer-form och bedömmer huruvida detta är upfyller kraven för ett skottår eller ej. Detta meddelas i bool-form.
        /// </summary>
        /// <param name="year"></param>
        /// <returns>Returnerar true ifall året i fråga är jämt delbart med 4. I de fall där året är ett sekel (jämt delbart med 100) retuneras true ifall det samtidigt är jämt delbart med 400. I alla andra fall returneras false.</returns>
        public bool IsLeapYear(int year)
        {
            if (year % 400 ==0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }        
        }

        /// <summary> 27
        /// Metoden tar emot en sträng med text och en integer som beskriver hur många gånger denna text skall upprepas i retur-strängen.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="times"></param>
        /// <returns>Returnerar en sträng innehållande "text" lika många gånger som "times" beskriver.</returns>
        public string RepeatString(string text, int times)
        {
            
            if (times > 0 && text.Length > 0)
            {
                string ord = "";
                for (int i = 1; i<=times; i++)
                {
                ord = ord + text;
                }
                return ord;
            }   
            else
            {
                return "";
            }
        }

        /// <summary> 28
        /// Metoden tar emot 3 st. integers och multiplicerar "factor" med alla tal från "start" till "end"; vare sig de är i ökande eller minskande ordning, adderar dessa med varandra och skriver sedan uträkningen, förenklingen och summan av dem. Ifall "start" och "end" är desamma returneras endast "0" i strängform.
        /// </summary>
        /// <param name="factor"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns>REturnerar en stäng innehållande resultatet av en ekvation genom att lägga ihop strängar för vänstra sidan, mellersta sidan (förenklingen) och den högra sidan (summan av talen).  </returns>
        public string MultiplicationTableSum(int factor, int start, int end)
        {
            string multiplikation = "";
            string addition = "";
            int summa = 0;

            if (factor <=0 || start == 0 && end == 0)
            {
                return "0";
            }

            if (start > end)
            {
                for (int i = start; i >= end; i--)
                {
                    if (i == end)
                    {
                        summa = summa + (factor * i);
                        multiplikation = multiplikation + "(" + factor + "*" + i + ")";
                        addition = addition + (factor * i);
                    }
                    else
                    {
                    summa = summa + (factor * i);
                    multiplikation = multiplikation + "(" + factor + "*" + i + ")" + "+";
                    addition = addition + (factor * i) + "+";
                    }

                }        
            }
            else if (start < end)
            {
                for (int i = start; i <= end; i++)
                {
                    if (i == end)
                    {
                        summa = summa + (factor * i);
                        multiplikation = multiplikation + "(" + factor + "*" + i + ")";
                        addition = addition + (factor * i);
                    }
                    else
                    {
                        summa = summa + (factor * i);
                        multiplikation = multiplikation + "(" + factor + "*" + i + ")" + "+";
                        addition = addition + (factor * i) + "+";
                    }
                }        
            }

            return multiplikation + " = " + addition + " = " + summa;
        }
    }
}
