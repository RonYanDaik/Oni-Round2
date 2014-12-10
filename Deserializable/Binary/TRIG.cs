namespace Round2.Generated.Binary
{
  internal class TRIG: Round2.BinaryInitializable
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
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_8;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_10;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_14;
      /// <summary>
      ///Link to the Geometry
      /// </summary>
      public System.Int32 m_M3GM_link_18;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_1C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_20;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_22;
      /// <summary>
      ///Link to the Trigger Emitter
      /// </summary>
      public System.Int32 m_TRGE_link_24;
      /// <summary>
      ///Link to the Object Animation
      /// </summary>
      public System.Int32 m_OBAN_link_28;
      /// <summary>
      ///Reference to an OSBD file
      /// </summary>
      public System.Int32 m_Trigger_active_sound_2C;
      /// <summary>
      ///Reference to an OSBD file
      /// </summary>
      public System.Int32 m_Trigger_hit_sound_4C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_6C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_70;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_74;

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
             l_bytes[i] = data[i + 8];
         }
         this.m_Unknown_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_Unknown_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_Unknown_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_Unknown_14 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_M3GM_link_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Unknown_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_Unknown_20 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 34];
         }
         this.m_Unknown_22 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_TRGE_link_24 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_OBAN_link_28 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_Trigger_active_sound_2C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 76];
         }
         this.m_Trigger_hit_sound_4C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 108];
         }
         this.m_Unknown_6C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 112];
         }
         this.m_Unknown_70 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 116];
         }
         this.m_Not_used_74 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
