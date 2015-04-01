using UnityEngine;
using System.Collections;

namespace Round2.Generated.Binary
{
    internal partial class OBAN
    {
        public Oni.Matrix InitialTransform
        {
            get
            {
                return new Oni.Matrix
                (
                    this.m_initial_position_matrix_a11_18,
                    this.m_initial_position_matrix_a12_1C,
                    this.m_initial_position_matrix_a13_20,
                    0,
                    this.m_initial_position_matrix_a21_24,
                    this.m_initial_position_matrix_a22_28,
                    this.m_initial_position_matrix_a23_2C,
                    0,
                    this.m_initial_position_matrix_a31_30,
                    this.m_initial_position_matrix_a32_34,
                    this.m_initial_position_matrix_a33_38,
                    0,
                    this.m_initial_position_matrix_a41_3C,
                    this.m_initial_position_matrix_a42_40,
                    this.m_initial_position_matrix_a43_44,
                    1
                );
            }
        }
    }
}
