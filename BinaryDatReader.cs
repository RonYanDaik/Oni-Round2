﻿using UnityEngine;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

public class BinaryDatReader : MonoBehaviour
{
    // 1..4  : Integer[1..4] dec
    // 5..8  : Integer[1..4] hex
    // 9     : float
    // 10    : bitset
    // 11    : raw-addr
    // 12    : untyped-dat-file-ID-link
    // 13..16: Signed Integer[1..4]
    // 17    : level-ID
    // 100..300: dat-file-name[0..200]
    // 501..614: typed-dat-file-ID-link
    // 1000..9999: Unused data[0-8999]
    // 10000+: string[0+]

    static Dictionary<int, FieldData> m_typesDict = new Dictionary<int, FieldData>();

    public static object ConverterStub(byte[] data, int len)
    {
        return 0;
    }

    internal class FieldData
    {
        public System.Type m_fldType = typeof(int);
        public delegate object Converter(byte[] data, int len);
        public Converter DoConvert = ConverterStub;
        public int m_strln = 4;
    }

    internal static FieldData SelectFieldData(int type)
    {
        if (type < 1000)
        {
            return m_typesDict[type];
        }
        else
        {
            if (type > 9999)
            {
                FieldData l_tmpdat = m_typesDict[10000];
                l_tmpdat.m_strln = type - 10000;
                return l_tmpdat;
            }
        }

        return new FieldData();
    }

    public static object l_int8(byte[] bytes, int len)
    {
        return bytes[0];
    }

    public static object l_int16(byte[] bytes, int len)
    {
        return (System.Int16)(bytes[0] + (bytes[1] << 8));
    }

    public static object l_int24(byte[] bytes, int len)
    {
        return bytes[0] + (bytes[1] << 8) + (bytes[2] << 16);
    }

    public static object l_int32(byte[] bytes, int len)
    {
        return bytes[0] + (bytes[1] << 8) + (bytes[2] << 16) + (bytes[3] << 24);
    }

    public static object l_float(byte[] bytes, int len)
    {
        return System.BitConverter.ToSingle(bytes, 0);
    }

    public static object l_str(byte[] bytes, int len)
    {
        char[] l_chars = new char[len];

        for (int i = 0; i < len; i++)
        {
            l_chars[i] = (char)bytes[i];
        }

        return new string(l_chars);
    }

    static BinaryDatReader()
    {
        System.Action<int, int, FieldData> l_cycle = (from, to, type) =>
        {
            for (int i = from; i < to; i++)
            {
                m_typesDict.Add(i, type);
            }
        };

        m_typesDict.Add(1, new FieldData() { m_fldType = typeof(byte), DoConvert = l_int8, m_strln = 1 });
        m_typesDict.Add(2, new FieldData() { m_fldType = typeof(System.Int16), DoConvert = l_int16, m_strln = 2 });
        m_typesDict.Add(3, new FieldData() { m_fldType = typeof(int), DoConvert = l_int24, m_strln = 3 });
        m_typesDict.Add(4, new FieldData() { m_fldType = typeof(int), DoConvert = l_int32, m_strln = 4 });
        m_typesDict.Add(5, new FieldData() { m_fldType = typeof(byte), DoConvert = l_int8, m_strln = 1 });
        m_typesDict.Add(6, new FieldData() { m_fldType = typeof(System.Int16), DoConvert = l_int16, m_strln = 2 });
        m_typesDict.Add(7, new FieldData() { m_fldType = typeof(int), DoConvert = l_int24, m_strln = 3 });
        m_typesDict.Add(8, new FieldData() { m_fldType = typeof(int), DoConvert = l_int32, m_strln = 4 });
        m_typesDict.Add(9, new FieldData() { m_fldType = typeof(float), DoConvert = l_float, m_strln = sizeof(float) });
        m_typesDict.Add(10, new FieldData() { m_fldType = typeof(int), DoConvert = l_int32, m_strln = 4 });
        m_typesDict.Add(11, new FieldData() { m_fldType = typeof(int), DoConvert = l_int32, m_strln = 4 });
        m_typesDict.Add(12, new FieldData() { m_fldType = typeof(int), DoConvert = l_int32, m_strln = 4 });
        m_typesDict.Add(13, new FieldData() { m_fldType = typeof(byte), DoConvert = l_int8, m_strln = 1 });
        m_typesDict.Add(14, new FieldData() { m_fldType = typeof(System.Int16), DoConvert = l_int16, m_strln = 2 });
        m_typesDict.Add(15, new FieldData() { m_fldType = typeof(int), DoConvert = l_int32, m_strln = 4 });
        m_typesDict.Add(16, new FieldData() { m_fldType = typeof(int), DoConvert = l_int32, m_strln = 4 });
        m_typesDict.Add(17, new FieldData() { m_fldType = typeof(int), DoConvert = l_int32, m_strln = 4 });
        l_cycle(100, 300, new FieldData() { m_fldType = typeof(int), DoConvert = l_int32, m_strln = 4 });
        l_cycle(501, 614, new FieldData() { m_fldType = typeof(int), DoConvert = l_int32, m_strln = 4 });
        m_typesDict.Add(10000, new FieldData() { m_fldType = typeof(string), DoConvert = l_str, m_strln = 0 });
    }

