using SOLID_principles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SOLID_principles.Models
{
    /// <summary>
    /// Реализация IGameSettings, загружающая параметры из JSON‑файла.
    /// SRP: класс отвечает только за предоставление настроек.
    /// OCP: метод Load можно вынести в фабрику, а сам класс остаётся закрытым для изменений.
    /// </summary>
    public class GameSettings : IGameSettings
    {
        public int MinNumber { get; init; }
        public int MaxNumber { get; init; }
        public int MaxAttempts { get; init; }

        public static GameSettings Load(string filePath = "appsettings.json")
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Файл настроек {filePath} не найден.");

            string json = File.ReadAllText(filePath);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement.GetProperty("GameSettings");

            return new GameSettings
            {
                MinNumber = root.GetProperty("MinNumber").GetInt32(),
                MaxNumber = root.GetProperty("MaxNumber").GetInt32(),
                MaxAttempts = root.GetProperty("MaxAttempts").GetInt32()
            };
        }
    }

}
