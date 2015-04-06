using UnityEngine;
using System.Collections;

namespace Round2
{
    internal abstract class BinaryInitializable
    {
        public abstract void Convert(byte[] data);
        public Oni.InstanceFile m_sourceFile;
    }
}
