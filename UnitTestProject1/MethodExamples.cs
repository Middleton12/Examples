using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //--Whole Numbrers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16;
            Int16 anotherSmallNumber = 16;
            int wholeNumber = 32;
            long LargeWholeNumber = 64;



            //--Decimals
            float floatExample = 1.234567f;
            double doubleExample = 1.37909d;
            decimal decimalExample = 1.70000m;

            //--Character
            char letter = 'j';



            //--Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int dif = numOne - numTwo;
            Console.WriteLine(dif);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int remainder = numOne % numTwo;

            Console.WriteLine("Hello");
        }

        [TestMethod]
        public void ReferanceTypes()
        {
            //--Strings
            string stringExamples = "This is a string";
            string name = "Joshua";
            string declared;
            declared = "Now it's intialized"; 

            //--Formatting strings
            string concatenate = stringExamples + " "+ name;                       // This is a string Joshua 
            string interpolate = $"{name}. Here is the string: {stringExamples}."; // Joshua. Here is the string: This is a string.
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);


            //--Other Ojects Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2019, 6, 29);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);

            //--Collections
            //--Arrays
            string anotherExampleString = "Hello World";
            string[] stringarray = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(stringarray);

            //--Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Joshua");

            //Queues

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            // Dictionaies
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");


            // Other Collections
            SortedList<int, string> SsortedKeyValuePair = new SortedList<int, string>();

            // Booleans
            bool isTure = 17 > 5;
            bool isFalse = 17 == 4;

        }

        [TestMethod]

        public void IfElseStatement()
        {
            bool isTrue = true;
         
        }
    }
}
