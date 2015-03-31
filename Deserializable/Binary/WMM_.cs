namespace Round2.Generated.Binary
{
  internal partial class WMM_: Round2.BinaryInitializable
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
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_1A;
      /// <summary>
      ///Name of the menu
      /// </summary>
      public System.String m_Menu_name_1C;
      /// <summary>
      ///Amount of packages that follow
      /// </summary>
      public System.Int32 m_Packages_5C;
      /// <summary>
      ///Field for package container
      /// </summary>
      public Package[] m_pkg_60;

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
             l_bytes[i] = data[i + 26];
         }
         this.m_Unknown_1A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<64; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Menu_name_1C = (System.String)BinaryDatReader.l_str(l_bytes, 64);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 92];
         }
         this.m_Packages_5C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
m_pkg_60 = new Package[this.m_Packages_5C];
for (int j=0;j<this.m_Packages_5C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 96+j * 68+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_60[j] == null ?  m_pkg_60[j] = new Package() :   m_pkg_60[j];
l_pkg.m_Menu_type_0 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
for (int j=0;j<this.m_Packages_5C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 96+j * 68+2];
         }
{
Package l_pkg;
l_pkg = m_pkg_60[j] == null ?  m_pkg_60[j] = new Package() :   m_pkg_60[j];
l_pkg.m_Return_number_2 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
for (int j=0;j<this.m_Packages_5C;j++)
{         for(int i=0; i<64; i++)
         {
             l_bytes[i] = data[i + 96+j * 68+4];
         }
{
Package l_pkg;
l_pkg = m_pkg_60[j] == null ?  m_pkg_60[j] = new Package() :   m_pkg_60[j];
l_pkg.m_Menu_entry_4 = (System.String)BinaryDatReader.l_str(l_bytes, 64);
}
}

     }
public partial class Package
{
      /// <summary>
      ///Type of the menu
      /// </summary>
      public System.Int16 m_Menu_type_0;
      /// <summary>
      ///Number that returns if you choose this menu point
      /// </summary>
      public System.Int16 m_Return_number_2;
      /// <summary>
      ///Entry of the menu
      /// </summary>
      public System.String m_Menu_entry_4;
}

  }
}
