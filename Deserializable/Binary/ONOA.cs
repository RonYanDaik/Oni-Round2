namespace Round2.Generated.Binary
{
  internal partial class ONOA: Round2.BinaryInitializable
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
         this.m_Not_used_8 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Packages_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
m_pkg_20 = new Package[this.m_Packages_1C];
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<3; i++)
         {
             l_bytes[i] = data[i + 32+j * 8+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_obj_id_0 = (System.Int32)BinaryDatReader.l_int24(l_bytes, 3);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 32+j * 8+3];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_High_bit_3 = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
for (int j=0;j<this.m_Packages_1C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 8+4];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_IDXA_link_4 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}

     }
public partial class Package
{
      /// <summary>
      ///object id
      /// </summary>
      public System.Int32 m_obj_id_0;
      /// <summary>
      ///High bit (obj type, see http://wiki.oni2.net/ONOA and http://wiki.oni2.net/OBD:BINA/OBJC#OBJC_types for more info)
      /// </summary>
      public System.Byte m_High_bit_3;
      /// <summary>
      ///Link to the Index Array
      /// </summary>
      public Link<IDXA> m_IDXA_link_4 =  new Link<IDXA>();
}

  }
}
