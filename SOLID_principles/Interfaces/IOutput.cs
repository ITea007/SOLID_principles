using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles.Interfaces
{
    /// <summary>
    /// Вывод сообщений.
    /// ISP: отделён от ввода, чтобы классы могли реализовывать только нужное.
    /// </summary>
    public interface IOutput
    {
        void WriteLine(string message);
        void Write(string message);
    }
}
