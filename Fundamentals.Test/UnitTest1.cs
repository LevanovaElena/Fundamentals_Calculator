using System;
using Xunit;
using Fundamentals;

namespace Fundamentals.Test
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldCalculator()
        {
            Calculator calc = new Calculator();


        }

        [Fact]
        public void Add()
        {
            double rez = Calculator.DoOperation(12, 10, "a");
            Assert.Equal(22, rez);
        }

        [Fact]
        public void Substract()
        {
            double rez = Calculator.DoOperation(12, 10, "s");
            Assert.Equal(2, rez);
            rez = Calculator.DoOperation(0, 10, "s");
            Assert.Equal(-10, rez);
        }

        [Fact]
        public void Multiply()
        {
            double rez = Calculator.DoOperation(12, 10, "m");
            Assert.Equal(120, rez);
            rez = Calculator.DoOperation(0, 10, "m");
            Assert.Equal(0, rez);
        }
        [Fact]
        public void Divide()
        {
            double rez = Calculator.DoOperation(12, 10, "d");
            Assert.Equal(1.2, rez);
        }
        [Fact]
        public void DivideByZero()
        {
            double rez = Calculator.DoOperation(12, 0, "d");
            Assert.Equal(double.NaN, rez);
        }
        [Fact]
        public void ShouldReturnNunIfOpIsNotValid()
        {
            double rez = Calculator.DoOperation(12, 0, "k");
            Assert.Equal(double.NaN, rez);
        }
    }
}
