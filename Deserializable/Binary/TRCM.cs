namespace Round2.Generated.Binary
{
  internal partial class TRCM: Round2.BinaryInitializable
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
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_8;
      /// <summary>
      ///Number of bodyparts
      /// </summary>
      public System.Int16 m_Bodyparts_C;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_E;
      /// <summary>
      ///Internal file name
      /// </summary>
      public System.String m_Internal_file_name_10;
      /// <summary>
      ///Old offset link; you can set it to zero if you want
      /// </summary>
      public System.Int32 m_Not_used_50;
      /// <summary>
      ///Old offset link; you can set it to zero if you want
      /// </summary>
      public System.Int32 m_Not_used_54;
      /// <summary>
      ///Old offset link; you can set it to zero if you want
      /// </summary>
      public System.Int32 m_Not_used_58;
      /// <summary>
      ///Link to the Body Geometry Array
      /// </summary>
      public Link<TRGA> m_TRGA_link_5C =  new Link<TRGA>();
      /// <summary>
      ///Link to the Body Translation Array
      /// </summary>
      public Link<TRTA> m_TRTA_link_60 =  new Link<TRTA>();
      /// <summary>
      ///Link to the Body Index Array
      /// </summary>
      public Link<TRIA> m_TRIA_link_64 =  new Link<TRIA>();
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_68;

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
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 8];
         }
         this.m_Unknown_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_Bodyparts_C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 14];
         }
         this.m_Not_used_E = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<64; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_Internal_file_name_10 = (System.String)BinaryDatReader.l_str(l_bytes, 64);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 80];
         }
         this.m_Not_used_50 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 84];
         }
         this.m_Not_used_54 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 88];
         }
         this.m_Not_used_58 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 92];
         }
         this.m_TRGA_link_5C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 96];
         }
         this.m_TRTA_link_60 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 100];
         }
         this.m_TRIA_link_64 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 104];
         }
         this.m_Not_used_68 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
