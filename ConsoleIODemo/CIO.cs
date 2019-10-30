using System;
using System.Collections.Generic;

namespace CSC160_ConsoleMenu
{
    public static class CIO
    {
        public static int PromptForMenuSelection(IEnumerable<string> options, bool withQuit)
        {
            string input = "";
            int userChoice = 1;

            int count = 0;
            if (withQuit == false)
            {
                foreach (string menu in options)
                {

                    Console.WriteLine((count += 1) + ") " + menu);

                }
                bool menuStop = false;
                do
                {
                    Console.Write("Please, select option: ");
                    try
                    {
                        input = Console.ReadLine();
                        userChoice = int.Parse(input);
                        if (userChoice < 1 || userChoice > count)
                        {
                            Console.WriteLine("Menu option not selected");
                        }
                        else
                        {
                            menuStop = true;
                        }

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Not a number. Re-enter");
                    }
                    catch (ArgumentNullException d)
                    {
                        Console.WriteLine("NULL. Re-enter");
                    }



                } while (!menuStop);

            }
            else if (withQuit == true)
            {
                foreach (string menu in options)
                {

                    Console.WriteLine((count += 1) + ") " + menu);

                }
                Console.WriteLine();
                Console.WriteLine("0) QUIT");
                bool menuStop = false;
                do
                {
                    Console.Write("Please, select option: ");
                    try
                    {
                        input = Console.ReadLine();
                        userChoice = int.Parse(input);
                        if (userChoice < 0 || userChoice > count)
                        {
                            Console.WriteLine("Menu option not selected");
                        }
                        else
                        {
                            menuStop = true;
                        }

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Not a number. Re-enter");
                    }
                    catch (ArgumentNullException d)
                    {
                        Console.WriteLine("NULL. Re-enter");
                    }catch(OverflowException oe)
                    {
                        Console.WriteLine("Invalid");
                    }
                } while (!menuStop);
            }
            return userChoice;

        }

        public static bool PromptForBool(string message, string trueString, string falseString)
        {
            bool a = true;
            bool stop = false;
            string input = "";
            
            do
            {
                Console.WriteLine(message);
                Console.WriteLine(trueString);
                Console.WriteLine(falseString);
               Console.WriteLine("Enter your answer: ");
                      input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    stop = true;
                    Console.WriteLine("Null / Empty String");
                }
                if (string.Equals(input, trueString))
                {
                    a = true;
                    stop= true;
                }
                else if (string.Equals(input, falseString))
                {
                    a = false;
                    stop = true;
                }

            } while (!stop);
            return a;
        }

        public static byte PromptForByte(string message, byte min, byte max)
        {

            byte userNum = 1;
            bool valid = false;

            do
            {
                if (string.IsNullOrEmpty(message))
                {
                    Console.WriteLine("Empty String. Please Re-input message");
                    userNum = 1;
                    valid = true;

                }
                else if (min < Byte.MinValue || max > Byte.MaxValue)
                {
                    Console.WriteLine("Input outside of byte range");
                    valid = false;
                }
                else
                {
                    Console.WriteLine(message);
                    try
                    {
                        string input = Console.ReadLine();
                        userNum = byte.Parse(input);
                        if (userNum < min || userNum > max || userNum < byte.MinValue || userNum > byte.MaxValue)
                        {
                            Console.WriteLine("Outside min and max");
                            valid = false;
                        }
                        else
                        {
                            valid = true;
                        }

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Not a byte");
                    }
                    catch (OverflowException f)
                    {
                        Console.WriteLine("Out of range");
                    }
                    catch (ArgumentNullException d)
                    {
                        Console.WriteLine("Null Argument");
                    }

                }
                // valid = true;
            } while (!valid);
            return userNum;
        }

        public static short PromptForShort(string message, short min, short max)
        {
            short userNum = 1;
            bool valid = false;

            do
            {
                if (string.IsNullOrEmpty(message))
                {
                    Console.WriteLine("Empty String. Please Re-input message");
                    userNum = 1;
                    valid = true;

                }
                else if (min < short.MinValue || max > short.MaxValue)
                {
                    Console.WriteLine("Input outside of short range");
                    valid = false;
                }
                else
                {
                    Console.WriteLine(message);
                    try
                    {
                        string input = Console.ReadLine();
                        userNum = short.Parse(input);
                        if (userNum < min || userNum > max || userNum < short.MinValue || userNum > short.MaxValue)
                        {
                            Console.WriteLine("Outside min and max");
                            valid = false;
                        }
                        else
                        {
                            valid = true;
                        }

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Not a short value");
                    }
                    catch (OverflowException f)
                    {
                        Console.WriteLine("Out of range");
                    }
                    catch (ArgumentNullException d)
                    {
                        Console.WriteLine("Null Argument");
                    }

                }
                // valid = true;
            } while (!valid);
            return userNum;
        }

