using SOLID_principles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles.Services
{
    /// <summary>
    /// Логика одного раунда игры "Угадай число".
    /// SRP: отвечает только за процесс угадывания.
    /// DIP: зависит исключительно от абстракций IOutput, IInput, INumberGenerator, IGameSettings.
    /// </summary>
    public class GameRound
    {
        private readonly IOutput _output;
        private readonly IInput _input;
        private readonly INumberGenerator _numberGenerator;
        private readonly IGameSettings _settings;

        public GameRound(IOutput output, IInput input, INumberGenerator numberGenerator, IGameSettings settings)
        {
            _output = output ?? throw new ArgumentNullException(nameof(output));
            _input = input ?? throw new ArgumentNullException(nameof(input));
            _numberGenerator = numberGenerator ?? throw new ArgumentNullException(nameof(numberGenerator));
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
        }

        /// <summary>
        /// Запускает игровой раунд и возвращает true, если число угадано.
        /// </summary>
        public bool Play()
        {
            int secretNumber = _numberGenerator.Generate(_settings.MinNumber, _settings.MaxNumber);
            _output.WriteLine($"Загадано число от {_settings.MinNumber} до {_settings.MaxNumber}.");
            _output.WriteLine($"У вас {_settings.MaxAttempts} попыток.");

            for (int attempt = 1; attempt <= _settings.MaxAttempts; attempt++)
            {
                _output.Write($"Попытка {attempt}: ");
                string input = _input.ReadLine();

                if (!int.TryParse(input, out int guess))
                {
                    _output.WriteLine("Некорректный ввод. Введите целое число.");
                    attempt--; // не засчитываем попытку
                    continue;
                }

                if (guess < _settings.MinNumber || guess > _settings.MaxNumber)
                {
                    _output.WriteLine($"Число должно быть от {_settings.MinNumber} до {_settings.MaxNumber}.");
                    attempt--;
                    continue;
                }

                if (guess == secretNumber)
                {
                    _output.WriteLine($"Поздравляем! Вы угадали число {secretNumber} за {attempt} попыток.");
                    return true;
                }

                _output.WriteLine(guess < secretNumber ? "Загаданное число больше." : "Загаданное число меньше.");
            }

            _output.WriteLine($"Вы исчерпали попытки. Загаданное число: {secretNumber}.");
            return false;
        }
    }
}
