using UnityEngine;
using System.Collections;

namespace Round2.Generated.Binary
{
    internal partial class PNTA
    {
        UnityEngine.Vector3[] m_arr = null;

        public UnityEngine.Vector3[] Array
        {
            get
            {
                if (m_arr == null)
                {
                    m_arr = this.m_pkg_40.ConvertAll<PNTA.Package, UnityEngine.Vector3>((PNTA.Package pkg) => new UnityEngine.Vector3(pkg.m_x_coordinate_0, pkg.m_y_coordinate_4, pkg.m_z_coordinate_8));
                }

                return m_arr;
            }
        }
    }
}
