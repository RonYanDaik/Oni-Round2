using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Round2.Generated.Binary
{
    namespace Namespaces
    {
        namespace BINA
        {
            namespace OBJC
            {
                internal class DOOR : OBJCM
                {
                    /// <summary>
                    /// points to a something at file0
                    /// </summary>
                    public string m_doorType;
                    public short m_doorID;
                    public short m_keyID;
                    public UnityEngine.Vector3 m_pos;
                    public float m_activationRadius;
                    /// <summary>
                    /// points to a something at file 0
                    /// </summary>
                    public string m_doortex;
                    bool m_lockFlag = false;

                    public override void ContinueParse(int npos, Oni.BinaryReader rawReader)
                    {
                        if (!m_lockFlag)
                        {
                            m_doorType = rawReader.ReadString(63);
                            m_doorID = (short)BinaryDatReader.l_int16(rawReader.ReadBytes(2), 2);
                            m_keyID = (short)BinaryDatReader.l_int16(rawReader.ReadBytes(2), 2);
                            //Debug.Log(m_doorID + "|" + m_keyID);
                            rawReader.Skip(2);
                            m_pos.x = (float)BinaryDatReader.l_float(rawReader.ReadBytes(4).ReverseBytes(), 4);
                            m_pos.y = (float)BinaryDatReader.l_float(rawReader.ReadBytes(4).ReverseBytes(), 4);
                            m_pos.z = (float)BinaryDatReader.l_float(rawReader.ReadBytes(4).ReverseBytes(), 4);
                            m_activationRadius = rawReader.ReadSingle();
                            m_doortex = rawReader.ReadString(63);
                            Binary.DOOR l_doorClass = null;

                            if ((l_doorClass = Round2.Generated.Binary.DOOR.PendDoorClass(m_doorType)) != null)
                            {
                                Door l_d = GameObject.CreatePrimitive(PrimitiveType.Plane).AddComponent<Door>();
                                l_d.m_proto = this;
                                l_d.ManualStart();
                            }
                        }
                        else
                        {
                            Debug.LogError("Attempt to reinitialize already locked object. Skipped.");
                        }

                        m_lockFlag = true;
                    }
                }
            }
        }
    }
}
