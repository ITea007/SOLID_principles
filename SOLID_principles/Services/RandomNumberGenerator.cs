using SOLID_principles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles.Services
{
    /// <summary>
    /// Генератор псевдослучайных чисел.
    /// SRP: только генерация числа.
    /// LSP: реализует INumberGenerator, может быть заменён любым другим генератором.
    /// </summary>
    public class RandomNumberGenerator : INumberGenerator
    {
        private readonly Random _random = new();

        public int Generate(int min, int max)
        {
            return _random.Next(min, max + 1);
        }
    }
}
