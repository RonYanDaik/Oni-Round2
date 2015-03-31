namespace Round2.Generated.Binary
{
  internal partial class ONCC_2: Round2.BinaryInitializable
  {
      /// <summary>
      ///File id
      /// </summary>
      public System.Int32 m_File_id_0;
      /// <summary>
      ///Level id
      /// </summary>
      public System.Int32 m_Level_id_4;
      /// <summary>
      ///Unknown; always the same; maybe downwards velocity?
      /// </summary>
      public System.Single m_Unknown_8;
      /// <summary>
      ///Downward gravity acceleration
      /// </summary>
      public System.Single m_Downward_acceleration_C;
      /// <summary>
      ///Starting velocity for a simple (tap) JUMP
      /// </summary>
      public System.Single m_Starting_velocity_10;
      /// <summary>
      ///Limit velocity for jumping and gravity flight 
      /// </summary>
      public System.Single m_Limit_velocity_14;
      /// <summary>
      ///Upward acceleration (jetpack) if you hold JUMP
      /// </summary>
      public System.Single m_Upward_acceleration_18;
      /// <summary>
      ///Unknown; always the same; maybe a gravity timer?
      /// </summary>
      public System.Int16 m_Unknown_1C;
      /// <summary>
      ///Jetpack timer; time during which you can use the jetpack
      /// </summary>
      public System.Int16 m_Jetpack_timer_1E;
      /// <summary>
      ///Maximal falling height without damage 
      /// </summary>
      public System.Single m_Height_no_damage_20;
      /// <summary>
      ///Maximal falling height with damage
      /// </summary>
      public System.Single m_Height_damage_24;
      /// <summary>
      ///Link to the shadow texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_28 =  new Link<TXMP>();
      /// <summary>
      ///Height, where the shadow fades out completely
      /// </summary>
      public System.Single m_Shadow_height_5__2C;
      /// <summary>
      ///Height, where the diameter of the shadow decreases and the shadow fades out half
      /// </summary>
      public System.Single m_Shadow_height_4_30;
      /// <summary>
      ///Height, where the diameter of the shadow decreases
      /// </summary>
      public System.Single m_Shadow_height_3_34;
      /// <summary>
      ///Height, where the diameter of the shadow decreases
      /// </summary>
      public System.Single m_Shadow_height_2_38;
      /// <summary>
      ///Height, where the diameter of the shadow decreases
      /// </summary>
      public System.Single m_Shadow_height_1_3C;
      /// <summary>
      ///Transparency of the shadow for the first part of a jump
      /// </summary>
      public System.Int16 m_Shadow_option_1_40;
      /// <summary>
      ///Transparency of the shadow for the second part of a jump
      /// </summary>
      public System.Int16 m_Shadow_option_2_42;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_44;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Byte m_Unknown_48;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Byte m_Unknown_49;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_4A;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_4C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_50;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_54;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_58;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_5C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_60;
      /// <summary>
      ///Regeneration time of one health point in 1/60 seconds if you use a hypo
      /// </summary>
      public System.Int16 m_Regeneration_time_64;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_66;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_68;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_6C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_70;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_74;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_78;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_7C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_7E;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_80;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_82;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_84;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_86;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_88;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_8A;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_8C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_8E;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_90;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Byte m_Unknown_92;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_93;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_94;
      /// <summary>
      ///Reference to an OSBD file of level 0
      /// </summary>
      public System.Int32 m_Hurt_light_sound_98;
      /// <summary>
      ///Reference to an OSBD file of level 0
      /// </summary>
      public System.Int32 m_Hurt_medium_sound_B8;
      /// <summary>
      ///Reference to an OSBD file of level 0
      /// </summary>
      public System.Int32 m_Hurt_heavy_sound_D8;
      /// <summary>
      ///Reference to an OSBD file of level 0
      /// </summary>
      public System.Int32 m_Death_sound_F8;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_118;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_11C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_120;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_124;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_128;
      /// <summary>
      ///Rotation factor * 360 degrees = possible rotation per frame or animation
      /// </summary>
      public System.Single m_Rotation_factor_12C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_130;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_132;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_134;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_138;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_13C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_140;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_144;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_148;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_14C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_150;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_154;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_158;
      /// <summary>
      ///recoil compensation amount (0 = min, 1 = max)
      /// </summary>
      public System.Single m_w0_sec___recoil_15C;
      /// <summary>
      ///best aiming angle in radians
      /// </summary>
      public System.Single m_w0_sec___best_angle_160;
      /// <summary>
      ///shot grouping error
      /// </summary>
      public System.Single m_w0_sec___error_164;
      /// <summary>
      ///shot grouping decay
      /// </summary>
      public System.Single m_w0_sec___decay_168;
      /// <summary>
      ///shooting inaccuracy multiplier
      /// </summary>
      public System.Single m_w0_sec___inaccuracy_16C;
      /// <summary>
      ///minimum delay between shots in frames
      /// </summary>
      public System.Int16 m_w0_sec___minimum_delay_170;
      /// <summary>
      ///maximum delay between shots in frames
      /// </summary>
      public System.Int16 m_w0_sec___maximum_delay_172;
      /// <summary>
      ///recoil compensation amount (0 = min, 1 = max)
      /// </summary>
      public System.Single m_w1_tap___recoil_174;
      /// <summary>
      ///best aiming angle in radians
      /// </summary>
      public System.Single m_w1_tap___best_angle_178;
      /// <summary>
      ///shot grouping error
      /// </summary>
      public System.Single m_w1_tap___error_17C;
      /// <summary>
      ///shot grouping decay
      /// </summary>
      public System.Single m_w1_tap___decay_180;
      /// <summary>
      ///shooting inaccuracy multiplier
      /// </summary>
      public System.Single m_w1_tap___inaccuracy_184;
      /// <summary>
      ///minimum delay between shots in frames
      /// </summary>
      public System.Int16 m_w1_tap___minimum_delay_188;
      /// <summary>
      ///maximum delay between shots in frames
      /// </summary>
      public System.Int16 m_w1_tap___maximum_delay_18A;
      /// <summary>
      ///recoil compensation amount (0 = min, 1 = max)
      /// </summary>
      public System.Single m_w2_sap___recoil_18C;
      /// <summary>
      ///best aiming angle in radians
      /// </summary>
      public System.Single m_w2_sap___best_angle_190;
      /// <summary>
      ///shot grouping error
      /// </summary>
      public System.Single m_w2_sap___error_194;
      /// <summary>
      ///shot grouping decay
      /// </summary>
      public System.Single m_w2_sap___decay_198;
      /// <summary>
      ///shooting inaccuracy multiplier
      /// </summary>
      public System.Single m_w2_sap___inaccuracy_19C;
      /// <summary>
      ///minimum delay between shots in frames
      /// </summary>
      public System.Int16 m_w2_sap___minimum_delay_1A0;
      /// <summary>
      ///maximum delay between shots in frames
      /// </summary>
      public System.Int16 m_w2_sap___maximum_delay_1A2;
      /// <summary>
      ///recoil compensation amount (0 = min, 1 = max)
      /// </summary>
      public System.Single m_w3_phr___recoil_1A4;
      /// <summary>
      ///best aiming angle in radians
      /// </summary>
      public System.Single m_w3_phr___best_angle_1A8;
      /// <summary>
      ///shot grouping error
      /// </summary>
      public System.Single m_w3_phr___error_1AC;
      /// <summary>
      ///shot grouping decay
      /// </summary>
      public System.Single m_w3_phr___decay_1B0;
      /// <summary>
      ///shooting inaccuracy multiplier
      /// </summary>
      public System.Single m_w3_phr___inaccuracy_1B4;
      /// <summary>
      ///minimum delay between shots in frames
      /// </summary>
      public System.Int16 m_w3_phr___minimum_delay_1B8;
      /// <summary>
      ///maximum delay between shots in frames
      /// </summary>
      public System.Int16 m_w3_phr___maximum_delay_1BA;
      /// <summary>
      ///recoil compensation amount (0 = min, 1 = max)
      /// </summary>
      public System.Single m_w4_psm___recoil_1BC;
      /// <summary>
      ///best aiming angle in radians
      /// </summary>
      public System.Single m_w4_psm___best_angle_1C0;
      /// <summary>
      ///shot grouping error
      /// </summary>
      public System.Single m_w4_psm___error_1C4;
      /// <summary>
      ///shot grouping decay
      /// </summary>
      public System.Single m_w4_psm___decay_1C8;
      /// <summary>
      ///shooting inaccuracy multiplier
      /// </summary>
      public System.Single m_w4_psm___inaccuracy_1CC;
      /// <summary>
      ///minimum delay between shots in frames
      /// </summary>
      public System.Int16 m_w4_psm___minimum_delay_1D0;
      /// <summary>
      ///maximum delay between shots in frames
      /// </summary>
      public System.Int16 m_w4_psm___maximum_delay_1D2;
      /// <summary>
      ///recoil compensation amount (0 = min, 1 = max)
      /// </summary>
      public System.Single m_w5_sbg___recoil_1D4;
      /// <summary>
      ///best aiming angle in radians
      /// </summary>
      public System.Single m_w5_sbg___best_angle_1D8;
      /// <summary>
      ///shot grouping error
      /// </summary>
      public System.Single m_w5_sbg___error_1DC;
      /// <summary>
      ///shot grouping decay
      /// </summary>
      public System.Single m_w5_sbg___decay_1E0;
      /// <summary>
      ///shooting inaccuracy multiplier
      /// </summary>
      public System.Single m_w5_sbg___inaccuracy_1E4;
      /// <summary>
      ///minimum delay between shots in frames
      /// </summary>
      public System.Int16 m_w5_sbg___minimum_delay_1E8;
      /// <summary>
      ///maximum delay between shots in frames
      /// </summary>
      public System.Int16 m_w5_sbg___maximum_delay_1EA;
      /// <summary>
      ///recoil compensation amount (0 = min, 1 = max)
      /// </summary>
      public System.Single m_w6_vdg___recoil_1EC;
      /// <summary>
      ///best aiming angle in radians
      /// </summary>
      public System.Single m_w6_vdg___best_angle_1F0;
      /// <summary>
      ///shot grouping error
      /// </summary>
      public System.Single m_w6_vdg___error_1F4;
      /// <summary>
      ///shot grouping decay
      /// </summary>
      public System.Single m_w6_vdg___decay_1F8;
      /// <summary>
      ///shooting inaccuracy multiplier
      /// </summary>
      public System.Single m_w6_vdg___inaccuracy_1FC;
      /// <summary>
      ///minimum delay between shots in frames
      /// </summary>
      public System.Int16 m_w6_vdg___minimum_delay_200;
      /// <summary>
      ///maximum delay between shots in frames
      /// </summary>
      public System.Int16 m_w6_vdg___maximum_delay_202;
      /// <summary>
      ///recoil compensation amount (0 = min, 1 = max)
      /// </summary>
      public System.Single m_w7_scc___recoil_204;
      /// <summary>
      ///best aiming angle in radians
      /// </summary>
      public System.Single m_w7_scc___best_angle_208;
      /// <summary>
      ///shot grouping error
      /// </summary>
      public System.Single m_w7_scc___error_20C;
      /// <summary>
      ///shot grouping decay
      /// </summary>
      public System.Single m_w7_scc___decay_210;
      /// <summary>
      ///shooting inaccuracy multiplier
      /// </summary>
      public System.Single m_w7_scc___inaccuracy_214;
      /// <summary>
      ///minimum delay between shots in frames
      /// </summary>
      public System.Int16 m_w7_scc___minimum_delay_218;
      /// <summary>
      ///maximum delay between shots in frames
      /// </summary>
      public System.Int16 m_w7_scc___maximum_delay_21A;
      /// <summary>
      ///recoil compensation amount (0 = min, 1 = max)
      /// </summary>
      public System.Single m_w8_mbo___recoil_21C;
      /// <summary>
      ///best aiming angle in radians
      /// </summary>
      public System.Single m_w8_mbo___best_angle_220;
      /// <summary>
      ///shot grouping error
      /// </summary>
      public System.Single m_w8_mbo___error_224;
      /// <summary>
      ///shot grouping decay
      /// </summary>
      public System.Single m_w8_mbo___decay_228;
      /// <summary>
      ///shooting inaccuracy multiplier
      /// </summary>
      public System.Single m_w8_mbo___inaccuracy_22C;
      /// <summary>
      ///minimum delay between shots in frames
      /// </summary>
      public System.Int16 m_w8_mbo___minimum_delay_230;
      /// <summary>
      ///maximum delay between shots in frames
      /// </summary>
      public System.Int16 m_w8_mbo___maximum_delay_232;
      /// <summary>
      ///recoil compensation amount (0 = min, 1 = max)
      /// </summary>
      public System.Single m_w9_scr___recoil_234;
      /// <summary>
      ///best aiming angle in radians
      /// </summary>
      public System.Single m_w9_scr___best_angle_238;
      /// <summary>
      ///shot grouping error
      /// </summary>
      public System.Single m_w9_scr___error_23C;
      /// <summary>
      ///shot grouping decay
      /// </summary>
      public System.Single m_w9_scr___decay_240;
      /// <summary>
      ///shooting inaccuracy multiplier
      /// </summary>
      public System.Single m_w9_scr___inaccuracy_244;
      /// <summary>
      ///minimum delay between shots in frames
      /// </summary>
      public System.Int16 m_w9_scr___minimum_delay_248;
      /// <summary>
      ///maximum delay between shots in frames
      /// </summary>
      public System.Int16 m_w9_scr___maximum_delay_24A;
      /// <summary>
      ///recoil compensation amount (0 = min, 1 = max)
      /// </summary>
      public System.Single m_w10_sni___recoil_24C;
      /// <summary>
      ///best aiming angle in radians
      /// </summary>
      public System.Single m_w10_sni___best_angle_250;
      /// <summary>
      ///shot grouping error
      /// </summary>
      public System.Single m_w10_sni___error_254;
      /// <summary>
      ///shot grouping decay
      /// </summary>
      public System.Single m_w10_sni___decay_258;
      /// <summary>
      ///shooting inaccuracy multiplier
      /// </summary>
      public System.Single m_w10_sni___inaccuracy_25C;
      /// <summary>
      ///minimum delay between shots in frames
      /// </summary>
      public System.Int16 m_w10_sni___minimum_delay_260;
      /// <summary>
      ///maximum delay between shots in frames
      /// </summary>
      public System.Int16 m_w10_sni___maximum_delay_262;
      /// <summary>
      ///recoil compensation amount (0 = min, 1 = max)
      /// </summary>
      public System.Single m_w11_ba1___recoil_264;
      /// <summary>
      ///best aiming angle in radians
      /// </summary>
      public System.Single m_w11_ba1___best_angle_268;
      /// <summary>
      ///shot grouping error
      /// </summary>
      public System.Single m_w11_ba1___error_26C;
      /// <summary>
      ///shot grouping decay
      /// </summary>
      public System.Single m_w11_ba1___decay_270;
      /// <summary>
      ///shooting inaccuracy multiplier
      /// </summary>
      public System.Single m_w11_ba1___inaccuracy_274;
      /// <summary>
      ///minimum delay between shots in frames
      /// </summary>
      public System.Int16 m_w11_ba1___minimum_delay_278;
      /// <summary>
      ///maximum delay between shots in frames
      /// </summary>
      public System.Int16 m_w11_ba1___maximum_delay_27A;
      /// <summary>
      ///recoil compensation amount (0 = min, 1 = max)
      /// </summary>
      public System.Single m_w12_ba2___recoil_27C;
      /// <summary>
      ///best aiming angle in radians
      /// </summary>
      public System.Single m_w12_ba2___best_angle_280;
      /// <summary>
      ///shot grouping error
      /// </summary>
      public System.Single m_w12_ba2___error_284;
      /// <summary>
      ///shot grouping decay
      /// </summary>
      public System.Single m_w12_ba2___decay_288;
      /// <summary>
      ///shooting inaccuracy multiplier
      /// </summary>
      public System.Single m_w12_ba2___inaccuracy_28C;
      /// <summary>
      ///minimum delay between shots in frames
      /// </summary>
      public System.Int16 m_w12_ba2___minimum_delay_290;
      /// <summary>
      ///maximum delay between shots in frames
      /// </summary>
      public System.Int16 m_w12_ba2___maximum_delay_292;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_294;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_298;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_29C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_2A0;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_2A4;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_2A8;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_2AC;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_2AE;
      /// <summary>
      ///0 = not used; 100 = used
      /// </summary>
      public System.Byte m_Taunt_sound_query_2B0;
      /// <summary>
      ///0 = not used; 100 = used
      /// </summary>
      public System.Byte m_Alert_sound_query_2B1;
      /// <summary>
      ///0 = not used; 100 = used
      /// </summary>
      public System.Byte m_Startle_sound_query_2B2;
      /// <summary>
      ///0 = not used; 100 = used
      /// </summary>
      public System.Byte m_Check_body_sound_query_2B3;
      /// <summary>
      ///0 = not used; 100 = used
      /// </summary>
      public System.Byte m_Pursue_sound_query_2B4;
      /// <summary>
      ///0 = not used; 100 = used
      /// </summary>
      public System.Byte m_Cower_sound_query_2B5;
      /// <summary>
      ///0 = not used; 100 = used
      /// </summary>
      public System.Byte m_Punch_heavy_sound_query_2B6;
      /// <summary>
      ///0 = not used; 100 = used
      /// </summary>
      public System.Byte m_Kich_heavy_sound_query_2B7;
      /// <summary>
      ///0 = not used; 100 = used
      /// </summary>
      public System.Byte m_Super3_sound_query_2B8;
      /// <summary>
      ///0 = not used; 100 = used
      /// </summary>
      public System.Byte m_Super4_sound_query_2B9;
      /// <summary>
      ///Reference to a SNDD file of level 0
      /// </summary>
      public System.Int32 m_Taunt_sound_2BC;
      /// <summary>
      ///Reference to a SNDD file of level 0
      /// </summary>
      public System.Int32 m_Alert_sound_2DC;
      /// <summary>
      ///Reference to a SNDD file of level 0
      /// </summary>
      public System.Int32 m_Startle_sound_2FC;
      /// <summary>
      ///Reference to a SNDD file of level 0
      /// </summary>
      public System.Int32 m_Check_body_sound_31C;
      /// <summary>
      ///Reference to a SNDD file of level 0
      /// </summary>
      public System.Int32 m_Pursue_sound_33C;
      /// <summary>
      ///Reference to a SNDD file of level 0
      /// </summary>
      public System.Int32 m_Cower_sound_35C;
      /// <summary>
      ///Reference to a SNDD file of level 0
      /// </summary>
      public System.Int32 m_Punch_heavy_sound_37C;
      /// <summary>
      ///Reference to a SNDD file of level 0
      /// </summary>
      public System.Int32 m_Kick_heavy_sound_39C;
      /// <summary>
      ///Reference to a SNDD file of level 0
      /// </summary>
      public System.Int32 m_Super3_sound_3BC;
      /// <summary>
      ///Reference to a SNDD file of level 0
      /// </summary>
      public System.Int32 m_Super4_sound_3DC;
      /// <summary>
      ///The max. distance where the AI can see you
      /// </summary>
      public System.Single m_Eyeshot_3FC;
      /// <summary>
      ///The max. distance where the AI can hear you
      /// </summary>
      public System.Single m_Earshot_400;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_404;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_408;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_40C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_410;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_414;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_418;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_41C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_420;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_424;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_428;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_42C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_430;
      /// <summary>
      ///Link to the Character Varient
      /// </summary>
      public Link<ONCV> m_ONCV_link_434 =  new Link<ONCV>();
      /// <summary>
      ///Link to the Character Particle Array
      /// </summary>
      public Link<ONCP> m_ONCP_link_438 =  new Link<ONCP>();
      /// <summary>
      ///Link to the Character Impact Array
      /// </summary>
      public Link<ONIA> m_ONIA_link_43C =  new Link<ONIA>();
      /// <summary>
      ///Unknown; maybe a canceled link; always the same
      /// </summary>
      public System.Int32 m_Unknown_440;
      /// <summary>
      ///Maybe the weight of the character?
      /// </summary>
      public System.String m_Unknown_444;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Footstep_walk_impact_454;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Footstep_run_impact_4D6;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Footstep_crouch_impact_558;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Fall_slide_impact_5DA;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Fall_land_impact_65C;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Fall_land_hard_impact_6DE;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Fall_knockdown_impact_760;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Fall_knockdown_impact_7E2;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Fall_knockdown_impact_864;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Footstep_turn_impact_8E6;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Footstep_run_start_impact_968;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Footstep_single_step_impact_9EA;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Footstep_run_stop_impact_A6C;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Footstep_walk_stop_impact_AEE;
      /// <summary>
      ///Reference to an Impt file of level 0
      /// </summary>
      public System.Int32 m_Footstep_run_sprint_impact_B70;
      /// <summary>
      ///Unknown; always the same; maybe only a filler
      /// </summary>
      public System.Int16 m_Unknown_BF2;
      /// <summary>
      ///Reference to a 3Dparticle.BINA file of level 0; only the mad bomber use it
      /// </summary>
      public System.Int32 m_Special_death_particles_BF4;
      /// <summary>
      ///Unknown; maybe a canceled link; always the same
      /// </summary>
      public System.Int32 m_Unknown_C34;
      /// <summary>
      ///Unknown; maybe a canceled link; always the same
      /// </summary>
      public System.Int32 m_Unknown_C38;
      /// <summary>
      ///Link to the Body Set
      /// </summary>
      public Link<TRBS> m_TRBS_link_C3C =  new Link<TRBS>();
      /// <summary>
      ///Link to the Texture Map Array
      /// </summary>
      public Link<TRMA> m_TRMA_link_C40 =  new Link<TRMA>();
      /// <summary>
      ///Link to the Body Part Material
      /// </summary>
      public Link<CBPM> m_CBPM_link_C44 =  new Link<CBPM>();
      /// <summary>
      ///Link to the Body Part Impacts
      /// </summary>
      public Link<CBPI> m_CBPI_link_C48 =  new Link<CBPI>();
      /// <summary>
      ///Peace timer in 1/60 seconds; after that time the character switches back from fight to peace mode
      /// </summary>
      public System.Int32 m_Peace_timer_C4C;
      /// <summary>
      ///First idle timer in 1/60 seconds; after that time Oni plays a special idle animation
      /// </summary>
      public System.Int32 m_First_idle_timer_C50;
      /// <summary>
      ///Second idle timer in 1/60 seconds; after that time Oni plays a special idle animation
      /// </summary>
      public System.Int32 m_Second_idle_timer_C54;
      /// <summary>
      ///Extra health informations are stored in the Character.BINA files
      /// </summary>
      public System.Int32 m_Basic_health_C58;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Basic_health_C5C;
      /// <summary>
      ///Minimal body size factor
      /// </summary>
      public System.Single m_Minimal_body_size_factor_C60;
      /// <summary>
      ///Maximal body size factor
      /// </summary>
      public System.Single m_Maximal_body_size_factor_C64;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_C68;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_C6C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_C70;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_C74;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_C78;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_C7C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_C80;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_C84;
      /// <summary>
      ///Link to the Animation Collection
      /// </summary>
      public Link<TRAC> m_TRAC_link_C88 =  new Link<TRAC>();
      /// <summary>
      ///Link to the Screen (Aiming) Collection
      /// </summary>
      public Link<TRSC> m_TRSC_link_C8C =  new Link<TRSC>();
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_C90;
      /// <summary>
      ///Unknown; only the mad bomber use it
      /// </summary>
      public System.Int16 m_Unknown_C92;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Byte m_Unknown_C94;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Byte m_Unknown_C95;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Byte m_Unknown_C96;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Byte m_Unknown_C97;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_useed_C98;

      public override void Convert(byte[] data)
      {
          byte[] l_bytes = new byte[16];
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 0];
         }
         this.m_File_id_0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 4];
         }
         this.m_Level_id_4 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 8];
         }
         this.m_Unknown_8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_Downward_acceleration_C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_Starting_velocity_10 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_Limit_velocity_14 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_Upward_acceleration_18 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Unknown_1C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 30];
         }
         this.m_Jetpack_timer_1E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_Height_no_damage_20 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_Height_damage_24 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_TXMP_link_28 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_Shadow_height_5__2C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 48];
         }
         this.m_Shadow_height_4_30 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 52];
         }
         this.m_Shadow_height_3_34 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 56];
         }
         this.m_Shadow_height_2_38 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 60];
         }
         this.m_Shadow_height_1_3C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 64];
         }
         this.m_Shadow_option_1_40 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 66];
         }
         this.m_Shadow_option_2_42 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 68];
         }
         this.m_Unknown_44 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 72];
         }
         this.m_Unknown_48 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 73];
         }
         this.m_Unknown_49 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 74];
         }
         this.m_Not_used_4A = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 76];
         }
         this.m_Unknown_4C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 80];
         }
         this.m_Unknown_50 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 84];
         }
         this.m_Unknown_54 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 88];
         }
         this.m_Unknown_58 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 92];
         }
         this.m_Unknown_5C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 96];
         }
         this.m_Unknown_60 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 100];
         }
         this.m_Regeneration_time_64 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 102];
         }
         this.m_Not_used_66 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 104];
         }
         this.m_Unknown_68 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 108];
         }
         this.m_Unknown_6C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 112];
         }
         this.m_Unknown_70 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 116];
         }
         this.m_Unknown_74 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 120];
         }
         this.m_Unknown_78 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 124];
         }
         this.m_Unknown_7C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 126];
         }
         this.m_Unknown_7E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 128];
         }
         this.m_Unknown_80 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 130];
         }
         this.m_Unknown_82 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 132];
         }
         this.m_Unknown_84 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 134];
         }
         this.m_Unknown_86 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 136];
         }
         this.m_Unknown_88 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 138];
         }
         this.m_Unknown_8A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 140];
         }
         this.m_Unknown_8C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 142];
         }
         this.m_Unknown_8E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 144];
         }
         this.m_Unknown_90 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 146];
         }
         this.m_Unknown_92 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 147];
         }
         this.m_Not_used_93 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 148];
         }
         this.m_Unknown_94 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 152];
         }
         this.m_Hurt_light_sound_98 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 184];
         }
         this.m_Hurt_medium_sound_B8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 216];
         }
         this.m_Hurt_heavy_sound_D8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 248];
         }
         this.m_Death_sound_F8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 280];
         }
         this.m_Unknown_118 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 284];
         }
         this.m_Unknown_11C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 288];
         }
         this.m_Unknown_120 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 292];
         }
         this.m_Unknown_124 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 296];
         }
         this.m_Unknown_128 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 300];
         }
         this.m_Rotation_factor_12C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 304];
         }
         this.m_Unknown_130 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 306];
         }
         this.m_Unknown_132 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 308];
         }
         this.m_Unknown_134 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 312];
         }
         this.m_Unknown_138 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 316];
         }
         this.m_Unknown_13C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 320];
         }
         this.m_Unknown_140 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 324];
         }
         this.m_Unknown_144 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 328];
         }
         this.m_Unknown_148 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 332];
         }
         this.m_Unknown_14C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 336];
         }
         this.m_Unknown_150 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 340];
         }
         this.m_Unknown_154 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 344];
         }
         this.m_Unknown_158 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 348];
         }
         this.m_w0_sec___recoil_15C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 352];
         }
         this.m_w0_sec___best_angle_160 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 356];
         }
         this.m_w0_sec___error_164 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 360];
         }
         this.m_w0_sec___decay_168 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 364];
         }
         this.m_w0_sec___inaccuracy_16C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 368];
         }
         this.m_w0_sec___minimum_delay_170 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 370];
         }
         this.m_w0_sec___maximum_delay_172 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 372];
         }
         this.m_w1_tap___recoil_174 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 376];
         }
         this.m_w1_tap___best_angle_178 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 380];
         }
         this.m_w1_tap___error_17C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 384];
         }
         this.m_w1_tap___decay_180 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 388];
         }
         this.m_w1_tap___inaccuracy_184 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 392];
         }
         this.m_w1_tap___minimum_delay_188 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 394];
         }
         this.m_w1_tap___maximum_delay_18A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 396];
         }
         this.m_w2_sap___recoil_18C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 400];
         }
         this.m_w2_sap___best_angle_190 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 404];
         }
         this.m_w2_sap___error_194 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 408];
         }
         this.m_w2_sap___decay_198 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 412];
         }
         this.m_w2_sap___inaccuracy_19C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 416];
         }
         this.m_w2_sap___minimum_delay_1A0 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 418];
         }
         this.m_w2_sap___maximum_delay_1A2 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 420];
         }
         this.m_w3_phr___recoil_1A4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 424];
         }
         this.m_w3_phr___best_angle_1A8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 428];
         }
         this.m_w3_phr___error_1AC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 432];
         }
         this.m_w3_phr___decay_1B0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 436];
         }
         this.m_w3_phr___inaccuracy_1B4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 440];
         }
         this.m_w3_phr___minimum_delay_1B8 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 442];
         }
         this.m_w3_phr___maximum_delay_1BA = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 444];
         }
         this.m_w4_psm___recoil_1BC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 448];
         }
         this.m_w4_psm___best_angle_1C0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 452];
         }
         this.m_w4_psm___error_1C4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 456];
         }
         this.m_w4_psm___decay_1C8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 460];
         }
         this.m_w4_psm___inaccuracy_1CC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 464];
         }
         this.m_w4_psm___minimum_delay_1D0 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 466];
         }
         this.m_w4_psm___maximum_delay_1D2 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 468];
         }
         this.m_w5_sbg___recoil_1D4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 472];
         }
         this.m_w5_sbg___best_angle_1D8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 476];
         }
         this.m_w5_sbg___error_1DC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 480];
         }
         this.m_w5_sbg___decay_1E0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 484];
         }
         this.m_w5_sbg___inaccuracy_1E4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 488];
         }
         this.m_w5_sbg___minimum_delay_1E8 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 490];
         }
         this.m_w5_sbg___maximum_delay_1EA = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 492];
         }
         this.m_w6_vdg___recoil_1EC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 496];
         }
         this.m_w6_vdg___best_angle_1F0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 500];
         }
         this.m_w6_vdg___error_1F4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 504];
         }
         this.m_w6_vdg___decay_1F8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 508];
         }
         this.m_w6_vdg___inaccuracy_1FC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 512];
         }
         this.m_w6_vdg___minimum_delay_200 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 514];
         }
         this.m_w6_vdg___maximum_delay_202 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 516];
         }
         this.m_w7_scc___recoil_204 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 520];
         }
         this.m_w7_scc___best_angle_208 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 524];
         }
         this.m_w7_scc___error_20C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 528];
         }
         this.m_w7_scc___decay_210 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 532];
         }
         this.m_w7_scc___inaccuracy_214 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 536];
         }
         this.m_w7_scc___minimum_delay_218 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 538];
         }
         this.m_w7_scc___maximum_delay_21A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 540];
         }
         this.m_w8_mbo___recoil_21C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 544];
         }
         this.m_w8_mbo___best_angle_220 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 548];
         }
         this.m_w8_mbo___error_224 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 552];
         }
         this.m_w8_mbo___decay_228 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 556];
         }
         this.m_w8_mbo___inaccuracy_22C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 560];
         }
         this.m_w8_mbo___minimum_delay_230 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 562];
         }
         this.m_w8_mbo___maximum_delay_232 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 564];
         }
         this.m_w9_scr___recoil_234 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 568];
         }
         this.m_w9_scr___best_angle_238 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 572];
         }
         this.m_w9_scr___error_23C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 576];
         }
         this.m_w9_scr___decay_240 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 580];
         }
         this.m_w9_scr___inaccuracy_244 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 584];
         }
         this.m_w9_scr___minimum_delay_248 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 586];
         }
         this.m_w9_scr___maximum_delay_24A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 588];
         }
         this.m_w10_sni___recoil_24C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 592];
         }
         this.m_w10_sni___best_angle_250 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 596];
         }
         this.m_w10_sni___error_254 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 600];
         }
         this.m_w10_sni___decay_258 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 604];
         }
         this.m_w10_sni___inaccuracy_25C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 608];
         }
         this.m_w10_sni___minimum_delay_260 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 610];
         }
         this.m_w10_sni___maximum_delay_262 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 612];
         }
         this.m_w11_ba1___recoil_264 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 616];
         }
         this.m_w11_ba1___best_angle_268 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 620];
         }
         this.m_w11_ba1___error_26C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 624];
         }
         this.m_w11_ba1___decay_270 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 628];
         }
         this.m_w11_ba1___inaccuracy_274 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 632];
         }
         this.m_w11_ba1___minimum_delay_278 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 634];
         }
         this.m_w11_ba1___maximum_delay_27A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 636];
         }
         this.m_w12_ba2___recoil_27C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 640];
         }
         this.m_w12_ba2___best_angle_280 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 644];
         }
         this.m_w12_ba2___error_284 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 648];
         }
         this.m_w12_ba2___decay_288 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 652];
         }
         this.m_w12_ba2___inaccuracy_28C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 656];
         }
         this.m_w12_ba2___minimum_delay_290 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 658];
         }
         this.m_w12_ba2___maximum_delay_292 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 660];
         }
         this.m_Unknown_294 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 664];
         }
         this.m_Unknown_298 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 668];
         }
         this.m_Unknown_29C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 672];
         }
         this.m_Unknown_2A0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 676];
         }
         this.m_Unknown_2A4 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 680];
         }
         this.m_Unknown_2A8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 684];
         }
         this.m_Unknown_2AC = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 686];
         }
         this.m_Unknown_2AE = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 688];
         }
         this.m_Taunt_sound_query_2B0 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 689];
         }
         this.m_Alert_sound_query_2B1 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 690];
         }
         this.m_Startle_sound_query_2B2 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 691];
         }
         this.m_Check_body_sound_query_2B3 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 692];
         }
         this.m_Pursue_sound_query_2B4 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 693];
         }
         this.m_Cower_sound_query_2B5 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 694];
         }
         this.m_Punch_heavy_sound_query_2B6 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 695];
         }
         this.m_Kich_heavy_sound_query_2B7 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 696];
         }
         this.m_Super3_sound_query_2B8 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 697];
         }
         this.m_Super4_sound_query_2B9 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 700];
         }
         this.m_Taunt_sound_2BC = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 732];
         }
         this.m_Alert_sound_2DC = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 764];
         }
         this.m_Startle_sound_2FC = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 796];
         }
         this.m_Check_body_sound_31C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 828];
         }
         this.m_Pursue_sound_33C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 860];
         }
         this.m_Cower_sound_35C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 892];
         }
         this.m_Punch_heavy_sound_37C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 924];
         }
         this.m_Kick_heavy_sound_39C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 956];
         }
         this.m_Super3_sound_3BC = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 988];
         }
         this.m_Super4_sound_3DC = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1020];
         }
         this.m_Eyeshot_3FC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1024];
         }
         this.m_Earshot_400 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1028];
         }
         this.m_Unknown_404 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1032];
         }
         this.m_Unknown_408 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1036];
         }
         this.m_Unknown_40C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1040];
         }
         this.m_Unknown_410 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1044];
         }
         this.m_Unknown_414 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1048];
         }
         this.m_Unknown_418 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1052];
         }
         this.m_Unknown_41C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1056];
         }
         this.m_Unknown_420 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1060];
         }
         this.m_Unknown_424 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1064];
         }
         this.m_Unknown_428 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1068];
         }
         this.m_Unknown_42C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1072];
         }
         this.m_Unknown_430 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1076];
         }
         this.m_ONCV_link_434 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1080];
         }
         this.m_ONCP_link_438 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1084];
         }
         this.m_ONIA_link_43C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1088];
         }
         this.m_Unknown_440 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<16; i++)
         {
             l_bytes[i] = data[i + 1092];
         }
         this.m_Unknown_444 = (System.String)BinaryDatReader.l_str(l_bytes, 16);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1108];
         }
         this.m_Footstep_walk_impact_454 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1238];
         }
         this.m_Footstep_run_impact_4D6 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1368];
         }
         this.m_Footstep_crouch_impact_558 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1498];
         }
         this.m_Fall_slide_impact_5DA = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1628];
         }
         this.m_Fall_land_impact_65C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1758];
         }
         this.m_Fall_land_hard_impact_6DE = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1888];
         }
         this.m_Fall_knockdown_impact_760 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 2018];
         }
         this.m_Fall_knockdown_impact_7E2 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 2148];
         }
         this.m_Fall_knockdown_impact_864 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 2278];
         }
         this.m_Footstep_turn_impact_8E6 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 2408];
         }
         this.m_Footstep_run_start_impact_968 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 2538];
         }
         this.m_Footstep_single_step_impact_9EA = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 2668];
         }
         this.m_Footstep_run_stop_impact_A6C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 2798];
         }
         this.m_Footstep_walk_stop_impact_AEE = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 2928];
         }
         this.m_Footstep_run_sprint_impact_B70 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 3058];
         }
         this.m_Unknown_BF2 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3060];
         }
         this.m_Special_death_particles_BF4 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3124];
         }
         this.m_Unknown_C34 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3128];
         }
         this.m_Unknown_C38 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3132];
         }
         this.m_TRBS_link_C3C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3136];
         }
         this.m_TRMA_link_C40 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3140];
         }
         this.m_CBPM_link_C44 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3144];
         }
         this.m_CBPI_link_C48 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3148];
         }
         this.m_Peace_timer_C4C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3152];
         }
         this.m_First_idle_timer_C50 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3156];
         }
         this.m_Second_idle_timer_C54 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3160];
         }
         this.m_Basic_health_C58 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3164];
         }
         this.m_Basic_health_C5C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3168];
         }
         this.m_Minimal_body_size_factor_C60 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3172];
         }
         this.m_Maximal_body_size_factor_C64 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3176];
         }
         this.m_Unknown_C68 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3180];
         }
         this.m_Unknown_C6C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3184];
         }
         this.m_Unknown_C70 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3188];
         }
         this.m_Unknown_C74 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3192];
         }
         this.m_Unknown_C78 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3196];
         }
         this.m_Unknown_C7C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3200];
         }
         this.m_Unknown_C80 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3204];
         }
         this.m_Unknown_C84 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3208];
         }
         this.m_TRAC_link_C88 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3212];
         }
         this.m_TRSC_link_C8C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 3216];
         }
         this.m_Unknown_C90 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 3218];
         }
         this.m_Unknown_C92 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 3220];
         }
         this.m_Unknown_C94 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 3221];
         }
         this.m_Unknown_C95 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 3222];
         }
         this.m_Unknown_C96 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 3223];
         }
         this.m_Unknown_C97 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3224];
         }
         this.m_Not_useed_C98 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
