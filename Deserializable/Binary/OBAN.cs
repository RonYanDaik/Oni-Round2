namespace Round2.Generated.Binary
{
  internal class OBAN: Round2.BinaryInitializable
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
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_8;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_10;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_14;
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
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_24;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_28;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_2C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_30;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_34;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_38;
      /// <summary>
      ///x-position of the start point
      /// </summary>
      public System.Single m_x_position_3C;
      /// <summary>
      ///y-position (height) of the start point
      /// </summary>
      public System.Single m_y_position_40;
      /// <summary>
      ///z-position of the start point
      /// </summary>
      public System.Single m_z_position_44;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_48;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_4C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_50;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_54;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_58;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_5C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_60;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_64;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_68;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_6C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_70;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_74;
      /// <summary>
      ///Number of frames
      /// </summary>
      public System.Int16 m_Frames_78;
      /// <summary>
      ///Animation time in 1/60 seconds
      /// </summary>
      public System.Int16 m_Animation_time_7A;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_7C;
      /// <summary>
      ///Amount of packages that follow
      /// </summary>
      public System.Int16 m_Packages_7E;
      /// <summary>
      ///Field for package container
      /// </summary>
      public Package[] m_pkg_80;

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
         this.m_Unknown_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 12];
         }
         this.m_Unknown_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_Unknown_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_Unknown_14 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_Unknown_18 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Unknown_1C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_Unknown_20 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_Unknown_24 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_Unknown_28 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_Unknown_2C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 48];
         }
         this.m_Unknown_30 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 52];
         }
         this.m_Unknown_34 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 56];
         }
         this.m_Unknown_38 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 60];
         }
         this.m_x_position_3C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64];
         }
         this.m_y_position_40 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 68];
         }
         this.m_z_position_44 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 72];
         }
         this.m_Unknown_48 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 76];
         }
         this.m_Unknown_4C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 80];
         }
         this.m_Unknown_50 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 84];
         }
         this.m_Unknown_54 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 88];
         }
         this.m_Unknown_58 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 92];
         }
         this.m_Unknown_5C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 96];
         }
         this.m_Unknown_60 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 100];
         }
         this.m_Unknown_64 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 104];
         }
         this.m_Unknown_68 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 108];
         }
         this.m_Unknown_6C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 112];
         }
         this.m_Unknown_70 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 116];
         }
         this.m_Unknown_74 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 120];
         }
         this.m_Frames_78 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 122];
         }
         this.m_Animation_time_7A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 124];
         }
         this.m_Unknown_7C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 126];
         }
         this.m_Packages_7E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
m_pkg_80 = new Package[this.m_Packages_7E];
for (int j=0;j<this.m_Packages_7E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 128+j * 32+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_80[j] == null ?  m_pkg_80[j] = new Package() :   m_pkg_80[j];
l_pkg.m_Unknown_0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_80 = new Package[this.m_Packages_7E];
for (int j=0;j<this.m_Packages_7E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 128+j * 32+4];
         }
{
Package l_pkg;
l_pkg = m_pkg_80[j] == null ?  m_pkg_80[j] = new Package() :   m_pkg_80[j];
l_pkg.m_Unknown_4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_80 = new Package[this.m_Packages_7E];
for (int j=0;j<this.m_Packages_7E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 128+j * 32+8];
         }
{
Package l_pkg;
l_pkg = m_pkg_80[j] == null ?  m_pkg_80[j] = new Package() :   m_pkg_80[j];
l_pkg.m_Unknown_8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_80 = new Package[this.m_Packages_7E];
for (int j=0;j<this.m_Packages_7E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 128+j * 32+12];
         }
{
Package l_pkg;
l_pkg = m_pkg_80[j] == null ?  m_pkg_80[j] = new Package() :   m_pkg_80[j];
l_pkg.m_Unknown_C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_80 = new Package[this.m_Packages_7E];
for (int j=0;j<this.m_Packages_7E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 128+j * 32+16];
         }
{
Package l_pkg;
l_pkg = m_pkg_80[j] == null ?  m_pkg_80[j] = new Package() :   m_pkg_80[j];
l_pkg.m_x_position_10 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_80 = new Package[this.m_Packages_7E];
for (int j=0;j<this.m_Packages_7E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 128+j * 32+20];
         }
{
Package l_pkg;
l_pkg = m_pkg_80[j] == null ?  m_pkg_80[j] = new Package() :   m_pkg_80[j];
l_pkg.m_y_position_14 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_80 = new Package[this.m_Packages_7E];
for (int j=0;j<this.m_Packages_7E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 128+j * 32+24];
         }
{
Package l_pkg;
l_pkg = m_pkg_80[j] == null ?  m_pkg_80[j] = new Package() :   m_pkg_80[j];
l_pkg.m_z_position_18 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_80 = new Package[this.m_Packages_7E];
for (int j=0;j<this.m_Packages_7E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 128+j * 32+28];
         }
{
Package l_pkg;
l_pkg = m_pkg_80[j] == null ?  m_pkg_80[j] = new Package() :   m_pkg_80[j];
l_pkg.m_Passed_time_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
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
      ///x-position
      /// </summary>
      public System.Single m_x_position_10;
      /// <summary>
      ///y-position
      /// </summary>
      public System.Single m_y_position_14;
      /// <summary>
      ///z-position
      /// </summary>
      public System.Single m_z_position_18;
      /// <summary>
      ///Passed time in 1/60 seconds
      /// </summary>
      public System.Int32 m_Passed_time_1C;
}

  }
}
