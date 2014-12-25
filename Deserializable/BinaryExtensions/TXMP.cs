using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Oni.Imaging;
using System;
using Oni.Motoko;

namespace Round2.Generated.Binary
{
    internal partial class TXMP
    {
        UnityEngine.Texture2D m_tex;

        public Oni.Imaging.SurfaceFormat Format
        {
            get
            {
                return (Oni.Imaging.SurfaceFormat)this.m_Storetype_90;
            }
        }

        public UnityEngine.Texture2D Surface_0
        {
            get
            {
                if (m_tex == null)
                {
                    //Debug.Log(BinaryDatReader.GetByIndex(this.m_ID_0).Template.Tag);
                    if (this.m_FileName_8.StartsWith("NONE") || this.m_FileName_8.StartsWith("EYE"))
                    {
                        return null;
                    }

                    byte[] l_bytes = Oni.Motoko.TextureDatReader.Read(BinaryDatReader.ResolveInstanceByLink(this.m_ID_0 << 8)).Surfaces[0].Convert(SurfaceFormat.RGBA).Data;
                    List<Color32> l_colors = new List<Color32>();

                    for (int i = 0; i < m_Width_8C * m_Height_8E; i ++)
                    {
                        l_colors.Add(new Color32(l_bytes[i * 4 + 0], l_bytes[i * 4 + 1], l_bytes[i * 4 + 2], l_bytes[i * 4 + 3]));
                    }

                    m_tex = new Texture2D(m_Width_8C, m_Height_8E,  UnityEngine.TextureFormat.RGBA32, true);
                    m_tex.SetPixels32(l_colors.ToArray());
                    m_tex.name = this.m_FileName_8;
                    m_tex.Apply(true, true);
                }

                return m_tex;
            }
        }
    }
}
