namespace Round2.Generated.Binary
{
  internal partial class ENVP: Round2.BinaryInitializable
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
      public System.Int16 m_Packages_1E;
      /// <summary>
      ///Field for package container
      /// </summary>
      public Package[] m_pkg_20;

      public override void Convert(byte[] data)
      {
          byte[] l_bytes = new byte[64];
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
             l_bytes[i] = data[i + 30];
         }
         this.m_Packages_1E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<64; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3D_particle_0 = (System.String)BinaryDatReader.l_str(l_bytes, 64);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<48; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+64];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Particle_name_40 = (System.String)BinaryDatReader.l_str(l_bytes, 48);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+112];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_transform_a11_70 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+116];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_transform_a12_74 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+120];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_transform_a13_78 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+124];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_transform_a21_7C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+128];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_transform_a22_80 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+132];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_transform_a23_84 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+136];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_transform_a31_88 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+140];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_transform_a32_8C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+144];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_transform_a33_90 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+148];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_transform_a41_94 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+152];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_transform_a42_98 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+156];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_transform_a43_9C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+160];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_scale_x_A0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+164];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_scale_y_A4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 208+168];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_A8 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
}
}

     }
public partial class Package
{
      /// <summary>
      ///Reference to a BINA file of level 0
      /// </summary>
      public System.String m_3D_particle_0;
      /// <summary>
      ///Name of the particle
      /// </summary>
      public System.String m_Particle_name_40;
      /// <summary>
      ///transform matrix a11
      /// </summary>
      public System.Single m_transform_a11_70;
      /// <summary>
      ///transform matrix a12
      /// </summary>
      public System.Single m_transform_a12_74;
      /// <summary>
      ///transform matrix a13
      /// </summary>
      public System.Single m_transform_a13_78;
      /// <summary>
      ///transform matrix a21
      /// </summary>
      public System.Single m_transform_a21_7C;
      /// <summary>
      ///transform matrix a22
      /// </summary>
      public System.Single m_transform_a22_80;
      /// <summary>
      ///transform matrix a23
      /// </summary>
      public System.Single m_transform_a23_84;
      /// <summary>
      ///transform matrix a31
      /// </summary>
      public System.Single m_transform_a31_88;
      /// <summary>
      ///transform matrix a32
      /// </summary>
      public System.Single m_transform_a32_8C;
      /// <summary>
      ///transform matrix a33
      /// </summary>
      public System.Single m_transform_a33_90;
      /// <summary>
      ///transform matrix a41
      /// </summary>
      public System.Single m_transform_a41_94;
      /// <summary>
      ///transform matrix a42
      /// </summary>
      public System.Single m_transform_a42_98;
      /// <summary>
      ///transform matrix a43
      /// </summary>
      public System.Single m_transform_a43_9C;
      /// <summary>
      ///decal x scale
      /// </summary>
      public System.Single m_scale_x_A0;
      /// <summary>
      ///decal y scale
      /// </summary>
      public System.Single m_scale_y_A4;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_A8;
}

  }
}
