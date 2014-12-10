using System;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public static class VersionUtils
{
    public static void ToogleActive(this GameObject go, bool value)
    {
#if (UNITY_3_5 || UNITY_3_4 || UNITY_3_3 || UNITY_3_2 || UNITY_3_1 || UNITY_3_0)
        go.SetActiveRecursively(value);
#else 
        go.SetActive(value);
#endif
    }

    public static bool IsActive(this GameObject go)
    {
#if (UNITY_3_5 || UNITY_3_4 || UNITY_3_3 || UNITY_3_2 || UNITY_3_1 || UNITY_3_0)
        return go.active;
#else 
        return go.activeSelf;
#endif
    }

}
