namespace Round2.Generated.Binary
{
  internal class M3GM: Round2.BinaryInitializable
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
      ///Unknown; not used
      /// </summary>
      public System.Int32 m_Unknown_8;
      /// <summary>
      ///Link to the 3D Point Array
      /// </summary>
      public System.Int32 m_PNTA_link_C;
      /// <summary>
      ///Link to the 3D Vector Array
      /// </summary>
      public System.Int32 m_VCRA_link_10;
      /// <summary>
      ///Link to the 3D Vector Array
      /// </summary>
      public System.Int32 m_VCRA_link_14;
      /// <summary>
      ///Link to the Texture Coordinate Array
      /// </summary>
      public System.Int32 m_TXCA_link_18;
      /// <summary>
      ///Link to the Index Array
      /// </summary>
      public System.Int32 m_IDXA_link_1C;
      /// <summary>
      ///Link to the Index Array
      /// </summary>
      public System.Int32 m_IDXA_link_20;
      /// <summary>
      ///Link to the Texture
      /// </summary>
      public System.Int32 m_TXMP_link_24;
      /// <summary>
      ///Unknown; not used
      /// </summary>
      public System.Int32 m_Unknown_28;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_2C;

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
         this.m_PNTA_link_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_VCRA_link_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_VCRA_link_14 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_TXCA_link_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_IDXA_link_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_IDXA_link_20 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_TXMP_link_24 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_Unknown_28 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_Not_used_2C = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
