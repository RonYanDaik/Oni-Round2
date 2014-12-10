namespace Round2.Generated.Binary
{
  internal class ONFA: Round2.BinaryInitializable
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
      public System.Int16 m_Packages_1C;
      /// <summary>
      ///Amount of packages that are possible
      /// </summary>
      public System.Int16 m_Packages_possible_1E;
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
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Packages_1C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 30];
         }
         this.m_Packages_possible_1E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+4];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+8];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+12];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+16];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_10 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+20];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_14 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+24];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_18 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+28];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_1C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+32];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_20 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+36];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_x_position_24 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+40];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_y_position_28 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+44];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_z_position_2C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+48];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_x_position_again_30 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+52];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_y_position_again_34 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+56];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_z_position_again_38 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+60];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_3C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+64];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Flag_node_id_40 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32+j * 68+66];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_42 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}

     }
public class Package
{
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_0;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_4;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_8;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_10;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_14;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_18;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_1C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_20;
      /// <summary>
      ///x-position
      /// </summary>
      public System.Single m_x_position_24;
      /// <summary>
      ///y-position (height)
      /// </summary>
      public System.Single m_y_position_28;
      /// <summary>
      ///z-position
      /// </summary>
      public System.Single m_z_position_2C;
      /// <summary>
      ///x-position again
      /// </summary>
      public System.Single m_x_position_again_30;
      /// <summary>
      ///y-position (height) again
      /// </summary>
      public System.Single m_y_position_again_34;
      /// <summary>
      ///z-position again
      /// </summary>
      public System.Single m_z_position_again_38;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_3C;
      /// <summary>
      ///Id of the flag node
      /// </summary>
      public System.Int16 m_Flag_node_id_40;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_42;
}

  }
}
