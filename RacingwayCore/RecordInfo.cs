using LiteDB;

namespace RacingwayCore;

public struct RecordInfo
{
    public required ObjectId Id { get; set; }
    public required string Name { get; set; }
    public required string World { get; set; }
    public required DateTime Created { get; set; }
    public required TimeSpan Time { get; set; }
    public required byte[] PackedRecord { get; set; }
}
