namespace Round2.Generated.Binary
{
  internal class AKOT: Round2.BinaryInitializable
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
      ///Link to the Oct Tree Interior Node Array
      /// </summary>
      public System.Int32 m_OTIT_link_8;
      /// <summary>
      ///Link to the Oct Tree Leaf Node Array
      /// </summary>
      public System.Int32 m_OTLF_link_C;
      /// <summary>
      ///Link to the Quad Tree Node Array
      /// </summary>
      public System.Int32 m_QTNA_link_10;
      /// <summary>
      ///Link to the Index Array
      /// </summary>
      public System.Int32 m_IDXA_link_14;
      /// <summary>
      ///Link to the Index Array
      /// </summary>
      public System.Int32 m_IDXA_link_18;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_1C;

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
         this.m_OTIT_link_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_OTLF_link_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_QTNA_link_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_IDXA_link_14 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_IDXA_link_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Not_used_1C = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}