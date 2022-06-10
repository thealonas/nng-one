using nng.VkFrameworks;

namespace nng_one.Containers;

public class VkFrameworkContainer
{
    private static VkFrameworkContainer? _instance;

    private VkFrameworkContainer()
    {
    }

    public VkFramework VkFramework { get; private set; } = null!;

    public static VkFrameworkContainer GetInstance()
    {
        return _instance ??= new VkFrameworkContainer();
    }

    public void SetFramework(VkFramework framework)
    {
        VkFramework = framework;
    }
}
