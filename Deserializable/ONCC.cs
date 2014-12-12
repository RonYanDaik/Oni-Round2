using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Round2
{
    public class _ONCC
    {
        [XmlElement("ONCC")]
        public __ONCC @ONCC;
    }

    [XmlType("ONCC")]
    public class __ONCC
    {
        [XmlIgnore]
        public List<AnimationClip> m_clips = new List<AnimationClip>();

        static Dictionary<string, __ONCC> m_nameToONCC = new Dictionary<string, __ONCC>();

        public static __ONCC GetByName(string name)
        {
            if (m_nameToONCC.ContainsKey(name))
            {
                return m_nameToONCC[name];
            }

            return null;
        }

        public void SetName(string name)
        {
            Debug.Log("character:" + name);
            m_nameToONCC.Add(name, this);
        }

        public enum Bodyparts
        {
            /*
            0	00	pelvis/none
            01	01	left thigh
            02	02	left calf
            03	03	left foot
            04	04	right thigh
            05	05	right calf
            06	06	right foot
            07	07	mid
            08	08	chest
            09	09	neck
            0A	10	head
            0B	11	left shoulder
            0C	12	left arm
            0D	13	left wrist
            0E	14	left fist
            0F	15	right shoulder
            10	16	right arm
            11	17	right wrist
            12	18	right fist
             */
            pelvis = 0,
            left_thigh = 0x1,
            left_calf = 0x2,
            left_foot = 0x3,
            right_thigh = 0x4,
            right_calf = 0x5,
            right_foot = 0x6,
            mid = 0x7,
            chest = 0x8,
            neck = 0x9,
            head = 0xA,
            left_shoulder = 0xB,
            left_arm = 0xC,
            left_wrist = 0xD,
            left_fist = 0xE,
            right_shoulder = 0xF,
            right_arm = 0x10,
            right_wrist = 0x11,
            right_fist = 0x12
        }


        [XmlAttribute]
        public int id;

        _TRBS m_bodySet;

        public _TRBS BodySet
        {
            get
            {
                return m_bodySet;
            }

            set
            {
                m_bodySet = value;
            }
        }

        [XmlIgnore]
        Dictionary<string, Oni.Totoro.Animation> m_stateTree = new Dictionary<string, Oni.Totoro.Animation>();

        public void AddAnimInfo(string name, object anim)
        {
            if (!m_stateTree.ContainsKey(name))
            {
                m_stateTree.Add(name, anim as Oni.Totoro.Animation);
            }
        }

        public object GetAnimInfo(string name)
        {
            return m_stateTree.ContainsKey(name) ? m_stateTree[name] : null;
        } 

        public _TRMA BodyTextures;

        internal void TMP_InstallNewCharacter(Oni.InstanceFile level0)
        {
            List<Mesh> l_meshes = new List<Mesh>();
            List<GameObject> l_parts = new List<GameObject>();

            foreach (Links.M3GMLNK geomery in this.BodySet.TRBS.Elements[4].TRCM.Geometry.TRGA.Geometries)
            {
                l_meshes.Add(geomery.M3GM.UnityMesh);
            }

            for (int i = 0; i < this.BodySet.TRBS.Elements[4].TRCM.BodyPartCount; i++)
            {
                GameObject l_newest;
                l_parts.Add(l_newest = GameObject.CreatePrimitive(PrimitiveType.Cube));
                l_newest.name = ((__ONCC.Bodyparts)i).ToString();
                l_newest.GetComponent<MeshFilter>().mesh = l_meshes[i];
                GameObject.Destroy(l_newest.collider);
                l_newest.renderer.material.shader = Shader.Find("TwoSidedDiffuse");
            }

            for (int i = 0; i < this.BodySet.TRBS.Elements[4].TRCM.BodyPartCount; i++)
            {
                l_parts[i].transform.parent = l_parts[this.BodySet.TRBS.Elements[4].TRCM.Hierarchy.TRIA.Elements[i].Parent].transform;
                Vector3 lpos = this.BodySet.TRBS.Elements[4].TRCM.Position.TRTA.Translations[i];
                l_parts[i].transform.localPosition = new UnityEngine.Vector3(-lpos.Value.x, lpos.Value.y, lpos.Value.z);
                Material l_m = l_parts[i].renderer.material;
                Texture2DQuery.TexturePend(this.BodyTextures.TRMA.Textures[i].TXMP.id, u => l_m.mainTexture = u);
            }

            //l_parts[0].transform.parent = new GameObject("chr").transform;
            Animation l_a = l_parts[0].gameObject.AddComponent<Animation>();
            l_parts[0].AddComponent<GUIANIMCONTROL>();
            l_parts[0].AddComponent<CharacterController>();
            Camera.allCameras[0].transform.parent =
            l_parts[0].transform;
        }
    }
}