    static Dictionary<Oni.InstanceDescriptor, System.Func<Round2.BinaryInitializable>> m_descriptors = new Dictionary<Oni.InstanceDescriptor, System.Func<Round2.BinaryInitializable>>();

    static void ParseBINA(Round2.BinaryInitializable obj, Oni.InstanceDescriptor ides)
    {
        Round2.Generated.Binary.BINA l_bina = (Round2.Generated.Binary.BINA)obj;
        
        using(Oni.BinaryReader l_rawReader = ides.GetRawReader(l_bina.m_Offset_C))
        {
            int l_tag = l_rawReader.ReadInt32();

            switch ((Oni.Metadata.BinaryTag)l_tag)
            {
                case Oni.Metadata.BinaryTag.OBJC:
                    {
                        int l_size = l_rawReader.ReadInt32();
                        int l_version = l_rawReader.ReadInt32();

                        for (int l_nextSize = l_rawReader.ReadInt32(); l_nextSize != 0; l_nextSize = l_rawReader.ReadInt32())
                        {
                            int l_npos = l_rawReader.Position + l_nextSize;//calculate next position
                            string l_objType = (string)l_str(l_rawReader.ReadBytes(4).ReverseBytes(), 4);
                            int l_objID = l_rawReader.ReadInt32();
                            int l_flags = l_rawReader.ReadInt32();
                            float l_xPos = l_rawReader.ReadSingle();
                            float l_yPos = l_rawReader.ReadSingle();
                            float l_zPos = l_rawReader.ReadSingle();
                            float l_xRot = l_rawReader.ReadSingle();
                            float l_yRot = l_rawReader.ReadSingle();
                            float l_zRot = l_rawReader.ReadSingle();
                            Round2.Generated.Binary.Namespaces.BINA.OBJC.OBJCM l_obj = ParseOBJCMember(l_objType, l_npos, l_rawReader, l_objID);

                            if (l_obj != null)
                            {
                                l_obj.m_header.m_type = l_objType;
                                l_obj.m_header.m_id = l_objID;
                                l_obj.m_header.m_flags = l_flags;
                                l_obj.m_header.m_pos = new Vector3(l_xPos, l_yPos, l_zPos);
                                l_obj.m_header.m_rot = new Vector3(l_xRot, l_yRot, l_zRot);

                                //TODO : casually refactor
                                //TODO : replace plane with quad. Fix scale after
                                if (l_obj is Round2.Generated.Binary.Namespaces.BINA.OBJC.PART)
                                {
                                    (l_obj as Round2.Generated.Binary.Namespaces.BINA.OBJC.PART).m_go.transform.position = new UnityEngine.Vector3(-l_obj.m_header.m_pos.x, l_obj.m_header.m_pos.y, l_obj.m_header.m_pos.z);
                                    (l_obj as Round2.Generated.Binary.Namespaces.BINA.OBJC.PART).m_go.transform.eulerAngles = l_obj.m_header.m_rot;
                                    (l_obj as Round2.Generated.Binary.Namespaces.BINA.OBJC.PART).m_go.transform.localScale = new UnityEngine.Vector3((l_obj as Round2.Generated.Binary.Namespaces.BINA.OBJC.PART).m_class.m_header.m_xScale / 5f, 1, (l_obj as Round2.Generated.Binary.Namespaces.BINA.OBJC.PART).m_class.m_header.m_yScale / 5f);
                                    Debug.DrawLine(Vector3.up * 10, new Vector3(-l_obj.m_header.m_pos.x, l_obj.m_header.m_pos.y, l_obj.m_header.m_pos.z), Color.green, 15f);

                                }

                                //Debug.LogWarning(l_nextSize + ":" + l_objType + ":" + ides.GetHashCode() + "{" + l_obj.m_header.m_pos + "}" + "[" + l_obj.m_header.m_rot + "]");
                            }

                            l_rawReader.Position = l_npos;
                        }
                    }
                    break;

                case Oni.Metadata.BinaryTag.PAR3:
                    {
                        int l_initPos = l_rawReader.Position;
                        Round2.Generated.Binary.Namespaces.BINA.OBJC.PAR3.Header l_header = new Round2.Generated.Binary.Namespaces.BINA.OBJC.PAR3.Header();
                        int l_completeParticleLength = l_rawReader.ReadInt32();
                        l_rawReader.Skip(2);//skip length duplicate
                        int l_version = l_rawReader.ReadInt16();
                        l_rawReader.ReadInt32();//flags
                        l_rawReader.ReadInt32();//flags2
                        l_rawReader.ReadInt32();//unused
                        l_header.m_variableCount = l_rawReader.ReadInt16();//amout of variables
                        l_header.m_eventsCount = l_rawReader.ReadInt16();//amount of events
                        l_header.m_emittersCount = l_rawReader.ReadInt16();//amount of emitters
                        l_rawReader.ReadInt16();//unknown
                        //Debug.Log(l_header.m_eventsCount.ToString("X") + " : PAR3 : " + ides.Name);
                        l_rawReader.Skip(16 * 4);//skip slots. currently, they aren't used
                        l_rawReader.Position = l_initPos + 0x120 - 4;
                        l_header.m_textureName = l_rawReader.ReadString(64);
                        l_rawReader.Position = l_initPos + 0xB4 - 4;
                        l_header.m_xScale = l_rawReader.ReadSingle();
                        l_rawReader.Position = l_initPos + 0xD0 - 4;
                        l_header.m_yScale = l_rawReader.ReadSingle();
                        Round2.Generated.Binary.Namespaces.BINA.OBJC.PART.RegisterParticleClass(new Round2.Generated.Binary.Namespaces.BINA.OBJC.PAR3() { m_header = l_header }, ides.Name);
                        //Debug.LogError(">>>" + l_header.m_textureName);//texture name here
                    }
                    break;

                default :
                    Debug.LogWarning("Cannot handle this tag yet");
                    break;
            }
        }
    }

