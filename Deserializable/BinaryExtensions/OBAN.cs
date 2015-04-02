using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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

        public partial class Package
        {
            public float RealTime
            {
                get
                {
                    return (float)this.m_Passed_time_1C / 60f;
                }
            }
        }

        /// <summary>
        /// Builds and returns animation clips. OBAN is separated with half stop frame by default
        /// TODO: rotations
        /// </summary>
        /// <param name="ignoreHalfStopFrame">returns 1 clip, not separated by half stop frame</param>
        /// <returns>(by default) 2 clips - before half stop frame and after half stop frame</returns>
        public AnimationClip[] GetClips(bool doorSpecificFlip = false, bool ignoreHalfStopFrame = false)
        {
            List<Keyframe> l_c1xp = new List<Keyframe>();
            List<Keyframe> l_c1yp = new List<Keyframe>();
            List<Keyframe> l_c1zp = new List<Keyframe>();
            List<Keyframe> l_c1xr = new List<Keyframe>();
            List<Keyframe> l_c1yr = new List<Keyframe>();
            List<Keyframe> l_c1zr = new List<Keyframe>();

            List<Keyframe> l_c2xp = new List<Keyframe>();
            List<Keyframe> l_c2yp = new List<Keyframe>();
            List<Keyframe> l_c2zp = new List<Keyframe>();
            List<Keyframe> l_c2xr = new List<Keyframe>();
            List<Keyframe> l_c2yr = new List<Keyframe>();
            List<Keyframe> l_c2zr = new List<Keyframe>();

            foreach (Package pkg in this.m_pkg_80)
            {
                if (!ignoreHalfStopFrame && this.m_Unknown_7C != 0 && pkg.m_Passed_time_1C >= this.m_Unknown_7C)
                {
                    //caused by odd content flip
                    l_c2xp.Add(new Keyframe(pkg.RealTime, -pkg.m_x_position_10));
                    l_c2yp.Add(new Keyframe(pkg.RealTime, pkg.m_y_position_14));
                    l_c2zp.Add(new Keyframe(pkg.RealTime, pkg.m_z_position_18));
                }

                if (ignoreHalfStopFrame || this.m_Unknown_7C == 0 || pkg.m_Passed_time_1C <= this.m_Unknown_7C)
                {
                    //caused by odd content flip
                    l_c1xp.Add(new Keyframe(pkg.RealTime, -pkg.m_x_position_10));
                    l_c1yp.Add(new Keyframe(pkg.RealTime, pkg.m_y_position_14));
                    l_c1zp.Add(new Keyframe(pkg.RealTime, pkg.m_z_position_18));
                }
            }

            AnimationClip l_clip1 = new AnimationClip();
            AnimationClip l_clip2 = new AnimationClip();
            l_clip1.SetCurve("", typeof(Transform), "m_LocalPosition.x", new AnimationCurve() { keys = l_c1xp.ToArray() });
            l_clip1.SetCurve("", typeof(Transform), "m_LocalPosition.y", new AnimationCurve() { keys = (doorSpecificFlip ?  l_c1zp : l_c1yp).ToArray() } );
            l_clip1.SetCurve("", typeof(Transform), "m_LocalPosition.z", new AnimationCurve() { keys = (doorSpecificFlip ? l_c1yp : l_c1zp).ToArray() } );
            l_clip1.name = "In";
            l_clip2.SetCurve("", typeof(Transform), "m_LocalPosition.x", new AnimationCurve() { keys = l_c2xp.ToArray() });
            l_clip2.SetCurve("", typeof(Transform), "m_LocalPosition.y", new AnimationCurve() { keys = (doorSpecificFlip ? l_c2zp : l_c2yp).ToArray() });
            l_clip2.SetCurve("", typeof(Transform), "m_LocalPosition.z", new AnimationCurve() { keys = (doorSpecificFlip ? l_c2yp : l_c2zp).ToArray() });
            l_clip2.name = "Out";

            return new AnimationClip[] { l_clip1, l_clip2 };
        }
    }
}
