using SOLID_principles.Interfaces;
using SOLID_principles.Models;
using SOLID_principles.UI;
using SOLID_principles.Services;

namespace SOLID_principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сборка зависимостей
            IGameSettings settings = GameSettings.Load();
            IOutput output = new ConsoleOutput();
            IInput input = new ConsoleInput();
            INumberGenerator numberGenerator = new RandomNumberGenerator();

            var runner = new GameRunner(output, input, numberGenerator, settings);
            runner.Run();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
