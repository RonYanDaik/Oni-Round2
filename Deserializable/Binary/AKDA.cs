namespace Round2.Generated.Binary
{
  internal class AKDA: Round2.BinaryInitializable
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
             l_bytes[i] = data[i + 32+j * 52+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 52+4];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Low_left_x_coordinate_4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 52+8];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Low_left_y_coordinate_8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 52+12];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Low_left_z_coordinate_C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 52+16];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Up_right_x_coordinate_10 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 52+20];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Up_right_y_coordinate_14 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 52+24];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Up_right_z_coordinate_18 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 52+28];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Center_x_coordinate_1C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 52+32];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Center_y_coordinate_20 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 52+36];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Center_z_coordinate_24 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 52+40];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Depth_28 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 52+44];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Width_2C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 52+48];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Height_30 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}

     }
public class Package
{
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_0;
      /// <summary>
      ///x-coordinate of the lower left point of the doorframe
      /// </summary>
      public System.Single m_Low_left_x_coordinate_4;
      /// <summary>
      ///y-coordinate (height) of the lower left point of the doorframe
      /// </summary>
      public System.Single m_Low_left_y_coordinate_8;
      /// <summary>
      ///z-coordinate of the lower left point of the doorframe
      /// </summary>
      public System.Single m_Low_left_z_coordinate_C;
      /// <summary>
      ///x-coordinate of the upper right point of the doorframe
      /// </summary>
      public System.Single m_Up_right_x_coordinate_10;
      /// <summary>
      ///y-coordinate (height) of the upper right point of the doorframe
      /// </summary>
      public System.Single m_Up_right_y_coordinate_14;
      /// <summary>
      ///z-coordinate of the upper right point of the doorframe
      /// </summary>
      public System.Single m_Up_right_z_coordinate_18;
      /// <summary>
      ///x-coordinate of the center point of the doorframe
      /// </summary>
      public System.Single m_Center_x_coordinate_1C;
      /// <summary>
      ///y-coordinate (height) of the center point of the doorframe
      /// </summary>
      public System.Single m_Center_y_coordinate_20;
      /// <summary>
      ///z-coordinate of the center point of the doorframe
      /// </summary>
      public System.Single m_Center_z_coordinate_24;
      /// <summary>
      ///Depth of the doorframe
      /// </summary>
      public System.Single m_Depth_28;
      /// <summary>
      ///Width of the doorframe
      /// </summary>
      public System.Single m_Width_2C;
      /// <summary>
      ///Height of the doorframe
      /// </summary>
      public System.Single m_Height_30;
}

  }
}