    private static Round2.Generated.Binary.Namespaces.BINA.OBJC.OBJCM ParseOBJCMember(string objType, int npos, Oni.BinaryReader rawReader, int objID)
    {
        Round2.Generated.Binary.Namespaces.BINA.OBJC.Header l_objh = new Round2.Generated.Binary.Namespaces.BINA.OBJC.Header();

        switch (objType)
        {
            case "DOOR":
                {
                    Round2.Generated.Binary.Namespaces.BINA.OBJC.OBJCM l_res = new Round2.Generated.Binary.Namespaces.BINA.OBJC.DOOR() { m_header = l_objh };
                    l_res.ContinueParse(npos, rawReader);
                    return l_res;
                }
                break;

            case "PART":
                {
                    Round2.Generated.Binary.Namespaces.BINA.OBJC.OBJCM l_res = new Round2.Generated.Binary.Namespaces.BINA.OBJC.PART() { m_header = l_objh };
                    l_res.ContinueParse(npos, rawReader);
                    //Debug.Log(l_res.m_header.m_pos.x);
                    
                    return l_res;
                }
                break;

            case "FURN":
                {
                    //Debug.DrawLine(Vector3.up * 10, new Vector3(-l_objh.m_pos.x, l_objh.m_pos.y, l_objh.m_pos.z), Color.green, 15f);
                }
                break;

            default:
                Debug.LogWarning("[UNSUPPORTED TAG : " + objType + "]");
                break;
        }

        return null;
    }

