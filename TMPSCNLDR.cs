using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class TMPSCNLDR : MonoBehaviour 
{
    static T DeserializeAs<T>(System.IO.MemoryStream ms) where T : new()
    {
        Debug.Log("asgdaskgdhk");
        return (T)new System.Xml.Serialization.XmlSerializer(typeof(T)).Deserialize(ms);
    }

    [Serializable]
    public struct TMP_TX_ENTRY
    {
        public string name;
        public Texture2D tex;
    }

    public List<string> m_texNames = new List<string>();
    public static TMPSCNLDR m_singleton;
    public Texture2D m_targeted_query_texture;
    public List<Mesh> m_meshLst = new List<Mesh>();

    public List<TMP_TX_ENTRY> m_txs = new List<TMP_TX_ENTRY>();

    static void UseONLV(Oni.InstanceDescriptor ides)
    {   
        Round2.ONLV l_onlv = ides.Decode<Round2.ONLV>();
        Debug.Log(l_onlv);
        Debug.Log(l_onlv.Environment);
        Debug.Break();
        Debug.DebugBreak();
        //Debug.Log((l_onlv = DeserializeAs<Round2.ONLV>(ides.AsXmlStream())).Environment.AKEV.Quads.AGQG.Quads[0].Points.Length);
        //l_onlv.InitEnv();
    }

    static void UseAKEV(Oni.InstanceDescriptor ides)
    {
        ides.AsXmlStream();
    }

    static void UseDOOR(Oni.InstanceDescriptor ides)
    {
        Round2.DOOR des = DeserializeAs<Round2.DOOR>(ides.AsXmlStream());
        Debug.Log(des.id);
    }

    static void UseTXMP(Oni.InstanceDescriptor ides)
    {
        Texture2D l_tex = null;

        if ((l_tex = ObtainTXFrom(ides)) != null)
        {
            Texture2DQuery.Loaded(ides.Index, l_tex);
            Debug.Log(ides.Decode<Round2.TXMP>());
            //DeserializeAs<Round2.TXMP>(ides.AsXmlStream());
        }

        //Debug.Log(ides.Name);
    }

    static void UseONCC(Oni.InstanceDescriptor ides)
    {
        DateTime l_n = DateTime.Now;
        ides.AsXmlStream();
        /*
        Round2.ONCC l_chr = DeserializeAs<Round2.ONCC>(ides.AsXmlStream());
        l_chr.SetName(ides.Name);
        Debug.Log(l_chr.BodySet.TRBS.id);
        Oni.Game.CharacterClass l_oncc = Oni.Game.CharacterClass.Read(ides);

        foreach (Oni.InstanceDescriptor animdes in l_oncc.Animations)
        {
            Oni.Totoro.Animation l_tram = Oni.Totoro.AnimationDatReader.Read(animdes);
            l_chr.AddAnimInfo(animdes.Name, l_tram);
            string l_clipname = animdes.Name;

            if (l_tram.FrameSize != 6)//TODO: fix?
            {
                continue;
            }

            AnimationClipHolder.Hold(animdes.Name, controller => 
            {
                bool frameSize = l_tram.FrameSize == 6;
                AnimationClip l_clip = new AnimationClip();
                l_clip.name = l_clipname;

                for (int i = 0; i < l_tram.Rotations.Count; i++)
                {
                    Keyframe[] l_kFrx = new Keyframe[l_tram.Rotations[i].Count];
                    Keyframe[] l_kFry = new Keyframe[l_tram.Rotations[i].Count];
                    Keyframe[] l_kFrz = new Keyframe[l_tram.Rotations[i].Count];
                    Keyframe[] l_kFrw = new Keyframe[l_tram.Rotations[i].Count];
                    int l_duration = 0;

                    for (int j = 0; j < l_tram.Rotations[i].Count; j++)
                    {
                        UnityEngine.Quaternion _l_q;

                        if (!frameSize)
                        {
                            Oni.Quaternion l_q = new Oni.Quaternion(l_tram.Rotations[i][j].Rotation);
                            _l_q = Quaternion.Euler(Oni.MathHelper.ToDegrees(l_q.ToEulerXYZ().X), Oni.MathHelper.ToDegrees(l_q.ToEulerXYZ().Y), Oni.MathHelper.ToDegrees(l_q.ToEulerXYZ().Z));
                        }
                        else
                        {
                            Oni.Quaternion qq = Oni.Quaternion.CreateFromEulerXYZ(l_tram.Rotations[i][j].Rotation.X, -l_tram.Rotations[i][j].Rotation.Y, -l_tram.Rotations[i][j].Rotation.Z);
                            _l_q = new Quaternion(qq.X, qq.Y, qq.Z, qq.W);
                        }

                        l_kFrx[j] = new Keyframe(l_duration * 0.0166666675f, _l_q.x);
                        l_kFry[j] = new Keyframe(l_duration * 0.0166666675f, _l_q.y);
                        l_kFrz[j] = new Keyframe(l_duration * 0.0166666675f, _l_q.z);
                        l_kFrw[j] = new Keyframe(l_duration * 0.0166666675f, _l_q.w);
                        
                        l_duration = l_duration + l_tram.Rotations[i][j].Duration;
                    }

                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    string l_path = "";
                    l_path = "";
                    sb.Remove(0, sb.Length);
                    sb.Append(i == 0 ? "" : ((Round2.ONCC.Bodyparts)i).ToString());
                    l_path = "";

                    for (int _i = l_chr.BodySet.TRBS.Elements[0].TRCM.Hierarchy.TRIA.Elements[i].Parent; _i != l_chr.BodySet.TRBS.Elements[0].TRCM.Hierarchy.TRIA.Elements[_i].Parent; _i = l_chr.BodySet.TRBS.Elements[0].TRCM.Hierarchy.TRIA.Elements[_i].Parent)
                    {
                        sb.Insert(0, '/');
                        sb.Insert(0, ((Round2.ONCC.Bodyparts)_i).ToString());
                    }

                    l_path = sb.ToString();
                    l_clip.SetCurve(l_path, typeof(Transform), "m_LocalRotation.x", new AnimationCurve(l_kFrx));
                    l_clip.SetCurve(l_path, typeof(Transform), "m_LocalRotation.y", new AnimationCurve(l_kFry));
                    l_clip.SetCurve(l_path, typeof(Transform), "m_LocalRotation.z", new AnimationCurve(l_kFrz));
                    l_clip.SetCurve(l_path, typeof(Transform), "m_LocalRotation.w", new AnimationCurve(l_kFrw));
                }

                l_clip.AddEvent(new AnimationEvent() { objectReferenceParameter = controller, functionName = "OnActionFrame", time = (0.0166666675f * l_tram.Velocities.Count) - 1 / 60f, stringParameter = l_clipname });
                l_clip.EnsureQuaternionContinuity();
                l_clip.wrapMode = WrapMode.ClampForever;
                //l_chr.m_clips.Add(l_clip);
                return l_clip;
            });

        }
        
        */
        Debug.Log("finished in " + (DateTime.Now - l_n).TotalSeconds);
    }

    static Dictionary<Oni.TemplateTag, Action<Oni.InstanceDescriptor>> m_installers = new Dictionary<Oni.TemplateTag, Action<Oni.InstanceDescriptor>>
    {
         //{Oni.TemplateTag.TXMP, UseTXMP},
         {Oni.TemplateTag.ONLV, UseONLV },
         //{ Oni.TemplateTag.ONCC, UseONCC }
         //{ Oni.TemplateTag.AKEV, UseAKEV },
         //{ Oni.TemplateTag.DOOR, UseDOOR },
    };

    static internal Texture2D ObtainTXFrom(Oni.InstanceDescriptor txca)
    {
        //Debug.Log(txca.Index);
        {
            try
            {
                Oni.Motoko.Texture l_rtex = Oni.Motoko.TextureDatReader.Read(txca);
                Texture2D l_t = new Texture2D(l_rtex.Width, l_rtex.Height, TextureFormat.RGBA32, true);
                Oni.Imaging.Surface l_s = l_rtex.Surfaces[0].Convert(Oni.Imaging.SurfaceFormat.RGBA);
                List<byte> l_colorBytes = new List<byte>();
                List<Color32> l_colors = new List<Color32>();

                foreach (byte b in l_s.Data)
                {
                    l_colorBytes.Add(b);

                    if (l_colorBytes.Count == 4)
                    {
                        l_colors.Add(new Color32(l_colorBytes[0], l_colorBytes[1], l_colorBytes[2], l_colorBytes[3]));
                        l_colorBytes.Clear();
                    }
                }

                l_t.name = txca.Name;
                l_t.SetPixels32(l_colors.ToArray());
                l_t.Apply(true);
                //Debug.Log(l_t +"|"+txca.Index, l_t);
                return l_t;
            }
            catch (System.Exception ee)
            {
                Debug.LogError("TXCA id : " + txca.Index + "\nName:" + txca.Name + "\n" + ee.ToString());
                return null;
            }
        }
    }

    int m_descriptorsLeft;
    List<Oni.InstanceDescriptor> m_descriptors;

    void Start()
    {
        Application.RegisterLogCallback
        (
            new Func<System.IO.StreamWriter, Application.LogCallback>
                    (
                        writer => (u1, u2, u3) => 
                        {
                            writer.WriteLine(u1 + "\n" + u2 + "\n" + "\n" + u3);
                        }
                    )
                    (
                        System.IO.File.AppendText("D:\\log.txt")
                    )
        );
        m_singleton = this;
       
        StartCoroutine(_Start());
    }

    void OnGUI()
    {
        GUILayout.Label(m_descriptorsLeft.ToString());
    }

    void TryInvoke(Action act)
    {
        try
        {
            act();
        }
        catch (Exception ee)
        {
            Debug.Log(ee);
        }
    }

	// Use this for initialization
	public IEnumerator _Start () 
    {
        //Debug.Log((new System.Object[] { 113, 123, "asd" }).ArrayAsSml());
        //Debug.Log((new System.Object[] { 113, 123, "asd", Round2.GunkFlags.Danger }).ArrayAsSml().SmlToArray());
        //return;
        yield return null;
        Oni.InstanceFileManager fm = new Oni.InstanceFileManager();
        Oni.InstanceFile level0 = fm.OpenFile((Application.isEditor ? @"D:\OniCleanInstall\" : @"..\..\") + @"GameDataFolder\level0_Final.dat");
        Oni.InstanceFile level1 = fm.OpenFile((Application.isEditor ? @"D:\OniCleanInstall\" : @"..\..\") + @"GameDataFolder\level1_Final.dat");
        m_descriptors = level1.GetNamedDescriptors();
        m_descriptorsLeft = m_descriptors.Count;

        foreach (Oni.InstanceDescriptor desc in m_descriptors)
        {
            if (m_installers.ContainsKey(desc.Template.Tag))
            {
                yield return null;
                TryInvoke(() =>
                {
                    m_installers[desc.Template.Tag](desc);
                });
            }

            m_descriptorsLeft--;
        }

        Round2.__ONCC.GetByName("konoko_generic").TMP_InstallNewCharacter(level0);
	}
}
