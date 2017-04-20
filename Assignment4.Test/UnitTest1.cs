using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Assignment_4
{
    [TestClass]
 
    public class TriangleSolveTest
    {
       //This method is to check that whether there is any zero in the input size of triangle.
        [Test]
        public void zeroCheck()
        {
            NUnit.Framework.Assert.IsFalse(TriangleSolverTest.triangleExists(1, 1, 0)); 

        }

        //This method is to check the positive value of the triangle.
        [Test]
        public void positiveCheck()
        {
            NUnit.Framework.Assert.IsTrue(TriangleSolverTest.triangleExists(7,8,9));

        }
        //This method is to check the negative value of the triangle
        [Test]
        public void negativeCheck()
        {
            NUnit.Framework.Assert.IsFalse(TriangleSolverTest.triangleExists(-5, 8, 9));

        }
        //This method is to check that whether the triangle is formed or not.
        [Test]
        public void triangleCheck()
        {
            NUnit.Framework.Assert.IsTrue(TriangleSolverTest.triangleExists(8, 8, 9));

        }
        //This method is to check if the all sides of triangle are zero.
        [Test]
        public void AllZeroCheck()
        {
            NUnit.Framework.Assert.IsFalse(TriangleSolverTest.triangleExists(0, 0, 0));

        }
        //This method is to check if all sides of triangle are having equal sides.
        [Test]
        public void equilateralCheck()
        {
            NUnit.Framework.Assert.AreEqual("Equilateral Triangle", TriangleSolverTest.Analyze(5,5,5));

        }
        //This method is to check if two sides are equal and one side is different.
        [Test]
        public void isosclesCheck()
        {
            NUnit.Framework.Assert.AreEqual("Isoscles Triangle", TriangleSolverTest.Analyze(5, 5, 6));

        }
        //This method is to check if all the sides of triangle are having different sides.
        [Test]
        public void scaleneCheck()
        {
            NUnit.Framework.Assert.AreEqual("Scalene Triangle", TriangleSolverTest.Analyze(5, 7, 6));

        }


    }
}
