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
                internal class PART : OBJCM
                {
                    static Dictionary<string, BINA.OBJC.PAR3> m_particleClasses = new Dictionary<string,PAR3>();

                    internal BINA.OBJC.PAR3 m_class;

                    public static void RegisterParticleClass(BINA.OBJC.PAR3 @class, string name)
                    {
                        name = name.Replace("\0", "").Remove(0, 4);

                        if (!m_particleClasses.ContainsKey(name))
                        {
                            //Debug.Log("ADD : " + name);
                            m_particleClasses.Add(name, @class);
                        }
                        else
                        {
                            Debug.LogError("DUPLICATE PAR3 NAME : " + name);
                        }
                    }

                    internal string m_pClass;
                    internal GameObject m_go;

                    public override void ContinueParse(int npos, Oni.BinaryReader rawReader)
                    {
                        m_pClass = rawReader.ReadString(64).Replace("\0", "");
                        rawReader.Skip(48);
                        rawReader.Skip(2);
                        float l_sX = rawReader.ReadSingle();
                        float l_sY = rawReader.ReadSingle();

                        if (m_particleClasses.ContainsKey(m_pClass))
                        {
                            m_class = m_particleClasses[m_pClass];
                            m_go = GameObject.CreatePrimitive(PrimitiveType.Plane);
                            GameObject.Destroy(m_go.collider);
                            m_go.name = m_pClass;
                            
                            if (BinaryDatReader.m_textures.ContainsKey(m_particleClasses[m_pClass].m_header.m_textureName))
                            {
                                m_go.renderer.material.mainTexture = BinaryDatReader.m_textures[m_particleClasses[m_pClass].m_header.m_textureName].Surface_0;
                                m_go.renderer.material.shader = Shader.Find("Particles/Additive");
                            }
                        }
                        else
                        {
                            Debug.LogError("NO KEY FOR " + m_pClass);   
                        }
                        //Debug.Log(rawReader.ReadString(48));//particle name
                        //throw new System.NotImplementedException();
                    }
                }
            }
        }
    }
}
