namespace Round2.Generated.Binary
{
  internal class ONLD: Round2.BinaryInitializable
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
      ///Id of current level
      /// </summary>
      public System.Int16 m_Current_level_8;
      /// <summary>
      ///Id of the level that follows
      /// </summary>
      public System.Int16 m_Next_level_A;
      /// <summary>
      ///Name of the level; you'll find it in the list, when you load a level
      /// </summary>
      public System.String m_Level_name_C;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_4C;

      public void Convert(byte[] data)
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
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 8];
         }
         this.m_Current_level_8 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 10];
         }
         this.m_Next_level_A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<64; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_Level_name_C = (System.String)BinaryDatReader.l_str(l_bytes, 64);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 76];
         }
         this.m_Not_used_4C = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
