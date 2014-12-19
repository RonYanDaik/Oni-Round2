namespace Round2.Generated.Binary
{
  internal partial class OBOA: Round2.BinaryInitializable
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

      public void Convert(byte[] data)
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
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_M3GA_link_0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+4];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_OBAN_link_4 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+8];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_ENVP_link_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+12];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+16];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+20];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_14 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+24];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+28];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+32];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_20 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+36];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_24 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+40];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_28 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+44];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_2C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+48];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_30 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+52];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_34 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+56];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_38 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+60];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_3C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+64];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_40 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+68];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_44 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+72];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_48 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+76];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_4C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+80];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_50 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+84];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_54 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+88];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_58 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+92];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_5C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+96];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_60 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+100];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_64 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+104];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_68 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+108];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_6C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<64; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+112];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Name_70 = (System.String)BinaryDatReader.l_str(l_bytes, 64);
}
}
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<64; i++)
         {
             l_bytes[i] = data[i + 32+j * 240+176];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_B0 = (System.String)BinaryDatReader.l_str(l_bytes, 64);
}
}

     }
public partial class Package
{
      /// <summary>
      ///Link to the Geometry Array
      /// </summary>
      public Link<M3GA> m_M3GA_link_0 =  new Link<M3GA>();
      /// <summary>
      ///Link to the Object Animation
      /// </summary>
      public Link<OBAN> m_OBAN_link_4 =  new Link<OBAN>();
      /// <summary>
      ///Link to the Environment Particle Array
      /// </summary>
      public Link<ENVP> m_ENVP_link_8 =  new Link<ENVP>();
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
      public System.Int32 m_Unknown_18;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_1C;
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
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_3C;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_40;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Single m_Unknown_44;
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
      ///Name of the object
      /// </summary>
      public System.String m_Name_70;
      /// <summary>
      ///Unknown; maybe an old development relict
      /// </summary>
      public System.String m_Unknown_B0;
}

  }
}
