using nng_one.Containers;

namespace nng_one.Logging;

public enum LogType
{
    Info,
    InfoVersionShow,
    Warning,
    Error,
    Debug
}

public class Logger
{
    private static readonly LogContainer LogContainer = LogContainer.GetInstance();

    protected Logger()
    {
    }

    private static string GetVersion()
    {
        var ver = Program.Version;
        return $"{ver.Major}.{ver.Minor}";
    }

    private static void ProcessMessage(string message, string name, ConsoleColor color, bool withoutTitle,
        bool skipLine, bool withoutColor)
    {
        if (!withoutColor) Console.ForegroundColor = color;
        var output = withoutTitle ? $"{message}" : $"[{name}] {message}";
        if (skipLine) Console.WriteLine(output);
        else Console.Write(output);
        Console.ResetColor();
    }

    private static bool IsAllowed(LogType type, bool force)
    {
        if (force) return true;
        return type != LogType.Debug || Program.DebugMode;
    }

    public static void Log(string message, LogType type = LogType.Info, string name = "nng one",
        bool force = false, bool withoutTitle = false, bool skipLine = true, bool withoutColor = false)
    {
        if (!IsAllowed(type, force)) return;
        switch (type)
        {
            case LogType.Info:
                ProcessMessage(message, name, ConsoleColor.Green, withoutTitle, skipLine, withoutColor);
                break;
            case LogType.InfoVersionShow:
                ProcessMessage($"v{GetVersion()} | {message}", name,
                    ConsoleColor.Green, withoutTitle, skipLine,
                    withoutColor);
                break;
            case LogType.Warning:
                ProcessMessage(message, name, ConsoleColor.Blue, withoutTitle, skipLine, withoutColor);
                break;
            case LogType.Error:
                ProcessMessage(message, name, ConsoleColor.Red, withoutTitle, skipLine, withoutColor);
                break;
            case LogType.Debug:
                ProcessMessage(message, name, ConsoleColor.Gray, withoutTitle, skipLine, withoutColor);
                break;
            default:
                ProcessMessage(message, name, ConsoleColor.Green, withoutTitle, skipLine, withoutColor);
                break;
        }
    }

    public static void Log(Exception e)
    {
        Log($"Произошла ошибка: {e.Message}", LogType.Debug);
    }

    public static void Log(Exception e, bool extended)
    {
        Log(!extended ? $"Произошла ошибка: {e.Message}" : $"{e}: {e.Message}", LogType.Debug);
    }

    public static void Clear()
    {
        Console.Clear();
    }

    public static void Clear(bool addMessages)
    {
        Console.Clear();
        if (!addMessages) return;
        foreach (var message in LogContainer.Messages) message.Send();
    }

    public static void Idle()
    {
        Log("Нажмите Enter для продолжения…", LogType.Warning);
        Console.ReadKey();
    }
}

public class Message : Logger
{
    public Message(string text, LogType type, string name = "nng one", bool forceSend = false)
    {
        Text = text;
        Type = type;
        Name = name;
        ForceSend = forceSend;
    }

    public string Text { get; set; }
    private LogType Type { get; }
    private string Name { get; }
    private bool ForceSend { get; }

    public void Send()
    {
        Log(Text, Type, Name, ForceSend);
    }

    public bool IsEmpty()
    {
        return string.IsNullOrEmpty(Text) || string.IsNullOrWhiteSpace(Text);
    }
}
