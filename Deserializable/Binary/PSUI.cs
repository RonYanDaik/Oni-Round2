namespace Round2.Generated.Binary
{
  internal class PSUI: Round2.BinaryInitializable
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
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_8;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_C;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_10;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_14;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_18;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_1C;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_20;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_24;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_28;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_2C;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_30;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_34;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_38;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_3C;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_40;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_44;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_48;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_4C;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_50;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_54;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_58;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_5C;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_60;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_64;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_68;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_6C;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_70;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_74;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_78;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_7C;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_80;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_84;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_88;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_8C;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_90;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_94;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_98;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_9C;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_A0;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_A4;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_A8;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_AC;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_B0;
      /// <summary>
      ///Link to the Part Specification
      /// </summary>
      public System.Int32 m_PSpc_link_B4;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_B8;

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
         this.m_PSpc_link_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_PSpc_link_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_PSpc_link_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_PSpc_link_14 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_PSpc_link_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_PSpc_link_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_PSpc_link_20 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_PSpc_link_24 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_PSpc_link_28 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_PSpc_link_2C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 48];
         }
         this.m_PSpc_link_30 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 52];
         }
         this.m_PSpc_link_34 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 56];
         }
         this.m_PSpc_link_38 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 60];
         }
         this.m_PSpc_link_3C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64];
         }
         this.m_PSpc_link_40 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 68];
         }
         this.m_PSpc_link_44 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 72];
         }
         this.m_PSpc_link_48 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 76];
         }
         this.m_PSpc_link_4C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 80];
         }
         this.m_PSpc_link_50 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 84];
         }
         this.m_PSpc_link_54 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 88];
         }
         this.m_PSpc_link_58 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 92];
         }
         this.m_PSpc_link_5C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 96];
         }
         this.m_PSpc_link_60 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 100];
         }
         this.m_PSpc_link_64 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 104];
         }
         this.m_PSpc_link_68 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 108];
         }
         this.m_PSpc_link_6C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 112];
         }
         this.m_PSpc_link_70 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 116];
         }
         this.m_PSpc_link_74 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 120];
         }
         this.m_PSpc_link_78 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 124];
         }
         this.m_PSpc_link_7C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 128];
         }
         this.m_PSpc_link_80 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 132];
         }
         this.m_PSpc_link_84 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 136];
         }
         this.m_PSpc_link_88 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 140];
         }
         this.m_PSpc_link_8C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 144];
         }
         this.m_PSpc_link_90 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 148];
         }
         this.m_PSpc_link_94 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 152];
         }
         this.m_PSpc_link_98 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 156];
         }
         this.m_PSpc_link_9C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 160];
         }
         this.m_PSpc_link_A0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 164];
         }
         this.m_PSpc_link_A4 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 168];
         }
         this.m_PSpc_link_A8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 172];
         }
         this.m_PSpc_link_AC = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 176];
         }
         this.m_PSpc_link_B0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 180];
         }
         this.m_PSpc_link_B4 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 184];
         }
         this.m_Not_used_B8 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);

     }
  }
}
