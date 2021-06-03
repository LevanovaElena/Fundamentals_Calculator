using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public interface IConsoleWrapper
    {
        string ReadLine();


    }
    public class ConsoleWrapper: IConsoleWrapper
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

    }
}
