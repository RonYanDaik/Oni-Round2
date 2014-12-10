namespace Round2.Generated.Binary
{
  internal class SNDD: Round2.BinaryInitializable
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
      ///Wav header; don't alter it
      /// </summary>
      public System.String m_Wav_header_8;
      /// <summary>
      ///Duration in 1/60 seconds
      /// </summary>
      public System.Int16 m_Duration_3E;
      /// <summary>
      ///Size of the part in the raw file
      /// </summary>
      public System.Int32 m_Size_40;
      /// <summary>
      ///At this position starts the part in the raw file
      /// </summary>
      public System.Int32 m_Offset_44;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_48;

      public void Convert(byte[] data)
      {
          byte[] l_bytes = new byte[54];
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
         for(int i=0; i<54; i++)
         {
             l_bytes[i] = data[i + 8];
         }
         this.m_Wav_header_8 = (System.String)BinaryDatReader.l_str(l_bytes, 54);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 62];
         }
         this.m_Duration_3E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64];
         }
         this.m_Size_40 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 68];
         }
         this.m_Offset_44 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 72];
         }
         this.m_Not_used_48 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
