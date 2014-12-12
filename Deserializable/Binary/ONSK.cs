namespace Round2.Generated.Binary
{
  internal class ONSK: Round2.BinaryInitializable
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
      ///Link to the top texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_8 =  new Link<TXMP>();
      /// <summary>
      ///Link to the left texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_C =  new Link<TXMP>();
      /// <summary>
      ///Link to the right texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_10 =  new Link<TXMP>();
      /// <summary>
      ///Link to the front texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_14 =  new Link<TXMP>();
      /// <summary>
      ///Link to the back texture
      /// </summary>
      public Link<TXMP> m_TXMP_link_18 =  new Link<TXMP>();
      /// <summary>
      ///Not used; maybe a canceled link
      /// </summary>
      public System.Int32 m_Not_used_1C;
      /// <summary>
      ///Link to the sun texture (not used in the game)
      /// </summary>
      public Link<TXMP> m_TXMP_link_20 =  new Link<TXMP>();
      /// <summary>
      ///Not used; maybe a canceled link
      /// </summary>
      public System.Int32 m_Not_used_24;
      /// <summary>
      ///Not used; maybe a canceled link
      /// </summary>
      public System.Int32 m_Not_used_28;
      /// <summary>
      ///Not used; maybe a canceled link
      /// </summary>
      public System.Int32 m_Not_used_2C;
      /// <summary>
      ///Not used; maybe a canceled link
      /// </summary>
      public System.Int32 m_Not_used_30;
      /// <summary>
      ///Not used; maybe a canceled link
      /// </summary>
      public System.Int32 m_Not_used_34;
      /// <summary>
      ///Not used; maybe a canceled link
      /// </summary>
      public System.Int32 m_Not_used_38;
      /// <summary>
      ///Not used; maybe a canceled link
      /// </summary>
      public System.Int32 m_Not_used_3C;
      /// <summary>
      ///Not used; maybe a canceled link
      /// </summary>
      public System.Int32 m_Not_used_40;
      /// <summary>
      ///Link to the lensflare texture (not used in the game)
      /// </summary>
      public Link<TXMP> m_TXMP_link_44 =  new Link<TXMP>();
      /// <summary>
      ///Not used; maybe a canceled link
      /// </summary>
      public System.Int32 m_Not_used_48;
      /// <summary>
      ///Not used; maybe a canceled link
      /// </summary>
      public System.Int32 m_Not_used_4C;
      /// <summary>
      ///Not used; maybe a canceled link
      /// </summary>
      public System.Int32 m_Not_used_50;
      /// <summary>
      ///Not used; maybe a canceled link
      /// </summary>
      public System.Int32 m_Not_used_54;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_58;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_5C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_60;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_64;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_80;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_84;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_A0;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_A4;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_C0;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_C4;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_E0;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_E4;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_E8;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_EC;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_F0;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_F4;

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
         this.m_Not_used_1C = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_TXMP_link_20 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_Not_used_24 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_Not_used_28 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_Not_used_2C = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 48];
         }
         this.m_Not_used_30 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 52];
         }
         this.m_Not_used_34 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 56];
         }
         this.m_Not_used_38 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 60];
         }
         this.m_Not_used_3C = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64];
         }
         this.m_Not_used_40 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 68];
         }
         this.m_TXMP_link_44 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 72];
         }
         this.m_Not_used_48 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 76];
         }
         this.m_Not_used_4C = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
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
         this.m_Unknown_58 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 92];
         }
         this.m_Unknown_5C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 96];
         }
         this.m_Unknown_60 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 100];
         }
         this.m_Not_used_64 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 128];
         }
         this.m_Unknown_80 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 132];
         }
         this.m_Not_used_84 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 160];
         }
         this.m_Unknown_A0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 164];
         }
         this.m_Not_used_A4 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 192];
         }
         this.m_Unknown_C0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 196];
         }
         this.m_Not_used_C4 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 224];
         }
         this.m_Unknown_E0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 228];
         }
         this.m_Unknown_E4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 232];
         }
         this.m_Unknown_E8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 236];
         }
         this.m_Unknown_EC = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 240];
         }
         this.m_Unknown_F0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 244];
         }
         this.m_Not_used_F4 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
