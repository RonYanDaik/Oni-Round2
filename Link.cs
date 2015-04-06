using UnityEngine;
using System.Collections;

namespace Round2
{
    namespace Generated
    {
        namespace Binary
        {
            internal class Link<T>
                where T : Round2.BinaryInitializable
            {
                public Link()
                {
                    m_sourceFile = BinaryDatReader.l_currentFile;
                }

                public Oni.InstanceFile m_sourceFile;
                public int m_lnkId;
                T m_cachedObject;

                public static implicit operator Link<T>(int lnkid)
                {
                    return new Link<T>() { m_lnkId = (int)lnkid };
                }

                public T Value
                {
                    get
                    {
                        return m_cachedObject == null ? m_cachedObject = BinaryDatReader.GetByLinkId<T>(m_lnkId, m_sourceFile) : m_cachedObject;
                    }
                }

                public Oni.InstanceDescriptor Descriptor
                {
                    get
                    {
                        return BinaryDatReader.ResolveInstanceByLink(m_lnkId, m_sourceFile);
                    }
                }

            }
        }
    }
}
