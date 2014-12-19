namespace Round2.Generated.Binary
{
  internal partial class CBPM: Round2.BinaryInitializable
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
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_8 =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_C =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_10 =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_14 =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_18 =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_1C =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_20 =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_24 =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_28 =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_2C =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_30 =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_34 =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_38 =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_3C =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_40 =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_44 =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_48 =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_4C =  new Link<Mtrl>();
      /// <summary>
      ///Link to the Material
      /// </summary>
      public Link<Mtrl> m_Mtrl_link_50 =  new Link<Mtrl>();
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_54;

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
         this.m_Mtrl_link_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_Mtrl_link_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_Mtrl_link_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_Mtrl_link_14 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_Mtrl_link_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Mtrl_link_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_Mtrl_link_20 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_Mtrl_link_24 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_Mtrl_link_28 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_Mtrl_link_2C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 48];
         }
         this.m_Mtrl_link_30 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 52];
         }
         this.m_Mtrl_link_34 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 56];
         }
         this.m_Mtrl_link_38 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 60];
         }
         this.m_Mtrl_link_3C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64];
         }
         this.m_Mtrl_link_40 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 68];
         }
         this.m_Mtrl_link_44 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 72];
         }
         this.m_Mtrl_link_48 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 76];
         }
         this.m_Mtrl_link_4C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 80];
         }
         this.m_Mtrl_link_50 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 84];
         }
         this.m_Not_used_54 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
