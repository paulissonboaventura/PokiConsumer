using PokiConsumer.Domain.Models.Utilities;

namespace PokiConsumer.Domain.Models.Pokemon;

public class VersionGroupDetail(int levelLearnedAt, Resource moveLearnMethod, Resource versionGroup) : BaseModel
{
    public int LevelLearnedAt { get; set; } = levelLearnedAt;
    public Resource MoveLearnMethod { get; set; } = moveLearnMethod;
    public Resource VersionGroup { get; set; } = versionGroup;

    public override string Endpoint => "move-learn-method";
}