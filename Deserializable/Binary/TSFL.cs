namespace Round2.Generated.Binary
{
  internal partial class TSFL: Round2.BinaryInitializable
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
      ///Char block 1
      /// </summary>
      public System.String m_Char_block_1_8;
      /// <summary>
      ///Char block 2
      /// </summary>
      public System.String m_Char_block_2_48;
      /// <summary>
      ///Char block 3
      /// </summary>
      public System.String m_Char_block_3_88;
      /// <summary>
      ///Char block 4
      /// </summary>
      public System.String m_Char_block_4_C8;
      /// <summary>
      ///Char block 5
      /// </summary>
      public System.String m_Char_block_5_108;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_148;

      public override void Convert(byte[] data)
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
         this.m_Char_block_1_8 = (System.String)BinaryDatReader.l_str(l_bytes, 64);
         for(int i=0; i<64; i++)
         {
             l_bytes[i] = data[i + 72];
         }
         this.m_Char_block_2_48 = (System.String)BinaryDatReader.l_str(l_bytes, 64);
         for(int i=0; i<64; i++)
         {
             l_bytes[i] = data[i + 136];
         }
         this.m_Char_block_3_88 = (System.String)BinaryDatReader.l_str(l_bytes, 64);
         for(int i=0; i<64; i++)
         {
             l_bytes[i] = data[i + 200];
         }
         this.m_Char_block_4_C8 = (System.String)BinaryDatReader.l_str(l_bytes, 64);
         for(int i=0; i<64; i++)
         {
             l_bytes[i] = data[i + 264];
         }
         this.m_Char_block_5_108 = (System.String)BinaryDatReader.l_str(l_bytes, 64);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 328];
         }
         this.m_Not_used_148 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
