namespace Round2.Generated.Binary
{
  internal class TRIA: Round2.BinaryInitializable
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
             l_bytes[i] = data[i + 30];
         }
         this.m_Packages_1E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 4+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Not_used_0 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 4+1];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Major_joint_1 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 4+2];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Minor_joint_2 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 4+3];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Not_used_3 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
}
}

     }
public class Package
{
      /// <summary>
      ///Oni doesn't need it; you can set it to what you want
      /// </summary>
      public System.Int32 m_Not_used_0;
      /// <summary>
      ///Major joint
      /// </summary>
      public System.Byte m_Major_joint_1;
      /// <summary>
      ///Minor joint
      /// </summary>
      public System.Byte m_Minor_joint_2;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_3;
}

  }
}
