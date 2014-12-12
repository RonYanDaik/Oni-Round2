namespace Round2.Generated.Binary
{
  internal class PSPC: Round2.BinaryInitializable
  {
      /// <summary>
      ///Empty comment
      /// </summary>
      public System.Int32 m_ID_0;
      /// <summary>
      ///Empty comment
      /// </summary>
      public System.Int32 m_LevelID_4;
      /// <summary>
      ///LT Left
      /// </summary>
      public System.Int16 m_LFT_LT_8;
      /// <summary>
      ///LT Top
      /// </summary>
      public System.Int16 m_TOP_LT_A;
      /// <summary>
      ///HL Left (rubber)
      /// </summary>
      public System.Int16 m_LFT_HL_C;
      /// <summary>
      ///HL Top (rubber)
      /// </summary>
      public System.Int16 m_TOP_HL_E;
      /// <summary>
      ///LB Left
      /// </summary>
      public System.Int16 m_LFT_LB_10;
      /// <summary>
      ///LB Top
      /// </summary>
      public System.Int16 m_TOP_LB_12;
      /// <summary>
      ///VT Left (rubber)
      /// </summary>
      public System.Int16 m_LFT_VT_14;
      /// <summary>
      ///VT Top (rubber)
      /// </summary>
      public System.Int16 m_TOP_VT_16;
      /// <summary>
      ///CC Left (rubber)
      /// </summary>
      public System.Int16 m_LFT_CC_18;
      /// <summary>
      ///CC Top (rubber)
      /// </summary>
      public System.Int16 m_TOP_CC_1A;
      /// <summary>
      ///VB Left (rubber)
      /// </summary>
      public System.Int16 m_LFT_VB_1C;
      /// <summary>
      ///VB Top (rubber)
      /// </summary>
      public System.Int16 m_TOP_VB_1E;
      /// <summary>
      ///RT Left
      /// </summary>
      public System.Int16 m_LFT_RT_20;
      /// <summary>
      ///RT Top
      /// </summary>
      public System.Int16 m_TOP_RT_22;
      /// <summary>
      ///HR Left (rubber)
      /// </summary>
      public System.Int16 m_LFT_HR_24;
      /// <summary>
      ///HR Top (rubber)
      /// </summary>
      public System.Int16 m_TOP_HR_26;
      /// <summary>
      ///RB Left
      /// </summary>
      public System.Int16 m_LFT_RB_28;
      /// <summary>
      ///RB Top
      /// </summary>
      public System.Int16 m_TOP_RB_2A;
      /// <summary>
      ///LT Right
      /// </summary>
      public System.Int16 m_RGH_LT_2C;
      /// <summary>
      ///LT Bottom
      /// </summary>
      public System.Int16 m_BTM_LT_2E;
      /// <summary>
      ///HL Right (rubber)
      /// </summary>
      public System.Int16 m_RGH_HL_30;
      /// <summary>
      ///HL Bottom (rubber)
      /// </summary>
      public System.Int16 m_BTM_HL_32;
      /// <summary>
      ///LB Right
      /// </summary>
      public System.Int16 m_RGH_LB_34;
      /// <summary>
      ///LB Bottom
      /// </summary>
      public System.Int16 m_BTM_LB_36;
      /// <summary>
      ///VT Right (rubber)
      /// </summary>
      public System.Int16 m_RGH_VT_38;
      /// <summary>
      ///VT Bottom (rubber)
      /// </summary>
      public System.Int16 m_BTM_VT_3A;
      /// <summary>
      ///CC Right (rubber)
      /// </summary>
      public System.Int16 m_RGH_CC_3C;
      /// <summary>
      ///CC Bottom (rubber)
      /// </summary>
      public System.Int16 m_BTM_CC_3E;
      /// <summary>
      ///VB Right (rubber)
      /// </summary>
      public System.Int16 m_RGH_VB_40;
      /// <summary>
      ///VB Bottom (rubber)
      /// </summary>
      public System.Int16 m_BTM_VB_42;
      /// <summary>
      ///RT Right
      /// </summary>
      public System.Int16 m_RGH_RT_44;
      /// <summary>
      ///RT Bottom
      /// </summary>
      public System.Int16 m_BTM_RT_46;
      /// <summary>
      ///HR Right (rubber)
      /// </summary>
      public System.Int16 m_RGH_HR_48;
      /// <summary>
      ///HR Bottom (rubber)
      /// </summary>
      public System.Int16 m_BTM_HR_4A;
      /// <summary>
      ///RB Right
      /// </summary>
      public System.Int16 m_RGH_RB_4C;
      /// <summary>
      ///RB Bottom
      /// </summary>
      public System.Int16 m_BTM_RB_4E;
      /// <summary>
      ///Corresponding texture
      /// </summary>
      public Link<TXMP> m_TXMP_Link_50 =  new Link<TXMP>();

      public void Convert(byte[] data)
      {
          byte[] l_bytes = new byte[4];
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 0];
         }
         this.m_ID_0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 4];
         }
         this.m_LevelID_4 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 8];
         }
         this.m_LFT_LT_8 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 10];
         }
         this.m_TOP_LT_A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_LFT_HL_C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 14];
         }
         this.m_TOP_HL_E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_LFT_LB_10 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 18];
         }
         this.m_TOP_LB_12 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_LFT_VT_14 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 22];
         }
         this.m_TOP_VT_16 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_LFT_CC_18 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 26];
         }
         this.m_TOP_CC_1A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_LFT_VB_1C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 30];
         }
         this.m_TOP_VB_1E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_LFT_RT_20 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 34];
         }
         this.m_TOP_RT_22 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_LFT_HR_24 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 38];
         }
         this.m_TOP_HR_26 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_LFT_RB_28 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 42];
         }
         this.m_TOP_RB_2A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_RGH_LT_2C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 46];
         }
         this.m_BTM_LT_2E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 48];
         }
         this.m_RGH_HL_30 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 50];
         }
         this.m_BTM_HL_32 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 52];
         }
         this.m_RGH_LB_34 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 54];
         }
         this.m_BTM_LB_36 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 56];
         }
         this.m_RGH_VT_38 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 58];
         }
         this.m_BTM_VT_3A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 60];
         }
         this.m_RGH_CC_3C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 62];
         }
         this.m_BTM_CC_3E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 64];
         }
         this.m_RGH_VB_40 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 66];
         }
         this.m_BTM_VB_42 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 68];
         }
         this.m_RGH_RT_44 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 70];
         }
         this.m_BTM_RT_46 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 72];
         }
         this.m_RGH_HR_48 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 74];
         }
         this.m_BTM_HR_4A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 76];
         }
         this.m_RGH_RB_4C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 78];
         }
         this.m_BTM_RB_4E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 80];
         }
         this.m_TXMP_Link_50 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);

     }
  }
}
