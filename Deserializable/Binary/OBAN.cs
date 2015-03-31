namespace Round2.Generated.Binary
{
  internal partial class OBAN: Round2.BinaryInitializable
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
      ///matrix a11
      /// </summary>
      public System.Single m_initial_position_matrix_a11_18;
      /// <summary>
      ///matrix a12
      /// </summary>
      public System.Single m_initial_position_matrix_a12_1C;
      /// <summary>
      ///matrix a13
      /// </summary>
      public System.Single m_initial_position_matrix_a13_20;
      /// <summary>
      ///matrix a21
      /// </summary>
      public System.Single m_initial_position_matrix_a21_24;
      /// <summary>
      ///matrix a22
      /// </summary>
      public System.Single m_initial_position_matrix_a22_28;
      /// <summary>
      ///matrix a23
      /// </summary>
      public System.Single m_initial_position_matrix_a23_2C;
      /// <summary>
      ///matrix a31
      /// </summary>
      public System.Single m_initial_position_matrix_a31_30;
      /// <summary>
      ///matrix a32
      /// </summary>
      public System.Single m_initial_position_matrix_a32_34;
      /// <summary>
      ///matrix a33
      /// </summary>
      public System.Single m_initial_position_matrix_a33_38;
      /// <summary>
      ///matrix a41
      /// </summary>
      public System.Single m_initial_position_matrix_a41_3C;
      /// <summary>
      ///matrix a42
      /// </summary>
      public System.Single m_initial_position_matrix_a42_40;
      /// <summary>
      ///matrix a43
      /// </summary>
      public System.Single m_initial_position_matrix_a43_44;
      /// <summary>
      ///matrix a11
      /// </summary>
      public System.Single m_fixed_transform_a11_48;
      /// <summary>
      ///matrix a12
      /// </summary>
      public System.Single m_fixed_transform_a12_4C;
      /// <summary>
      ///matrix a13
      /// </summary>
      public System.Single m_fixed_transform_a13_50;
      /// <summary>
      ///matrix a21
      /// </summary>
      public System.Single m_fixed_transform_a21_54;
      /// <summary>
      ///matrix a22
      /// </summary>
      public System.Single m_fixed_transform_a22_58;
      /// <summary>
      ///matrix a23
      /// </summary>
      public System.Single m_fixed_transform_a23_5C;
      /// <summary>
      ///matrix a31
      /// </summary>
      public System.Single m_fixed_transform_a31_60;
      /// <summary>
      ///matrix a32
      /// </summary>
      public System.Single m_fixed_transform_a32_64;
      /// <summary>
      ///matrix a33
      /// </summary>
      public System.Single m_fixed_transform_a33_68;
      /// <summary>
      ///matrix a41
      /// </summary>
      public System.Single m_fixed_transform_a41_6C;
      /// <summary>
      ///matrix a42
      /// </summary>
      public System.Single m_fixed_transform_a42_70;
      /// <summary>
      ///matrix a43
      /// </summary>
      public System.Single m_fixed_transform_a43_74;
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

      public override void Convert(byte[] data)
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
         this.m_initial_position_matrix_a11_18 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_initial_position_matrix_a12_1C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_initial_position_matrix_a13_20 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_initial_position_matrix_a21_24 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_initial_position_matrix_a22_28 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_initial_position_matrix_a23_2C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 48];
         }
         this.m_initial_position_matrix_a31_30 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 52];
         }
         this.m_initial_position_matrix_a32_34 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 56];
         }
         this.m_initial_position_matrix_a33_38 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 60];
         }
         this.m_initial_position_matrix_a41_3C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64];
         }
         this.m_initial_position_matrix_a42_40 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 68];
         }
         this.m_initial_position_matrix_a43_44 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 72];
         }
         this.m_fixed_transform_a11_48 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 76];
         }
         this.m_fixed_transform_a12_4C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 80];
         }
         this.m_fixed_transform_a13_50 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 84];
         }
         this.m_fixed_transform_a21_54 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 88];
         }
         this.m_fixed_transform_a22_58 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 92];
         }
         this.m_fixed_transform_a23_5C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 96];
         }
         this.m_fixed_transform_a31_60 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 100];
         }
         this.m_fixed_transform_a32_64 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 104];
         }
         this.m_fixed_transform_a33_68 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 108];
         }
         this.m_fixed_transform_a41_6C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 112];
         }
         this.m_fixed_transform_a42_70 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 116];
         }
         this.m_fixed_transform_a43_74 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
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
l_pkg.m_x_rot_0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_7E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 128+j * 32+4];
         }
{
Package l_pkg;
l_pkg = m_pkg_80[j] == null ?  m_pkg_80[j] = new Package() :   m_pkg_80[j];
l_pkg.m_y_rot_4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_7E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 128+j * 32+8];
         }
{
Package l_pkg;
l_pkg = m_pkg_80[j] == null ?  m_pkg_80[j] = new Package() :   m_pkg_80[j];
l_pkg.m_z_rot_8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_7E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 128+j * 32+12];
         }
{
Package l_pkg;
l_pkg = m_pkg_80[j] == null ?  m_pkg_80[j] = new Package() :   m_pkg_80[j];
l_pkg.m_w_rot_C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
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
public partial class Package
{
      /// <summary>
      ///x-rot
      /// </summary>
      public System.Single m_x_rot_0;
      /// <summary>
      ///y-rot
      /// </summary>
      public System.Single m_y_rot_4;
      /// <summary>
      ///z-rot
      /// </summary>
      public System.Single m_z_rot_8;
      /// <summary>
      ///w-rot
      /// </summary>
      public System.Single m_w_rot_C;
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
