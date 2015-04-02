using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Round2.Generated.Binary
{
    internal partial class ONLV 
    {
        GameObject l_lvlObj = null;
        //GeometryBuilder m_bldr;
        Dictionary<int, Dictionary<int, GeometryBuilder>> m_fullRenderInfo = new Dictionary<int, Dictionary<int, GeometryBuilder>>();

        /// <summary>
        /// see http://wiki.oni2.net/OBD:AGQC for more data
        /// </summary>
        public void BuildCollisions()
        { 
            //this is nothing to do yet
        }

        public void Build()
        {
            //m_bldr = new GeometryBuilder(this.m_Level_name_8, this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array, this.m_AKEV_Link_48.Value.m_TXCA_link_10.Value.Array);
            l_lvlObj = new GameObject(this.m_Level_name_8);
            l_lvlObj.AddComponent<MeshRenderer>().material = new Material(Shader.Find("VertexShadedDiffuse"));

            foreach (AGQR.Package renderInfo in this.m_AKEV_Link_48.Value.m_AGQR_link_18.Value.m_pkg_20)
            {
                if (!m_fullRenderInfo.ContainsKey(renderInfo.m_TXMA_id_0))
                {
                    m_fullRenderInfo.Add(renderInfo.m_TXMA_id_0, new Dictionary<int, GeometryBuilder>());
                }
            }

            HashSet<int> l_ignoreQuadLst = new HashSet<int>();

            /*
            foreach (OBOA.Package pkg in this.m_OBOA_Link_4C.Value.m_pkg_20)
            {
                OBJCInst.BindOBOAPKG(pkg);
            }*/

            foreach (ONOA.Package pkg in this.m_ONOA_Link_74.Value.m_pkg_20)
            {
                if (pkg.m_High_bit_3 == 0x03)//let's search only for doors
                {
                    if (pkg.m_IDXA_link_4.m_lnkId != 0)
                    {
                        foreach (IDXA.Package index in pkg.m_IDXA_link_4.Value.m_pkg_20)
                        {
                            l_ignoreQuadLst.Add(index.m_Index_id_0);
                        }
                    }
                    else
                    {
                        Debug.LogError("IDXA LINK = 0");
                    }
                }
            }

            int l_i = 0;

            foreach (OBOA.Package pkg in this.m_OBOA_Link_4C.Value.m_pkg_20)
            {
                l_i++;
                RTOBOA.Instantiate(pkg);
                //Door.OBOALink(pkg);

                if (pkg.m_OBAN_link_4.m_lnkId != 0)
                {
                    /*
                     * TODO : implement OBOA's not only for doors, similar to code below:
                    string l_objname = pkg.m_Name_70;
                    UnityEngine.Vector3 l_pos = new UnityEngine.Vector3(-pkg.m_OBAN_link_4.Value.m_x_position_3C, pkg.m_OBAN_link_4.Value.m_y_position_40, pkg.m_OBAN_link_4.Value.m_z_position_44);
                    GameObject l_g = new GameObject(l_objname);
                    l_g.transform.position = l_pos;
                    l_g.AddComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
                    l_g.AddComponent<MeshFilter>().mesh = pkg.m_M3GA_link_0.Value.m_pkg_20[0].m_M3GM_link_0.Value.UnityMesh;
                    l_g.AddComponent<MeshCollider>().mesh = pkg.m_M3GA_link_0.Value.m_pkg_20[0].m_M3GM_link_0.Value.UnityMesh;
                    l_g.transform.position = new UnityEngine.Vector3(-pkg.m_OBAN_link_4.Value.m_x_position_3C, pkg.m_OBAN_link_4.Value.m_y_position_40, pkg.m_OBAN_link_4.Value.m_z_position_44);*/
                }
                else
                {
                    Debug.LogError("OBAN LINK = 0, " + l_i + "\\" + this.m_OBOA_Link_4C.Value.m_pkg_20.Length);
                }
            }

            List<int>.Enumerator l_renderKeysEnumerator = new List<int>( this.m_AKEV_Link_48.Value.m_AGQR_link_18.Value.m_pkg_20.ConvertAll<AGQR.Package, int>( u => u.m_TXMA_id_0)).GetEnumerator();
            int l_quadID = 0;

            foreach(AGQG.Package quad in this.m_AKEV_Link_48.Value.m_AGQG_link_14.Value.m_pkg_20)
            {
                l_renderKeysEnumerator.MoveNext();

                if (!m_fullRenderInfo[l_renderKeysEnumerator.Current].ContainsKey(quad.m_flags_30))
                { 
                    TXMP l_tx = this.m_AKEV_Link_48.Value.m_TXMA_link_24.Value.m_pkg_20[l_renderKeysEnumerator.Current].m_TXMP_link_0.Value;
                    m_fullRenderInfo[l_renderKeysEnumerator.Current].Add(quad.m_flags_30, new GeometryBuilder(l_tx == null ? "unknown texture" : l_tx.m_FileName_8, this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array, this.m_AKEV_Link_48.Value.m_TXCA_link_10.Value.Array));
                }

                if (!l_ignoreQuadLst.Contains(l_quadID++))//i bet nobody needs additional vertices for doors
                {
                    //Debug.DrawLine(this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_1_0], this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_2_4], Color.green, 15f);
                    //Debug.DrawLine(this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_2_4], this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_3_8], Color.green, 15f);

                    {
                        if (quad.m_pnta_id_3_8 == quad.m_pnta_id_4_C)
                        {
                            byte[] l_color1Bytes = System.BitConverter.GetBytes(quad.m_argb_vrtx_color_1_20);
                            byte[] l_color2Bytes = System.BitConverter.GetBytes(quad.m_argb_vrtx_color_2_24);
                            byte[] l_color3Bytes = System.BitConverter.GetBytes(quad.m_argb_vrtx_color_3_28);
                            m_fullRenderInfo[l_renderKeysEnumerator.Current][quad.m_flags_30]
                                .Triangle
                                (
                                    quad.m_pnta_id_1_0, 
                                    quad.m_pnta_id_2_4, 
                                    quad.m_pnta_id_3_8, 
                                    quad.m_txca_id_1_10, 
                                    quad.m_txca_id_2_14, 
                                    quad.m_txca_id_3_18,
                                    new Color32[]
                                    { 
                                        new Color32 ( l_color1Bytes[0], l_color1Bytes[1], l_color1Bytes[2],l_color1Bytes[3]),
                                        new Color32 ( l_color2Bytes[0], l_color2Bytes[1], l_color2Bytes[2],l_color2Bytes[3]),
                                        new Color32 ( l_color3Bytes[0], l_color3Bytes[1], l_color3Bytes[2],l_color3Bytes[3])
                                    }
                                );

                            Debug.DrawLine(this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_3_8], this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_3_8] + UnityEngine.Vector3.up, new Color32(l_color1Bytes[0], l_color1Bytes[1], l_color1Bytes[2], l_color1Bytes[3]), 15f);
                            //m_bldr.Triangle(quad.m_pnta_id_1_0, quad.m_pnta_id_2_4, quad.m_pnta_id_3_8, quad.m_txca_id_1_10, quad.m_txca_id_2_14, quad.m_txca_id_3_18);
                            //Debug.DrawLine(this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_3_8], this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_1_0], Color.green, 15f);
                        }
                        else
                        {
                            byte[] l_color1Bytes = System.BitConverter.GetBytes(quad.m_argb_vrtx_color_1_20);
                            byte[] l_color2Bytes = System.BitConverter.GetBytes(quad.m_argb_vrtx_color_2_24);
                            byte[] l_color3Bytes = System.BitConverter.GetBytes(quad.m_argb_vrtx_color_3_28);
                            byte[] l_color4Bytes = System.BitConverter.GetBytes(quad.m_argb_vrtx_color_4_2C);
                            m_fullRenderInfo[l_renderKeysEnumerator.Current][quad.m_flags_30]
                                .Quad
                                (
                                    quad.m_pnta_id_1_0, 
                                    quad.m_pnta_id_2_4, 
                                    quad.m_pnta_id_3_8, 
                                    quad.m_pnta_id_4_C, 
                                    quad.m_txca_id_1_10, 
                                    quad.m_txca_id_2_14, 
                                    quad.m_txca_id_3_18, 
                                    quad.m_txca_id_4_1C,
                                    new Color32[]
                                    {
                                        new Color32 ( l_color1Bytes[0], l_color1Bytes[1], l_color1Bytes[2],l_color1Bytes[3]),
                                        new Color32 ( l_color2Bytes[0], l_color2Bytes[1], l_color2Bytes[2],l_color2Bytes[3]),
                                        new Color32 ( l_color3Bytes[0], l_color3Bytes[1], l_color3Bytes[2],l_color3Bytes[3]),
                                        new Color32 ( l_color4Bytes[0], l_color4Bytes[1], l_color4Bytes[2],l_color4Bytes[3])
                                    }
                                );
                            //m_bldr.Quad(quad.m_pnta_id_1_0, quad.m_pnta_id_2_4, quad.m_pnta_id_3_8, quad.m_pnta_id_4_C, quad.m_txca_id_1_10, quad.m_txca_id_2_14, quad.m_txca_id_3_18, quad.m_txca_id_4_1C);
                            //Debug.DrawLine(this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_3_8], this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_4_C], Color.green, 15f);
                            //Debug.DrawLine(this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_4_C], this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_1_0], Color.green, 15f);
                        }
                    }
                }
            }

            foreach (int txid in m_fullRenderInfo.Keys)
            {
                foreach (int flags in m_fullRenderInfo[txid].Keys)
                {
                    m_fullRenderInfo[txid][flags].UpdateMesh();
                    GameObject l_g = new GameObject(" flags = " + flags.ToString("X") + " :: " + m_fullRenderInfo[txid][flags].Name);

                    Material l_m = (l_g.AddComponent<MeshRenderer>().material = new Material(Shader.Find("VertexShadedDiffuse")));

                    if (this.m_AKEV_Link_48.Value.m_TXMA_link_24.Value.m_pkg_20[txid] != null && this.m_AKEV_Link_48.Value.m_TXMA_link_24.Value.m_pkg_20[txid].m_TXMP_link_0.Value != null)
                    {   
                        l_m.mainTexture = this.m_AKEV_Link_48.Value.m_TXMA_link_24.Value.m_pkg_20[txid].m_TXMP_link_0.Value.Surface_0;
                    }

                    l_g.AddComponent<MeshFilter>().mesh = m_fullRenderInfo[txid][flags].Mesh;
                    GunkFlags l_quadFlags = (GunkFlags)flags;

                    if ((l_quadFlags & GunkFlags.Ghost) != 0 || (l_quadFlags & GunkFlags.StairsUp) != 0 || (l_quadFlags & GunkFlags.StairsDown) != 0 || (l_quadFlags & GunkFlags.DoorFrame) != 0 || (l_quadFlags & GunkFlags.Furniture) != 0)
                    {
                        continue;
                    }
                    else
                    {
                        l_g.AddComponent<MeshCollider>().mesh = m_fullRenderInfo[txid][flags].Mesh;
                    }
                }
            }

            //this.m_bldr.UpdateMesh();
            //l_lvlObj.AddComponent<MeshFilter>().mesh = this.m_bldr.Mesh;
        }
    }
}
