using MessagePack;

namespace RacingwayCore;

[MessagePackObject]
public readonly record struct Address(uint WorldId, uint TerritoryId, uint MapId, sbyte? Ward = null, sbyte? Plot = null, short? Room = null)
{
    [Key(0)] public readonly uint WorldId =  WorldId;
    [Key(1)] public readonly uint TerritoryId = TerritoryId;
    [Key(2)] public readonly uint MapId = MapId;
    [Key(3)] public readonly sbyte? Ward = Ward;
    [Key(4)] public readonly sbyte? Plot = Plot;
    [Key(5)] public readonly short? Room = Room;
}