        public static int PromptForInt(string message, int min, int max)
        {
            int userNum = 1;
            bool valid = false;

            do
            {
                if (string.IsNullOrEmpty(message))
                {
                    Console.WriteLine("Empty String. Please Re-input message");
                    userNum = 1;
                    valid = true;

                }
                else if (min < int.MinValue || max > int.MaxValue)
                {
                    Console.WriteLine("Input outside of Integer Range");
                    valid = false;
                }
                else
                {
                    Console.WriteLine(message);
                    try
                    {
                        string input = Console.ReadLine();
                        userNum = int.Parse(input);
                        if (userNum < min || userNum > max || userNum < int.MinValue || userNum > int.MaxValue)
                        {
                            Console.WriteLine("Outside min and max");
                            valid = false;
                        }
                        else
                        {
                            valid = true;
                        }

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Not a Integer");
                    }
                    catch (OverflowException f)
                    {
                        Console.WriteLine("Out of range");
                    }
                    catch (ArgumentNullException d)
                    {
                        Console.WriteLine("Null Argument");
                    }

                }
                // valid = true;
            } while (!valid);
            return userNum;
        }

        public static long PromptForLong(string message, long min, long max)
        {
            long userNum = 1;
            bool valid = false;

            do
            {
                if (string.IsNullOrEmpty(message))
                {
                    Console.WriteLine("Empty String. Please Re-input message");
                    userNum = 1;
                    valid = true;

                }
                else if (min < long.MinValue || max > long.MaxValue)
                {
                    Console.WriteLine("Input outside of Long range");
                    valid = false;
                }
                else
                {
                    Console.WriteLine(message);
                    try
                    {
                        string input = Console.ReadLine();
                        userNum = long.Parse(input);
                        if (userNum < min || userNum > max || userNum < long.MinValue || userNum > long.MaxValue)
                        {
                            Console.WriteLine("Outside min and max");
                            valid = false;
                        }
                        else
                        {
                            valid = true;
                        }

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Not a Long");
                    }
                    catch (OverflowException f)
                    {
                        Console.WriteLine("Out of range");
                    }
                    catch (ArgumentNullException d)
                    {
                        Console.WriteLine("Null Argument");
                    }

                }
                // valid = true;
            } while (!valid);
            return userNum;
        }

        public static float PromptForFloat(string message, float min, float max)
        {
            float userNum = 1;
            bool valid = false;

            do
            {
                if (string.IsNullOrEmpty(message))
                {
                    Console.WriteLine("Empty String. Please Re-input message");
                    userNum = 1;
                    valid = true;

                }
                else if (min < float.MinValue || max > float.MaxValue)
                {
                    Console.WriteLine("Input outside of Float Range");
                    valid = false;
                }
                else
                {
                    Console.WriteLine(message);
                    try
                    {
                        string input = Console.ReadLine();
                        userNum = float.Parse(input);
                        if (userNum < min || userNum > max || userNum < float.MinValue || userNum > float.MaxValue)
                        {
                            Console.WriteLine("Outside min and max");
                            valid = false;
                        }
                        else
                        {
                            valid = true;
                        }

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Not a Float");
                    }
                    catch (OverflowException f)
                    {
                        Console.WriteLine("Out of range");
                    }
                    catch (ArgumentNullException d)
                    {
                        Console.WriteLine("Null Argument");
                    }

                }
                // valid = true;
            } while (!valid);
            return userNum;
        }

