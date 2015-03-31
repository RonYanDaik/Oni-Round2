namespace Round2.Generated.Binary
{
  internal partial class TXMP: Round2.BinaryInitializable
  {
      /// <summary>
      ///ID of this file
      /// </summary>
      public System.Int32 m_ID_0;
      /// <summary>
      ///ID of the level this file is in
      /// </summary>
      public System.Int32 m_LevelID_4;
      /// <summary>
      ///Name of the texture
      /// </summary>
      public System.String m_FileName_8;
      /// <summary>
      ///MIP Mapping Bitset
      /// </summary>
      public System.Int32 m_MIP_Mapping_88;
      /// <summary>
      ///Depth-Bitset
      /// </summary>
      public System.Int32 m_Depth_89;
      /// <summary>
      ///Unknown; always zero
      /// </summary>
      public System.Int16 m_Unknown_8A;
      /// <summary>
      ///x-resolution of image
      /// </summary>
      public System.Int16 m_Width_8C;
      /// <summary>
      ///y-resolution of image
      /// </summary>
      public System.Int16 m_Height_8E;
      /// <summary>
      ///Storetype-Bitset
      /// </summary>
      public System.Int32 m_Storetype_90;
      /// <summary>
      ///Link to the TXAN-file; only used if the texture is the first image of an texture animation
      /// </summary>
      public Link<TXAN> m_TXAN_Link_94 =  new Link<TXAN>();
      /// <summary>
      ///Link to another TXMP-file; only used in connection with shade vertex effects
      /// </summary>
      public Link<TXMP> m_TXMP_Link_98 =  new Link<TXMP>();
      /// <summary>
      ///Address of the image data in the .raw-file (only for PC-dat-files)
      /// </summary>
      public Link<Raw> m_Raw_Link_9C =  new Link<Raw>();
      /// <summary>
      ///Address of the image data in the .raw-file (only for MAC-dat-files)
      /// </summary>
      public Link<Raw> m_Raw_Link_A0 =  new Link<Raw>();
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_A4;

      public override void Convert(byte[] data)
      {
          byte[] l_bytes = new byte[128];
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 0];
         }
         this.m_ID_0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 4];
         }
         this.m_LevelID_4 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<128; i++)
         {
             l_bytes[i] = data[i + 8];
         }
         this.m_FileName_8 = (System.String)BinaryDatReader.l_str(l_bytes, 128);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 136];
         }
         this.m_MIP_Mapping_88 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 137];
         }
         this.m_Depth_89 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 138];
         }
         this.m_Unknown_8A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 140];
         }
         this.m_Width_8C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 142];
         }
         this.m_Height_8E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 144];
         }
         this.m_Storetype_90 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 148];
         }
         this.m_TXAN_Link_94 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 152];
         }
         this.m_TXMP_Link_98 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 156];
         }
         this.m_Raw_Link_9C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 160];
         }
         this.m_Raw_Link_A0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 164];
         }
         this.m_Not_used_A4 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
