using UnityEngine;
using System.Collections;

namespace Round2.Generated.Binary
{
    internal partial class TXCA
    {
        UnityEngine.Vector2[] m_arr = null;

        public UnityEngine.Vector2[] Array
        {
            get
            {
                return m_arr == null ? m_arr = this.m_pkg_20.ConvertAll<Package, UnityEngine.Vector2>(pkg => new UnityEngine.Vector2(pkg.m_x_coordinate_0, pkg.m_y_coordinate_4)) : m_arr;
            }
        }
    }
}
