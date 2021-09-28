using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Methods
{
    [TestClass]
    public class Methods
    {
        //Input
        //What We Do
        //Output

        //Acces mopdifier----Return Type---Method Signature

        public int AddTwoNumbers(int numOne, int nunTwo)
        {
            int sum = numOne + nunTwo;
            return sum;
        }
        private int SubtractTwoNumbers( int a, int b)
        {
            int num = a - b;
            return num;
        }
        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;
        }
        private int FindRemainder( int a , int numTwo)
        {
            int remainder = a % numTwo;
            return remainder;
        }



        [TestMethod]
        public void TestMethod1()
        {
            int sum = AddTwoNumbers(7, 12);
            int sumTwo = AddTwoNumbers(5, 43);

            Assert.AreEqual(19, sum);
        }
    }
}
