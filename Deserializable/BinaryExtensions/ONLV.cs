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
            l_lvlObj.AddComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse"));
            Debug.Log(this.m_AKEV_Link_48.Value.m_AGQR_link_18.Value.m_pkg_20.Length + "|" + this.m_AKEV_Link_48.Value.m_AGQG_link_14.Value.m_pkg_20.Length);

            foreach (AGQR.Package renderInfo in this.m_AKEV_Link_48.Value.m_AGQR_link_18.Value.m_pkg_20)
            {
                if (!m_fullRenderInfo.ContainsKey(renderInfo.m_TXMA_id_0))
                {
                    m_fullRenderInfo.Add(renderInfo.m_TXMA_id_0, new Dictionary<int, GeometryBuilder>());
                }
            }

            List<int>.Enumerator l_renderKeysEnumerator = new List<int>( this.m_AKEV_Link_48.Value.m_AGQR_link_18.Value.m_pkg_20.ConvertAll<AGQR.Package, int>( u => u.m_TXMA_id_0)).GetEnumerator();
            
            foreach(AGQG.Package quad in this.m_AKEV_Link_48.Value.m_AGQG_link_14.Value.m_pkg_20)
            {
                l_renderKeysEnumerator.MoveNext();

                if (!m_fullRenderInfo[l_renderKeysEnumerator.Current].ContainsKey(quad.m_flags_30))
                { 
                    TXMP l_tx = this.m_AKEV_Link_48.Value.m_TXMA_link_24.Value.m_pkg_20[l_renderKeysEnumerator.Current].m_TXMP_link_0.Value;

                    m_fullRenderInfo[l_renderKeysEnumerator.Current].Add(quad.m_flags_30, new GeometryBuilder(l_tx == null ? "unknown texture" : l_tx.m_FileName_8, this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array, this.m_AKEV_Link_48.Value.m_TXCA_link_10.Value.Array));
                }

                if (quad.m_obj_id_34 == -1)//i bet nobody needs additional vertices for objects with geometry
                {
                    Debug.DrawLine(this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_1_0], this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_2_4], Color.green, 15f);
                    Debug.DrawLine(this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_2_4], this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_3_8], Color.green, 15f);

                    
                    {
                        if (quad.m_pnta_id_3_8 == quad.m_pnta_id_4_C)
                        {

                            m_fullRenderInfo[l_renderKeysEnumerator.Current][quad.m_flags_30].Triangle(quad.m_pnta_id_1_0, quad.m_pnta_id_2_4, quad.m_pnta_id_3_8, quad.m_txca_id_1_10, quad.m_txca_id_2_14, quad.m_txca_id_3_18);
                        
                            //m_bldr.Triangle(quad.m_pnta_id_1_0, quad.m_pnta_id_2_4, quad.m_pnta_id_3_8, quad.m_txca_id_1_10, quad.m_txca_id_2_14, quad.m_txca_id_3_18);
                            Debug.DrawLine(this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_3_8], this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_1_0], Color.green, 15f);
                        }
                        else
                        {
                            m_fullRenderInfo[l_renderKeysEnumerator.Current][quad.m_flags_30].Quad(quad.m_pnta_id_1_0, quad.m_pnta_id_2_4, quad.m_pnta_id_3_8, quad.m_pnta_id_4_C, quad.m_txca_id_1_10, quad.m_txca_id_2_14, quad.m_txca_id_3_18, quad.m_txca_id_4_1C);
                            //m_bldr.Quad(quad.m_pnta_id_1_0, quad.m_pnta_id_2_4, quad.m_pnta_id_3_8, quad.m_pnta_id_4_C, quad.m_txca_id_1_10, quad.m_txca_id_2_14, quad.m_txca_id_3_18, quad.m_txca_id_4_1C);
                            Debug.DrawLine(this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_3_8], this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_4_C], Color.green, 15f);
                            Debug.DrawLine(this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_4_C], this.m_AKEV_Link_48.Value.m_PNTA_link_8.Value.Array[quad.m_pnta_id_1_0], Color.green, 15f);
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
                    
                    Material l_m = (l_g.AddComponent<MeshRenderer>().material = new Material(Shader.Find("Diffuse")));

                    if (this.m_AKEV_Link_48.Value.m_TXMA_link_24.Value.m_pkg_20[txid] != null && this.m_AKEV_Link_48.Value.m_TXMA_link_24.Value.m_pkg_20[txid].m_TXMP_link_0.Value != null)
                    {   
                        l_m.mainTexture = this.m_AKEV_Link_48.Value.m_TXMA_link_24.Value.m_pkg_20[txid].m_TXMP_link_0.Value.Surface_0;
                    }

                    l_g.AddComponent<MeshFilter>().mesh = m_fullRenderInfo[txid][flags].Mesh;
                }
            }

            //this.m_bldr.UpdateMesh();
            //l_lvlObj.AddComponent<MeshFilter>().mesh = this.m_bldr.Mesh;
        }
    }
}
