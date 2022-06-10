using nng_one.Logging;

namespace nng_one.Containers;

public class LogContainer
{
    private static LogContainer? _instance;

    private LogContainer()
    {
        Messages = new List<Message>();
    }

    public List<Message> Messages { get; }

    public static LogContainer GetInstance()
    {
        return _instance ??= new LogContainer();
    }
}
