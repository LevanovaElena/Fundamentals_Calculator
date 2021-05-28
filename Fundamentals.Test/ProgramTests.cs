using System;
using Xunit;
using Fundamentals;

namespace Fundamentals.Test
{
    public class ProgramTests
    {
        [Fact]
        public void ShouldReserveUserInput()
        {
            IConsoleWrapper consoleWrapper = new MockConsoleWrapper();
            string userInput = consoleWrapper.ReadLine();
            Assert.Equal("2", userInput);
            userInput = consoleWrapper.ReadLine();
            Assert.Equal("5", userInput);
            userInput = consoleWrapper.ReadLine();
            Assert.Equal("a", userInput);
            userInput = consoleWrapper.ReadLine();
            Assert.Equal("n", userInput);
        }
        [Fact]
        public void ShouldReserveOutput()
        {
            string userOutput = Program.Output("a", 2, 5);
            Assert.Equal("Your result: 7\n", userOutput);
            userOutput = Program.Output("d", 2, 5);
            Assert.Equal("Your result: 0,4\n", userOutput);
            userOutput = Program.Output("m", 2, 5);
            Assert.Equal("Your result: 10\n", userOutput);
            userOutput = Program.Output("s", 2, 5);
            Assert.Equal("Your result: -3\n", userOutput);
            userOutput = Program.Output("g", 2, 5);
            Assert.Equal("This operation will result in a mathematical error.\n", userOutput);
            userOutput = Program.Output("g", 2, 5);
            Assert.Equal("Oh no! An exception occurred trying to do the math.\n", userOutput);

        }

        [Fact]
        public void ShouldMultiplyFiveAndTwo()
        {
            Program.ConsoleWrapper = new MockConsoleWrapper();
            Program.Main(new string[0]);
        }
    }

    public class MockConsoleWrapper: IConsoleWrapper
    {
        int count = 0;
        public string ReadLine()
        {
            count++;
            if (count == 1) return "2";
            if (count==2)return "5";
            if (count == 3) return "a";
            return "n";

        }
    }

}
