namespace Round2.Generated.Binary
{
  internal partial class AKEV: Round2.BinaryInitializable
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
      ///Link to the 3D Point Array
      /// </summary>
      public Link<PNTA> m_PNTA_link_8 =  new Link<PNTA>();
      /// <summary>
      ///Link to the Plane Equation Array
      /// </summary>
      public Link<PLEA> m_PLEA_link_C =  new Link<PLEA>();
      /// <summary>
      ///Link to the Texture Coordinate Array
      /// </summary>
      public Link<TXCA> m_TXCA_link_10 =  new Link<TXCA>();
      /// <summary>
      ///Link to the Gunk Quad General Array
      /// </summary>
      public Link<AGQG> m_AGQG_link_14 =  new Link<AGQG>();
      /// <summary>
      ///Link to the Gunk Quad Render Array
      /// </summary>
      public Link<AGQR> m_AGQR_link_18 =  new Link<AGQR>();
      /// <summary>
      ///Link to the Gunk Quad Collision Array
      /// </summary>
      public Link<AGQC> m_AGQC_link_1C =  new Link<AGQC>();
      /// <summary>
      ///Link to the Gunk Quad Debug Array
      /// </summary>
      public Link<AGDB> m_AGDB_link_20 =  new Link<AGDB>();
      /// <summary>
      ///Link to the Texture Map Array
      /// </summary>
      public Link<TXMA> m_TXMA_link_24 =  new Link<TXMA>();
      /// <summary>
      ///Link to the BNV Node Array
      /// </summary>
      public Link<AKVA> m_AKVA_link_28 =  new Link<AKVA>();
      /// <summary>
      ///Link to the Side Array
      /// </summary>
      public Link<AKBA> m_AKBA_link_2C =  new Link<AKBA>();
      /// <summary>
      ///Link to the Index Array
      /// </summary>
      public Link<IDXA> m_IDXA_link_30 =  new Link<IDXA>();
      /// <summary>
      ///Link to the Index Array
      /// </summary>
      public Link<IDXA> m_IDXA_link_34 =  new Link<IDXA>();
      /// <summary>
      ///Link to the BSP Node Array
      /// </summary>
      public Link<AKBP> m_AKBP_link_38 =  new Link<AKBP>();
      /// <summary>
      ///Link to the BSP Tree Node Array
      /// </summary>
      public Link<ABNA> m_ABNA_link_3C =  new Link<ABNA>();
      /// <summary>
      ///Link to the Oct Tree
      /// </summary>
      public Link<AKOT> m_AKOT_link_40 =  new Link<AKOT>();
      /// <summary>
      ///Link to the Adjacency Array
      /// </summary>
      public Link<AKAA> m_AKAA_link_44 =  new Link<AKAA>();
      /// <summary>
      ///Link to the Door Frame Array
      /// </summary>
      public Link<AKDA> m_AKDA_link_48 =  new Link<AKDA>();
      /// <summary>
      ///Maximal negative x-coordinate of the level model
      /// </summary>
      public System.Single m_Neg__x_coordinate_4C;
      /// <summary>
      ///Maximal negative y-coordinate of the level model
      /// </summary>
      public System.Single m_Neg__y_coordinate_50;
      /// <summary>
      ///Maximal negative z-coordinate (height) of the level model
      /// </summary>
      public System.Single m_Neg__z_coordinate_54;
      /// <summary>
      ///Maximal positive x-coordinate of the level model
      /// </summary>
      public System.Single m_Pos__x_coordinate_58;
      /// <summary>
      ///Maximal positive y-coordinate (height) of the level model
      /// </summary>
      public System.Single m_Pos__y_coordinate_5C;
      /// <summary>
      ///Maximal positive z-coordinate of the level model
      /// </summary>
      public System.Single m_Pos__z_coordinate_60;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_64;
      /// <summary>
      ///Unknown; maybe the tolerance
      /// </summary>
      public System.Single m_Unknown_7C;

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
         this.m_PNTA_link_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_PLEA_link_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_TXCA_link_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_AGQG_link_14 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_AGQR_link_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_AGQC_link_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_AGDB_link_20 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_TXMA_link_24 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_AKVA_link_28 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_AKBA_link_2C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 48];
         }
         this.m_IDXA_link_30 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 52];
         }
         this.m_IDXA_link_34 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 56];
         }
         this.m_AKBP_link_38 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 60];
         }
         this.m_ABNA_link_3C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64];
         }
         this.m_AKOT_link_40 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 68];
         }
         this.m_AKAA_link_44 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 72];
         }
         this.m_AKDA_link_48 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 76];
         }
         this.m_Neg__x_coordinate_4C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 80];
         }
         this.m_Neg__y_coordinate_50 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 84];
         }
         this.m_Neg__z_coordinate_54 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 88];
         }
         this.m_Pos__x_coordinate_58 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 92];
         }
         this.m_Pos__y_coordinate_5C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 96];
         }
         this.m_Pos__z_coordinate_60 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 100];
         }
         this.m_Not_used_64 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 124];
         }
         this.m_Unknown_7C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);

     }
  }
}
