namespace Round2.Generated.Binary
{
  internal class DOOR: Round2.BinaryInitializable
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
      ///Link to the Object Furn Geom Array
      /// </summary>
      public Link<OFGA> m_OFGA_link_8 =  new Link<OFGA>();
      /// <summary>
      ///Unknown; maybe a canceled link; always the same
      /// </summary>
      public System.Int32 m_Unknown_C;
      /// <summary>
      ///Link to the Object Animation
      /// </summary>
      public Link<OBAN> m_OBAN_link_10 =  new Link<OBAN>();
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_14;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_18;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_1C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_20;
      /// <summary>
      ///Reference to an OSBD file of level 0
      /// </summary>
      public System.Int32 m_Door_open_sound_24;
      /// <summary>
      ///Reference to an OSBD file of level 0
      /// </summary>
      public System.Int32 m_Door_close_sound_44;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_64;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_68;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_useed_6C;

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
         this.m_OFGA_link_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_Unknown_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_OBAN_link_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_Unknown_14 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_Unknown_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Unknown_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_Unknown_20 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_Door_open_sound_24 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 68];
         }
         this.m_Door_close_sound_44 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 100];
         }
         this.m_Unknown_64 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 104];
         }
         this.m_Unknown_68 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 108];
         }
         this.m_Not_useed_6C = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
