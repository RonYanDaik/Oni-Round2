namespace Round2.Generated.Binary
{
  internal partial class AKVA: Round2.BinaryInitializable
  {
      /// <summary>
      ///Empty comment
      /// </summary>
      public System.Int32 m_File_ID_0;
      /// <summary>
      ///Empty comment
      /// </summary>
      public System.Int32 m_Level_ID_4;
      /// <summary>
      ///Empty comment
      /// </summary>
      public System.Int32 m_Unused_8;
      /// <summary>
      ///Empty comment
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
         this.m_File_ID_0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 4];
         }
         this.m_Level_ID_4 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 8];
         }
         this.m_Unused_8 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Packages_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_AKBP_index_0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+4];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_AKVA_index_4 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+8];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_AKBA_index_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+12];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_AKBA_index_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+16];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_AKVA_index_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+20];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_AKVA_index_14 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+24];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+28];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_X_tiles_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+32];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Y_tiles_20 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+36];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_RAW_offset_24 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+40];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_RAW_size_28 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+44];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Tile_size_2C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+48];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_AABB_X__30 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+52];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_AABB_Y__34 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+56];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_AABB_Z__38 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+60];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_AABB_X__3C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+64];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_AABB_Y__40 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+68];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_AABB_Z__44 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+72];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_48 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+74];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_4A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+76];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_AKVA_index_4C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+80];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_50 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+84];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_54 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+88];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_58 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+92];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Bitset_5C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+100];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Plane_Y_64 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+104];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Plane_Z_68 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+108];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Plane_D_6C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 116+112];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Plane_D_70 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}

     }
public partial class Package
{
      /// <summary>
      ///BSP tree for this BNV
      /// </summary>
      public System.Int32 m_AKBP_index_0;
      /// <summary>
      ///index of this BNV
      /// </summary>
      public System.Int32 m_AKVA_index_4;
      /// <summary>
      ///"side" range start
      /// </summary>
      public System.Int32 m_AKBA_index_8;
      /// <summary>
      ///"side" range end
      /// </summary>
      public System.Int32 m_AKBA_index_C;
      /// <summary>
      ///first child BNV
      /// </summary>
      public System.Int32 m_AKVA_index_10;
      /// <summary>
      ///next sibling BNV
      /// </summary>
      public System.Int32 m_AKVA_index_14;
      /// <summary>
      ///always -1
      /// </summary>
      public System.Int32 m_Unknown_18;
      /// <summary>
      ///size of pathfinding grid
      /// </summary>
      public System.Int32 m_X_tiles_1C;
      /// <summary>
      ///size of pathfinding grid
      /// </summary>
      public System.Int32 m_Y_tiles_20;
      /// <summary>
      ///offset of grid data
      /// </summary>
      public System.Int32 m_RAW_offset_24;
      /// <summary>
      ///size of grid data
      /// </summary>
      public System.Int32 m_RAW_size_28;
      /// <summary>
      ///usually 4 world units
      /// </summary>
      public System.Single m_Tile_size_2C;
      /// <summary>
      ///BNV AABB
      /// </summary>
      public System.Single m_AABB_X__30;
      /// <summary>
      ///BNV AABB
      /// </summary>
      public System.Single m_AABB_Y__34;
      /// <summary>
      ///BNV AABB
      /// </summary>
      public System.Single m_AABB_Z__38;
      /// <summary>
      ///BNV AABB
      /// </summary>
      public System.Single m_AABB_X__3C;
      /// <summary>
      ///BNV AABB
      /// </summary>
      public System.Single m_AABB_Y__40;
      /// <summary>
      ///BNV AABB
      /// </summary>
      public System.Single m_AABB_Z__44;
      /// <summary>
      ///always -2
      /// </summary>
      public System.Int16 m_Unknown_48;
      /// <summary>
      ///always -2
      /// </summary>
      public System.Int16 m_Unknown_4A;
      /// <summary>
      ///index of this BNV again
      /// </summary>
      public System.Int32 m_AKVA_index_4C;
      /// <summary>
      ///always 0
      /// </summary>
      public System.Int32 m_Unknown_50;
      /// <summary>
      ///always 0
      /// </summary>
      public System.Int32 m_Unknown_54;
      /// <summary>
      ///always 0 (was a RAW offset once?)
      /// </summary>
      public System.Int32 m_Unknown_58;
      /// <summary>
      ///1Plane X
      /// </summary>
      public System.Int32 m_Bitset_5C;
      /// <summary>
      ///floor and ceiling normal
      /// </summary>
      public System.Single m_Plane_Y_64;
      /// <summary>
      ///floor and ceiling normal
      /// </summary>
      public System.Single m_Plane_Z_68;
      /// <summary>
      ///distance of floor to origin
      /// </summary>
      public System.Single m_Plane_D_6C;
      /// <summary>
      ///distance of ceiling to origin
      /// </summary>
      public System.Single m_Plane_D_70;
}

  }
}
