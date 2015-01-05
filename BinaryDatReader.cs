﻿using UnityEngine;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;

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
            byte[] l_data = new byte[l_bina.m_Size_8];
            l_rawReader.Read(l_data, 0, l_bina.m_Size_8);
            Debug.LogError("BINA size : " + l_bina.m_Size_8 + " :: id " + l_bina.m_File_id_0);
            byte[] l_bytes = new byte[l_data.Length];

            for (int i = 0; i < 4; i++)//read teh damn tag
            {
                l_bytes[i] = l_data[i + 0];
            }

            Oni.Metadata.BinaryTag l_tag = (Oni.Metadata.BinaryTag)l_int32(l_bytes, 4);
            Debug.LogError("Binary tag : " + l_tag + "|" + ((int)l_tag).ToString("X"));

            switch (l_tag)
            {
                case Oni.Metadata.BinaryTag.OBJC:
                    {
                        for (int i = 0; i < 4; i++)//read teh damn size
                        {
                            l_bytes[i] = l_data[i + 0x04];
                        }

                        int l_size = (int)l_int32(l_bytes, 4);
                        Debug.LogWarning(l_size);

                        for (int i = 0; i < 4; i++)//read teh damn version
                        {
                            l_bytes[i] = l_data[i + 0x08];
                        }

                        int l_ver = (int)l_int32(l_bytes, 4);
                        Debug.LogWarning(l_ver);

                        for (int i = 0; i < 4; i++)//read teh damn first obj size
                        {
                            l_bytes[i] = l_data[i + 0x0c];
                        }

                        int l_nextSize = (int)l_int32(l_bytes, 4);
                        Debug.LogWarning(l_nextSize);
                        List<byte> l_data2 = new List<byte>(l_data);
                        l_data2.RemoveRange(0, 0x10);

                        for (; l_data2.Count > 0 && l_nextSize > 0; )
                        {
                            TryParseOBJCMember(l_data2.ToArray(), l_nextSize);
                            l_data2.RemoveRange(0, l_nextSize);

                            for (int i = 0; i < 4; i++)//read teh damn obj size
                            {
                                l_bytes[i] = l_data2[i];
                            }

                            l_nextSize = (int)l_int32(l_bytes, 4);
                            l_data2.RemoveRange(0, 0x4);
                        }
                    }
                    break;

                default:
                    Debug.LogError("Cannot handle this tag yet : " + l_tag);
                    break;
            }
        }
    }

    static void TryParseOBJCMember(byte[] data, int len)
    {
        string l_tag = new string(new char[] { (char)data[3], (char)data[2], (char)data[1], (char)data[0] });

        switch (l_tag)
        { 
            case "DOOR":

                break;
        }
    }

    internal static T ConvertInstance<T>(Oni.InstanceDescriptor ides)
         where T : Round2.BinaryInitializable
    {
        if (!m_descriptors.ContainsKey(ides))
        {
            System.Func<Round2.BinaryInitializable> l_initilizer = InitializeLoader(ides.Index, ides, "Round2.Generated.Binary." + typeof(T).Name);

            if (ides.Template.Tag == Oni.TemplateTag.BINA)
            {
                ParseBINA(l_initilizer(), ides);
            }
        }
    
        return (T)m_descriptors[ides]();
    }

    internal static Oni.InstanceDescriptor ResolveInstanceByLink(int link)
    {
        Oni.InstanceDescriptor ides = 
        l_currentFile.ResolveLink(link);
        return ides;
    }

    internal static T GetByLinkId<T>(int linkId) 
        where T : Round2.BinaryInitializable
    {
        Oni.InstanceDescriptor l_located = l_currentFile.ResolveLink(linkId);
        return ConvertInstance<T>(l_located);
    }


    internal static Oni.InstanceDescriptor GetInstance0(int id)
    {
        return l_0File.GetDescriptor(id);
    }

    internal static Oni.InstanceDescriptor GetInstance(int id)
    {
        return l_currentFile.GetDescriptor(id);
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
            //using ()
            {
                List<byte> l_bytes = new List<byte>(System.BitConverter.GetBytes(ides.Index));
                l_bytes.AddRange(System.BitConverter.GetBytes(-1));//re-define for current level usage
                //Oni.BinaryReader l_reader = null;
                l_bytes.AddRange(reader.ReadBytes(ides.DataSize));
                System.Type l_t = typeof(Round2.BinaryInitializable).Assembly.GetType(resultTypeName);//add Round2.Generated.Binary. before typename!
                object l_res = System.Activator.CreateInstance(l_t);
                m_bytesUsed += l_bytes.Count;

                System.Func<Round2.BinaryInitializable> l_resultingLoader = () =>
                    {
                        (l_res as Round2.BinaryInitializable).Convert(l_bytes.ToArray());
                        m_descriptors.Remove(ides);
                        m_descriptors.Add(ides, () => l_res as Round2.BinaryInitializable);
                        return l_res as Round2.BinaryInitializable;
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

    void _Start()
    {
        Oni.InstanceFileManager fm = new Oni.InstanceFileManager();
        l_0File = fm.OpenFile((Application.isEditor ? @"D:\OniCleanInstall\" : @"..\..\") + @"GameDataFolder\level0_Final.dat");
        l_currentFile = fm.OpenFile((Application.isEditor ? @"D:\OniCleanInstall\" : @"..\..\") + @"GameDataFolder\level1_Final.dat");
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

                ZeroRegistryPush(ides);
            }
            catch (System.Exception ee)
            {
                Debug.LogError("cant add " + ides.Name + " beause of " + ee.ToString());
            }
        }

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
            l_convertionSource.Insert(0, "\n      public void Convert(byte[] data)\n      {\n");
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

namespace Round2
{
    interface BinaryInitializable
    {
       void Convert(byte[] data);
    }
}

namespace Round2
{
    namespace Generated
    {
        namespace Binary
        {
            internal class Raw : Round2.BinaryInitializable
            {
                public int l_addr;

                public void Convert(byte[] data)
                {
                    //shouldn't be called anyway, huh?
                    throw new System.Exception("Don't forget to not use this stuff!");
                }
            }
        }
    }
}

namespace Round2
{
    namespace Generated
    {
        namespace Binary
        {
            internal class Link<T> where T : Round2.BinaryInitializable
            {
                public int m_lnkId;
                T m_cachedObject;

                public static implicit operator Link<T>(int lnkid)
                {
                    return new Link<T>() { m_lnkId = (int)lnkid };
                }

                public T Value
                {
                    get
                    {
                        return m_cachedObject == null ? m_cachedObject = BinaryDatReader.GetByLinkId<T>(m_lnkId) : m_cachedObject;
                    }
                }

                public Oni.InstanceDescriptor Descriptor
                {
                    get
                    {
                        return BinaryDatReader.ResolveInstanceByLink(m_lnkId);
                    }
                }
            }
        }
    }
}