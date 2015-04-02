using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Door : MonoBehaviour 
{
    public List<Vector3> m_rotations = new List<Vector3>();
    internal Round2.Generated.Binary.Namespaces.BINA.OBJC.DOOR m_proto;
    List<RTOBOA> m_myOBJS = new List<RTOBOA>();

    void OnInitialize()
    {
        try
        {
            transform.position = new Vector3(-m_proto.m_header.m_pos.x, m_proto.m_header.m_pos.y, m_proto.m_header.m_pos.z);

            foreach(RTOBOA obj in m_myOBJS = RTOBOA.GetByDoorID((int)m_proto.m_doorID & 0x0FFF))
            {
               
                Round2.Generated.Binary.OBOA.Package l_pkg = obj.m_proto;
                m_rotations.Add(m_proto.m_header.m_rot);
                gameObject.name = m_proto.m_doorType + "::" + m_proto.m_doorID + "(" + m_proto.m_keyID + ")";
                Round2.Generated.Binary.DOOR l_doorClass = Round2.Generated.Binary.DOOR.PendDoorClass(m_proto.m_doorType);
                obj.SetOBANInput(l_doorClass.m_OBAN_link_10.Value);

                if (l_pkg != null)
                {
                    Round2.Generated.Binary.OBAN.Package l_frame0 = l_doorClass.m_OBAN_link_10.Value.m_pkg_80[0];
                    Vector3 l_rot = new Oni.Quaternion(l_frame0.m_x_rot_0, l_frame0.m_y_rot_4, l_frame0.m_z_rot_8, l_frame0.m_w_rot_C).UnityQuaternionRaw().eulerAngles;
                    m_rotations.Add(l_rot);
                    obj.transform.position = new Vector3(-l_pkg.m_x_pos_20, l_pkg.m_y_pos_24, l_pkg.m_z_pos_28);
                    Oni.Vector3 l_scale;
                    Oni.Vector3 l_pos;
                    Oni.Quaternion l__rot;
                    m_rotations.Add(l__rot.UnityQuaternionRaw().eulerAngles);
                    l_doorClass.m_OBAN_link_10.Value.InitialTransform.Decompose(out l_scale, out l__rot, out l_pos);
                    //more looks like a hack. Still works fine.
                    obj.transform.rotation = Quaternion.Euler(m_rotations[0]) * Quaternion.Euler(m_rotations[1]) * Quaternion.Euler(180,0,0);
                }

                GameObject l_pivot = new GameObject("pivot");
                l_pivot.transform.parent = transform;
                l_pivot.transform.position = obj.transform.position;
                l_pivot.transform.rotation = obj.transform.rotation;
                obj.transform.parent = l_pivot.transform;

                if (obj.m_proto.m_door_id_14 > 0 && ((int)obj.m_proto.m_door_id_14 & 0x1000) != 0)
                {
                    //l_pivot.name += " # mirror ";
                    l_pivot.transform.rotation *= Quaternion.Euler(180, 180, 0);
                }

                obj.gameObject.SetActive(true);
            }

            SphereCollider l_sc = gameObject.AddComponent<SphereCollider>();
            l_sc.radius = Mathf.Sqrt(m_proto.m_activationRadius) / 2f;
            l_sc.center = Vector3.up * (l_sc.radius);
            l_sc.isTrigger = true;
        }
        catch (System.Exception ee)
        {
            Debug.LogException(ee, this);
        }
    }

    internal static System.Action m_lateInitialize = () => { };

    void Start()
    {
        OnInitialize();
    }

    void OnTriggerEnter()
    {
        foreach (RTOBOA oboa in m_myOBJS)
        {
            oboa.AnimateIn();
        }
    }

    void OnTriggerExit()
    {
        foreach (RTOBOA oboa in m_myOBJS)
        {
            oboa.AnimateOut();
        }
    }
}
