namespace Round2.Generated.Binary
{
  internal partial class TRAM: Round2.BinaryInitializable
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
      ///Address of the y-position data in the .raw-file
      /// </summary>
      public Link<Raw> m_Raw_link_C =  new Link<Raw>();
      /// <summary>
      ///Address of the x-z-position data in the .raw-file
      /// </summary>
      public Link<Raw> m_Raw_link_10 =  new Link<Raw>();
      /// <summary>
      ///Address of the attack data in the .raw-file
      /// </summary>
      public Link<Raw> m_Raw_link_14 =  new Link<Raw>();
      /// <summary>
      ///Address of the damage data in the .raw-file
      /// </summary>
      public Link<Raw> m_Raw_link_18 =  new Link<Raw>();
      /// <summary>
      ///Address of the motion blur data in the .raw-file
      /// </summary>
      public Link<Raw> m_Raw_link_1C =  new Link<Raw>();
      /// <summary>
      ///Address of the shortcut data in the .raw-file
      /// </summary>
      public Link<Raw> m_Raw_link_20 =  new Link<Raw>();
      /// <summary>
      ///Address of the throw data in the .raw-file
      /// </summary>
      public Link<Raw> m_Raw_link_24 =  new Link<Raw>();
      /// <summary>
      ///Address of the footstep data in the .raw-file
      /// </summary>
      public Link<Raw> m_Raw_link_28 =  new Link<Raw>();
      /// <summary>
      ///Address of the particle data in the .raw-file
      /// </summary>
      public Link<Raw> m_Raw_link_2C =  new Link<Raw>();
      /// <summary>
      ///Address of the position data in the .raw-file
      /// </summary>
      public Link<Raw> m_Raw_link_30 =  new Link<Raw>();
      /// <summary>
      ///Address of the bodypart animation data in the .raw-file
      /// </summary>
      public Link<Raw> m_Raw_link_34 =  new Link<Raw>();
      /// <summary>
      ///Address of the sound data in the .raw-file
      /// </summary>
      public Link<Raw> m_Raw_link_38 =  new Link<Raw>();
      /// <summary>
      ///Flags; it seems that Oni read it as 4 byte string from left to right; I would read it as 4 seperate bitsets
      /// </summary>
      public System.Int32 m_Flags_3C;
      /// <summary>
      ///First direct animation link; this animation follows after a left mouse click (punch)
      /// </summary>
      public Link<TRAM> m_TRAM_link_40 =  new Link<TRAM>();
      /// <summary>
      ///Second direct animation link; this animation follows after a right mouse click (kick)
      /// </summary>
      public Link<TRAM> m_TRAM_link_44 =  new Link<TRAM>();
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
      ///Amount of packages of the extent data
      /// </summary>
      public System.Int32 m_Extent_packages_138;
      /// <summary>
      ///Address of the extent data in the .raw-file
      /// </summary>
      public Link<Raw> m_Raw_link_13C =  new Link<Raw>();
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
         this.m_Flags_3C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
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

     }
  }
}
