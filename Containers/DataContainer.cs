using nng.Models;

namespace nng_one.Containers;

public class DataContainer
{
    private static DataContainer? _instance;

    private DataContainer()
    {
        Model = new DataModel(Array.Empty<long>(), Array.Empty<UserModel>());
    }

    public DataModel Model { get; private set; }

    public static DataContainer GetInstance()
    {
        return _instance ??= new DataContainer();
    }

    public void SetModel(DataModel model)
    {
        Model = model;
    }
}
