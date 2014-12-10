namespace Round2.Generated.Binary
{
  internal class ONLV: Round2.BinaryInitializable
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
      public System.Int32 m_AKEV_Link_48;
      /// <summary>
      ///Link to the Starting Object Array
      /// </summary>
      public System.Int32 m_OBOA_Link_4C;
      /// <summary>
      ///Link to the Imported Marker Node Array
      /// </summary>
      public System.Int32 m_ONMA_Link_50;
      /// <summary>
      ///Link to the Imported Flag Node Array
      /// </summary>
      public System.Int32 m_ONFA_Link_54;
      /// <summary>
      ///Link to the Trigger Array
      /// </summary>
      public System.Int32 m_ONTA_Link_58;
      /// <summary>
      ///Link to the Sky Class
      /// </summary>
      public System.Int32 m_ONSK_Link_5C;
      /// <summary>
      ///Unknown; maybe a canceled link; always the same
      /// </summary>
      public System.Int32 m_Unknown_60;
      /// <summary>
      ///Link to the AI Character Setup Array
      /// </summary>
      public System.Int32 m_AISA_Link_64;
      /// <summary>
      ///Link to the AI Script Trigger Array
      /// </summary>
      public System.Int32 m_AITR_Link_68;
      /// <summary>
      ///Link to the Imported Spawn Array
      /// </summary>
      public System.Int32 m_ONSA_Link_6C;
      /// <summary>
      ///Link to the Door Class Array
      /// </summary>
      public System.Int32 m_OBDC_Link_70;
      /// <summary>
      ///Link to the Object Gunk Array
      /// </summary>
      public System.Int32 m_ONOA_Link_74;
      /// <summary>
      ///Link to the Environment Particle Array
      /// </summary>
      public System.Int32 m_ENVP_Link_78;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_7C;
      /// <summary>
      ///Link to the Corpse Array
      /// </summary>
      public System.Int32 m_CRSA_Link_300;
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
