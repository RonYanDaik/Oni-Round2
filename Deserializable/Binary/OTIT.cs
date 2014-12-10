namespace Round2.Generated.Binary
{
  internal class OTIT: Round2.BinaryInitializable
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
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_child_pointer_0 = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+3];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_3 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+4];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_child_pointer_4 = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+7];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_7 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+8];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_child_pointer_8 = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+11];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_B = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+12];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_4th_child_pointer_C = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+15];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_F = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+16];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_5th_child_pointer_10 = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+19];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_13 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+20];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_6th_child_pointer_14 = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+23];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_17 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+24];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_7th_child_pointer_18 = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+27];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_1B = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+28];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_8th_child_pointer_1C = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 32+31];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_1F = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}

     }
public class Package
{
      /// <summary>
      ///Pointer to the 1st child
      /// </summary>
      public System.Int32 m_1st_child_pointer_0;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_3;
      /// <summary>
      ///Pointer to the 2nd child
      /// </summary>
      public System.Int32 m_2nd_child_pointer_4;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_7;
      /// <summary>
      ///Pointer to the 3rd child
      /// </summary>
      public System.Int32 m_3rd_child_pointer_8;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_B;
      /// <summary>
      ///Pointer to the 4th child
      /// </summary>
      public System.Int32 m_4th_child_pointer_C;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_F;
      /// <summary>
      ///Pointer to the 5th child
      /// </summary>
      public System.Int32 m_5th_child_pointer_10;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_13;
      /// <summary>
      ///Pointer to the 6th child
      /// </summary>
      public System.Int32 m_6th_child_pointer_14;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_17;
      /// <summary>
      ///Pointer to the 7th child
      /// </summary>
      public System.Int32 m_7th_child_pointer_18;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_1B;
      /// <summary>
      ///Pointer to the 8th child
      /// </summary>
      public System.Int32 m_8th_child_pointer_1C;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_1F;
}

  }
}
