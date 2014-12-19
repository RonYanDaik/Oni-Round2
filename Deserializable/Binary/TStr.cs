namespace Round2.Generated.Binary
{
  internal partial class TStr: Round2.BinaryInitializable
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
      ///Animation string
      /// </summary>
      public System.String m_Animation_string_8;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_88;

      public void Convert(byte[] data)
      {
          byte[] l_bytes = new byte[128];
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
         for(int i=0; i<128; i++)
         {
             l_bytes[i] = data[i + 8];
         }
         this.m_Animation_string_8 = (System.String)BinaryDatReader.l_str(l_bytes, 128);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 136];
         }
         this.m_Not_used_88 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
