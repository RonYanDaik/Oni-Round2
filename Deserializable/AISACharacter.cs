using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Round2
{
    public class AISACharacter 
    {
        public string Name;
        public int ScriptId;
        public int FlagId;
        string m_team;

        public string Team
        {
            get
            {
                return m_team;
            }

            set
            {
                m_team = value;
            }
        }

        public _ONCC Class;
        public int Ammo;
    }
}
