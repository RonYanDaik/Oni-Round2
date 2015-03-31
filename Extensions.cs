using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Collections.Generic;

public static class Extensions  
{
    const string SMLSIG = "[ SML :: ";

    internal static Vector3 UnityVector(this Oni.Vector3 @this)
    {
        return new Vector3(@this.X, @this.Y, @this.Z);
    }

    internal static Quaternion UnityQuaternionRaw(this Oni.Quaternion @this)
    {
        return new Quaternion(@this.X, @this.Y, @this.Z, @this.W);
    }

    internal static bool Contains<T1, T2>(this Dictionary<T1, T2> dict, T1 key, T2 value)
    {
        return dict.ContainsKey(key) && (object)dict[key] == (object)value;
    }

    internal static byte[] ReverseBytes(this byte[] @this)
    {
        byte[] l_res = new byte[@this.Length];

        for (int i = 0; i < @this.Length; i++)
        {
            l_res[i] = @this[@this.Length - 1 - i];
        }

        return l_res;
    }

    internal static T2[] ConvertAll<T1, T2>(this T1[] @this, Func<T1, T2> predicate)
    { 
        T2[] l_res = new T2[@this.Length];

        for (int i = 0; i < l_res.Length; i++)
        {
            l_res[i] = predicate(@this[i]);
        }

        return l_res;
    }

    internal static LinkedList<T2> ConvertAll<T1, T2>(this LinkedList<T1> @this, Func<T1, T2> predicate)
    {
        LinkedList<T2> l_newest = new LinkedList<T2>();

        foreach (T1 val in @this)
        {
            l_newest.Add(predicate(val));
        }

        return l_newest;
    }

    internal static LinkedListNode<T> Add<T>(this LinkedList<T> lst, T value)
    {
       return lst.AddLast(value);
    }

    internal static T[] ToArray<T>(this LinkedList<T> lst)
    {
        T[] l_res = new T[lst.Count];
        int i = 0;

        foreach (T l_t in lst)
        {
            l_res[i++] = l_t;
        }

        return l_res;
    }

    internal static object[] SmlToArray(this string data)
    {
        if (data.StartsWith(SMLSIG))
        {
            string[] l_vals = data.Split('|');
            List<object> l_res = new List<object>();

            for (int i = 1; i < l_vals.Length;i++)
            {
                string[] l_contents = l_vals[i].Split('~');
                string l_typename = l_contents[0];
                string l_val = l_contents[1].Remove(0,1);
                int l_rNumber = l_val[l_val.Length - 1] == '}' ? 1 : 2;
                l_val = l_val.Remove(l_val.Length - l_rNumber, l_rNumber);
                //Debug.Log(l_typename);
                System.Type l_type = System.Type.GetType(l_typename);
                System.Object l_resval = null;

                if (l_val.Length > 0 && l_type != null && (l_type.IsAssignableFrom(typeof(IConvertible)) || l_type.IsPrimitive || l_type == typeof(string) || l_type.IsEnum))
                {
                    if (l_type.IsEnum)
                    {
                        l_resval = Enum.Parse(l_type, l_val, true);
                    }
                    else
                    {
                        l_resval = Convert.ChangeType(l_val, l_type);
                    }
                }

                l_res.Add(l_resval);
                //Debug.Log(l_resval);
            }

            return l_res.ToArray();
        }
        else
        {
            Debug.LogError("sml sig not detected");
            return null;
        }
    }
   
    internal static string ArrayAsSml<T>(this T[] data)
    {
        string l_s = SMLSIG;

        foreach (T member in data)
        {
            l_s += "|" + member.GetType().AssemblyQualifiedName + "~{" + member.ToString() + "}";
        }

        return l_s + "]";
    }

    internal static T Decode<T>(this Oni.InstanceDescriptor des)
    {
        List<IGenericMemberAcessor> l_members = new List<IGenericMemberAcessor>();
        T l_val = default(T);
        l_members.Add(new MemberAcess<T>(u => l_val = u, () => l_val, typeof(T).Name));
        Oni.Action<Oni.InstanceDescriptor> l_ides = null;
        System.Xml.XmlWriter l_w = new SWAGGYXmlWriter(l_members.GetEnumerator());
        l_ides = u =>
        {
            try
            {
                Debug.LogWarning("complex object : " + u.Name);
                Oni.Xml.GenericXmlWriter.Write(l_w, l_ides, u);
            }
            catch (System.Exception ee)
            {
                //Debug.Log(ee);
                //Debug.Log(des.IsPlaceholder);
            }
        };
        Oni.Xml.GenericXmlWriter.Write(l_w, l_ides, des);
        l_w.Flush();
        return l_val;
    }

    internal static MemoryStream AsXmlStream(this Oni.InstanceDescriptor des)
    {
        DateTime l_dt = DateTime.Now;
        Debug.LogWarning(des.DataSize);
        MemoryStream l_ms = new MemoryStream(des.DataSize);
        Round2.TXMP l_v = null;
        List<IGenericMemberAcessor> l_stt = new List<IGenericMemberAcessor>();
        l_stt.Add
            (
                new MemberAcess<Round2.TXMP>
                    (
                        u => 
                            {
                                l_v = u;
                            },
                        () => l_v,
                        "TXMP"
                    )
             );

        System.Xml.XmlWriter l_w = new SWAGGYXmlWriter(l_stt.GetEnumerator());//System.Xml.XmlWriter.Create(l_ms);
        Oni.Action<Oni.InstanceDescriptor> l_ides = null;
        l_ides = u =>
        {
            try
            {
                Oni.Xml.GenericXmlWriter.Write(l_w, l_ides, u);
            }
            catch (System.Exception ee)
            {
                throw;
                //Debug.Log(ee);
                //Debug.Log(des.IsPlaceholder);
            }
        };
        Oni.Xml.GenericXmlWriter.Write(l_w, l_ides, des);
        l_w.Flush();
        l_ms.Seek(0, SeekOrigin.Begin);
        Debug.Log("ASXMLSTREAM : " + (DateTime.Now - l_dt));
        return l_ms;
    }
}
