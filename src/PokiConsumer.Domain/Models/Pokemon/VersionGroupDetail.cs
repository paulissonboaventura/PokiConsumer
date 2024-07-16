using PokiConsumer.Domain.Utilities;

namespace PokiConsumer.Domain.Models.Pokemon;

public class VersionGroupDetail(int levelLearnedAt, Resource moveLearnMethod, Resource versionGroup)
{
    public int LevelLearnedAt { get; set; } = levelLearnedAt;
    public Resource MoveLearnMethod { get; set; } = moveLearnMethod;
    public Resource VersionGroup { get; set; } = versionGroup;
}