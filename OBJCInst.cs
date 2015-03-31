using UnityEngine;
using System.Collections;
using System.Collections.Generic;

internal class OBJCInst : MonoBehaviour 
{
    protected void Init()
    {
    }

    //protected Round2.Generated.Binary.ONOA.Package m_onoa;
    static Dictionary<int, OBJCInst> m_objcRegistry = new Dictionary<int, OBJCInst>();
    int? m_id;

    public int ObjID
    {
        get
        {
            return m_id ?? 0;
        }

        set
        {
            if (m_id.HasValue)
            {
                m_objcRegistry.Remove(m_id.Value);
            }

            m_id = value;
            m_objcRegistry.Add(m_id.Value, this);
        }
    }

    public int DoorID
    {
        get
        {
            return ObjID << 24 >> 24;
        }
    }
}
