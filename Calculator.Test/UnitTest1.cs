using System;
using Xunit;
using Calculator;
using System.Linq;

namespace Calculator.Test
{
    public class ProgramTest
    {
      
        [Theory]
        [InlineData(new double[]{ 4, 2, 5, 6, 3 },20)]
        [InlineData(new double[] { 4, (-2), 5, 6, 3 }, 16)]
        [InlineData(new double[] { 4, (-2), 5, 6, (-3) }, 10)]
        public void AddValues(double[] TestArray,double expectedResult)
        {
                       
            // Act
            double actualResult = Program.Addition(TestArray);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(new double[] { 4, 2, 5, 6, 3 }, -12)]
        [InlineData(new double[] { 4, (-2), 5, 6, 3 }, -8)]
        [InlineData(new double[] { 4, (-2), 5, 6, (-3) }, -2)]
        public void SubtractValues(double[] TestArray, double expectedResult)
        {
                     
            // Act
            double actualResult = Program.Subtraction(TestArray);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(4,3,12)]
        [InlineData(5,(-2),-10)]
        [InlineData((-4), (-3), 12)]
        public void MultiplyValues(double x , double y , double expectedResult)
        {
            // Act
            double actualResult = Program.Multipicaton(x, y);
            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void DivideValues()
        {
            // Arrange
            double x = 10;
            double y = 2;
            double ExpResult = 5;

            // Act
            double result = Program.Division(x,y);
            // Assert
            Assert.Equal(ExpResult, result);
        }
        [Fact]
        public void SquarerootOfValues()
        {
            // Arrange
            double x = 16;

            double expected = 4;

            // Act
            double result = Program.GetSquareRoot(x);
            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void DividByZero()
        {
            // Arrange

            double x = 10;
            double y = 0;
            double ExpResult = x / y;

            // Act

            double result = Program.Division(x, y);

            //Assert

            Assert.Equal(ExpResult, result);
        }
        [Fact]
        public void DividByZeroWithException()
        {
            double x = 10;
            double y = 0;


            double result = Program.Division(x,y);

            Assert.True(Double.IsInfinity(result));
        }
        [Fact]
        public void DividePrecisionValues()
        {
            // Arrange
            double x = 13;
            double y = 7;
            double ExpResult = 1.857;

            // Act
            double result = Program.Division(x, y);
            // Assert
            Assert.Equal(ExpResult, result,3);
        }
    }
}