    internal static T ConvertInstance<T>(Oni.InstanceDescriptor ides)
         where T : Round2.BinaryInitializable
    {
        if (!m_descriptors.ContainsKey(ides))
        {
            System.Func<Round2.BinaryInitializable> l_initializer = InitializeLoader(ides.Index, ides, "Round2.Generated.Binary." + typeof(T).Name);


            if (ides.Template.Tag == Oni.TemplateTag.BINA)
            {
                try
                {
                    //ParseBINA2(l_initializer(), ides);
                    ParseBINA(l_initializer(), ides);
                }
                catch (System.Exception ee)
                {
                    Debug.LogError(ee.ToString());
                }
            }
        }

        return (T)m_descriptors[ides]();
    }


    internal static Oni.InstanceDescriptor ResolveInstanceByLink(int link, Oni.InstanceFile srcFile)
    {
        Oni.InstanceDescriptor ides =
        srcFile.ResolveLink(link);
        return ides;
    }

    //this one breaks links to file0. Resolve somehow ffs
    internal static T GetByLinkId<T>(int linkId, Oni.InstanceFile srcFile) 
        where T : Round2.BinaryInitializable
    {
        Oni.InstanceDescriptor l_located = srcFile.ResolveLink(linkId);
        return ConvertInstance<T>(l_located);
    }

    internal static Oni.InstanceDescriptor GetInstance0(int id)
    {
        return l_0File.GetDescriptor(id);
    }

    static int m_bytesUsed = 0;
    static Dictionary<int, System.Func<int, Oni.BinaryReader>> m_sepReaders = new Dictionary<int, System.Func<int, Oni.BinaryReader>>();

    static System.Func<Round2.BinaryInitializable> InitializeLoader(int id, Oni.InstanceDescriptor ides, string resultTypeName)
    {
        try
        {
            if (ides.IsPlaceholder)
            {
                return null;
            }

            Oni.BinaryReader reader = ides.OpenRead();
            Oni.InstanceFile l_file = ides.File;
            //using ()
            {
                List<byte> l_bytes = new List<byte>(System.BitConverter.GetBytes(ides.Index));
                l_bytes.AddRange(System.BitConverter.GetBytes(-1));//re-define for current level usage
                //Oni.BinaryReader l_reader = null;
                l_bytes.AddRange(reader.ReadBytes(ides.DataSize));
                System.Type l_t = typeof(Round2.BinaryInitializable).Assembly.GetType(resultTypeName);//add Round2.Generated.Binary. before typename!
                object l_res = System.Activator.CreateInstance(l_t);
                m_bytesUsed += l_bytes.Count;
                (l_res as Round2.BinaryInitializable).m_sourceFile = l_file;

                System.Func<Round2.BinaryInitializable> l_resultingLoader = () =>
                    {
                        try
                        {
                            (l_res as Round2.BinaryInitializable).Convert(l_bytes.ToArray());
                            m_descriptors.Remove(ides);
                            m_descriptors.Add(ides, () => l_res as Round2.BinaryInitializable);
                            return l_res as Round2.BinaryInitializable;
                        }
                        catch (System.Exception ee)
                        {
                            if (ee is System.IndexOutOfRangeException)
                            {
                                Debug.LogError("! bytes[" + l_bytes.Count + "]");
                            }
                           
                            throw;
                        }
                    };

                m_descriptors.Add(ides, l_resultingLoader);
                return l_resultingLoader;
            }
            reader.Dispose();
        }
        catch (System.Exception ee)
        {
            Debug.Log("Exception at id : " + id + "\n" + ee.ToString() + "\n" + ee.InnerException);
        }

        return null;
    }

