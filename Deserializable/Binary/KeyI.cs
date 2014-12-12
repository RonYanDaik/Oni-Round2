namespace Round2.Generated.Binary
{
  internal class KeyI: Round2.BinaryInitializable
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
      ///Link to the punch texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_8 =  new Link<TXMP>();
      /// <summary>
      ///Link to the kick texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_C =  new Link<TXMP>();
      /// <summary>
      ///Link to the forward texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_10 =  new Link<TXMP>();
      /// <summary>
      ///Link to the backward texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_14 =  new Link<TXMP>();
      /// <summary>
      ///Link to the left texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_18 =  new Link<TXMP>();
      /// <summary>
      ///Link to the right texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_1C =  new Link<TXMP>();
      /// <summary>
      ///Link to the crouch texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_20 =  new Link<TXMP>();
      /// <summary>
      ///Link to the jump texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_24 =  new Link<TXMP>();
      /// <summary>
      ///Link to the hold texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_28 =  new Link<TXMP>();
      /// <summary>
      ///Link to the plus texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_2C =  new Link<TXMP>();
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_30;

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
         this.m_TXMP_link_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_TXMP_link_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_TXMP_link_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_TXMP_link_14 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_TXMP_link_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_TXMP_link_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_TXMP_link_20 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_TXMP_link_24 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_TXMP_link_28 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_TXMP_link_2C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 48];
         }
         this.m_Not_used_30 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
