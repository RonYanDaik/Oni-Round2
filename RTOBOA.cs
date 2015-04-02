using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RTOBOA : MonoBehaviour 
{
    internal Round2.Generated.Binary.OBOA.Package m_proto;
    static Dictionary<int, List<RTOBOA>> m_doorIDLST = new Dictionary<int, List<RTOBOA>>();

    public static List<RTOBOA> GetByDoorID(int id)
    {
        return m_doorIDLST[id];
    }

    internal static void Instantiate(Round2.Generated.Binary.OBOA.Package proto)
    {
        RTOBOA l_obj = GameObject.CreatePrimitive(PrimitiveType.Plane).AddComponent<RTOBOA>();
        Destroy(l_obj.collider);
        l_obj.m_proto = proto;
        l_obj.transform.position = new Vector3(-proto.m_x_pos_20, proto.m_y_pos_24, proto.m_z_pos_28);
        l_obj.transform.rotation = new Quaternion(proto.m_x_pos_20, proto.m_y_rot_30, proto.m_z_rot_34, proto.m_w_rot_38);

        if (proto.m_M3GA_link_0.m_lnkId != 0)
        {
            Round2.Generated.Binary.M3GM l_m3gm = proto.m_M3GA_link_0.Value.m_pkg_20[0].m_M3GM_link_0.Value;
            l_obj.GetComponent<MeshFilter>().mesh = l_m3gm.UnityMesh;
            l_obj.gameObject.AddComponent<MeshCollider>().mesh = l_m3gm.UnityMesh;
            l_obj.renderer.material.mainTexture = l_m3gm.m_TXMP_link_24.Value.Surface_0;
        }

        if (proto.m_door_id_14 > 0)
        {
            int l_realdID = proto.m_door_id_14 & 0x0FFF;

            if (!m_doorIDLST.ContainsKey(l_realdID))
            {
                m_doorIDLST.Add(l_realdID, new List<RTOBOA>());
            }

            m_doorIDLST[l_realdID].Add(l_obj);
        }

        l_obj.gameObject.SetActive(false);
    }

    public void Start()
    { 
       
    }

    Animation m_anim;

    internal void SetOBANInput(Round2.Generated.Binary.OBAN oban)
    {
        if (m_anim == null)
        {
            m_anim = gameObject.AddComponent<Animation>();
            m_anim.playAutomatically = false;
            m_anim.animatePhysics = true;
        }

        AnimationClip[] l_clips = oban.GetClips(true);

        m_anim.AddClip(l_clips[0], "In");
        m_anim.AddClip(l_clips[1], "Out");
    }

    public void AnimateIn()
    {
        if (m_anim != null)
        {
            m_anim.Play("In");
        }
    }

    public void AnimateOut()
    {
        if (m_anim != null)
        {
            m_anim.Play("Out");
        }
    }
}
