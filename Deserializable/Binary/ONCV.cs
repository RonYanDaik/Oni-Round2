namespace Round2.Generated.Binary
{
  internal class ONCV: Round2.BinaryInitializable
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
      ///Link to the next higher Character Variant
      /// </summary>
      public Link<ONCV> m_ONCV_link_8 =  new Link<ONCV>();
      /// <summary>
      ///Basic character type
      /// </summary>
      public System.Int32 m_Basic_character_type_C;
      /// <summary>
      ///Upgrade character type; used when you play on hard and the "upgrade difficulty" bit in the Character.BINA file is set
      /// </summary>
      public System.Int32 m_Upgrade_character_type_2C;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_4C;

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
         this.m_ONCV_link_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_Basic_character_type_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_Upgrade_character_type_2C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 76];
         }
         this.m_Not_used_4C = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
