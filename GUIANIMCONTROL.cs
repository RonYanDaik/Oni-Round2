using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[System.Flags]
internal enum AnimFlags
{
    jump = 1 << 0,
    jump_fw = 1 << 1,
    jump_bk = 1 << 2,
    jump_rt = 1 << 3,
    jump_lt = 1 << 4,
    crouch = 1 << 5,
    idle = 1 << 6,
    land = 1 << 7,
    run = 1 << 8,
    run_bk = 1 << 9,
    ss_lt = 1 << 10,
    ss_rt = 1 << 11,
    stepa = 1 << 12,
    stepb = 1 << 13,
    start = 1 << 14,
    stop = 1 << 15,
    lt = 1 << 16,
    rt = 1 << 17,
    idle1 = 1 << 18,
    idle2 = 1 << 19,
    ss_lt_run = 1 << 20,//needed for transition from ss_lt to run
    ss_rt_run = 1 << 21,//needed for transition from ss_rt to run
    crouch2idlea = 1 << 22,
    crouch2idleb = 1 << 23,
    idle2croucha = 1 << 24,
    idle2crouchb = 1 << 25,
    fw = 1 << 26,
    bk = 1 << 27,
    slide = 1 << 28,//needed for slide animations for right, left, backward slide
    slide_run = 1 << 29,
    id = 1 << 30//keep this flag last
}

public class GUIANIMCONTROL : MonoBehaviour 
{
    float jumpHeight = 25;
    AnimFlags m_lastFlags = AnimFlags.idle1;
    AnimFlags m_prevFlags = 0;
    bool m_lockCursor = false;
    IInputChannel m_channel = new PlayerInputChannel();
    TRAMState m_state;

    class TRAMState
    {
        private TRAMState()
        { 
            
        }

        public class Transitioner
        {
            public TRAMState m_nextState;
            public Func<bool> m_valueTracker;
        }

        Action OnActivate = null;
        public AnimFlags m_correspondingValue = AnimFlags.idle1;
        List<Transitioner> m_lastFrameTransitions = new List<Transitioner>();
        List<Transitioner> m_anyFrameTransitions = new List<Transitioner>();
        List<Transitioner> m_landingTransitions = new List<Transitioner>();
        string m_dbgName;

