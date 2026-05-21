using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles.Interfaces
{
    /// <summary>
    /// Настройки игры: диапазон чисел и максимальное количество попыток.
    /// </summary>
    public interface IGameSettings
    {
        int MinNumber { get; }
        int MaxNumber { get; }
        int MaxAttempts { get; }
    }
}
