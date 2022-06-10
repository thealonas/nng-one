using nng_one.Configs;
using nng_one.Interfaces;
using VkNet.Model;

namespace nng_one.FunctionParameters;

public enum MiscFunctionType
{
    Stats,
    RemoveBanned
}

public class MiscParameters : IFunctionParameter
{
    public MiscParameters(Config config, MiscFunctionType type, IEnumerable<Group>? groups)
    {
        Config = config;
        Type = type;
        Groups = groups;
    }

    public MiscFunctionType Type { get; }
    public IEnumerable<Group>? Groups { get; }

    public Config Config { get; }
}
