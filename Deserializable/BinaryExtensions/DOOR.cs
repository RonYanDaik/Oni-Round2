using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Round2
{
    internal interface ObjectRegistry<T>
    {
        int Id();
    }
}

namespace Round2.Generated.Binary
{
    internal partial class DOOR : ObjectRegistry<Door>
    {
        public int Id()
        {
            return 0;
        }

        public static DOOR PendDoorClass(string className)
        {
            string l_RealClassName = className.Replace("\0", "");
            return m_doorClassReg.ContainsKey(l_RealClassName) ? m_doorClassReg[l_RealClassName] : null;
        }

        static Dictionary<string, DOOR> m_doorClassReg = new Dictionary<string, DOOR>();

        internal static void RegisterDoorClass(Oni.InstanceDescriptor ides)
        {
            //if (ides != null)
            {
                if (ides.Template.Tag == Oni.TemplateTag.DOOR)
                {
                    m_doorClassReg.Add(ides.Name, BinaryDatReader.ConvertInstance<DOOR>(ides));
                    //Debug.Log("Registered door class : [" + ides.Name + "]");
                }
            }
        }
    }
}
