﻿using UnityEngine;
using System.Collections;
using Round2;
using System.Xml.Serialization;

namespace Round2
{
    public partial class Links
    {
        [XmlType("Link")]
        public class M3GMLNK
        {
            public Round2.M3GM M3GM;
        }
    }
}
