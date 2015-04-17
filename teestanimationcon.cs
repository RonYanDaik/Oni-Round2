using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class teestanimationcon : MonoBehaviour 
{
    IInputChannel m_plch = new PlayerInputChannel();
    Dictionary<ChannelKind, bool> m_channelMap = new Dictionary<ChannelKind, bool>() 
    {
        { ChannelKind.Backward, false},
        { ChannelKind.Crouch, false},
        { ChannelKind.Forward, false},
        { ChannelKind.Jump, false},
        { ChannelKind.Kick, false},
        { ChannelKind.Left, false},
        { ChannelKind.Punch, false},
        { ChannelKind.Right, false}
    };

    AnimFlags IdleCycle()
    {
        foreach (ChannelKind kind in Enum.GetValues(typeof(ChannelKind)))
        {
            if (m_channelMap[kind])
            {
                Func<AnimFlags> l_ch = ChooseChannel(kind);
                m_currentRoutine = l_ch;
                return l_ch();
            }
        }

        m_currentRoutine = () =>
        {
            m_currentRoutine = IdleCycle;
            return AnimFlags.idle2;
        };
        return AnimFlags.idle1;
    }

    private Func<AnimFlags> ChooseChannel(ChannelKind kind)
    {
        switch (kind)
        { 
            case ChannelKind.Backward:
            case ChannelKind.Forward:
            case ChannelKind.Right:
            case ChannelKind.Left:
                return DirectionalMove(kind);
                break;
        }

        return IdleCycle;
    }

    private Func<AnimFlags> DirectionalMove(ChannelKind mainChannel)
    {
        AnimFlags l_direction = AnimFlags.idle1;

        switch (mainChannel)
        { 
            case ChannelKind.Forward:
                l_direction = AnimFlags.run;
                break;
            case ChannelKind.Backward:
                l_direction = AnimFlags.run_bk;
                break;
            case ChannelKind.Left:
                l_direction = AnimFlags.ss_lt;
                break;
            case ChannelKind.Right:
                l_direction = AnimFlags.ss_rt;
                break;
        }

        bool l_switchCase = false;

        return () =>
        {
            m_currentRoutine = () =>
            {
                Func<AnimFlags> l_exitScenario = () => { m_currentRoutine = IdleCycle; return AnimFlags.stepb; };
                Func<AnimFlags> l_stopScenario = () => { m_currentRoutine = IdleCycle; return AnimFlags.stop; };
                Func<AnimFlags> l_loop = () =>
                {
                    return l_direction | (m_plch[mainChannel] ? ((l_switchCase = !l_switchCase) ? AnimFlags.rt : AnimFlags.lt) : l_stopScenario());
                };

                Func<AnimFlags> l_loopEnter = () =>
                {
                    m_currentRoutine = l_loop;
                    return AnimFlags.start;
                };

                return l_direction | (m_plch[mainChannel] ? l_loopEnter : l_exitScenario)();
            };
            return l_direction | AnimFlags.stepa;
        };
    }

    void Start() 
    {
        m_currentRoutine = IdleCycle;
	}

    Func<AnimFlags> m_currentRoutine;
    float m_lastTime;

    void FormAnimation()
    {
        foreach (ChannelKind kind in Enum.GetValues(typeof(ChannelKind)))
        {
            m_channelMap[kind] = m_plch[kind];
        }

        Debug.Log(m_currentRoutine());
    }

	// Update is called once per frame
	void Update () 
    {
        if (Time.time - m_lastTime > 1)
        {
            m_lastTime = Time.time;
            FormAnimation();
        }
	}
}
