namespace Round2.Generated.Binary
{
  internal class TRAM_2: Round2.BinaryInitializable
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
      ///Unknown; always zero
      /// </summary>
      public System.Int32 m_Unknown_8;
      /// <summary>
      ///Address of the y-position data in the .raw-file
      /// </summary>
      public System.Int32 m_Raw_link_C;
      /// <summary>
      ///Address of the x-z-position data in the .raw-file
      /// </summary>
      public System.Int32 m_Raw_link_10;
      /// <summary>
      ///Address of the attack data in the .raw-file
      /// </summary>
      public System.Int32 m_Raw_link_14;
      /// <summary>
      ///Address of the damage data in the .raw-file
      /// </summary>
      public System.Int32 m_Raw_link_18;
      /// <summary>
      ///Address of the motion blur data in the .raw-file
      /// </summary>
      public System.Int32 m_Raw_link_1C;
      /// <summary>
      ///Address of the shortcut data in the .raw-file
      /// </summary>
      public System.Int32 m_Raw_link_20;
      /// <summary>
      ///Address of the throw data in the .raw-file
      /// </summary>
      public System.Int32 m_Raw_link_24;
      /// <summary>
      ///Address of the footstep data in the .raw-file
      /// </summary>
      public System.Int32 m_Raw_link_28;
      /// <summary>
      ///Address of the particle data in the .raw-file
      /// </summary>
      public System.Int32 m_Raw_link_2C;
      /// <summary>
      ///Address of the position data in the .raw-file
      /// </summary>
      public System.Int32 m_Raw_link_30;
      /// <summary>
      ///Address of the bodypart animation data in the .raw-file
      /// </summary>
      public System.Int32 m_Raw_link_34;
      /// <summary>
      ///Address of the sound data in the .raw-file
      /// </summary>
      public System.Int32 m_Raw_link_38;
      /// <summary>
      ///Flags 1 in connection to the anim_flags.StNA file
      /// </summary>
      public System.Int32 m_Flags_1_3C;
      /// <summary>
      ///Flags 2 in connection to the anim_flags.StNA file
      /// </summary>
      public System.Int32 m_Flags_2_3D;
      /// <summary>
      ///Flags 3 in connection to the anim_flags.StNA file
      /// </summary>
      public System.Int32 m_Flags_3_3E;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Byte m_Unknown_3F;
      /// <summary>
      ///First direct animation link; this animation follows after a left mouse click (punch)
      /// </summary>
      public System.Int32 m_TRAM_link_40;
      /// <summary>
      ///Second direct animation link; this animation follows after a right mouse click (kick)
      /// </summary>
      public System.Int32 m_TRAM_link_44;
      /// <summary>
      ///Used parts; used for weapon animations like recoil, reload, draw weapon, etc.
      /// </summary>
      public System.Int32 m_Used_parts_48;
      /// <summary>
      ///Replace parts; used for weapon animations like recoil, reload, draw weapon, etc.
      /// </summary>
      public System.Int32 m_Replace_parts_4C;
      /// <summary>
      ///Final rotation; stored as multiples of the number "pi" (3.141592...)
      /// </summary>
      public System.Single m_Final_rotation_50;
      /// <summary>
      ///Move direction
      /// </summary>
      public System.Int16 m_Move_direction_54;
      /// <summary>
      ///Attack voice sound (f.e. Konokos "Rising fury!")
      /// </summary>
      public System.Int16 m_Attack_voice_sound_56;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_58;
      /// <summary>
      ///Unknown; always 1,000,000,000 if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_5C;
      /// <summary>
      ///Unknown; always -1,000,000,000 if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_60;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_64;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_68;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_6C;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_70;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_74;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_78;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_7C;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_80;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_84;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_88;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_8C;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_90;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_94;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_98;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_9C;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_A0;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_A4;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_A8;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_AC;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_B0;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_B4;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_B8;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_BC;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_C0;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_C4;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_C8;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_CC;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_D0;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_D4;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_D8;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_DC;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_E0;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_E4;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_E8;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_EC;
      /// <summary>
      ///Unknown; always zero if the attack part doesn't exist
      /// </summary>
      public System.Single m_Unknown_F0;
      /// <summary>
      ///Unknown; always -1 if the attack part doesn't exist
      /// </summary>
      public System.Int16 m_Unknown_F4;
      /// <summary>
      ///Unknown; always zero
      /// </summary>
      public System.Int16 m_Unknown_F6;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_F8;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_FC;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_100;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_104;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_108;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_10C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_110;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_114;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Byte m_Unknown_116;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Byte m_Unknown_117;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_118;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_11C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_120;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_124;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_128;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_12C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_130;
      /// <summary>
      ///Unknown; always zero
      /// </summary>
      public System.Int32 m_Unknown_134;
      /// <summary>
      ///Amount of packages of the extent data
      /// </summary>
      public System.Int32 m_Extent_packages_138;
      /// <summary>
      ///Address of the extent data in the .raw-file
      /// </summary>
      public System.Int32 m_Raw_link_13C;
      /// <summary>
      ///Reference to an attack sound (f.e. "slap") of level 0
      /// </summary>
      public System.Int32 m_Attack_sound_140;
      /// <summary>
      ///Hard pause in 1/60 seconds
      /// </summary>
      public System.Int16 m_Hard_pause_150;
      /// <summary>
      ///Soft pause in 1/60 seconds
      /// </summary>
      public System.Int16 m_Soft_pause_152;
      /// <summary>
      ///Unknown; it seems that it belongs to the sound part
      /// </summary>
      public System.Int16 m_Unknown_154;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_156;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_158;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_15A;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_15C;
      /// <summary>
      ///Frames per second
      /// </summary>
      public System.Int16 m_Frames_15E;
      /// <summary>
      ///Compression size
      /// </summary>
      public System.Int16 m_Compression_160;
      /// <summary>
      ///ID for the animation of the opponent
      /// </summary>
      public System.Int16 m_Type_162;
      /// <summary>
      ///ID for the animation of the opponent
      /// </summary>
      public System.Int16 m_Animation_Type_164;
      /// <summary>
      ///From state
      /// </summary>
      public System.Int16 m_From_state_166;
      /// <summary>
      ///To state
      /// </summary>
      public System.Int16 m_To_state_168;
      /// <summary>
      ///Amount of bodyparts
      /// </summary>
      public System.Int16 m_Bodyparts_16A;
      /// <summary>
      ///Animation length in frames
      /// </summary>
      public System.Int16 m_Frames_16C;
      /// <summary>
      ///Duration of the animation in frames
      /// </summary>
      public System.Int16 m_Duration_16E;
      /// <summary>
      ///Varient; It seems that Oni read it as 2 byte string from left to right; I would read it as 2 seperate bitsets or as a short
      /// </summary>
      public System.Int16 m_Varient_170;
      /// <summary>
      ///Varient end; It seems that Oni read it as 2 byte string from left to right; I would read it as a short
      /// </summary>
      public System.Int16 m_Varient_end_172;
      /// <summary>
      ///Atomic start
      /// </summary>
      public System.Int16 m_Atomic_start_174;
      /// <summary>
      ///Atomic end
      /// </summary>
      public System.Int16 m_Atomic_end_176;
      /// <summary>
      ///End interpolation
      /// </summary>
      public System.Int16 m_End_interpolation_178;
      /// <summary>
      ///Maximal interpolation
      /// </summary>
      public System.Int16 m_Maximal_interpolation_17A;
      /// <summary>
      ///Action frame; at this frame starts the "real" animation
      /// </summary>
      public System.Int16 m_Action_frame_17C;
      /// <summary>
      ///First level; the level where you can use this animation the first time
      /// </summary>
      public System.Int16 m_First_level_17E;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Byte m_Unknown_180;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Byte m_Unknown_181;
      /// <summary>
      ///Amount of packages of the attack data
      /// </summary>
      public System.Byte m_Attack_packages_182;
      /// <summary>
      ///Amount of packages of the damage data
      /// </summary>
      public System.Byte m_Damage_packages_183;
      /// <summary>
      ///Amount of packages of the motion blur data
      /// </summary>
      public System.Byte m_Motion_blur_packages_184;
      /// <summary>
      ///Amount of packages of the shortcut data
      /// </summary>
      public System.Byte m_Shortcut_packages_185;
      /// <summary>
      ///Amount of packages of the footstep data
      /// </summary>
      public System.Byte m_Footstep_packages_186;
      /// <summary>
      ///Amount of packages of the particle data
      /// </summary>
      public System.Byte m_Particle_packages_187;
      /// <summary>
      ///Not used
      /// </summary>
      public System.String m_Not_used_188;

