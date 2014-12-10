namespace Round2.Generated.Binary
{
  internal class TRAC: Round2.BinaryInitializable
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
      ///Link to a shared Animation Collection
      /// </summary>
      public System.Int32 m_TRAC_link_18;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_1C;
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
             l_bytes[i] = data[i + 24];
         }
         this.m_TRAC_link_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Unknown_1C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 30];
         }
         this.m_Packages_1E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 12+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 12+4];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Not_used_4 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 12+8];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_TRAM_link_8 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
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
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_4;
      /// <summary>
      ///Link to the Animation
      /// </summary>
      public System.Int32 m_TRAM_link_8;
}

  }
}
