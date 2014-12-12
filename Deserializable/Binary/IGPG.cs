namespace Round2.Generated.Binary
{
  internal class IGPG: Round2.BinaryInitializable
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
      ///Link to the Font Family
      /// </summary>
      public Link<TSFF> m_TSFF_link_8 =  new Link<TSFF>();
      /// <summary>
      ///Font option
      /// </summary>
      public System.Int32 m_Font_option_C;
      /// <summary>
      ///Font color - blue part
      /// </summary>
      public System.Byte m_Font_color_B_10;
      /// <summary>
      ///Font color - green part
      /// </summary>
      public System.Byte m_Font_color_G_11;
      /// <summary>
      ///Font color - red part
      /// </summary>
      public System.Byte m_Font_color_R_12;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Byte m_Unknown_13;
      /// <summary>
      ///Font size of the text; maybe the minimal font size in connection to the screen resolution
      /// </summary>
      public System.Int16 m_Font_size_14;
      /// <summary>
      ///Enables the previous entries; it's a bitset
      /// </summary>
      public System.Int16 m_Enabler_16;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public Link<PSPC> m_PSPC_link_18 =  new Link<PSPC>();
      /// <summary>
      ///Link to the In-Game User Interface String Array
      /// </summary>
      public Link<IGSA> m_IGSA_link_1C =  new Link<IGSA>();
      /// <summary>
      ///Link to the In-Game User Interface String Array
      /// </summary>
      public Link<IGSA> m_IGSA_link_20 =  new Link<IGSA>();
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
         this.m_TSFF_link_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_Font_option_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_Font_color_B_10 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 17];
         }
         this.m_Font_color_G_11 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 18];
         }
         this.m_Font_color_R_12 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 19];
         }
         this.m_Unknown_13 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_Font_size_14 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 22];
         }
         this.m_Enabler_16 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_PSPC_link_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_IGSA_link_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_IGSA_link_20 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_Not_used_24 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