    void Start()
    {
        _Start();
    }

    static Oni.InstanceFile l_0File;
    internal static Oni.InstanceFile l_currentFile;

    internal static Dictionary<string, Oni.InstanceDescriptor> m_level0instances = new Dictionary<string, Oni.InstanceDescriptor>();

    static void ZeroRegistryPush(Oni.InstanceDescriptor ides)
    {
        m_level0instances.Add(ides.Name + "|" + ides.Template.Tag, ides);
    }

    static Oni.InstanceDescriptor ZeroRegistryPull(Oni.InstanceDescriptor ides)
    {
        string l_name = ides.Name + "|" + ides.Template.Tag;
        return m_level0instances.ContainsKey(l_name) ? m_level0instances[l_name] : null;
    }

    internal static Dictionary<string, Round2.Generated.Binary.TXMP> m_textures = new Dictionary<string, Round2.Generated.Binary.TXMP>();
    internal static Action m_act = () => { };

    void _Start()
    {
        Oni.InstanceFileManager fm = new Oni.InstanceFileManager();
        l_currentFile = l_0File = fm.OpenFile((Application.isEditor ? @"D:\OniCleanInstall\" : @"..\..\") + @"GameDataFolder\level0_Final.dat");
        System.DateTime l_dt = System.DateTime.Now;

        foreach (Oni.InstanceDescriptor ides in l_0File.Descriptors)
        {
            try
            {
                if (ides.IsPlaceholder)
                {
                    Debug.LogError("placeholder in 0 file " + ides.Template.Tag);
                    continue;
                }
                else
                {
                    switch (ides.Template.Tag)
                    {
                        case Oni.TemplateTag.DOOR:
                            Round2.Generated.Binary.DOOR.RegisterDoorClass(ides);
                            break;
                        case Oni.TemplateTag.BINA:
                            ConvertInstance<Round2.Generated.Binary.BINA>(ides);
                            break;
                        case Oni.TemplateTag.TXMP:
                            m_textures.Add(ides.Name, ConvertInstance<Round2.Generated.Binary.TXMP>(ides));
                            break;
                    }
                }

                ZeroRegistryPush(ides);
            }
            catch (System.Exception ee)
            {
                Debug.LogError("cant add " + ides.Name + " beause of " + ee.ToString());
            }
        }

        l_currentFile = fm.OpenFile((Application.isEditor ? @"D:\OniCleanInstall\" : @"..\..\") + @"GameDataFolder\level1_Final.dat");
        
        foreach (Oni.InstanceDescriptor ides in l_currentFile.Descriptors)
        {
            switch (ides.Template.Tag)
            {
                case Oni.TemplateTag.BINA:
                    ConvertInstance<Round2.Generated.Binary.BINA>(ides);
                    break;

                case Oni.TemplateTag.AKEV:
                    Debug.Log(ides.Index);
                    break;

                case Oni.TemplateTag.ONLV:
                    Round2.Generated.Binary.ONLV l_lvl = ConvertInstance<Round2.Generated.Binary.ONLV>(ides);
                    Debug.Log(l_lvl.m_AKEV_Link_48.Value.m_File_id_0);
                    l_lvl.Build();
                    
                    foreach (Round2.Generated.Binary.AISA.Package pkg in l_lvl.m_AISA_Link_64.Value.m_pkg_20)
                    {
                        Debug.LogWarning(pkg.m_ONCC_link_28.m_lnkId);
                        Debug.Log(l_currentFile.GetDescriptor(pkg.m_ONCC_link_28.m_lnkId).Template.Tag);
                        Debug.Log(pkg.m_ONCC_link_28.Value);
                        pkg.m_ONCC_link_28.Value.BuildONCC(pkg.m_ONCC_link_28.Descriptor);
                    }
                    break;
            }
        }

        Door.m_lateInitialize();
        Door.m_lateInitialize = () => { };
        //BINA_OBJC_DOOR.m_lateImpl();
        Debug.Log("initialization is over in " + (System.DateTime.Now -  l_dt).Milliseconds + " ms");
    }


#if UNITY_EDITOR
    [UnityEditor.MenuItem("Round2/Draw binary readers")]
#endif
    private static void DrawBinaryReaders()
    {
        foreach (string s in System.IO.Directory.GetFiles(System.IO.Path.Combine(Application.streamingAssetsPath, "DatDefinitions"), "*.txt"))
        {
            Debug.Log(s);
            List<string> l_lines = System.IO.File.ReadAllLines(s).ToList();
            l_lines.Add("");
            IEnumerator<string> l_linesEnum = l_lines.GetEnumerator();
            l_linesEnum.MoveNext();
            l_linesEnum.MoveNext();
            string l_typename = System.IO.Path.GetFileNameWithoutExtension(s);
            StringBuilder l_sourceMaker = new StringBuilder();
            StringBuilder l_convertionSource = new StringBuilder();
            StringBuilder l_pkgMaker = new StringBuilder();
            l_pkgMaker.AppendLine("public partial class Package\n{");
            l_sourceMaker.AppendLine("namespace Round2.Generated.Binary\n{");
            l_sourceMaker.Append("  internal partial class ");
            l_sourceMaker.Append(l_typename);
            l_sourceMaker.AppendLine(": Round2.BinaryInitializable");
            l_sourceMaker.AppendLine("  {");

            int l_biggestBytesNeeded = 0;
            bool l_pkgMode = false;
            int l_pkgOffset = 0;
            int l_pkgsize = 0;
            int l_pkgCountOffset = 0;

            for (string currStr = l_linesEnum.Current; l_linesEnum.MoveNext(); currStr = l_linesEnum.Current)
            {
                if (currStr.Length < 3)
                {
                    continue;
                }

                string[] l_definition = currStr.Split('	');

                if (currStr[0] == '*')
                {
                    l_pkgMode = true;
                    Debug.Log(">>" + l_definition.Length);
                    l_pkgOffset = int.Parse(l_definition[2].Remove(0, 1), System.Globalization.NumberStyles.HexNumber);
                    Debug.Log(l_typename);
                    l_pkgsize = int.Parse(l_definition[5]);
                    WriteStructField(l_sourceMaker, "pkg", l_pkgOffset, "Package[]", "Field for package container", true);

                    l_convertionSource.Append("m_pkg_");
                    l_convertionSource.Append(l_pkgOffset.ToString("X"));
                    l_convertionSource.Append(" = new Package[");
                    l_convertionSource.Append("this.m_Packages_");
                    l_convertionSource.Append((l_pkgCountOffset).ToString("X"));
                    l_convertionSource.Append("];\n");
                    /*
                     * note : datatype (int8, int16 or int32) for package count is variable when '$' not exists
                     * if fields[4][1] <> '$' then
                begin
                  case StrToInt(fields[4]) of
                    1:
                      packages := Data[StrToInt(fields[3])];
                    2:
                      packages := Data[StrToInt(fields[3])] + Data[StrToInt(fields[3]) + 1] * 256;
                    4:
                      packages := Data[StrToInt(fields[3])] + Data[StrToInt(fields[3]) + 1] *
                        256 + Data[StrToInt(fields[3]) + 2] * 256 * 256 + Data[StrToInt(fields[3]) + 3] * 256 * 256 * 256;
                  end;
                end*/
                }
                else
                {
                    Debug.Log(currStr);
                    string l_fldName = ConvertName(l_definition[0]);

                    int l_fldOffset = int.Parse(l_definition[1].Remove(0, 1), System.Globalization.NumberStyles.HexNumber);

                    if (l_fldName == "Packages")
                    {
                        l_pkgCountOffset = l_fldOffset;
                    }

                    int l_fldType = int.Parse(l_definition[2]);
                    FieldData l_dat = SelectFieldData(l_fldType);
                    Debug.Log(l_definition.Length);
                    string l_fldComment = l_definition.Length > 3 ? l_definition[3] : "Empty comment";

                    if (l_biggestBytesNeeded < l_dat.m_strln)
                    {
                        l_biggestBytesNeeded = l_dat.m_strln;
                    }

                    WriteStructField(l_pkgMode ? l_pkgMaker : l_sourceMaker, l_fldName, l_fldOffset, l_dat, l_fldComment);

                    //if (!l_pkgMode)
                    {
                        if (l_pkgMode)
                        {
                            l_convertionSource.Append("for (int j=0;j<this.m_Packages");
                            l_convertionSource.Append("_");
                            l_convertionSource.Append((l_pkgCountOffset).ToString("X"));
                            l_convertionSource.Append(";j++)\n{");
                        }

                        l_convertionSource.Append("         for(int i=0; i<");
                        l_convertionSource.Append(l_dat.m_strln);
                        l_convertionSource.AppendLine("; i++)");
                        l_convertionSource.AppendLine("         {");
                        l_convertionSource.Append("             l_bytes[i] = data[i + ");

                        if (l_pkgMode)
                        {
                            l_convertionSource.Append(l_pkgOffset);
                            l_convertionSource.Append("+");
                            l_convertionSource.Append("j * ");
                            l_convertionSource.Append(l_pkgsize);
                            l_convertionSource.Append("+");
                        }

                        l_convertionSource.Append(l_fldOffset);
                        l_convertionSource.AppendLine("];\n         }");

                        if (l_pkgMode)
                        {
                            l_convertionSource.Append("{\nPackage l_pkg;\n");
                            l_convertionSource.Append("l_pkg = m_pkg_");
                            l_convertionSource.Append(l_pkgOffset.ToString("X"));
                            l_convertionSource.Append("[j] == null ? ");
                            l_convertionSource.Append(" m_pkg_");
                            l_convertionSource.Append(l_pkgOffset.ToString("X"));
                            l_convertionSource.Append("[j] = new Package() :  ");
                            l_convertionSource.Append(" m_pkg_");
                            l_convertionSource.Append(l_pkgOffset.ToString("X"));
                            l_convertionSource.Append("[j];\n");
                            l_convertionSource.Append("l_pkg.");
                        }
                        else
                        {
                            l_convertionSource.Append("         this.");
                        }

                        l_convertionSource.Append("m_");
                        l_convertionSource.Append(l_fldName);
                        l_convertionSource.Append("_");
                        l_convertionSource.Append(l_fldOffset.ToString("X"));
                        l_convertionSource.Append(" = ");
                        l_convertionSource.Append("(System.");
                        l_convertionSource.Append(l_dat.m_fldType.Name);
                        l_convertionSource.Append(")BinaryDatReader.");
                        l_convertionSource.Append(l_dat.DoConvert.Method.Name);
                        l_convertionSource.Append("(l_bytes, ");
                        l_convertionSource.Append(l_dat.m_strln);
                        l_convertionSource.AppendLine(");");

                        if (l_pkgMode)
                        {
                            l_convertionSource.AppendLine("}\n}");
                        }
                    }
                }
            }

            l_convertionSource.Insert(0, "];\n");
            l_convertionSource.Insert(0, l_biggestBytesNeeded);
            l_convertionSource.Insert(0, "          byte[] l_bytes = new byte[");
            l_convertionSource.Insert(0, "\n      public override void Convert(byte[] data)\n      {\n");
            l_convertionSource.AppendLine("\n     }");
            l_sourceMaker.Append(l_convertionSource.ToString());
            l_pkgMaker.AppendLine("}");
            if (l_pkgMode)
            {
                l_sourceMaker.AppendLine(l_pkgMaker.ToString());
            }

            l_sourceMaker.AppendLine("  }");
            l_sourceMaker.AppendLine("}");
            Debug.Log(l_sourceMaker.ToString());
            string l_filepath = "";
            l_filepath = System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Path.Combine(Application.dataPath, "Deserializable"), "Binary"), System.IO.Path.GetFileNameWithoutExtension(s)) + ".cs";
            System.IO.File.WriteAllText(l_filepath, l_sourceMaker.ToString());
            //UnityEditor.AssetDatabase.Refresh(UnityEditor.ImportAssetOptions.ForceUpdate);
            //Debug.Log(l_convertionSource.ToString());
        }

        Debug.Log("Drawing is over");
    }

    private static void WriteStructField(StringBuilder l_sourceMaker, string l_fldName, int l_fldOffset, string l_fldType, string l_fldComment, bool isLocal = false, string initialization = null)
    {
        l_sourceMaker.AppendLine("      /// <summary>");
        l_sourceMaker.Append("      ///");
        l_sourceMaker.AppendLine(l_fldComment);
        l_sourceMaker.AppendLine("      /// </summary>");
        bool l_lnkFlag = false;
        string l_lnkType = "";

        if (!l_fldName.EndsWith("link") && (!l_fldName.EndsWith("Link")))
        {
            if (!isLocal)
            {
                l_sourceMaker.Append("      public System.");
            }
            else
            {
                l_sourceMaker.Append("      public ");
            }

            l_sourceMaker.Append(l_fldType);
        }
        else
        {
            l_lnkFlag = true;
            l_sourceMaker.Append("      public Link<");
            l_lnkType = l_fldName.Split('_')[0];

            if (l_fldName.Count(c => c == '_') > 1)//hack for WMM_ filetype
            {
                l_lnkType += "_";
            }

            l_sourceMaker.Append(l_lnkType);
            l_sourceMaker.Append(">");
        }

        l_sourceMaker.Append(" ");
        l_sourceMaker.Append("m_");
        l_sourceMaker.Append(l_fldName);
        l_sourceMaker.Append("_");
        l_sourceMaker.Append(l_fldOffset.ToString("X"));

        if (l_lnkFlag)
        {
            l_sourceMaker.Append(" = ");
            l_sourceMaker.Append(" new ");
            l_sourceMaker.Append("Link<");
            l_sourceMaker.Append(l_lnkType);
            l_sourceMaker.Append(">()");
        }
        else
        {
            if (initialization != null)
            {
                l_sourceMaker.Append(" = ");
                l_sourceMaker.Append(initialization);
            }
        }

        l_sourceMaker.AppendLine(";");
    }

    private static void WriteStructField(StringBuilder l_sourceMaker, string l_fldName, int l_fldOffset, FieldData l_dat, string l_fldComment)
    {
        WriteStructField(l_sourceMaker, l_fldName, l_fldOffset, l_dat.m_fldType.Name, l_fldComment);
    }

    private static string ConvertName(string l_fldName)
    {
        char[] l_fldNameChars = l_fldName.ToCharArray();

        {
            int l_cpos = 0;

            foreach (char c in l_fldNameChars)
            {
                switch (c)
                {
                    case ' ':
                    case '-':
                    case '+':
                    case '=':
                    case '.':
                    case '/':
                    case '\\':
                        l_fldNameChars[l_cpos] = '_';
                        break;
                }

                l_cpos++;
            }
        }

        l_fldName = new string(l_fldNameChars);
        return l_fldName;
    }
}



