using UnityEngine;
using System.Collections;

namespace Round2.Generated.Binary
{
    internal partial class M3GM
    {
        Mesh m_mesh;

        public Mesh UnityMesh
        {
            get
            {
                if (m_mesh == null)
                {
                    m_mesh = new Mesh();
                    m_mesh.vertices = this.m_PNTA_link_C.Value.m_pkg_40.ConvertAll<PNTA.Package, UnityEngine.Vector3>(u => new UnityEngine.Vector3(u.m_x_coordinate_0, u.m_y_coordinate_4, u.m_z_coordinate_8));
                    m_mesh.uv = this.m_TXCA_link_18.Value.m_pkg_20.ConvertAll<TXCA.Package, UnityEngine.Vector2>(u => new UnityEngine.Vector2(u.m_x_coordinate_0, u.m_y_coordinate_4));
                    m_mesh.triangles = this.m_IDXA_link_1C.Value.DecodeForM3GM_1();
                    m_mesh.RecalculateNormals();
                    m_mesh.RecalculateBounds();
                }

                return m_mesh;
            }
        }
    }
}
