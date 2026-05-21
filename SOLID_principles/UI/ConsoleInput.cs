using SOLID_principles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles.UI
{
    /// <summary>
    /// Чтение ввода из консоли.
    /// SRP: только ввод.
    /// </summary>
    public class ConsoleInput : IInput
    {
        public string ReadLine() => Console.ReadLine() ?? string.Empty;
    }
}
