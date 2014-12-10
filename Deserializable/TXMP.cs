using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.Collections.Generic;

interface IGenericMemberAccessorCollection
{
    List<IGenericMemberAcessor> Members
    {
        get;
    }
}

namespace Round2
{
    public class _TXMP
    {
        public TXMP @TXMP;
    }

    /// <summary>
    /// Does not uses animation, data offset or envmap. See comments section to discover more
    /// </summary>
    public class TXMP : IXmlSerializable
    {
        int m_id;

        [XmlAttribute("_id")]
        public int id
        {
            get 
            {
                return m_id;
            }

            set
            {
                m_id = value;
                Texture2DQuery.TexturePend(m_id, u => m_tex = u);
            }
        }

        public string Flags;
        public int Width;
        public int Height;
        public string Format;
        UnityEngine.Texture2D m_tex = null;

        public override string ToString()
        {
            return id + "|" + Flags + "|" + Width + "|" + Height + "|" + Format;
        }

        /*<Flags>HasMipMaps SwapBytes</Flags>
                    <Width>64</Width>
                    <Height>64</Height>
                    <Format>DXT1</Format>
                    <Animation></Animation>
                    <EnvMap></EnvMap>
                    <DataOffset>79520</DataOffset>*/

        System.Xml.Schema.XmlSchema IXmlSerializable.GetSchema()
        {
            throw new System.NotImplementedException();
        }

        void IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
        {
            
        }

        void IXmlSerializable.WriteXml(System.Xml.XmlWriter writer)
        {
            throw new System.NotImplementedException();
        }

    }
}
