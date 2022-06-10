using nng_one.Configs;
using nng_one.Interfaces;
using VkNet.Model;

namespace nng_one.FunctionParameters;

public class SearchParameters : IFunctionParameter
{
    public SearchParameters(IEnumerable<User> users, IEnumerable<Group> groups, Config config)
    {
        Users = users;
        Groups = groups;
        Config = config;
    }

    public IEnumerable<User> Users { get; }
    public IEnumerable<Group> Groups { get; }
    public Config Config { get; }
}
