namespace Round2.Generated.Binary
{
  internal partial class TURR: Round2.BinaryInitializable
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
      ///Name of the turret
      /// </summary>
      public System.String m_Turret_name_8;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_48;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_4C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_54;
      /// <summary>
      ///Amount of used packages (the file contains space for 16 packages)
      /// </summary>
      public System.Int16 m_Packages_used_56;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_58;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_5A;
      /// <summary>
      ///Link to the Geometry
      /// </summary>
      public Link<M3GM> m_M3GM_link_60 =  new Link<M3GM>();
      /// <summary>
      ///Unknown; always the same; maybe a canceled link
      /// </summary>
      public System.Int32 m_Unknown_64;
      /// <summary>
      ///Unknown; always the same; maybe a canceled link
      /// </summary>
      public System.Int32 m_Unknown_68;
      /// <summary>
      ///Link to the Geometry
      /// </summary>
      public Link<M3GM> m_M3GM_link_6C =  new Link<M3GM>();
      /// <summary>
      ///Unknown; always the same; maybe a canceled link
      /// </summary>
      public System.Int32 m_Unknown_70;
      /// <summary>
      ///Link to the Geometry
      /// </summary>
      public Link<M3GM> m_M3GM_link_74 =  new Link<M3GM>();
      /// <summary>
      ///Unknown; always the same; maybe a canceled link
      /// </summary>
      public System.Int32 m_Unknown_78;
      /// <summary>
      ///Unknown; always the same if it's a floor turret
      /// </summary>
      public System.Single m_Unknown_7C;
      /// <summary>
      ///Unknown; always the same if it's a floor turret
      /// </summary>
      public System.Single m_Unknown_80;
      /// <summary>
      ///Unknown; always the same if it's a floor turret
      /// </summary>
      public System.Single m_Unknown_84;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_88;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_8C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_90;

      public override void Convert(byte[] data)
      {
          byte[] l_bytes = new byte[64];
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
         for(int i=0; i<64; i++)
         {
             l_bytes[i] = data[i + 8];
         }
         this.m_Turret_name_8 = (System.String)BinaryDatReader.l_str(l_bytes, 64);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 72];
         }
         this.m_Unknown_48 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 76];
         }
         this.m_Not_used_4C = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 84];
         }
         this.m_Unknown_54 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 86];
         }
         this.m_Packages_used_56 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 88];
         }
         this.m_Unknown_58 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 90];
         }
         this.m_Not_used_5A = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 96];
         }
         this.m_M3GM_link_60 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
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
         this.m_M3GM_link_6C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 112];
         }
         this.m_Unknown_70 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 116];
         }
         this.m_M3GM_link_74 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 120];
         }
         this.m_Unknown_78 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
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

     }
  }
}
