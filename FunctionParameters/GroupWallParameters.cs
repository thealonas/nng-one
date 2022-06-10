using nng_one.Configs;
using nng_one.Interfaces;
using VkNet.Model;

namespace nng_one.FunctionParameters;

public enum GroupWallParametersType
{
    Repost,
    DeleteAllPosts
}

public class GroupWallParameters : IFunctionParameter
{
    public GroupWallParameters(Config config, GroupWallParametersType type,
        IEnumerable<Group> groups,
        string? postId)
    {
        Config = config;
        Groups = groups;
        Type = type;
        PostId = postId;
    }

    public GroupWallParametersType Type { get; }
    public IEnumerable<Group> Groups { get; }
    public string? PostId { get; }
    public Config Config { get; }
}