        public static TRAMState FormState(AnimFlags state, Action activationHandler = null, string name = "")
        {
            return new TRAMState() { m_correspondingValue = state, m_dbgName = name, OnActivate = activationHandler };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <param name="tracker"></param>
        /// <returns>value of next state in chain</returns>
        public TRAMState AddLastFrameCondition(TRAMState other, Func<bool> tracker)
        {
            Debug.Log( this.m_correspondingValue + " > " + other.m_correspondingValue);
            m_lastFrameTransitions.Add(new Transitioner() { m_nextState = other, m_valueTracker = tracker });
            return other;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <param name="tracker"></param>
        /// <returns>value of next state in chain</returns>
        public TRAMState AddAnyFrameCondition(TRAMState other, Func<bool> tracker)
        {
            m_anyFrameTransitions.Add(new Transitioner() { m_nextState = other, m_valueTracker = tracker });
            return other;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <param name="tracker"></param>
        /// <returns>value of next state in chain</returns>
        public TRAMState AddLangingCondition(TRAMState other, Func<bool> tracker)
        {
            m_landingTransitions.Add(new Transitioner() { m_nextState = other, m_valueTracker = tracker });
            return other;
        }

        public TRAMState OnLand()
        {
            TRAMState l_res = null;
            foreach (Transitioner tr in m_landingTransitions)
            {
                if (tr.m_valueTracker())
                {
                    if (l_res != null)
                    {
                        Debug.LogWarning("CONFICTING TRANSITIONS : " + l_res.m_correspondingValue + " and " + tr.m_nextState.m_correspondingValue);
                    }

                    l_res = tr.m_nextState;
                }
            }

            if (l_res != null && l_res.OnActivate != null)
            {
                l_res.OnActivate();
            }
            return l_res ?? this;
        }

        public TRAMState OnAnyFrame()
        {
            TRAMState l_res = null;

            foreach (Transitioner tr in m_anyFrameTransitions)
            {
                if (tr.m_valueTracker())
                {
                    if (l_res != null)
                    {
                        Debug.LogWarning("CONFICTING TRANSITIONS : " + l_res.m_correspondingValue + " and " + tr.m_nextState.m_correspondingValue);
                    }

                    l_res = tr.m_nextState;
                }
            }

            if (l_res != null && l_res.OnActivate != null)
            {
                l_res.OnActivate();
            }
            return l_res ?? this;
        }

        public TRAMState OnLastFrame()
        {
            TRAMState l_res = null;

            foreach (Transitioner tr in m_lastFrameTransitions)
            {
                if (tr.m_valueTracker())
                {
                    if (l_res != null)
                    {
                        Debug.LogWarning("CONFICTING TRANSITIONS : " + l_res.m_correspondingValue + " and " + tr.m_nextState.m_correspondingValue);
                    }

                    l_res = tr.m_nextState;
                }
            }

            if (l_res != null && l_res.OnActivate != null)
            {
                l_res.OnActivate();
            }
            return l_res ?? this;
        }

    }

    string GetAnim()
    {
        m_prevFlags = m_lastFlags;
        m_targetAngle = Quaternion.Euler(0, 0, 0);
        m_state = m_state.OnAnyFrame();
        m_lastFlags = m_state.m_correspondingValue;

        string animname = "";

        foreach (string s in m_lastFlags.ToString().Split(",".ToCharArray()))
        {
            switch (s.Replace(" ",""))
            {
                case "ss_rt":
                    animname += "ss_rt";
                    break;
                case "ss_lt":
                    animname += "ss_lt";
                    break;
                case "run_bk":
                    animname += "run_bk";
                    break;
                case "stepa":
                    animname +=  "1stepa";
                    break;
                case "stepb":
                    animname += "1stepb";
                    break;
                default:
                    animname += s.Replace(" ", "");
                    break;
                case "rt":
                    animname += "rt";
                    break;
                case "lt":
                    animname += "lt";
                    break;
            }

            animname += "_";
        }

        animname = animname.Remove(animname.Length - 1);

        if ((m_lastFlags & AnimFlags.run) != 0)
        {
            switch (animname)
            {
                case "run_1stepa":
                    animname = "run1stepa";
                    break;
                case "run_1stepb":
                    animname = "run1stepb";
                    break;
                case "run_start":
                    animname = "runstart";
                    break;
                case "run_stop":
                    animname = "runstop";
                    break;
            }
        }
    
        return animname;
    }

    public float m_jumpVal = 45;

    void OnLand()
    {
        m_state = m_state.OnLand();
        m_lastFlags = m_state.m_correspondingValue;
        m_upperVector = 0;
        m_jumpStart = -1;
        m_waitingForLanding = false;
        m_rememberedSpeed = Vector3.zero;
    }

    bool m_comFlag;
    bool m_forcedMix = false;

    public bool ComFlag
    {
        get { return m_comFlag; }
        set 
        {
            //Debug.Log(value);
            m_forcedMix = value != m_comFlag;
            m_comFlag = value;
        }
    }

    void DoJump()
    {
        m_upperVector = m_jumpVal;
        m_jumpStart = Time.time;
        m_waitingForLanding = true;
        //ComFlag = false;
        m_rememberedSpeed = m_motionVector;
    }

	// Use this for initialization
	void Start ()
    {
        transform.position += Vector3.up * 2;
        Vector3 angles = transform.eulerAngles;
        m_camera = GetComponentInChildren<Camera>().transform;
        m_camera.transform.parent = null;
        m_x = angles.y;
        m_y = angles.x;

        #region input axis accessors
        Func<bool> l_forwardPositive = () => m_channel[ChannelKind.Forward];
        Func<bool> l_forwardNegative = () => !m_channel[ChannelKind.Forward];
        Func<bool> l_backwardPositive = () => m_channel[ChannelKind.Backward];
        Func<bool> l_backwardNegative = () => !m_channel[ChannelKind.Backward];
        Func<bool> l_sidestepLeftPositive = () => m_channel[ChannelKind.Left];
        Func<bool> l_sidestepLeftNegative = () => !m_channel[ChannelKind.Left];
        Func<bool> l_sidestepRightPositive = () => m_channel[ChannelKind.Right];
        Func<bool> l_sidestepRightNegative = () => !m_channel[ChannelKind.Right];
        Func<bool> l_crouchNegative = () => !m_channel[ChannelKind.Crouch];
        Func<bool> l_crouchPositive = () => m_channel[ChannelKind.Crouch];
        Func<bool> l_jumpPositive = () => m_channel[ChannelKind.Jump];
        Func<bool> l_jumpNegative = () => !m_channel[ChannelKind.Jump];
        #endregion

        TRAMState l_idle1 = TRAMState.FormState(AnimFlags.idle1);
        TRAMState l_idle2 = TRAMState.FormState(AnimFlags.idle2);
        TRAMState l_run1stepa = TRAMState.FormState(AnimFlags.run | AnimFlags.stepa);
        TRAMState l_run_bk_1stepa = TRAMState.FormState(AnimFlags.run_bk | AnimFlags.stepa);
        TRAMState l_ss_lt_1stepa = TRAMState.FormState(AnimFlags.ss_lt | AnimFlags.stepa);
        TRAMState l_ss_rt_1stepa = TRAMState.FormState(AnimFlags.ss_rt | AnimFlags.stepa);
        TRAMState l_ss_rt_Lt = TRAMState.FormState(AnimFlags.ss_rt | AnimFlags.lt);
        TRAMState l_ss_rt_Rt = TRAMState.FormState(AnimFlags.ss_rt | AnimFlags.rt);
        TRAMState l_ss_rt_Start = TRAMState.FormState(AnimFlags.ss_rt | AnimFlags.start);
        TRAMState l_ss_rt_stop = TRAMState.FormState(AnimFlags.ss_rt | AnimFlags.stop);
        TRAMState l_ss_lt_Lt = TRAMState.FormState(AnimFlags.ss_lt | AnimFlags.lt);
        TRAMState l_ss_lt_Rt = TRAMState.FormState(AnimFlags.ss_lt | AnimFlags.rt);
        TRAMState l_ss_lt_Start = TRAMState.FormState(AnimFlags.ss_lt | AnimFlags.start);
        TRAMState l_ss_lt_stop = TRAMState.FormState(AnimFlags.ss_lt | AnimFlags.stop);

        #region run
        TRAMState l_runLt = TRAMState.FormState(AnimFlags.run | AnimFlags.lt);
        TRAMState l_runRt = TRAMState.FormState(AnimFlags.run | AnimFlags.rt);
        TRAMState l_runStart = TRAMState.FormState(AnimFlags.run | AnimFlags.start);
        TRAMState l_runstepb = TRAMState.FormState(AnimFlags.run | AnimFlags.stepb);
        TRAMState l_runstop = TRAMState.FormState(AnimFlags.run | AnimFlags.stop);
        TRAMState l_run_ss_rt = TRAMState.FormState(AnimFlags.run | AnimFlags.ss_rt);
        TRAMState l_run_ss_lt = TRAMState.FormState(AnimFlags.run | AnimFlags.ss_lt);
        TRAMState l_crouch_fw = TRAMState.FormState(AnimFlags.crouch | AnimFlags.fw);

        {
            l_run1stepa.AddAnyFrameCondition(l_crouch_fw, l_crouchPositive);
            l_runStart.AddAnyFrameCondition(l_crouch_fw, l_crouchPositive);
            l_runLt.AddAnyFrameCondition(l_crouch_fw, l_crouchPositive);
            l_runRt.AddAnyFrameCondition(l_crouch_fw, l_crouchPositive);
            l_crouch_fw.AddLastFrameCondition(l_idle1, l_forwardNegative);
            l_crouch_fw.AddLastFrameCondition(l_run1stepa, l_forwardPositive);

            Func<bool> l_run_specific_negative = () =>
            {
                m_targetAngle = Quaternion.Euler(0, l_sidestepLeftPositive() ? -45 : l_sidestepRightPositive() ? 45 : 0, 0);
                return l_forwardNegative();
            };

            l_run1stepa
            .AddLastFrameCondition(l_runStart, l_forwardPositive)
            .AddLastFrameCondition(l_runRt, l_forwardPositive)
            .AddLastFrameCondition(l_runLt , l_forwardPositive)
            .AddLastFrameCondition(l_runRt, l_forwardPositive);
            l_run1stepa.AddLastFrameCondition(l_runstepb, l_forwardNegative);
            l_runLt.AddAnyFrameCondition(l_runstop, l_run_specific_negative);
            l_runRt.AddAnyFrameCondition(l_runstop, l_run_specific_negative);
            l_runRt.AddAnyFrameCondition(l_run_ss_rt, () => l_forwardNegative() && l_sidestepRightPositive());
            l_runLt.AddAnyFrameCondition(l_run_ss_rt, () => l_forwardNegative() && l_sidestepRightPositive());
            l_runRt.AddAnyFrameCondition(l_run_ss_lt, () => l_forwardNegative() && l_sidestepLeftPositive());
            l_runLt.AddAnyFrameCondition(l_run_ss_lt, () => l_forwardNegative() && l_sidestepLeftPositive());
            l_run_ss_rt.AddLastFrameCondition(l_ss_rt_Rt, l_sidestepRightPositive);
            l_run_ss_rt.AddLastFrameCondition(l_ss_rt_stop, l_sidestepRightNegative);
            l_run_ss_lt.AddLastFrameCondition(l_ss_lt_Lt, l_sidestepLeftPositive);
            l_run_ss_lt.AddLastFrameCondition(l_ss_lt_stop, l_sidestepLeftNegative);
            l_runLt.AddAnyFrameCondition(l_run_bk_1stepa, () => l_forwardNegative() && l_backwardPositive());
            l_runRt.AddAnyFrameCondition(l_run_bk_1stepa, () => l_forwardNegative() && l_backwardPositive());
            l_runstop.AddLastFrameCondition(l_idle1, l_forwardNegative);
            l_runstepb.AddLastFrameCondition(l_idle1, l_forwardNegative);
            l_runstepb.AddAnyFrameCondition(l_run1stepa, l_forwardPositive);
            l_runstop.AddAnyFrameCondition(l_run1stepa, l_forwardPositive);
            l_runStart.AddLastFrameCondition(l_runstop, l_forwardNegative);
        }
        #endregion

        #region run bk
        TRAMState l_run_bk_Lt = TRAMState.FormState(AnimFlags.run_bk | AnimFlags.lt);
        TRAMState l_run_bk_Rt = TRAMState.FormState(AnimFlags.run_bk | AnimFlags.rt);
        TRAMState l_run_bk_Start = TRAMState.FormState(AnimFlags.run_bk | AnimFlags.start);
        TRAMState l_run_bk_stepb = TRAMState.FormState(AnimFlags.run_bk | AnimFlags.stepb);
        TRAMState l_run_bk_stop = TRAMState.FormState(AnimFlags.run_bk | AnimFlags.stop);
        TRAMState l_run_bk_ss_rt = TRAMState.FormState(AnimFlags.run_bk | AnimFlags.ss_rt);
        TRAMState l_run_bk_ss_lt = TRAMState.FormState(AnimFlags.run_bk | AnimFlags.ss_lt);
        TRAMState l_crouch_bk = TRAMState.FormState(AnimFlags.crouch | AnimFlags.bk);
        TRAMState l_run_bk_slide = TRAMState.FormState(AnimFlags.run_bk | AnimFlags.slide);
        TRAMState l_run_bk_slide_run = TRAMState.FormState(AnimFlags.run_bk | AnimFlags.slide_run);
        TRAMState l_run_bk_slide_id = TRAMState.FormState(AnimFlags.run_bk | AnimFlags.slide | AnimFlags.id);

        {
            l_run_bk_1stepa.AddAnyFrameCondition(l_crouch_bk, l_crouchPositive);
            l_run_bk_Start.AddAnyFrameCondition(l_run_bk_slide, l_crouchPositive);
            l_run_bk_Lt.AddAnyFrameCondition(l_run_bk_slide, l_crouchPositive);
            l_run_bk_Rt.AddAnyFrameCondition(l_run_bk_slide, l_crouchPositive);
            l_run_bk_slide.AddLastFrameCondition(l_run_bk_slide_run, l_backwardPositive);
            l_run_bk_slide.AddLastFrameCondition(l_run_bk_slide_id, l_backwardNegative);
            l_crouch_bk.AddLastFrameCondition(l_idle1, ()=> true);
            l_run_bk_slide_id.AddLastFrameCondition(l_idle1, () => true);
            l_run_bk_slide_run.AddLastFrameCondition(l_idle1, l_backwardNegative);
            l_run_bk_slide_run.AddLastFrameCondition(l_run_bk_Lt, l_backwardPositive);

            Func<bool> l_run_bk_specific_negative = () =>
            {
                m_targetAngle = Quaternion.Euler(0, l_sidestepLeftPositive() ? 45 : l_sidestepRightPositive() ? -45 : 0, 0);
                return l_backwardNegative();
            };

            l_run_bk_1stepa
            .AddLastFrameCondition(l_run_bk_Start, l_backwardPositive)
            .AddLastFrameCondition(l_run_bk_Rt, l_backwardPositive)
            .AddLastFrameCondition(l_run_bk_Lt, l_backwardPositive)
            .AddLastFrameCondition(l_run_bk_Rt, l_backwardPositive);
            l_run_bk_1stepa.AddLastFrameCondition(l_run_bk_stepb, l_backwardNegative);
            l_run_bk_Lt.AddAnyFrameCondition(l_run_bk_stop, l_run_bk_specific_negative);
            l_run_bk_Rt.AddAnyFrameCondition(l_run_bk_stop, l_run_bk_specific_negative);
            l_run_bk_Lt.AddAnyFrameCondition(l_run1stepa, () => l_backwardNegative() && l_forwardPositive());
            l_run_bk_Rt.AddAnyFrameCondition(l_run1stepa, () => l_backwardNegative() && l_forwardPositive());
            l_run_bk_Lt.AddAnyFrameCondition(l_run_bk_ss_rt, () => l_backwardNegative() && l_sidestepRightPositive());
            l_run_bk_Rt.AddAnyFrameCondition(l_run_bk_ss_rt, () => l_backwardNegative() && l_sidestepRightPositive());
            l_run_bk_Lt.AddAnyFrameCondition(l_run_bk_ss_lt, () => l_backwardNegative() && l_sidestepLeftPositive());
            l_run_bk_Rt.AddAnyFrameCondition(l_run_bk_ss_lt, () => l_backwardNegative() && l_sidestepLeftPositive());
            l_run_bk_ss_rt.AddLastFrameCondition(l_ss_rt_Rt, l_sidestepRightPositive);
            l_run_bk_ss_rt.AddLastFrameCondition(l_ss_rt_stop, l_sidestepRightNegative);
            l_run_bk_ss_lt.AddLastFrameCondition(l_ss_lt_Lt, l_sidestepLeftPositive);
            l_run_bk_ss_lt.AddLastFrameCondition(l_ss_lt_stop, l_sidestepLeftNegative);
            l_run_bk_stop.AddLastFrameCondition(l_idle1, l_backwardNegative);
            l_run_bk_stepb.AddLastFrameCondition(l_idle1, l_backwardNegative);
            l_run_bk_stepb.AddAnyFrameCondition(l_run_bk_1stepa, l_backwardPositive);
            l_run_bk_stop.AddAnyFrameCondition(l_run_bk_1stepa, l_backwardPositive);
            l_run_bk_Start.AddLastFrameCondition(l_run_bk_stop, l_backwardNegative);
        }
        #endregion

        #region ss_lt
        l_ss_lt_1stepa
        .AddLastFrameCondition(l_ss_lt_Start, l_sidestepLeftPositive)
        .AddLastFrameCondition(l_ss_lt_Lt, l_sidestepLeftPositive)
        .AddLastFrameCondition(l_ss_lt_Rt, l_sidestepLeftPositive)
        .AddLastFrameCondition(l_ss_lt_Lt, l_sidestepLeftPositive);
        TRAMState l_ss_lt_stepb = TRAMState.FormState(AnimFlags.ss_lt | AnimFlags.stepb);
        TRAMState l_ss_lt_run = TRAMState.FormState(AnimFlags.ss_lt_run);
        TRAMState l_jump_lt_start = TRAMState.FormState(AnimFlags.jump_lt | AnimFlags.start, DoJump);
        TRAMState l_jump_lt_idle = TRAMState.FormState(AnimFlags.jump_lt | AnimFlags.idle);
        TRAMState l_jump_lt_land = TRAMState.FormState(AnimFlags.jump_lt | AnimFlags.land);
        TRAMState l_jump_lt_land_lt = TRAMState.FormState(AnimFlags.jump_lt | AnimFlags.land | AnimFlags.lt);
        TRAMState l_jump_lt_crouch = TRAMState.FormState(AnimFlags.jump_lt | AnimFlags.crouch);
        TRAMState l_ss_lt_slide = TRAMState.FormState(AnimFlags.ss_lt | AnimFlags.slide);
        TRAMState l_crouch_lt = TRAMState.FormState(AnimFlags.crouch | AnimFlags.lt);
        l_ss_lt_1stepa.AddAnyFrameCondition(l_crouch_lt, l_crouchPositive);
        l_ss_lt_Lt.AddAnyFrameCondition(l_ss_lt_slide, l_crouchPositive);
        l_ss_lt_Rt.AddAnyFrameCondition(l_ss_lt_slide, l_crouchPositive);
        l_ss_lt_Start.AddAnyFrameCondition(l_ss_lt_slide, l_crouchPositive);
        l_ss_lt_slide.AddLastFrameCondition(l_ss_lt_stop, l_sidestepLeftNegative);
        l_ss_lt_slide.AddLastFrameCondition(l_ss_lt_Lt, l_sidestepLeftPositive);
        l_crouch_lt.AddLastFrameCondition(l_idle1, () => true);
        l_ss_lt_1stepa.AddLastFrameCondition(l_ss_lt_stepb, l_sidestepLeftNegative);
        l_ss_lt_Lt.AddAnyFrameCondition(l_ss_lt_stop, l_sidestepLeftNegative);
        l_ss_lt_Rt.AddAnyFrameCondition(l_ss_lt_stop, l_sidestepLeftNegative);
        l_ss_lt_Lt.AddAnyFrameCondition(l_run_bk_Lt, l_backwardPositive);
        l_ss_lt_Rt.AddAnyFrameCondition(l_run_bk_Lt, l_backwardPositive);
        l_ss_lt_Lt.AddAnyFrameCondition(l_ss_lt_run, l_forwardPositive);
        l_ss_lt_Rt.AddAnyFrameCondition(l_ss_lt_run, l_forwardPositive);
        l_ss_lt_Lt.AddAnyFrameCondition(l_jump_lt_start, l_jumpPositive);
        l_ss_lt_Rt.AddAnyFrameCondition(l_jump_lt_start, l_jumpPositive);
        l_jump_lt_start.AddLastFrameCondition(l_jump_lt_idle, l_crouchNegative);
        l_jump_lt_start.AddLastFrameCondition(l_jump_lt_crouch, l_crouchPositive);
        l_jump_lt_idle.AddAnyFrameCondition(l_jump_lt_crouch, l_crouchPositive);
        l_jump_lt_idle.AddLangingCondition(l_jump_lt_land_lt, l_sidestepLeftPositive);
        l_jump_lt_idle.AddLangingCondition(l_jump_lt_land, l_sidestepLeftNegative);
        l_jump_lt_crouch.AddLangingCondition(l_jump_lt_land_lt, l_sidestepLeftPositive);
        l_jump_lt_crouch.AddLangingCondition(l_jump_lt_land, l_sidestepLeftNegative);
        l_jump_lt_land.AddLastFrameCondition(l_ss_lt_1stepa, l_sidestepLeftPositive);
        l_jump_lt_land.AddLastFrameCondition(l_idle1, l_sidestepLeftNegative);
        l_jump_lt_land_lt.AddLastFrameCondition(l_ss_lt_Rt, l_sidestepLeftPositive);
        l_jump_lt_land_lt.AddLastFrameCondition(l_ss_lt_stop, l_sidestepLeftNegative);
        l_ss_lt_run.AddLastFrameCondition(l_runRt, l_forwardPositive);
        l_ss_lt_run.AddLastFrameCondition(l_ss_lt_stop, l_forwardNegative);
        l_ss_lt_stop.AddLastFrameCondition(l_idle1, l_sidestepLeftNegative);
        l_ss_lt_stepb.AddLastFrameCondition(l_idle1, l_sidestepLeftNegative);
        l_ss_lt_stepb.AddAnyFrameCondition(l_ss_lt_1stepa, l_sidestepLeftPositive);
        l_ss_lt_stop.AddAnyFrameCondition(l_ss_lt_1stepa, l_sidestepLeftPositive);
        l_ss_lt_Start.AddLastFrameCondition(l_ss_lt_stop, l_sidestepLeftNegative);
        #endregion

        #region ss_rt
        l_ss_rt_1stepa
        .AddLastFrameCondition(l_ss_rt_Start, l_sidestepRightPositive)
        .AddLastFrameCondition(l_ss_rt_Rt, l_sidestepRightPositive)
        .AddLastFrameCondition(l_ss_rt_Lt, l_sidestepRightPositive)
        .AddLastFrameCondition(l_ss_rt_Rt, l_sidestepRightPositive);
        TRAMState l_ss_rt_stepb = TRAMState.FormState(AnimFlags.ss_rt | AnimFlags.stepb);
        TRAMState l_ss_rt_run = TRAMState.FormState(AnimFlags.ss_rt_run);
        TRAMState l_jump_rt_start = TRAMState.FormState(AnimFlags.jump_rt | AnimFlags.start, DoJump);
        TRAMState l_jump_rt_idle = TRAMState.FormState(AnimFlags.jump_rt | AnimFlags.idle);
        TRAMState l_jump_rt_land = TRAMState.FormState(AnimFlags.jump_rt | AnimFlags.land);
        TRAMState l_jump_rt_land_lt = TRAMState.FormState(AnimFlags.jump_rt | AnimFlags.land | AnimFlags.rt);
        TRAMState l_jump_rt_crouch = TRAMState.FormState(AnimFlags.jump_rt | AnimFlags.crouch);
        TRAMState l_ss_rt_slide = TRAMState.FormState(AnimFlags.ss_rt | AnimFlags.slide);
        TRAMState l_crouch_rt = TRAMState.FormState(AnimFlags.crouch | AnimFlags.rt);
        l_ss_rt_1stepa.AddAnyFrameCondition(l_crouch_rt, l_crouchPositive);
        l_ss_rt_Lt.AddAnyFrameCondition(l_ss_rt_slide, l_crouchPositive);
        l_ss_rt_Rt.AddAnyFrameCondition(l_ss_rt_slide, l_crouchPositive);
        l_ss_rt_Start.AddAnyFrameCondition(l_ss_rt_slide, l_crouchPositive);
        l_ss_rt_slide.AddLastFrameCondition(l_ss_rt_stop, l_sidestepRightNegative);
        l_ss_rt_slide.AddLastFrameCondition(l_ss_rt_Lt, l_sidestepRightPositive);
        l_crouch_rt.AddLastFrameCondition(l_idle1, () => true);
        l_ss_rt_1stepa.AddLastFrameCondition(l_ss_rt_stepb, l_sidestepRightNegative);
        l_ss_rt_Lt.AddAnyFrameCondition(l_ss_rt_stop, l_sidestepRightNegative);
        l_ss_rt_Rt.AddAnyFrameCondition(l_ss_rt_stop, l_sidestepRightNegative);
        l_ss_rt_Lt.AddAnyFrameCondition(l_run_bk_Rt, l_backwardPositive);
        l_ss_rt_Rt.AddAnyFrameCondition(l_run_bk_Rt, l_backwardPositive);
        l_ss_rt_Lt.AddAnyFrameCondition(l_ss_rt_run, l_forwardPositive);
        l_ss_rt_Rt.AddAnyFrameCondition(l_ss_rt_run, l_forwardPositive);
        l_ss_rt_Lt.AddAnyFrameCondition(l_jump_rt_start, l_jumpPositive);
        l_ss_rt_Rt.AddAnyFrameCondition(l_jump_rt_start, l_jumpPositive);
        l_jump_rt_start.AddLastFrameCondition(l_jump_rt_idle, l_crouchNegative);
        l_jump_rt_start.AddLastFrameCondition(l_jump_rt_crouch, l_crouchPositive);
        l_jump_rt_idle.AddAnyFrameCondition(l_jump_rt_crouch, l_crouchPositive);
        l_jump_rt_idle.AddLangingCondition(l_jump_rt_land_lt, l_sidestepRightPositive);
        l_jump_rt_idle.AddLangingCondition(l_jump_rt_land, l_sidestepRightNegative);
        l_jump_rt_crouch.AddLangingCondition(l_jump_rt_land_lt, l_sidestepRightPositive);
        l_jump_rt_crouch.AddLangingCondition(l_jump_rt_land, l_sidestepRightNegative);
        l_jump_rt_land.AddLastFrameCondition(l_ss_rt_1stepa, l_sidestepRightPositive);
        l_jump_rt_land.AddLastFrameCondition(l_idle1, l_sidestepRightNegative);
        l_jump_rt_land_lt.AddLastFrameCondition(l_ss_rt_Rt, l_sidestepRightPositive);
        l_jump_rt_land_lt.AddLastFrameCondition(l_ss_rt_stop, l_sidestepRightNegative);
        l_ss_rt_run.AddLastFrameCondition(l_runLt, l_forwardPositive);
        l_ss_rt_run.AddLastFrameCondition(l_ss_rt_stop, l_forwardNegative);
        l_ss_rt_stop.AddLastFrameCondition(l_idle1, l_sidestepRightNegative);
        l_ss_rt_stepb.AddLastFrameCondition(l_idle1, l_sidestepRightNegative);
        l_ss_rt_stepb.AddAnyFrameCondition(l_ss_rt_1stepa, l_sidestepRightPositive);
        l_ss_rt_stop.AddAnyFrameCondition(l_ss_rt_1stepa, l_sidestepRightPositive);
        l_ss_rt_Start.AddLastFrameCondition(l_ss_rt_stop, l_sidestepRightNegative);
        #endregion

        TRAMState l_jump_start = TRAMState.FormState(AnimFlags.jump | AnimFlags.start, DoJump);

        #region idle -> jump
        TRAMState l_jump_idle = TRAMState.FormState(AnimFlags.jump | AnimFlags.idle);
        TRAMState l_jump_land = TRAMState.FormState(AnimFlags.jump | AnimFlags.land);
        TRAMState l_jump_land_fw = TRAMState.FormState(AnimFlags.jump | AnimFlags.land | AnimFlags.fw);
        TRAMState l_jump_crouch = TRAMState.FormState(AnimFlags.jump | AnimFlags.crouch);
        l_jump_start.AddLastFrameCondition(l_jump_idle, () => true);
        l_jump_idle.AddAnyFrameCondition(l_jump_crouch, l_crouchPositive);
        l_jump_idle.AddLangingCondition(l_jump_land, l_forwardNegative);
        l_jump_idle.AddLangingCondition(l_jump_land_fw, l_forwardPositive);
        l_jump_crouch.AddLangingCondition(l_jump_land, l_forwardNegative);
        l_jump_crouch.AddLangingCondition(l_jump_land_fw, l_forwardPositive);
        l_jump_land_fw.AddLastFrameCondition(l_runLt, l_forwardPositive);
        l_jump_land_fw.AddLastFrameCondition(l_runstop, l_forwardNegative);
        l_jump_land.AddLastFrameCondition(l_run1stepa, l_forwardPositive);
        l_jump_land.AddLastFrameCondition(l_run_bk_1stepa, l_backwardPositive);
        l_jump_land.AddLastFrameCondition(l_ss_lt_1stepa, l_sidestepLeftPositive);
        l_jump_land.AddLastFrameCondition(l_ss_rt_1stepa, l_sidestepRightPositive);
        l_jump_land.AddLastFrameCondition(l_idle1, () => !(m_channel[ChannelKind.Forward] || m_channel[ChannelKind.Backward] || m_channel[ChannelKind.Right] || m_channel[ChannelKind.Left]));
        #endregion

        #region crouch motion
        TRAMState l_idle2croucha = TRAMState.FormState(AnimFlags.idle2croucha);
        TRAMState l_idle2crouchb = TRAMState.FormState(AnimFlags.idle2crouchb);
        TRAMState l_crouch2idlea = TRAMState.FormState(AnimFlags.crouch2idlea);
        TRAMState l_crouch2idleb = TRAMState.FormState(AnimFlags.crouch2idleb);
        TRAMState l_crouch_idle = TRAMState.FormState(AnimFlags.crouch | AnimFlags.idle);
        l_crouch_idle.AddLastFrameCondition(l_crouch_idle, l_crouchPositive);
        l_crouch_idle.AddAnyFrameCondition(l_crouch2idleb, l_crouchNegative);
        l_crouch2idleb.AddLastFrameCondition(l_idle2crouchb, l_crouchPositive);
        l_crouch2idleb.AddLastFrameCondition(l_crouch2idlea, l_crouchNegative);
        l_crouch2idlea.AddLastFrameCondition(l_idle1, l_crouchNegative);
        l_crouch2idlea.AddLastFrameCondition(l_idle2croucha, l_crouchPositive);
        l_idle2croucha.AddLastFrameCondition(l_idle2crouchb, l_crouchPositive);
        l_idle2crouchb.AddLastFrameCondition(l_crouch_idle, l_crouchPositive);
        l_idle2crouchb.AddLastFrameCondition(l_crouch_idle, l_crouchNegative);
        l_idle2croucha.AddLastFrameCondition(l_crouch2idlea, l_crouchNegative);
        #endregion

        #region crouch run
        TRAMState l_crouch_run_lt = TRAMState.FormState(AnimFlags.crouch | AnimFlags.run | AnimFlags.lt);
        TRAMState l_crouch_run_rt = TRAMState.FormState(AnimFlags.crouch | AnimFlags.run | AnimFlags.rt);
        {
            Func<bool> l_crouch_run_specific_input = () => l_crouchPositive() && (l_sidestepLeftPositive() | l_sidestepRightPositive() | l_forwardPositive());
            Func<bool> l_crouch_run_specific_input_neg = () => l_crouchPositive() && (!l_sidestepLeftPositive() && !l_sidestepRightPositive() && !l_forwardPositive());

            Func<bool> l_crouch_miltidirection = () =>
            {
                m_targetAngle = Quaternion.Euler(0, (m_channel[ChannelKind.Left] ? -90 : m_channel[ChannelKind.Right] ? 90f : 0) / (m_channel[ChannelKind.Forward] ? 2f : 1f), 0);
                return l_crouchNegative();
            };

            l_crouch_run_lt.AddLastFrameCondition(l_crouch_run_rt, l_crouch_run_specific_input);
            l_crouch_run_rt.AddLastFrameCondition(l_crouch_run_lt, l_crouch_run_specific_input);
            l_crouch_run_lt.AddAnyFrameCondition(l_runStart, l_crouch_miltidirection);
            l_crouch_run_rt.AddAnyFrameCondition(l_runStart, l_crouch_miltidirection);
            l_crouch_run_lt.AddAnyFrameCondition(l_crouch_idle, l_crouch_run_specific_input_neg);
            l_crouch_run_rt.AddAnyFrameCondition(l_crouch_idle, l_crouch_run_specific_input_neg);
            l_crouch_idle.AddAnyFrameCondition(l_crouch_run_lt, l_crouch_run_specific_input);
        }
        #endregion

        #region crouch run bk
        TRAMState l_crouch_run_bk_lt = TRAMState.FormState(AnimFlags.crouch | AnimFlags.run_bk | AnimFlags.lt);
        TRAMState l_crouch_run_bk_rt = TRAMState.FormState(AnimFlags.crouch | AnimFlags.run_bk | AnimFlags.rt);
        {
            Func<bool> l_crouch_run_bk_specific_input = () => l_crouchPositive() && (l_sidestepLeftPositive() | l_sidestepRightPositive() | l_backwardPositive());
            Func<bool> l_crouch_run_bk_specific_input_neg = () => l_crouchPositive() && (!l_sidestepLeftPositive() && !l_sidestepRightPositive() && !l_backwardPositive());

            Func<bool> l_crouch_bk_miltidirection = () =>
            {
                m_targetAngle = Quaternion.Euler(0, (m_channel[ChannelKind.Left] ? 90 : m_channel[ChannelKind.Right] ? -90f : 0) / (m_channel[ChannelKind.Backward] ? 2f : 1f), 0);
                return l_crouchNegative() && l_forwardNegative();
            };

            l_crouch_run_bk_lt.AddLastFrameCondition(l_crouch_run_bk_rt, l_crouch_run_bk_specific_input);
            l_crouch_run_bk_rt.AddLastFrameCondition(l_crouch_run_bk_lt, l_crouch_run_bk_specific_input);
            l_crouch_run_bk_lt.AddAnyFrameCondition(l_run_bk_Start, l_crouch_bk_miltidirection);
            l_crouch_run_bk_rt.AddAnyFrameCondition(l_run_bk_Start, l_crouch_bk_miltidirection);
            l_crouch_run_bk_lt.AddAnyFrameCondition(l_crouch_idle, l_crouch_run_bk_specific_input_neg);
            l_crouch_run_bk_rt.AddAnyFrameCondition(l_crouch_idle, l_crouch_run_bk_specific_input_neg);
            l_crouch_idle.AddAnyFrameCondition(l_crouch_run_bk_lt, () => m_channel[ChannelKind.Backward | ChannelKind.Crouch]);
        }
        #endregion

        #region jump fw
        TRAMState l_jump_fw_start = TRAMState.FormState(AnimFlags.jump_fw | AnimFlags.start, DoJump);
        TRAMState l_jump_fw_idle = TRAMState.FormState(AnimFlags.jump_fw | AnimFlags.idle);
        TRAMState l_jump_fw_land = TRAMState.FormState(AnimFlags.jump_fw | AnimFlags.land);
        TRAMState l_jump_fw_land_fw = TRAMState.FormState(AnimFlags.jump_fw | AnimFlags.land | AnimFlags.fw);
        TRAMState l_jump_fw_crouch = TRAMState.FormState(AnimFlags.jump_fw | AnimFlags.crouch);
        l_runLt.AddAnyFrameCondition(l_jump_fw_start, l_jumpPositive);
        l_runRt.AddAnyFrameCondition(l_jump_fw_start, l_jumpPositive);
        l_jump_fw_start.AddLastFrameCondition(l_jump_fw_idle, l_crouchNegative);
        l_jump_fw_start.AddLastFrameCondition(l_jump_fw_crouch, l_crouchPositive);
        l_jump_fw_idle.AddAnyFrameCondition(l_jump_fw_crouch, l_crouchPositive);
        l_jump_fw_idle.AddLangingCondition(l_jump_fw_land, l_forwardNegative);
        l_jump_fw_idle.AddLangingCondition(l_jump_fw_land_fw, l_forwardPositive);
        l_jump_fw_crouch.AddLangingCondition(l_jump_fw_land, l_forwardNegative);
        l_jump_fw_crouch.AddLangingCondition(l_jump_fw_land_fw, l_forwardPositive);
        l_jump_fw_land.AddLastFrameCondition(l_run1stepa, l_forwardPositive);
        l_jump_fw_land.AddLastFrameCondition(l_idle1, l_forwardNegative);
        l_jump_fw_land_fw.AddLastFrameCondition(l_runstop, l_forwardNegative);
        l_jump_fw_land_fw.AddLastFrameCondition(l_runLt, l_forwardPositive);
        #endregion

        #region jump bk
        TRAMState l_jump_bk_start = TRAMState.FormState(AnimFlags.jump_bk | AnimFlags.start, DoJump);
        TRAMState l_jump_bk_idle = TRAMState.FormState(AnimFlags.jump_bk | AnimFlags.idle);
        TRAMState l_jump_bk_land = TRAMState.FormState(AnimFlags.jump_bk | AnimFlags.land);
        TRAMState l_jump_bk_land_bk = TRAMState.FormState(AnimFlags.jump_bk | AnimFlags.land | AnimFlags.bk);
        TRAMState l_jump_bk_crouch = TRAMState.FormState(AnimFlags.jump_bk | AnimFlags.crouch);
        l_run_bk_Lt.AddAnyFrameCondition(l_jump_bk_start, l_jumpPositive);
        l_run_bk_Rt.AddAnyFrameCondition(l_jump_bk_start, l_jumpPositive);
        l_jump_bk_start.AddLastFrameCondition(l_jump_bk_idle, l_crouchNegative);
        l_jump_bk_start.AddLastFrameCondition(l_jump_bk_crouch, l_crouchPositive);
        l_jump_bk_idle.AddAnyFrameCondition(l_jump_bk_crouch, l_crouchPositive);
        l_jump_bk_idle.AddLangingCondition(l_jump_bk_land, l_backwardNegative);
        l_jump_bk_idle.AddLangingCondition(l_jump_bk_land_bk, l_backwardPositive);
        l_jump_bk_crouch.AddLangingCondition(l_jump_bk_land, l_backwardNegative);
        l_jump_bk_crouch.AddLangingCondition(l_jump_bk_land_bk, l_backwardPositive);
        l_jump_bk_land.AddLastFrameCondition(l_run_bk_1stepa, l_backwardPositive);
        l_jump_bk_land.AddLastFrameCondition(l_idle1, l_backwardNegative);
        l_jump_bk_land_bk.AddLastFrameCondition(l_run_bk_stop, l_backwardNegative);
        l_jump_bk_land_bk.AddLastFrameCondition(l_run_bk_Lt, l_backwardPositive);
        #endregion

        #region idle
        l_idle1.AddLastFrameCondition(l_idle2, () => !m_channel[ChannelKind.Any]);
        l_idle2.AddLastFrameCondition(l_idle1, () => !m_channel[ChannelKind.Any]);
        l_idle1.AddAnyFrameCondition(l_run1stepa, l_forwardPositive);
        l_idle2.AddAnyFrameCondition(l_run1stepa, l_forwardPositive);
        l_idle1.AddAnyFrameCondition(l_run_bk_1stepa, l_backwardPositive);
        l_idle2.AddAnyFrameCondition(l_run_bk_1stepa, l_backwardPositive);
        l_idle1.AddAnyFrameCondition(l_ss_lt_1stepa, l_sidestepLeftPositive);
        l_idle2.AddAnyFrameCondition(l_ss_lt_1stepa, l_sidestepLeftPositive);
        l_idle1.AddAnyFrameCondition(l_ss_rt_1stepa, l_sidestepRightPositive);
        l_idle2.AddAnyFrameCondition(l_ss_rt_1stepa, l_sidestepRightPositive);
        l_idle1.AddAnyFrameCondition(l_jump_start, l_jumpPositive);
        l_idle2.AddAnyFrameCondition(l_jump_start, l_jumpPositive);
        l_idle1.AddAnyFrameCondition(l_idle2croucha, l_crouchPositive);
        l_idle2.AddAnyFrameCondition(l_idle2croucha, l_crouchPositive);
        #endregion

        m_state = l_idle1;
    }

    public float m_upperVector = 0;
    public Vector3 m_motionVector;

    public Vector3 MotionVector
    {
        get
        {
            return m_motionVector;
        }
        set 
        { 
            m_motionVector = value;
        }
    }

    Vector3 m_clipDirection = Vector3.zero;
    Vector3 m_lastClipDirection = Vector3.zero;
    AnimationState from;
    AnimationState to;
    float _from_time;
    float startTime;
    string adds2 = "";
    List<string> m_loadedClips = new List<string>();
    string m_characterName = "KONOKO";
    string m_characterCombName = "KONCOM";
    
    public void OnActionFrame(string param)
    {
        //Debug.Log(param + "|" + m_clipname + "||" + param.Contains(m_clipname));
        
        if ( !param.Contains(m_clipname))
        {
            return;
        }

        if (param.Contains("|DONOTUSE"))
        {
            Debug.Log(param);
            Debug.Break();
            return;
        }

        //if (param == m_clipname)
        {
            //OnLastFrame();
        }
        m_state = m_state.OnLastFrame();
        PlayClip(GetAnim());
        return;
        //Debug.Log("animation finish:" + param);
    }

    void PlayClip(string animname)
    {
        string l_bufferedName = animname;
        AnimFlags l_bufferedFlags = m_lastFlags;
        animname = (!ComFlag ? m_characterName : this.m_characterCombName) + l_bufferedName;

        if (!m_loadedClips.Contains(animname))
        {
            AnimationClip l_clip = AnimationClipHolder.Get(animname, this);
            
            if (l_clip == null)
            {
                ComFlag = !ComFlag;
                animname = (!ComFlag ? m_characterName : this.m_characterCombName) + l_bufferedName;
                Debug.LogWarning("forcibly switching com flag");
                m_lastFlags = l_bufferedFlags;
                l_clip = AnimationClipHolder.Get(animname, this);
            }

            if (l_clip == null)//if clip is still null
            {
                Debug.LogError("Cant load clip " + animname);
                return;
            }
            else
            {
                l_clip.name = animname;
                animation.AddClip(l_clip, animname);
                m_loadedClips.Add(animname);
            }
        }

        if (animname != m_clipname && !animation.IsPlaying(animname) && m_loadedClips.Contains(animname))
        {
            Oni.Totoro.AnimationState old = 0;
            Oni.Totoro.AnimationState @new = 0;
           
            if (!string.IsNullOrEmpty(m_clipname))
            {
                from = animation[m_clipname];
                to = animation[animname];
                old = (Round2.Generated.Binary.ONCC.GetByName("konoko_generic").GetAnimInfo(m_clipname)).ToState;
            }
            /*
            NewBehaviourScript.m_events[name].stringParameter = NewBehaviourScript.m_events[name].stringParameter.Replace("|DONOTUSE", "");
            
            if (!string.IsNullOrEmpty(m_clipname))
            {
                NewBehaviourScript.m_events[m_clipname].stringParameter += "|DONOTUSE";
                from = animation[m_clipname];
                to = animation[name];
                old = NewBehaviourScript.m_anims[m_clipname].ToState;
                
            }*/

            m_clipname = animname;
            @new = Round2.Generated.Binary.ONCC.GetByName("konoko_generic").GetAnimInfo(animname).FromState;
            adds2 = "mixstate: " + (old != @new);
            adds2 += "\nforced mix : " + m_forcedMix;
            adds2 += "\nfade len = " + (10f / animation[animname].clip.frameRate);
            adds2 += "\n" + old + "==" + @new;

            {
                if (old != @new || m_forcedMix)
                {
                    animation.CrossFade(animname, 10f / animation[animname].clip.frameRate);
                }
                else
                {
                    animation.CrossFade(animname, 3f / animation[animname].clip.frameRate);
                }
            }
        }
        else
        {
            if (!m_loadedClips.Contains(animname))
            {
                Debug.LogError("nave no clip " + animname);
                Debug.LogError("clipdump:");
                string dump = "";

                /*
                foreach(string __name in NewBehaviourScript.m_events.Keys)
                {
                    dump += __name + "\n";
                }*/

                Debug.LogError(dump);
            }
        }
    }

    void OnColliosionEnter()
    {
        Debug.Log("enter!");
    }

    bool m_waitingForLanding = false;
    CollisionFlags m_lastCollisionFlags;
    float m_jumpStart = -1f;
    public float m_travelDist = 0.7f;
    public float m_longerTravelDist = 1f;
    public float m_travelSpd = 0.3f;
    Vector3 m_rememberedSpeed = Vector3.zero;
    float m_x = 0;
    float m_y = 0;

    static float ClampAngle (float angle, float min, float max)
    {
        if (angle < -360)
        {
            angle += 360;
        }
        if (angle > 360)
        {
            angle -= 360;
        }
	    return Mathf.Clamp (angle, min, max);
    }

    Quaternion m_targetAngle = Quaternion.identity;
    Quaternion m_interpAngle = Quaternion.identity;
    public float yMinLimit = -60;
    public float yMaxLimit = 70;
    public float ySpeed = 100;
    public float xSpeed = 100;
    Transform m_camera;
    public static Transform m_cameraOrientTarget;

    void Update()
    {   
        //GetComponentInChildren<Camera>().transform.localPosition = new Vector3(0, 25, -21);
        //GetComponentInChildren<Camera>().transform.LookAt(transform.position + Vector3.up * 15f);
        if (m_lockCursor)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                m_lockCursor = false;
                Screen.lockCursor = false;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
            {
                m_lockCursor = true;
                Screen.lockCursor = true;
            }
        }

        Vector3 l_jw = new Vector3(0, m_jumpStart != 0 ? (-Mathf.Clamp((Time.time - m_jumpStart) / m_travelSpd - Mathf.PI, 0, 1)) + (Mathf.Cos(Mathf.Clamp((Time.time - m_jumpStart) / m_travelSpd, -Mathf.PI, Mathf.PI))) * (Input.GetKey(KeyCode.Space) ? m_longerTravelDist : m_travelDist) : 0, 0);
        CollisionFlags flags = GetComponentInChildren<CharacterController>().Move((transform.rotation * (m_motionVector + m_rememberedSpeed + l_jw * 100) + Physics.gravity) * Time.deltaTime);
        //rigidbody.MovePosition(Vector3.up);
        //rigidbody.MovePosition(Vector3.down);
        {
            if(m_lockCursor)
            {
                m_x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
                m_y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
            }

            m_interpAngle = Quaternion.Lerp(m_interpAngle, m_targetAngle, Time.deltaTime * 15f);
            m_y = ClampAngle(m_y, yMinLimit, yMaxLimit);
            Quaternion rotation = Quaternion.Euler(m_y, m_x, 0);
            Vector3 position = rotation * new Vector3(0, 0, -25f) + transform.position;
            m_camera.rotation = Quaternion.Euler(rotation.eulerAngles.x, 0, 0);
            transform.rotation = Quaternion.Euler(0, rotation.eulerAngles.y + m_interpAngle.eulerAngles.y, 0);
            m_camera.position = position;
            m_camera.LookAt(transform.position + new Vector3(0, 15, 0));
        }

        if ((flags & CollisionFlags.CollidedBelow) != 0)
        {
            if (m_waitingForLanding)
            {
                OnLand();
            }
        }
        else
        {
            //if just lifted off
            if ((flags & CollisionFlags.CollidedBelow) == 0)
            {
                if ((m_lastCollisionFlags & CollisionFlags.CollidedBelow) != 0)
                {
                    if (m_jumpStart == -1)
                    {
                        RaycastHit l_botLH = new RaycastHit();
                        Debug.DrawRay(transform.position + 1 * Vector3.up, Vector3.down, Color.red, 15f);
                        if (!Physics.Raycast(new Ray() { origin = transform.position + 1 * Vector3.up, direction = Vector3.down }, out l_botLH, 1.25f))
                        {
                            m_jumpStart = Time.time - Mathf.PI * m_travelSpd;
                            m_rememberedSpeed = m_motionVector;
                            Debug.Log("FALL LIFTOFF");
                            m_waitingForLanding = true;
                            m_lastFlags = AnimFlags.jump | AnimFlags.idle;
                        }
                    }
                    //m_jumpStart = Time.time;
                }
            }
        }

        m_lastCollisionFlags = flags;
        PlayClip(GetAnim());

        if (animation[GetAnim()] != null)
        {
            adds = animation[GetAnim()].normalizedTime.ToString() + "\n" + (m_jumpStart != 0 ? m_upperVector * (Time.time - m_jumpStart) - 0.5f * (Time.time - m_jumpStart) * (Time.time - m_jumpStart) * 9.8f : 0).ToString();
        }
    }

    Vector2 m_scrollVal = Vector2.zero;

    public static List<AnimationClip> m_clips = new List<AnimationClip>();
    string m_clipname = "";
    string adds = "";
	// Update is called once per frame
    void OnGUI()
    {
        GUILayout.Space(50);
        GUILayout.Label(m_clipname + "\n" + adds + "\n" + adds2 + "\nadditional angle:" + m_targetAngle.eulerAngles + "\nJumpTime : " +(m_jumpStart != -1 ? Time.time - m_jumpStart : 0 ));

        return;
        if (animation != null)
        {
            m_scrollVal = GUILayout.BeginScrollView(m_scrollVal, GUIStyle.none);
            foreach (AnimationClip clip in m_clips)
            {
                if (GUILayout.Button(clip.name))
                {
                    PlayClip(clip.name);
                }
            }
            GUILayout.EndScrollView();
        }
    }
}
