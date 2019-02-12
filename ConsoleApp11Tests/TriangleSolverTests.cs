
using ConsoleApp11;
using System;
using NUnit.Framework;

namespace ConsoleApp11.Tests
{
    [TestFixture]
    public class TriangleSolverTests
    {
        [Test]
        public void Sides2and3and4forNotPossible()
        {
            //Arrange
            int s1 = 2, s2 = 3, s3 = 5;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "Triangle cannot be possible");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Sides2and2and2forEquilateral()
        {
            //Arrange
            int s1 = 2, s2 = 2, s3 = 2;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "This is an Equilateral Triangle");
            Console.WriteLine("Please check the result");
        }


        [Test]
        public void Sides10and5and6forScalene()
        {
            //Arrange
            int s1 = 10, s2 = 5, s3 = 6;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "This is a Scalene Triangle");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Sides5and3and3forIsosceles()
        {
            //Arrange
            int s1 = 5, s2 = 3, s3 = 3;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "This is an Isosceles Triangle");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Sides6and6and3forIsosceles()
        {
            //Arrange
            int s1 = 6, s2 = 6, s3 = 3;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "This is an Isosceles Triangle");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void Sides0and3and6forNotPossible()
        {
            //Arrange
            int s1 = 0, s2 = 3, s3 = 6;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "Triangle cannot be possible");
            Console.WriteLine("Please check the result");
        }


        [Test]
        public void SidesNegativeand3and6forNotPossible()
        {
            //Arrange
            int s1 = -3, s2 = 3, s3 = 6;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "Triangle cannot be possible");
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void TwoSidesNegativeand3and6forNotPossible()
        {
            //Arrange
            int s1 = -3, s2 = -3, s3 = 6;

            //Act
            String length = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(length, "Triangle cannot be possible");
            Console.WriteLine("Please check the result");
        }



    }
}

       