using System;
using System.Collections.Generic;
using System.Linq;

namespace TestEPAM
{
    public static class Functions
    {
        public static int[] SortIntArray(int[] intArray)
        {
            //Print out initial array
            Console.WriteLine("Initial:");
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }

            //This biult-in function can be used
            //Array.Sort(intArray);

            //My solution
            int movedInt;
            //loop through 0 to array.length
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                // loop through i + 1 to array.length
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    // compare array element with the next one
                    if (intArray[i] > intArray[j])
                    {
                        movedInt = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = movedInt;
                    }
                }
            }

            //Print out result
            Console.WriteLine("\nResult:");
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            
            return intArray;
        }

        public static bool Contains(int[] intArray, int soughtInt)
        {
            //This built-in functionality can be used
            //return intArray.Contains(soughtInt);

            //Loop through each element
            foreach(int i in intArray)
            {
                //Compare
                if(i == soughtInt)
                {
                    return true;
                }
            }

            return false;
        }

        public static void FindUniqueWords(string text)
        {
            //Split in words first
            string [] splitArray = text.Split(' ');
            List<string> splitList = splitArray.ToList();

            //Built-in Linq function
            //List<string> castList = splitList.GroupBy(w => w.Replace(",", "").Replace(".", "")).
            //    Where(g => g.Count() == 1).Select(g => g.Key).ToList();

            //My solution
            for(int i = 0; i < splitList.Count; i++)
            {
                splitList[i] = splitList[i].Replace(",", "").Replace(".", "");
            }

            List<string> castList = new List<string>();
            List<string> nonUniqueList = new List<string>();
            foreach (string s in splitList)
            {
                //Adding non-unique words to a separate list
                if (castList.Contains(s))
                {
                    nonUniqueList.Add(s);
                }

                //Composing a list with all words
                castList.Add(s);
            }

            //Removing non-unique words
            foreach (string s in nonUniqueList)
            {
                castList.RemoveAll(x => x == s);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Unique words:");
            foreach (string s in castList)
            {
                Console.WriteLine(s);
            }
        }

        public static ulong Factorial(ulong i)
        {
            ulong fact = 1;
            
            for(ulong j = 1; j <= i; j++)
            {
                fact = fact * j;
            }

            Console.WriteLine();
            Console.WriteLine("Factorial:");
            Console.WriteLine(fact);
            return fact;
        }

        public static bool IsValidString(string text)
        {
            //Splitting the string to an array of chars
            char[] arr = text.ToCharArray();
            bool result = true;

            //List of uncoupled opening braces
            List<char> listChar = new List<char>();

            //Looping through the array
            foreach(char c in arr)
            {
                //Checking if the element is a certain opening character
                if (c == '(' || c == '[' || c == '{')
                {
                    //Adding the opening character to the list
                    listChar.Add(c);
                }
                //Checking if the element is a certain closing character
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (listChar.Count != 0)
                    {
                        //Checking whether the opening and the closing characters match
                        if (isSameType(listChar[listChar.Count - 1], c))
                        {
                            //Removing verified characters from the list
                            listChar.RemoveAt(listChar.Count - 1);
                        }
                        else
                        {
                            result = false;
                            break;
                        }
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }

            //Last check
            if(result == true && listChar.Count != 0)
            {
                result = false;
            }

            //Showing result
            Console.WriteLine("\nIs string valid:");
            Console.WriteLine(result);

            return result;
        }

        private static bool isSameType(char one, char two)
        {
            if(one == '(' && two == ')')
            {
                return true;
            }else if(one == '[' && two == ']')
            {
                return true;
            }
            else if (one == '{' && two == '}')
            {
                return true;
            }

            return false;
        }
    }
}