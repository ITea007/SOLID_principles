using SOLID_principles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles.UI
{
    /// <summary>
    /// Вывод сообщений в консоль.
    /// SRP: только вывод.
    /// </summary>
    public class ConsoleOutput : IOutput
    {
        public void WriteLine(string message) => Console.WriteLine(message);
        public void Write(string message) => Console.Write(message);
    }

}
