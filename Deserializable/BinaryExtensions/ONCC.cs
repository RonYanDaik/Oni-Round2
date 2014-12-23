using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Round2.Generated.Binary
{
    internal partial class ONCC
    {
        Dictionary<string, Oni.Totoro.Animation> m_stateTree = new Dictionary<string, Oni.Totoro.Animation>();

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

        void AddAnimInfo(string name, Oni.Totoro.Animation anim)
        {
            if (!m_stateTree.ContainsKey(name))
            {
                m_stateTree.Add(name, anim as Oni.Totoro.Animation);
            }
        }

        public void BuildONCC()
        {
            M3GM[] l_bodyParts = new M3GM[19];
            GameObject[] l_gs = new GameObject[19];

            {
                int l_i = 0;

                foreach (Round2.Generated.Binary.TRGA.Package pkg in this.m_TRBS_link_C3C.Value.m_TRCM_link_18.Value.m_TRGA_link_5C.Value.m_pkg_20)
                {
                    l_bodyParts[l_i++] = pkg.m_M3GM_link_0.Value;
                }
            }

            {
                int l_i = 0;

                foreach (M3GM m in l_bodyParts)
                {
                    Texture2D m_tex = this.m_TRMA_link_C40.Value.m_pkg_20[l_i].m_TXMP_link_0.Value.Surface_0;
                    l_gs[l_i] = new GameObject(((Bodyparts)l_i).ToString());
                    l_gs[l_i].AddComponent<MeshFilter>().mesh = m.UnityMesh;
                    (l_gs[l_i++].AddComponent<MeshRenderer>().material = new Material(Shader.Find("TwoSidedDiffuse"))).mainTexture = m_tex;
                }
            }

            {
                int l_i = 0;

                string child = "";
                string parent = "";
                string sibling = "";

                int l_latestParent = 0;
                int l_nextChainStart = 0;
                List<int> l_childs = new List<int>();
                List<int> l_siblings = new List<int>();

                foreach (TRIA.Package pkg in this.m_TRBS_link_C3C.Value.m_TRCM_link_18.Value.m_TRIA_link_64.Value.m_pkg_20)
                {
                    child += "|" + pkg.m_Major_joint_1;
                    sibling += "|" + pkg.m_Minor_joint_2;
                    parent += "|" + pkg.m_Not_used_0;
                    l_childs.Add(pkg.m_Major_joint_1);
                    l_siblings.Add(pkg.m_Minor_joint_2);

                    if (pkg.m_Major_joint_1 != 0)
                    {
                        l_gs[pkg.m_Major_joint_1].transform.parent = l_gs[l_i].transform;
                    }

                    if (pkg.m_Minor_joint_2 != 0)
                    {
                        l_gs[pkg.m_Minor_joint_2].transform.parent = l_gs[l_i].transform.parent;
                    }

                    l_i++;
                }

                Debug.Log(parent);
                Debug.Log(child);
                Debug.Log(sibling);
                l_i = 0;

                foreach (TRTA.Package pkg in this.m_TRBS_link_C3C.Value.m_TRCM_link_18.Value.m_TRTA_link_60.Value.m_pkg_20)
                {
                    l_gs[l_i++].transform.localPosition = new UnityEngine.Vector3(-pkg.m_x_position_0, pkg.m_y_position_4, pkg.m_z_position_8);
                }

                Oni.InstanceDescriptor l_TRAC = BinaryDatReader.GetByIndex(this.m_File_id_0);
                Oni.Game.CharacterClass l_oncc = Oni.Game.CharacterClass.Read(l_TRAC);

                foreach (Oni.InstanceDescriptor animdes in l_oncc.Animations)
                {
                    //Debug.Log(animdes.Name);
                    Oni.Totoro.Animation l_tram = Oni.Totoro.AnimationDatReader.Read(animdes);
                    AddAnimInfo(animdes.Name, l_tram);
                    string l_clipname = animdes.Name;

                    if (l_tram.FrameSize != 6)//TODO: fix?
                    {
                        continue;
                    }


                    AnimationClipHolder.Hold(animdes.Name, controller =>
                    {
                        AnimationClip l_clip = null;
                        l_clip.name = l_clipname;

                        for (int i = 0; i < l_tram.Rotations.Count; i++)
                        {
                            Keyframe[] l_kFrx = new Keyframe[l_tram.Rotations[i].Count];
                            Keyframe[] l_kFry = new Keyframe[l_tram.Rotations[i].Count];
                            Keyframe[] l_kFrz = new Keyframe[l_tram.Rotations[i].Count];
                            Keyframe[] l_kFrw = new Keyframe[l_tram.Rotations[i].Count];
                            int l_duration = 0;

                        }

                        return l_clip;
                    });
                }
            }
        }
    }
}
