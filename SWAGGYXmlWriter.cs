using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System;

public interface IGenericMemberAcessor
{
    object Value
    {
        get;
        set;
    }

    System.Type Type
    {
        get;
    }

    string Name
    {
        get;
    }
}

public class MemberAcess<T> : IGenericMemberAcessor
{
    System.Action<T> m_set;
    System.Func<T> m_get;
    string m_name;

    public MemberAcess (System.Action<T> set, System.Func<T> get, string name)
    {
        m_set = set;
        m_get = get;
        m_name = name;
    }

    object IGenericMemberAcessor.Value
    {
        get
        {
            return m_get();
        }
        set
        {
            m_set((T)value);
        }
    }

    System.Type IGenericMemberAcessor.Type
    {
        get
        {
            return typeof(T);
        }
    }

    string IGenericMemberAcessor.Name
    {
        get 
        {
            return m_name;
        }
    }
}

public class SWAGGYXmlWriter : System.Xml.XmlWriter
{
    IEnumerator<IGenericMemberAcessor> m_memberEnum;
    WaitState m_state = WaitState.WaitForMembers;
    Stack<string> m_namesStack = new Stack<string>();

    enum WaitState
    {
        WaitForMembers,
        WaitForArrayEnd,
        Field,
        Value
    }

    string m_latestName;

    void MemberWritten(string name = null, string value = null)
    {
        if (name != null)
        {
            m_namesStack.Push(name);
        }
    
        //Debug.LogWarning(name + "=" + value + "|" + m_state + ">>" + (m_memberEnum.Current != null ? m_memberEnum.Current.Name : ""));

        switch (m_state)
        {
            case WaitState.WaitForMembers:
                {
                    m_memberEnum.MoveNext();
                    IGenericMemberAcessor l_enumerationMember = m_memberEnum.Current;
                    object l_createdObject = System.Activator.CreateInstance(l_enumerationMember.Type);

                    OnFlush = () =>
                        {
                            l_enumerationMember.Value = l_createdObject; 
                        };

                    if(l_createdObject is IGenericMemberAccessorCollection)
                    {
                        m_memberEnum = (l_createdObject as IGenericMemberAccessorCollection).Members.GetEnumerator();
                    }
                    
                    m_memberEnum.MoveNext();
                    m_state = WaitState.Field;
                }
                break;

            case WaitState.Field:
                {
                    Debug.Log("Wait for field : " + name);
                    m_latestName = name;
                    m_state = WaitState.Value;
                }
                break;

            case WaitState.Value:
                {
                    if (m_latestName == m_memberEnum.Current.Name)
                    {
                        object o = null;
                        m_memberEnum.Current.Value = o = Convert.ChangeType(value, m_memberEnum.Current.Type);
                        //Debug.LogError("set value :: " + o);
                        m_memberEnum.MoveNext();
                    }

                    m_state = WaitState.Field;
                }
                break;

        }
    }

    event Action OnFlush = null;

    public SWAGGYXmlWriter(IEnumerator<IGenericMemberAcessor> members)
    {
        m_memberEnum = members;
    }

    public override void Flush()
    {
        OnFlush();
        //Debug.Log("Flush");
    }

    public override void WriteEndAttribute()
    {
        //Debug.Log("End attribute");
    }

    public override void WriteEndElement()
    {
        //Debug.Log("End element");
    }

    public override void WriteStartAttribute(string prefix, string localName, string ns)
    {
        this.MemberWritten(localName);
        //Debug.Log("Start attribute + " + prefix + " + " + localName + " + " + ns);
    }

    public override void WriteStartElement(string prefix, string localName, string ns)
    {
        this.MemberWritten(localName);
        //Debug.Log("Start element + " + prefix + " + " + localName + " + " + ns);
    }

    public override void WriteString(string text)
    {
        this.MemberWritten(value: text);
        //Debug.Log("Written string + " + text);
    }

    public override void Close()
    {
        throw new System.NotImplementedException();
    }

    public override void WriteEndDocument()
    {
        throw new System.NotImplementedException();
    }

    public override string LookupPrefix(string ns)
    {
        throw new System.NotImplementedException();
    }

    public override void WriteBase64(byte[] buffer, int index, int count)
    {
        throw new System.NotImplementedException();
    }

    public override void WriteCData(string text)
    {
        throw new System.NotImplementedException();
    }

    public override void WriteCharEntity(char ch)
    {
        throw new System.NotImplementedException();
    }

    public override void WriteChars(char[] buffer, int index, int count)
    {
        throw new System.NotImplementedException();
    }

    public override void WriteComment(string text)
    {
        throw new System.NotImplementedException();
    }

    public override void WriteDocType(string name, string pubid, string sysid, string subset)
    {
        throw new System.NotImplementedException();
    }

    public override void WriteEntityRef(string name)
    {
        throw new System.NotImplementedException();
    }

    public override void WriteFullEndElement()
    {
        throw new System.NotImplementedException();
    }

    public override void WriteProcessingInstruction(string name, string text)
    {
        throw new System.NotImplementedException();
    }

    public override void WriteRaw(string data)
    {
        throw new System.NotImplementedException();
    }

    public override void WriteRaw(char[] buffer, int index, int count)
    {
        throw new System.NotImplementedException();
    }

    public override void WriteStartDocument(bool standalone)
    {
        throw new System.NotImplementedException();
    }

    public override void WriteStartDocument()
    {
        throw new System.NotImplementedException();
    }

    public override System.Xml.WriteState WriteState
    {
        get { throw new System.NotImplementedException(); }
    }

    public override void WriteSurrogateCharEntity(char lowChar, char highChar)
    {
        throw new System.NotImplementedException();
    }

    public override void WriteWhitespace(string ws)
    {
        throw new System.NotImplementedException();
    }
}
