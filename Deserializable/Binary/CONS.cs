namespace Round2.Generated.Binary
{
  internal class CONS: Round2.BinaryInitializable
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
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_8;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_10;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_14;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_18;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_1C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Single m_Unknown_20;
      /// <summary>
      ///Link to the Object Furn Geom Array
      /// </summary>
      public Link<OFGA> m_OFGA_link_24 =  new Link<OFGA>();
      /// <summary>
      ///Link to the Geometry
      /// </summary>
      public Link<M3GM> m_M3GM_link_28 =  new Link<M3GM>();
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_2C;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_2E;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.String m_Unknown_30;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.String m_Unknown_50;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.String m_Unknown_70;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_90;

      public void Convert(byte[] data)
      {
          byte[] l_bytes = new byte[32];
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
         this.m_Unknown_C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_Unknown_10 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_Unknown_14 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
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
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_Unknown_20 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_OFGA_link_24 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_M3GM_link_28 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_Unknown_2C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 46];
         }
         this.m_Unknown_2E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<32; i++)
         {
             l_bytes[i] = data[i + 48];
         }
         this.m_Unknown_30 = (System.String)BinaryDatReader.l_str(l_bytes, 32);
         for(int i=0; i<32; i++)
         {
             l_bytes[i] = data[i + 80];
         }
         this.m_Unknown_50 = (System.String)BinaryDatReader.l_str(l_bytes, 32);
         for(int i=0; i<32; i++)
         {
             l_bytes[i] = data[i + 112];
         }
         this.m_Unknown_70 = (System.String)BinaryDatReader.l_str(l_bytes, 32);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 144];
         }
         this.m_Not_used_90 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
