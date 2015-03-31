namespace Round2.Generated.Binary
{
  internal partial class Mtrl: Round2.BinaryInitializable
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
      public System.Int16 m_Unknown_8;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_A;
      /// <summary>
      ///Link to the next higher Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_10 =  new Link<Mtrl>();
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_14;

      public override void Convert(byte[] data)
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
         this.m_Unknown_8 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 10];
         }
         this.m_Not_used_A = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_Mtrl_link_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_Not_used_14 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
