using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class GeometryBuilder 
{
    string m_name;
    Vector3[] m_vrtx;
    Vector2[] m_txcoords;
    Vector3[] m_normals;
    
    public string Name
    {
        get
        {
            return m_name;
        }
    }

    public GeometryBuilder(string name, Vector3[] positionSource, Vector2[] txcoordSource, Vector3[] normalsSouce = null)
    {
        m_name = name;
        m_vrtx = positionSource;
        m_txcoords = txcoordSource;
        m_normals = normalsSouce;
    }

    public void Quad(int v1, int v2, int v3, int v4, int t1, int t2, int t3, int t4, Color32[] colors = null)
    {
        Triangle(v1, v2, v3, t1, t2, t3, colors == null ? new Color32[] { Color.white, Color.white, Color.white } : new Color32[] { colors[0], colors[1], colors[2] });
        Triangle(v3, v4, v1, t3, t4, t1, colors == null ? new Color32[] { Color.white, Color.white, Color.white } : new Color32[] { colors[2], colors[3], colors[0] });
    }

    List<UvGroup> m_groups = new List<UvGroup>() { new UvGroup() };

    class UvGroup
    {
        public int m_offset = 0;
        public Dictionary<int, Color32> m_vtrToColor = new Dictionary<int, Color32>();
        public Dictionary<int, int> m_vrtToUv = new Dictionary<int, int>();
        /// <summary>
        /// add vertex index here
        /// </summary>
        public List<int> m_strip = new List<int>();
    }

    internal void Triangle(int v1, int v2, int v3, int t1, int t2, int t3, Color32[] colors = null)
    {
        bool l_addToNewStrip = true;

        foreach (UvGroup group in m_groups)
        {
            if (!group.m_vrtToUv.Contains(t1, v1) && !group.m_vrtToUv.Contains(t2, v2) && !group.m_vrtToUv.Contains(t3, v3))
            {
                if (!group.m_vrtToUv.ContainsKey(v1) && !group.m_vrtToUv.ContainsKey(v2) && !group.m_vrtToUv.ContainsKey(v3))
                {
                    group.m_vtrToColor.Add(v1, colors[0]);
                    group.m_vtrToColor.Add(v2, colors[1]);
                    group.m_vtrToColor.Add(v3, colors[2]);
                    group.m_vrtToUv.Add(v1, t1);
                    group.m_vrtToUv.Add(v2, t2);
                    group.m_vrtToUv.Add(v3, t3);
                    group.m_strip.Add(v1);
                    group.m_strip.Add(v2);
                    group.m_strip.Add(v3);
                    return;
                }
            }
            else
            {
                if (group.m_vrtToUv.Contains(t1, v1) && group.m_vrtToUv.Contains(t2, v2) && group.m_vrtToUv.Contains(t3, v3))
                {
                    group.m_strip.Add(v1);
                    group.m_strip.Add(v2);
                    group.m_strip.Add(v3);
                    return;
                }
                else
                {
                    l_addToNewStrip = true;
                }
            }
        }

        if (l_addToNewStrip)
        {
            UvGroup l_group = new UvGroup();
            m_groups.Add(l_group);
            l_group.m_vtrToColor.Add(v1, colors[0]);
            l_group.m_vtrToColor.Add(v2, colors[1]);
            l_group.m_vtrToColor.Add(v3, colors[2]);
            l_group.m_vrtToUv.Add(v1, t1);
            l_group.m_vrtToUv.Add(v2, t2);
            l_group.m_vrtToUv.Add(v3, t3);
            l_group.m_strip.Add(v1);
            l_group.m_strip.Add(v2);
            l_group.m_strip.Add(v3);
        }
        else
        {
            throw new Exception("wtf");
        }
    }

    class TRI
    {
        public int t1;
        public int v1;
        public int t2;
        public int v2;
        public int t3;
        public int v3;

        public static bool operator == (TRI @this, TRI other)
        {
            return
                @this.t1 == other.t1 && @this.v1 == @this.v1 &&
                @this.t2 == other.t2 && @this.v2 == @this.v2 &&
                @this.t3 == other.t3 && @this.v3 == @this.v3;
        }

        public static bool operator !=(TRI @this, TRI other)
        {
            return
                !
                (@this.t1 == other.t1 && @this.v1 == @this.v1 &&
                @this.t2 == other.t2 && @this.v2 == @this.v2 &&
                @this.t3 == other.t3 && @this.v3 == @this.v3);
        }

        public override int GetHashCode()
        {
            List<byte> l_bytes = new List<byte>();
            l_bytes.AddRange(BitConverter.GetBytes(t1));
            l_bytes.AddRange(BitConverter.GetBytes(t2));
            l_bytes.AddRange(BitConverter.GetBytes(t3));
            l_bytes.AddRange(BitConverter.GetBytes(v1));
            l_bytes.AddRange(BitConverter.GetBytes(v2));
            l_bytes.AddRange(BitConverter.GetBytes(v3));
            return LyHash(l_bytes.ToArray());
        }
    }

    /// <summary>
    /// Each dictionary is vertex-to-triangle dictionary
    /// </summary>
    List<Dictionary<int, TRI>> m_uvLayers = new List<Dictionary<int, TRI>>();

    static int LyHash(byte[] bytes)
    {
        int l_res = 0;

        for (int i = 0; i < bytes.Length; i++)
        { 
            l_res = (l_res * 1664525) + bytes[i] + 1013904223;
        }

        return l_res;
    }

    Mesh m_mesh = new Mesh();

    public void UpdateMesh()
    {
        m_mesh.Clear();
        List<CombineInstance> l_internalList = new List<CombineInstance>();

        if (m_groups.Count > 0)
        {
            foreach (UvGroup group in m_groups)
            {
                List<Vector3> l_vrts = new List<Vector3>();
                List<Vector2> l_uvs = new List<Vector2>();
                Dictionary<int, int> l_fakeToRealIndex = new Dictionary<int, int>();
                List<int> l_indices = new List<int>();
                List<Color32> l_colors = new List<Color32>();

                foreach (int vrti in group.m_vrtToUv.Keys)
                {
                    l_vrts.Add(m_vrtx[vrti]);
                    l_uvs.Add(m_txcoords[group.m_vrtToUv[vrti]]);

                    if (!l_fakeToRealIndex.ContainsKey(vrti))
                    {
                        l_fakeToRealIndex.Add(vrti, l_fakeToRealIndex.Count);
                    }

                    l_indices.Add(l_fakeToRealIndex[vrti]);
                }

                foreach (int vrti in group.m_vrtToUv.Keys)
                {
                    l_colors.Add(group.m_vtrToColor[vrti]);
                }

                CombineInstance l_ci = new CombineInstance();
                Mesh l_mesh = new UnityEngine.Mesh();
                l_mesh.vertices = l_vrts.ConvertAll<UnityEngine.Vector3>( u => new Vector3(-u.x, u.y, u.z)).ToArray();
                l_mesh.uv = l_uvs.ToArray();
                l_mesh.colors32 = l_colors.ToArray();
                List<int> l_indicesRealigned = new List<int>();
                List<int> l_indicesBuffer = new List<int>(3);

                foreach (int index in l_indices)
                {
                    l_indicesBuffer.Add(index);

                    if (l_indicesBuffer.Count > 2)
                    {
                        l_indicesBuffer.Reverse();
                        l_indicesRealigned.AddRange(l_indicesBuffer);
                        l_indicesBuffer.Clear();
                    }
                }

                l_mesh.triangles = l_indicesRealigned.ToArray();
                l_ci.mesh = l_mesh;
                l_ci.transform = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, Vector3.one);
                l_internalList.Add(l_ci);
            }
        }
        else
        {
            Debug.LogWarning("dafuq wtf here is groups 0");
        }

        m_mesh.CombineMeshes(l_internalList.ToArray());

        foreach (CombineInstance ci in l_internalList)
        {
            ci.mesh.Clear();
            GameObject.Destroy(ci.mesh);
        }

        m_mesh.RecalculateBounds();
        m_mesh.RecalculateNormals();
    }

    public Mesh @Mesh
    {
        get
        {
            return m_mesh;
        }
    }
}
