using nng_one.Controllers;
using nng_one.Logging;

namespace nng_one;

public static class Startup
{
    public static void Start()
    {
        Logger.Clear(true);
        var menu = new Menu.Menu().GetResult();
        FunctionController.ProcessFunction(menu);
    }
}
