using Newtonsoft.Json;
using nng_one.Exceptions;
using nng_one.Logging;

namespace nng_one.Configs;

public static class ConfigProcessor
{
    private const string ConfigFileName = "config.json";

    public static Config LoadConfig()
    {
        if (!File.Exists(ConfigFileName)) throw new ConfigNotFoundException("Конфиг не найден");
        return JsonConvert.DeserializeObject<Config>(File.ReadAllText(ConfigFileName));
    }

    public static void SaveConfig(Config config)
    {
        Logger.Log("Сохранение конфига", LogType.Debug);
        File.WriteAllText(ConfigFileName, JsonConvert.SerializeObject(config, Formatting.Indented));
    }
}
