using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* https://www.thecodingguys.net/tutorials/csharp/csharp-switch-statement
             * SYNTAX:
             * switch (expression)
                {

                case constant-expression;
                break;


                default :
                statement

                break;

                }
            */

            // This is a simple Switch Statement and is just like an If Else Statement.
            // First we made a string variable called mystring, and gave it the value null.
            // Then asked the user for their favourite food, took that value and then ran it through the Switch Statement.
            // If you type in something other than "Pizza" or "Chips" you will get the default value.
            // The break keyword is required, as it prevents “falling”.
            // When you insert the break keyword you will not automatically jump to the next case.

            /*
            string mystring = null;
            Console.WriteLine("What is your favourite food?");
            mystring = Console.ReadLine();

            switch (mystring)
            {
                case "Pizza":
                    Console.WriteLine("Hell yeah, pizza!");
                    break;
                case "Chips":
                    Console.WriteLine("Chips are awesome!");
                    break;
                default:
                    Console.WriteLine("I guess it was something healthy!");
                    break;
            }
            Console.ReadLine();

            */

            /* SWITCH STATEMENT RULES:
             * The constant-expressions must be different
             * Switch Statement expressions must be primitive data types (int, string, bool, char); if you want double or float you need to use an If Statement
             * You must always include the break
             * If you need to calculate your case you must use an If Statement
             * Unlike Visual Basic, in C# you cannot use relational operators, you must use an If Statement
             */

            /* ToLower() method
             * we have also converted all the case label keys to lower case. This way the result will be lower case and both will be compared, so when the user types “Pizza” it will be converted to lower case and be compared to the case labels. So whatever the user types, such as “PizZa”, it will become “pizza” and we compare “pizza” to “pizza”.
             */

            /*

            string mystring = null;
            Console.WriteLine("What is your favourite food?");
            mystring = Console.ReadLine();

            switch (mystring.ToLower())
            {
                case "pizza":
                    Console.WriteLine("Oh yeah pizza!");
                    break;
                case "chips":
                    Console.WriteLine("I love chips too!");
                    break;
                default:
                    Console.WriteLine("I guess it was something healthy!");
                    break;
            }

            Console.ReadLine();

            */


            /* GoTo Keyword
             * You can use the goto keyword to go to another case label or move out of the Switch Statement. In the following example, if the user types “20” they will go back to the first label.
             * In the third case label, the goto keyword is used and goes back to the first label, and the output will be “You picked 20”.
             */

            int myNum = 0;


            Console.WriteLine("Please enter a number");
            int.TryParse(Console.ReadLine(), out myNum);

            switch (myNum)
            {
                case 10:
                    Console.WriteLine("You picked " + myNum);
                    break;

                case 15:
                    Console.WriteLine("You picked " + myNum);
                    break;

                case 20:
                    goto case 10;


                default:
                    Console.WriteLine("Didn't catch that");
                    break;

            }
           Console.ReadLine();



        }
    }
}
