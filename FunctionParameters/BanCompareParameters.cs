using nng_one.Configs;
using nng_one.Interfaces;

namespace nng_one.FunctionParameters;

public class BanCompareParameters : IFunctionParameter
{
    public BanCompareParameters(IEnumerable<long> groups, IEnumerable<long> users, Config config)
    {
        Config = config;
        Users = users;
        Groups = groups;
    }

    public IEnumerable<long> Groups { get; }
    public IEnumerable<long> Users { get; }

    public Config Config { get; }
}