      public void Convert(byte[] data)
      {
          byte[] l_bytes = new byte[24];
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
         this.m_Unknown_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_Raw_link_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_Raw_link_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_Raw_link_14 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_Raw_link_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Raw_link_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_Raw_link_20 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_Raw_link_24 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_Raw_link_28 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_Raw_link_2C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 48];
         }
         this.m_Raw_link_30 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 52];
         }
         this.m_Raw_link_34 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 56];
         }
         this.m_Raw_link_38 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 60];
         }
         this.m_Flags_1_3C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 61];
         }
         this.m_Flags_2_3D = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 62];
         }
         this.m_Flags_3_3E = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 63];
         }
         this.m_Unknown_3F = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64];
         }
         this.m_TRAM_link_40 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 68];
         }
         this.m_TRAM_link_44 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 72];
         }
         this.m_Used_parts_48 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 76];
         }
         this.m_Replace_parts_4C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 80];
         }
         this.m_Final_rotation_50 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 84];
         }
         this.m_Move_direction_54 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 86];
         }
         this.m_Attack_voice_sound_56 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
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
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 100];
         }
         this.m_Unknown_64 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
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
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 124];
         }
         this.m_Unknown_7C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 128];
         }
         this.m_Unknown_80 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 132];
         }
         this.m_Unknown_84 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 136];
         }
         this.m_Unknown_88 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 140];
         }
         this.m_Unknown_8C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 144];
         }
         this.m_Unknown_90 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 148];
         }
         this.m_Unknown_94 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 152];
         }
         this.m_Unknown_98 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 156];
         }
         this.m_Unknown_9C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 160];
         }
         this.m_Unknown_A0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 164];
         }
         this.m_Unknown_A4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 168];
         }
         this.m_Unknown_A8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 172];
         }
         this.m_Unknown_AC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 176];
         }
         this.m_Unknown_B0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 180];
         }
         this.m_Unknown_B4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 184];
         }
         this.m_Unknown_B8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 188];
         }
         this.m_Unknown_BC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 192];
         }
         this.m_Unknown_C0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 196];
         }
         this.m_Unknown_C4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 200];
         }
         this.m_Unknown_C8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 204];
         }
         this.m_Unknown_CC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 208];
         }
         this.m_Unknown_D0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 212];
         }
         this.m_Unknown_D4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 216];
         }
         this.m_Unknown_D8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 220];
         }
         this.m_Unknown_DC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 224];
         }
         this.m_Unknown_E0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 228];
         }
         this.m_Unknown_E4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 232];
         }
         this.m_Unknown_E8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 236];
         }
         this.m_Unknown_EC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 240];
         }
         this.m_Unknown_F0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 244];
         }
         this.m_Unknown_F4 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 246];
         }
         this.m_Unknown_F6 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 248];
         }
         this.m_Unknown_F8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 252];
         }
         this.m_Unknown_FC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 256];
         }
         this.m_Unknown_100 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 260];
         }
         this.m_Unknown_104 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 264];
         }
         this.m_Unknown_108 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 268];
         }
         this.m_Unknown_10C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 272];
         }
         this.m_Unknown_110 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 276];
         }
         this.m_Unknown_114 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 278];
         }
         this.m_Unknown_116 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 279];
         }
         this.m_Unknown_117 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 280];
         }
         this.m_Unknown_118 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 284];
         }
         this.m_Unknown_11C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 288];
         }
         this.m_Unknown_120 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 292];
         }
         this.m_Unknown_124 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 296];
         }
         this.m_Unknown_128 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 300];
         }
         this.m_Unknown_12C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 304];
         }
         this.m_Unknown_130 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 308];
         }
         this.m_Unknown_134 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 312];
         }
         this.m_Extent_packages_138 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 316];
         }
         this.m_Raw_link_13C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 320];
         }
         this.m_Attack_sound_140 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 336];
         }
         this.m_Hard_pause_150 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 338];
         }
         this.m_Soft_pause_152 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 340];
         }
         this.m_Unknown_154 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 342];
         }
         this.m_Unknown_156 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 344];
         }
         this.m_Unknown_158 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 346];
         }
         this.m_Unknown_15A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 348];
         }
         this.m_Unknown_15C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 350];
         }
         this.m_Frames_15E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 352];
         }
         this.m_Compression_160 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 354];
         }
         this.m_Type_162 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 356];
         }
         this.m_Animation_Type_164 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 358];
         }
         this.m_From_state_166 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 360];
         }
         this.m_To_state_168 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 362];
         }
         this.m_Bodyparts_16A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 364];
         }
         this.m_Frames_16C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 366];
         }
         this.m_Duration_16E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 368];
         }
         this.m_Varient_170 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 370];
         }
         this.m_Varient_end_172 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 372];
         }
         this.m_Atomic_start_174 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 374];
         }
         this.m_Atomic_end_176 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 376];
         }
         this.m_End_interpolation_178 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 378];
         }
         this.m_Maximal_interpolation_17A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 380];
         }
         this.m_Action_frame_17C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 382];
         }
         this.m_First_level_17E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 384];
         }
         this.m_Unknown_180 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 385];
         }
         this.m_Unknown_181 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 386];
         }
         this.m_Attack_packages_182 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 387];
         }
         this.m_Damage_packages_183 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 388];
         }
         this.m_Motion_blur_packages_184 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 389];
         }
         this.m_Shortcut_packages_185 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 390];
         }
         this.m_Footstep_packages_186 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 391];
         }
         this.m_Particle_packages_187 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<24; i++)
         {
             l_bytes[i] = data[i + 392];
         }
         this.m_Not_used_188 = (System.String)BinaryDatReader.l_str(l_bytes, 24);

     }
  }
}
