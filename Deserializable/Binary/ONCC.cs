namespace Round2.Generated.Binary
{
  internal partial class ONCC: Round2.BinaryInitializable
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
      ///Shadow texture
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
      ///Regeneration time of one health point in 1/60 seconds if you use a hypo
      /// </summary>
      public System.Int16 m_Regeneration_time_64;
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
      ///Rotation factor * 360 degrees = possible rotation per frame or animation
      /// </summary>
      public System.Single m_Rotation_factor_12C;
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
      ///Character varient link
      /// </summary>
      public Link<ONCV> m_ONCV_link_434 =  new Link<ONCV>();
      /// <summary>
      ///Character particle array link; useless?
      /// </summary>
      public Link<ONCP> m_ONCP_link_438 =  new Link<ONCP>();
      /// <summary>
      ///Character impact array link; useless?
      /// </summary>
      public Link<ONIA> m_ONIA_link_43C =  new Link<ONIA>();
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
      ///Reference to a 3Dparticle.BINA file of level 0; only the mad bomber use it
      /// </summary>
      public System.Int32 m_Special_death_particles_BF4;
      /// <summary>
      ///Body set link
      /// </summary>
      public Link<TRBS> m_TRBS_link_C3C =  new Link<TRBS>();
      /// <summary>
      ///Texture map array link
      /// </summary>
      public Link<TRMA> m_TRMA_link_C40 =  new Link<TRMA>();
      /// <summary>
      ///Body part material link
      /// </summary>
      public Link<CBPM> m_CBPM_link_C44 =  new Link<CBPM>();
      /// <summary>
      ///Body part impact link
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
      ///Animation collection link
      /// </summary>
      public Link<TRAC> m_TRAC_link_C88 =  new Link<TRAC>();
      /// <summary>
      ///Screen (aiming) collection link
      /// </summary>
      public Link<TRSC> m_TRSC_link_C8C =  new Link<TRSC>();

      public void Convert(byte[] data)
      {
          byte[] l_bytes = new byte[4];
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
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 100];
         }
         this.m_Regeneration_time_64 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
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
             l_bytes[i] = data[i + 300];
         }
         this.m_Rotation_factor_12C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
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
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3060];
         }
         this.m_Special_death_particles_BF4 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
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
             l_bytes[i] = data[i + 3208];
         }
         this.m_TRAC_link_C88 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 3212];
         }
         this.m_TRSC_link_C8C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);

     }
  }
}
