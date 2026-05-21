using SOLID_principles.Interfaces;
using SOLID_principles.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles
{
    /// <summary>
    /// Оркестратор игры.
    /// DIP: зависит от абстракций, что позволяет легко менять компоненты.
    /// </summary>
    public class GameRunner
    {
        private readonly GameRound _gameRound;

        public GameRunner(IOutput output, IInput input, INumberGenerator numberGenerator, IGameSettings settings)
        {
            _gameRound = new GameRound(output, input, numberGenerator, settings);
        }

        public void Run()
        {
            _gameRound.Play();
        }
    }
}
