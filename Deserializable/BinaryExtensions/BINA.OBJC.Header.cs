using UnityEngine;
using System.Collections;

namespace Round2.Generated.Binary
{
    namespace Namespaces
    {
        namespace BINA
        {
            namespace OBJC
            {
                internal abstract class OBJCM
                {
                    public Header m_header;
                    public abstract void ContinueParse(int npos, Oni.BinaryReader rawReader);
                }

                internal class Header
                {
                    public string m_type;
                    public int m_id;
                    public int m_flags;
                    public UnityEngine.Vector3 m_pos;
                    public UnityEngine.Vector3 m_rot;
                }
            }
        }
    }
}
