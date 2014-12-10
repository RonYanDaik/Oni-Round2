namespace Round2.Generated.Binary
{
  internal class ONCP: Round2.BinaryInitializable
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
          byte[] l_bytes = new byte[16];
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
{         for(int i=0; i<16; i++)
         {
             l_bytes[i] = data[i + 32+j * 88+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Particle_name_0 = (System.String)BinaryDatReader.l_str(l_bytes, 16);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 88+16];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Particle_reference_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32+j * 88+80];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Bodypart_50 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32+j * 88+82];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_52 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 88+84];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_54 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}

     }
public class Package
{
      /// <summary>
      ///Name of the particle (all entries after the first 00 are useless)
      /// </summary>
      public System.String m_Particle_name_0;
      /// <summary>
      ///Reference to a BINA file of level 0
      /// </summary>
      public System.Int32 m_Particle_reference_10;
      /// <summary>
      ///Particle is fixed to this bodypart
      /// </summary>
      public System.Int16 m_Bodypart_50;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_52;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_54;
}

  }
}
