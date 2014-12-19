namespace Round2.Generated.Binary
{
  internal partial class AGQG: Round2.BinaryInitializable
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
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_8;
      /// <summary>
      ///Amount of packages that follow
      /// </summary>
      public System.Int32 m_Packages_1C;
      /// <summary>
      ///Field for package container
      /// </summary>
      public Package[] m_pkg_20;

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
         this.m_Not_used_8 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Packages_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 56+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_pnta_id_1_0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 56+4];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_pnta_id_2_4 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 56+8];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_pnta_id_3_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 56+12];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_pnta_id_4_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 56+16];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_txca_id_1_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 56+20];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_txca_id_2_14 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 56+24];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_txca_id_3_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 56+28];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_txca_id_4_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 56+32];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_argb_vrtx_color_1_20 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 56+36];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_argb_vrtx_color_2_24 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 56+40];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_argb_vrtx_color_3_28 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 56+44];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_argb_vrtx_color_4_2C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32+j * 56+48];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_flags_30 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32+j * 56+52];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_obj_id_34 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}

     }
public partial class Package
{
      /// <summary>
      ///pnta id of first vertex
      /// </summary>
      public System.Int32 m_pnta_id_1_0;
      /// <summary>
      ///pnta id of second vertex
      /// </summary>
      public System.Int32 m_pnta_id_2_4;
      /// <summary>
      ///pnta id of third vertex
      /// </summary>
      public System.Int32 m_pnta_id_3_8;
      /// <summary>
      ///pnta id of fourth vertex
      /// </summary>
      public System.Int32 m_pnta_id_4_C;
      /// <summary>
      ///txca id of first vertex
      /// </summary>
      public System.Int32 m_txca_id_1_10;
      /// <summary>
      ///txca id of second vertex
      /// </summary>
      public System.Int32 m_txca_id_2_14;
      /// <summary>
      ///txca id of third vertex
      /// </summary>
      public System.Int32 m_txca_id_3_18;
      /// <summary>
      ///txca id of fourth vertex
      /// </summary>
      public System.Int32 m_txca_id_4_1C;
      /// <summary>
      ///color of vertex 1
      /// </summary>
      public System.Int32 m_argb_vrtx_color_1_20;
      /// <summary>
      ///color of vertex 2
      /// </summary>
      public System.Int32 m_argb_vrtx_color_2_24;
      /// <summary>
      ///color of vertex 3
      /// </summary>
      public System.Int32 m_argb_vrtx_color_3_28;
      /// <summary>
      ///color of vertex 4
      /// </summary>
      public System.Int32 m_argb_vrtx_color_4_2C;
      /// <summary>
      ///flags (see definition at http://wiki.oni2.net/OBD:AGQG)
      /// </summary>
      public System.Int16 m_flags_30;
      /// <summary>
      ///id of ONOA object belong to (if -1 then belongs to satan or something)
      /// </summary>
      public System.Int16 m_obj_id_34;
}

  }
}
