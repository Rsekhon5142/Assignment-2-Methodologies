using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_2;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Input_Scalene45_35_30ExpectScalene()
        {
            //Arrange
            int triSide1 = 45;
            int triSide2 = 35;
            int triSide3 = 30;
            string ExpectedOutput = "Scalene triangle";

            //Act
            string ActualOutput = Traiangle_solver.Analyze(triSide1, triSide2, triSide3);

            //Assert
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }

        [Test]
        public void Input_Isosceles70_70_35ExpectIsosceles()
        {
            //Arrange
            int triSide1 = 70;
            int triSide2 = 70;
            int triSide3 = 35;
            string ExpectedOutput = "Isosceles triangle";

            //Act
            string ActualOutput = Traiangle_solver.Analyze(triSide1, triSide2, triSide3);

            //Assert
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }
        [Test]
        public void Input_Equilateral70_70_70ExpectEquilateral()
        {
            //Arrange
            int triSide1 = 70;
            int triSide2 = 70;
            int triSide3 = 70;
            string ExpectedOutput = "Equilateral triangle";

            //Act
            string ActualOutput = Traiangle_solver.Analyze(triSide1, triSide2, triSide3);

            //Assert
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }
        [Test]
        public void Input_BiggerVal7000_70_70ExpectTriangleCannotBeFormed()
        {
            //Arrange
            int triSide1 = 7000;
            int triSide2 = 70;
            int triSide3 = 70;
            string ExpectedOutput = "Triangle cannot be formed";

            //Act
            string ActualOutput = Traiangle_solver.Analyze(triSide1, triSide2, triSide3);

            //Assert
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }
        [Test]
        public void Input_Smaller1_7000_70ExpectTriangleCannotBeFormed()
        {
            //Arrange
            int triSide1 = 1;
            int triSide2 = 7000;
            int triSide3 = 70;
            string ExpectedOutput = "Triangle cannot be formed";

            //Act
            string ActualOutput = Traiangle_solver.Analyze(triSide1, triSide2, triSide3);

            //Assert
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }
        [Test]
        public void Input_Zero0_0_0ExpectEquilateral()
        {
            //Arrange
            int triSide1 = 0;
            int triSide2 = 0;
            int triSide3 = 0;
            string ExpectedOutput = "Invalid triangle dimensions";

            //Act
            string ActualOutput = Traiangle_solver.Analyze(triSide1, triSide2, triSide3);

            //Assert
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }
        [Test]
        public void Input_Negative70_80_90ExpectInvalid_Triangle_Dimensions()
        {
            //Arrange
            int triSide1 = -70;
            int triSide2 = 80;
            int triSide3 = 90;
            string ExpectedOutput = "Invalid triangle dimensions";

            //Act
            string ActualOutput = Traiangle_solver.Analyze(triSide1, triSide2, triSide3);

            //Assert
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }
        [Test]
        public void Input_7_8_6ExpectScalene()
        {
            //Arrange
            int triSide1 = 7;
            int triSide2 = 8;
            int triSide3 = 6;
            string ExpectedOutput = "Scalene triangle";

            //Act
            string ActualOutput = Traiangle_solver.Analyze(triSide1, triSide2, triSide3);

            //Assert
            Assert.AreEqual(ExpectedOutput, ActualOutput);
        }

    }
}
