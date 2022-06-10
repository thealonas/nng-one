using nng_one.Configs;
using nng_one.Interfaces;
using VkNet.Model;

namespace nng_one.FunctionParameters;

public enum EditorOperationType
{
    Give,
    Fire
}

public class EditorParameters : IFunctionParameter
{
    public EditorParameters(EditorOperationType type, Config config, IEnumerable<User>? users,
        IEnumerable<Group> groups)
    {
        Type = type;
        Users = users;
        Groups = groups;
        Config = config;
    }

    public EditorOperationType Type { get; }
    public IEnumerable<User>? Users { get; }
    public IEnumerable<Group> Groups { get; }
    public Config Config { get; }
}
