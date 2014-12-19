namespace Round2.Generated.Binary
{
  internal partial class FILM: Round2.BinaryInitializable
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
      ///x-coordinate of the start point
      /// </summary>
      public System.Single m_x_coordinate_8;
      /// <summary>
      ///y-coordinate (height) of the start point
      /// </summary>
      public System.Single m_y_coordinate_C;
      /// <summary>
      ///z-coordinate of the start point
      /// </summary>
      public System.Single m_z_coordinate_10;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_14;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_18;
      /// <summary>
      ///Look from left or right to facing state
      /// </summary>
      public System.Single m_Look_left_right_1C;
      /// <summary>
      ///Look up or down
      /// </summary>
      public System.Single m_Look_up_down_20;
      /// <summary>
      ///Lenght of the film in 1/60 seconds
      /// </summary>
      public System.Int32 m_Film_lenght_24;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_28;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_2C;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_30;
      /// <summary>
      ///Amount of packages that follow
      /// </summary>
      public System.Int32 m_Packages_3C;
      /// <summary>
      ///Field for package container
      /// </summary>
      public Package[] m_pkg_40;

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
         this.m_x_coordinate_8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_y_coordinate_C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_z_coordinate_10 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_Unknown_14 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_Unknown_18 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Look_left_right_1C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_Look_up_down_20 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_Film_lenght_24 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_Unknown_28 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_Unknown_2C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 48];
         }
         this.m_Not_used_30 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 60];
         }
         this.m_Packages_3C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
m_pkg_40 = new Package[this.m_Packages_3C];
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64+j * 24+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_Camera_angle_0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64+j * 24+4];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_Character_rotation_4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 64+j * 24+8];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_Unknown_8 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64+j * 24+10];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_Movement_A = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 64+j * 24+11];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_Unknown_B = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64+j * 24+12];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_Unknown_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64+j * 24+16];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_Frames_to_go_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 64+j * 24+20];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_Unknown_14 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 64+j * 24+22];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_Unknown_16 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}

     }
public partial class Package
{
      /// <summary>
      ///Camera angle in degrees (up / down)
      /// </summary>
      public System.Single m_Camera_angle_0;
      /// <summary>
      ///Rotation of the charcter on the y-axis in degrees
      /// </summary>
      public System.Single m_Character_rotation_4;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_8;
      /// <summary>
      ///Movement bitset
      /// </summary>
      public System.Int32 m_Movement_A;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Byte m_Unknown_B;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_C;
      /// <summary>
      ///Number of the frames to go
      /// </summary>
      public System.Int32 m_Frames_to_go_10;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_14;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_16;
}

  }
}
