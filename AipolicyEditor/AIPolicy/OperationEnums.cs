﻿namespace AipolicyEditor.AIPolicy
{
    public enum ChatChannels2 : uint
    {
        Normal = 0,
        Faction = 1,
        Anonymous = 2,
        Broadcast = 3,
        Instance = 4,
        System = 5,
        InstanceCenterScreen = 6,
        Whisper = 7
    }

    public enum TalkTextAppendDataMask : uint
    {
        None = 0,
        Name = 1,
        LocalVar0 = 2,
        LocalVar1 = 4,
        LocalVar2 = 8,
        TalkingName = 0x10,
        ADM6 = 0x20
    }

    public enum FactionPVPPointType : uint
    {
        MineCar = 0,
        MineBase = 1,
        MineCarArrived = 2
    }

    public enum OperatorType : uint
    {
        Add = 0,
        Sub = 1,
        Mul = 2,
        Div = 3,
        Mod = 4,
        Num
    }

    public enum VarType : uint
    {
        GlobalVarID = 0,
        LocalVarID = 1,
        Const = 2,
        Random = 3,
        Num
    }

    public enum MonsterPatrolSpeedType : uint
    {
        Begin = 0,
        Slow = 1,
        Fast = 2,
        End = 3,
        Num
    }

    public enum MonsterPatrolType : uint
    {
        StopAtEnd = 0,
        Return = 1,
        Loop = 2,
        Num
    }

    public enum SummoneeDisppearType : uint
    {
        Never = 0,
        FollowSummoner = 1,
        FollowSummonTarget = 2,
        FollowSummonerOrSummonTarget = 3,
        Num
    }
}
