using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles.Interfaces
{
    /// <summary>
    /// Генератор случайного числа в указанном диапазоне.
    /// </summary>
    public interface INumberGenerator
    {
        int Generate(int min, int max);
    }
}
