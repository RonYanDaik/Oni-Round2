using UnityEngine;
using System.Collections;

public class PlayerInputChannel : IInputChannel
{
    public bool this[ChannelKind channelID]
    {
        get
        {
            KeyCode? l_keyToCheck = null;

            switch (channelID)
            {
                case ChannelKind.Jump:
                    l_keyToCheck = KeyCode.Space;
                    break;

                case ChannelKind.Kick:
                    break;

                case ChannelKind.Crouch:
                    l_keyToCheck = KeyCode.LeftShift;
                    break;
                
                case ChannelKind.Punch:
                    break;

                case ChannelKind.Forward:
                    l_keyToCheck = KeyCode.W;
                    break;

                case ChannelKind.Backward:
                    l_keyToCheck = KeyCode.S;
                    break;

                case ChannelKind.Left:
                    l_keyToCheck = KeyCode.A;
                    break;

                case ChannelKind.Right:
                    l_keyToCheck = KeyCode.D;
                    break;

                case ChannelKind.Any:
                    {
                        foreach (ChannelKind kind in System.Enum.GetValues(typeof(ChannelKind)))
                        {
                            if (kind != ChannelKind.Any)
                            {
                                bool l_v = this[kind];

                                if (l_v)
                                {
                                    return l_v;
                                }
                            }
                        }
                    }
                    break;

                default:
                    
                    //multiple options here
                    {
                        
                        bool? l_v = null;

                        foreach (ChannelKind kind in System.Enum.GetValues(typeof(ChannelKind)))
                        {
                            if (kind != ChannelKind.Any)
                            {
                                if ((channelID & kind) != 0)
                                {
                                    if (l_v == null)
                                    {
                                        l_v = this[kind];
                                    }

                                    l_v = l_v.Value && this[kind];
                                }
                            }
                        }

                        return l_v ?? false;
                    }
                   
                    break;
            }

            return l_keyToCheck != null && Input.GetKey(l_keyToCheck.Value);
        }
        set
        {
            //cant set player input
        }
    }
}
