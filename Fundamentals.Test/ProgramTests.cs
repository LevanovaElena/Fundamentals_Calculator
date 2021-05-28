using System;
using Xunit;
using Fundamentals;

namespace Fundamentals.Test
{
    public class ProgramTests
    {
        [Fact]
        public void ShouldProgram()
        {
            Program calc = new Program();
        }
        [Fact]
        public void ShouldInitConsoleWrapper()
        {
            Program calc = new Program();
            ConsoleWrapper console = new ConsoleWrapper("n");
            Assert.Equal(double.NaN, console.NumInput1);
            Assert.Equal(double.NaN, console.NumInput2);
            Assert.Equal("", console.Operation);
            Assert.Equal("n", console.SimbolOut);
        }
        [Fact]
        public void ShouldReadConsole()
        {
            ConsoleWrapper cns = new ConsoleWrapper("n");
            string input = ConsoleWrapper.GetConsoleRead();

        }

        [Fact]
        public void ShouldGetInput1()
        {
            ConsoleWrapper cns = new ConsoleWrapper("n");
            double input = cns.GetNumInput();

        }

        [Fact]
        public void ShouldCalculateResult()
        {
            ConsoleWrapper cns = new ConsoleWrapper("n");
            double input = cns.CalculateResult();            
        }
    }
}
