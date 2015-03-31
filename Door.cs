using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Door : MonoBehaviour 
{
    static Dictionary<int, Round2.Generated.Binary.OBOA.Package> m_doorLinks = new Dictionary<int, Round2.Generated.Binary.OBOA.Package>();
    public bool m_oboaflag;
    public int m_criticalLink;

    internal static void OBOALink(Round2.Generated.Binary.OBOA.Package pkg)
    {
        if (pkg.m_door_id_14 > 0)
        {
            if (!m_doorLinks.ContainsKey(pkg.m_door_id_14))
            {
                m_doorLinks.Add(pkg.m_door_id_14, pkg);
            }
            else
            {
                if (pkg.m_OBAN_link_4.m_lnkId != 0 && m_doorLinks[pkg.m_door_id_14].m_OBAN_link_4.m_lnkId == 0)
                {
                    Debug.LogError("replacement query for " + pkg.m_door_id_14);
                }


                Debug.LogError("Duplicate door id : " + pkg.m_door_id_14);
            }
        }
    }

    internal Round2.Generated.Binary.Namespaces.BINA.OBJC.DOOR m_proto;

    internal static System.Action m_lateInitialize = () => { };

	public void ManualStart()
    {
        m_lateInitialize += () =>
        {
            try
            {
                Debug.Log("door" + m_proto.m_doorID);
                gameObject.name = m_proto.m_doorType + "::" + m_proto.m_doorID + "(" + m_proto.m_keyID + ")";
                Round2.Generated.Binary.DOOR l_doorClass = Round2.Generated.Binary.DOOR.PendDoorClass(m_proto.m_doorType);
                m_oboaflag = m_doorLinks.ContainsKey((int)m_proto.m_doorID);
                Round2.Generated.Binary.OBOA.Package l_pkg = null;
                Destroy(this.collider);

                if (!m_doorLinks.ContainsKey((int)m_proto.m_doorID))
                {
                    Debug.LogError("NO OBOA FOR THIS DOOR " + m_proto.m_doorID, this);
                }
                else
                {
                    l_pkg = m_doorLinks[(int)m_proto.m_doorID];
                }

                if (l_pkg != null)
                {
                    m_criticalLink = l_doorClass.m_OBAN_link_10.m_lnkId;
                    this.GetComponent<MeshFilter>().mesh = l_pkg.m_M3GA_link_0.Value.m_pkg_20[0].m_M3GM_link_0.Value.UnityMesh;
                    renderer.material.mainTexture = l_pkg.m_M3GA_link_0.Value.m_pkg_20[0].m_M3GM_link_0.Value.m_TXMP_link_24.Value.Surface_0;
                    Round2.Generated.Binary.OBAN.Package l_frame0 = l_doorClass.m_OBAN_link_10.Value.m_pkg_80[0];
                    Vector3 l_rot = new Oni.Quaternion(l_frame0.m_x_rot_0, l_frame0.m_y_rot_4, l_frame0.m_z_rot_8, l_frame0.m_w_rot_C).ToEulerXYZ().UnityVector();
                    transform.position = new Vector3(-l_pkg.m_x_pos_20, l_pkg.m_y_pos_24, l_pkg.m_z_pos_28);
                    Oni.Vector3 l_scale;
                    Oni.Vector3 l_pos;
                    Oni.Quaternion l__rot;
                    l_doorClass.m_OBAN_link_10.Value.InitialTransform.Decompose(out l_scale, out l__rot, out l_pos);
                    #region same shit for any "DOOR" or "OBOA" object!
                    l__rot = new Oni.Quaternion(l_pkg.m_x_rot_2C, l_pkg.m_y_rot_30, l_pkg.m_z_rot_34, l_pkg.m_w_rot_38);
                    Vector3 l_eulerRot = l__rot.UnityQuaternionRaw().eulerAngles;
                    transform.rotation = Quaternion.Euler(l_eulerRot.x, -l_eulerRot.y, -l_eulerRot.z);
                    #endregion
                    transform.localScale = l_scale.UnityVector();
                }
            }
            catch (System.Exception ee)
            {
                Debug.LogException(ee);   
            }
            //transform.rotation = l_pkg.
        };
	}
}
