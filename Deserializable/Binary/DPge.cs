namespace Round2.Generated.Binary
{
  internal class DPge: Round2.BinaryInitializable
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
      ///Level
      /// </summary>
      public System.Int16 m_Level_8;
      /// <summary>
      ///Page
      /// </summary>
      public System.Int16 m_Page_A;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_C;
      /// <summary>
      ///Link to the In-Game User Interface Page
      /// </summary>
      public Link<IGPG> m_IGPG_link_40 =  new Link<IGPG>();
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_44;

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
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 8];
         }
         this.m_Level_8 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 10];
         }
         this.m_Page_A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_Not_used_C = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64];
         }
         this.m_IGPG_link_40 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 68];
         }
         this.m_Not_used_44 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
