namespace Round2.Generated.Binary
{
  internal partial class ONLV: Round2.BinaryInitializable
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
      ///Name of the level
      /// </summary>
      public System.String m_Level_name_8;
      /// <summary>
      ///Link to the Environment
      /// </summary>
      public Link<AKEV> m_AKEV_Link_48 =  new Link<AKEV>();
      /// <summary>
      ///Link to the Starting Object Array
      /// </summary>
      public Link<OBOA> m_OBOA_Link_4C =  new Link<OBOA>();
      /// <summary>
      ///Link to the Imported Marker Node Array
      /// </summary>
      public Link<ONMA> m_ONMA_Link_50 =  new Link<ONMA>();
      /// <summary>
      ///Link to the Imported Flag Node Array
      /// </summary>
      public Link<ONFA> m_ONFA_Link_54 =  new Link<ONFA>();
      /// <summary>
      ///Link to the Trigger Array
      /// </summary>
      public Link<ONTA> m_ONTA_Link_58 =  new Link<ONTA>();
      /// <summary>
      ///Link to the Sky Class
      /// </summary>
      public Link<ONSK> m_ONSK_Link_5C =  new Link<ONSK>();
      /// <summary>
      ///Unknown; maybe a canceled link; always the same
      /// </summary>
      public System.Int32 m_Unknown_60;
      /// <summary>
      ///Link to the AI Character Setup Array
      /// </summary>
      public Link<AISA> m_AISA_Link_64 =  new Link<AISA>();
      /// <summary>
      ///Link to the AI Script Trigger Array
      /// </summary>
      public Link<AITR> m_AITR_Link_68 =  new Link<AITR>();
      /// <summary>
      ///Link to the Imported Spawn Array
      /// </summary>
      public Link<ONSA> m_ONSA_Link_6C =  new Link<ONSA>();
      /// <summary>
      ///Link to the Door Class Array
      /// </summary>
      public Link<OBDC> m_OBDC_Link_70 =  new Link<OBDC>();
      /// <summary>
      ///Link to the Object Gunk Array
      /// </summary>
      public Link<ONOA> m_ONOA_Link_74 =  new Link<ONOA>();
      /// <summary>
      ///Link to the Environment Particle Array
      /// </summary>
      public Link<ENVP> m_ENVP_Link_78 =  new Link<ENVP>();
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_7C;
      /// <summary>
      ///Link to the Corpse Array
      /// </summary>
      public Link<CRSA> m_CRSA_Link_300 =  new Link<CRSA>();
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_304;

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
         for(int i=0; i<64; i++)
         {
             l_bytes[i] = data[i + 8];
         }
         this.m_Level_name_8 = (System.String)BinaryDatReader.l_str(l_bytes, 64);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 72];
         }
         this.m_AKEV_Link_48 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 76];
         }
         this.m_OBOA_Link_4C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 80];
         }
         this.m_ONMA_Link_50 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 84];
         }
         this.m_ONFA_Link_54 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 88];
         }
         this.m_ONTA_Link_58 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 92];
         }
         this.m_ONSK_Link_5C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 96];
         }
         this.m_Unknown_60 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 100];
         }
         this.m_AISA_Link_64 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 104];
         }
         this.m_AITR_Link_68 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 108];
         }
         this.m_ONSA_Link_6C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 112];
         }
         this.m_OBDC_Link_70 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 116];
         }
         this.m_ONOA_Link_74 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 120];
         }
         this.m_ENVP_Link_78 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 124];
         }
         this.m_Not_used_7C = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 768];
         }
         this.m_CRSA_Link_300 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 772];
         }
         this.m_Not_used_304 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
