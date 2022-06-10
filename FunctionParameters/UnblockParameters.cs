using nng_one.Configs;
using nng_one.Interfaces;
using VkNet.Model;

namespace nng_one.FunctionParameters;

public class UnblockParameters : IFunctionParameter
{
    public UnblockParameters(Config config, IEnumerable<Group> groups, IEnumerable<User>? users)
    {
        Config = config;
        Groups = groups;
        Users = users;
    }

    public IEnumerable<User>? Users { get; }
    public IEnumerable<Group> Groups { get; }
    public Config Config { get; }
}
