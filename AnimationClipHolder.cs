using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public static class AnimationClipHolder
{
    static Dictionary<string, Func<GUIANIMCONTROL, AnimationClip>> m_holdDict = new Dictionary<string, Func<GUIANIMCONTROL, AnimationClip>>();

    public static void Hold(string name, Func<GUIANIMCONTROL, AnimationClip> generator)
    {
        if (!m_holdDict.ContainsKey(name))
        {
            m_holdDict.Add(name, generator);
        }
    }

    public static AnimationClip Get(string animname, GUIANIMCONTROL caller)
    {
        Debug.Log("::"  + animname);
        Debug.Log("query for " + animname);
        if (m_holdDict.ContainsKey(animname))
        {
            return m_holdDict[animname](caller);
        }
        else
        {
            return null;
        }
    }
}
