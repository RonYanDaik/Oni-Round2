namespace Round2.Generated.Binary
{
  internal partial class TRAS: Round2.BinaryInitializable
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
      ///Link to the Aiming Animation
      /// </summary>
      public Link<TRAM> m_TRAM_link_8 =  new Link<TRAM>();
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_10;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_14;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_16;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_18;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_1C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_20;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_22;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_24;

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
         this.m_TRAM_link_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_Unknown_C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_Unknown_10 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_Unknown_14 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 22];
         }
         this.m_Unknown_16 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_Unknown_18 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Unknown_1C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_Unknown_20 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 34];
         }
         this.m_Unknown_22 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_Not_used_24 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
