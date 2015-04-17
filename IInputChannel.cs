using UnityEngine;
using System.Collections;
using System;

[Flags]
public enum ChannelKind : int
{
    Forward = 1 << 1,
    Backward = 1 << 2,
    Left = 1 << 3,
    Right = 1 << 4,
    Crouch = 1 << 5,
    Jump = 1 << 6,
    Punch = 1 << 7,
    Kick = 1 << 8,
    Any = 1 << 9
}

public interface IInputChannel 
{
    bool this[ChannelKind channelID]
    {
        get;
        set;
    }
}