        public static double PromptForDouble(string message, double min, double max)
        {
            double userNum = 1;
            bool valid = false;

            do
            {
                if (string.IsNullOrEmpty(message))
                {
                    Console.WriteLine("Empty String. Please Re-input message");
                    userNum = 1;
                    valid = true;

                }
                else if (min < double.MinValue || max > double.MaxValue)
                {
                    Console.WriteLine("Input outside of Double range");
                    valid = false;
                }
                else
                {
                    Console.WriteLine(message);
                    try
                    {
                        string input = Console.ReadLine();
                        userNum = double.Parse(input);
                        if (userNum < min || userNum > max || userNum < double.MinValue || userNum > double.MaxValue)
                        {
                            Console.WriteLine("Outside min and max");
                            valid = false;
                        }
                        else
                        {
                            valid = true;
                        }

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Not a Double");
                    }
                    catch (OverflowException f)
                    {
                        Console.WriteLine("Out of range");
                    }
                    catch (ArgumentNullException d)
                    {
                        Console.WriteLine("Null Argument");
                    }

                }
                // valid = true;
            } while (!valid);
            return userNum;
        }

        public static decimal PromptForDecimal(string message, decimal min, decimal max)
        {
            decimal userNum = 1;
            bool valid = false;

            do
            {
                if (string.IsNullOrEmpty(message))
                {
                    Console.WriteLine("Empty String. Please Re-input message");
                    userNum = 1;
                    valid = true;

                }
                else if (min < decimal.MinValue || max > decimal.MaxValue)
                {
                    Console.WriteLine("Input outside of decimal range");
                    valid = false;
                }
                else
                {
                    Console.WriteLine(message);
                    try
                    {
                        string input = Console.ReadLine();
                        userNum = decimal.Parse(input);
                        if (userNum < min || userNum > max || userNum < decimal.MinValue || userNum > decimal.MaxValue)
                        {
                            Console.WriteLine("Outside min and max");
                            valid = false;
                        }
                        else
                        {
                            valid = true;
                        }

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Not a Decimal");
                    }
                    catch (OverflowException f)
                    {
                        Console.WriteLine("Out of range");
                    }
                    catch (ArgumentNullException d)
                    {
                        Console.WriteLine("Null Argument");
                    }

                }
                // valid = true;
            } while (!valid);
            return (decimal)userNum;
        }

        public static string PromptForInput(string message, bool allowEmpty)
        {

            string userInput = "";
            bool valid = false;
            do
            {
                if (string.IsNullOrEmpty(message))
                {

                    Console.WriteLine("Empty Prompt. Please re-enter");
                    valid = true;

                }

                Console.WriteLine(message);
                userInput = Console.ReadLine();

                if (allowEmpty == true)
                {
                    if (string.IsNullOrEmpty(userInput))
                    {

                        Console.WriteLine(userInput);
                        valid = true;

                    }
                }
                else if (allowEmpty == false)
                {
                    if (string.IsNullOrEmpty(userInput))
                    {

                        Console.WriteLine("Empty Strings not allowed");

                        valid = false;

                    }
                    else
                    {
                        Console.WriteLine(userInput);
                        valid = true;
                    }
                }

            } while (!valid);
            return userInput;
        }

        public static char PromptForChar(string message, char min, char max)
        {

            string userInput = "";
            char[] c = { 'a', 'b', 'c' };
            bool valid = false;
            do
            {
                if (string.IsNullOrEmpty(message))
                {

                    Console.WriteLine("Empty Prompt. Please re-enter");
                    valid = true;

                }

                Console.WriteLine(message);
                try
                {
                    userInput = Console.ReadLine();
                c = userInput.ToCharArray();
                }catch(IndexOutOfRangeException io)
                {
                    valid = false;
                }catch(ArgumentNullException ane)
                {
                    valid = false;
                }catch(NullReferenceException nre)
                {
                    valid = false;
                }

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Char not entered. Please re-enter");
                    
                    valid = false;
                }
                else if (userInput.Length > 1)
                {
                    Console.WriteLine("Only one Char is allowed. Please re-enter");
                    valid = false;
                }
                //else if(((int)char.GetNumericValue(c[0]) < (int)char.GetNumericValue(min) || (int)char.GetNumericValue(c[0]) > (int)char.GetNumericValue(max)))
                //{
                //    Console.WriteLine("Outside min and max");
                //    valid = false;
                //}
                else if (((int)(c[0]) > (int)(min-1) && (int)(c[0]) < (int)(max+1)))
                {
                    
                    valid = true;
                }
                else
                {
                    valid = false;
                    Console.WriteLine("Invalid. Out of Range");
                }
                 



            } while (!valid);

            return c[0];
        }
    }
}

