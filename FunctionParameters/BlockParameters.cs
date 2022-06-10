using nng_one.Configs;
using nng_one.Interfaces;

namespace nng_one.FunctionParameters;

public class BlockParameters : IFunctionParameter
{
    public BlockParameters(IEnumerable<long> users, IEnumerable<long> groups, Config config)
    {
        Users = users;
        Groups = groups;
        Config = config;
    }

    public IEnumerable<long> Users { get; }
    public IEnumerable<long> Groups { get; }
    public Config Config { get; }
}
