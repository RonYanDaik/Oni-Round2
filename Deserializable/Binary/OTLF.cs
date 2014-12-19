namespace Round2.Generated.Binary
{
  internal partial class OTLF: Round2.BinaryInitializable
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
             l_bytes[i] = data[i + 32+j * 36+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_0 = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+3];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_3 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+4];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_4 = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+7];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_7 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+8];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_8 = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+11];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_B = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+12];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_C = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+15];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_F = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+16];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_10 = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+19];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_13 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+20];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_14 = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+23];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_17 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+24];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_18 = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+27];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_1B = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+28];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_1C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 36+32];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_20 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}

     }
public partial class Package
{
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_0;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_3;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_4;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_7;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_8;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_B;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_C;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_F;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_10;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_13;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_14;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_17;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_18;
      /// <summary>
      ///High bit
      /// </summary>
      public System.Byte m_High_bit_1B;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_1C;
      /// <summary>
      ///Unknown; always the same (?)
      /// </summary>
      public System.Int32 m_Unknown_20;
}

  }
}
