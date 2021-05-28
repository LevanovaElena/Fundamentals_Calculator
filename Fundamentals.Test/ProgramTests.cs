using System;
using Xunit;
using Fundamentals;
using System.Collections.Generic;

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
        Queue<string> numbers = new Queue<string>();

        public MockConsoleWrapper()
        {
            numbers.Enqueue("2"); ///2
            numbers.Enqueue("5"); //2,5
            numbers.Enqueue("a"); //2,5,a
            numbers.Enqueue("n");//2,5,a,n
        }


        public string ReadLine()
        {
            return numbers.Dequeue(); 
        }
    }

}
