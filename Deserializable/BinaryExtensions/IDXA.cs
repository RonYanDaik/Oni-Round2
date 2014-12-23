using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Round2.Generated.Binary
{
    internal partial class IDXA
    {
        /// <summary>
        /// Fix triangle order using decoding table for M3GM 1 case
        /// </summary>
        /// <returns></returns>
        public int[] DecodeForM3GM_1()
        {
            List<int> l_idxlst = new List<int>();
            List<int> l_tmpidxlst = new List<int>();

            int[][] l_stripSchemes = new int[][] 
            {
                new int[] { 0, 1, 2 },
                new int[] { 2, 1, 3 },
            };

            for (int i = 0; i < this.m_pkg_20.Length; i++)
            {
                if (this.m_pkg_20[i].m_High_bit_3 > 0)
                {
                    l_tmpidxlst.Clear();
                }

                l_tmpidxlst.Add(this.m_pkg_20[i + 0].m_Index_id_0);

                switch (l_tmpidxlst.Count)
                {
                    case 3:
                        l_idxlst.Add(l_tmpidxlst[0]);
                        l_idxlst.Add(l_tmpidxlst[1]);
                        l_idxlst.Add(l_tmpidxlst[2]);
                        break;

                    case 4:
                        l_idxlst.Add(l_tmpidxlst[2]);
                        l_idxlst.Add(l_tmpidxlst[1]);
                        l_idxlst.Add(l_tmpidxlst[3]);
                        l_tmpidxlst.RemoveRange(0, 2);
                        break;
                }
            }

            return l_idxlst.ToArray();
        }
    }
}