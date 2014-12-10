namespace Round2.Generated.Binary
{
  internal class TSFT: Round2.BinaryInitializable
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
      public System.Int16 m_Unknown_E;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_10;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_14;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_16;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_18;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_1A;
      /// <summary>
      ///Link to the Glyph Array
      /// </summary>
      public System.Int32 m_TSGA_link_1C;
      /// <summary>
      ///Not used
      /// </summary>
      public System.Int32 m_Not_used_20;
      /// <summary>
      ///Amount of packages that follow
      /// </summary>
      public System.Int32 m_Packages_41C;
      /// <summary>
      ///Field for package container
      /// </summary>
      public Package[] m_pkg_420;

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
             l_bytes[i] = data[i + 14];
         }
         this.m_Unknown_E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 16];
         }
         this.m_Unknown_10 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 20];
         }
         this.m_Unknown_14 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 22];
         }
         this.m_Unknown_16 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_Unknown_18 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 26];
         }
         this.m_Unknown_1A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_TSGA_link_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_Not_used_20 = (System.Int32)BinaryDatReader.ConverterStub(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1052];
         }
         this.m_Packages_41C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
m_pkg_420 = new Package[this.m_Packages_41C];
for (int j=0;j<this.m_Packages_41C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 1056+j * 4+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_420[j] == null ?  m_pkg_420[j] = new Package() :   m_pkg_420[j];
l_pkg.m_Unknown_0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}

     }
public class Package
{
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int32 m_Unknown_0;
}

  }
}
