
using Newtonsoft.Json;

namespace Race
{
    public class StatisticStorage
    {
        public static readonly string Path = @"GameStatistic.json";
        public static List<GameStatistic> GetAll()
        {
            string data = FileProvider.ReadAll(Path);
            if (string.IsNullOrWhiteSpace(data)) return new List<GameStatistic>();
            return JsonConvert.DeserializeObject<List<GameStatistic>>(data);
        }
        public static void Add(GameStatistic gameStatistic)
        {
            var gameStatistics = GetAll();
            gameStatistics.Add(gameStatistic);
            FileProvider.WriteData(Path, JsonConvert.SerializeObject(gameStatistics));
        }
    } 
}
