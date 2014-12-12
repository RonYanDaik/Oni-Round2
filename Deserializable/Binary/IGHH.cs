namespace Round2.Generated.Binary
{
  internal class IGHH: Round2.BinaryInitializable
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
      ///Link to the left HUD image
      /// </summary>
      public Link<TXMP> m_TXMP_link_24 =  new Link<TXMP>();
      /// <summary>
      ///Link to the right HUD image
      /// </summary>
      public Link<TXMP> m_TXMP_link_28 =  new Link<TXMP>();
      /// <summary>
      ///The left HUD image starts 55 pixel from the left screen border
      /// </summary>
      public System.Int32 m_Left_image_position_2C;
      /// <summary>
      ///The right HUD image starts 42 pixel from the right screen border (65535 - 65493 = 42)
      /// </summary>
      public System.Int32 m_Right_image_position_30;
      /// <summary>
      ///Number of words on the left side
      /// </summary>
      public System.Int32 m_Left_words_34;
      /// <summary>
      ///Number of words on the right side
      /// </summary>
      public System.Int32 m_Right_words_38;
      /// <summary>
      ///Amount of word-packages that follow
      /// </summary>
      public System.Int32 m_Packages_3C;
      /// <summary>
      ///Field for package container
      /// </summary>
      public Package[] m_pkg_40;

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
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_TXMP_link_24 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_TXMP_link_28 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_Left_image_position_2C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 48];
         }
         this.m_Right_image_position_30 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 52];
         }
         this.m_Left_words_34 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 56];
         }
         this.m_Right_words_38 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 60];
         }
         this.m_Packages_3C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
m_pkg_40 = new Package[this.m_Packages_3C];
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<64; i++)
         {
             l_bytes[i] = data[i + 64+j * 68+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_Text_field_0 = (System.String)BinaryDatReader.l_str(l_bytes, 64);
}
}
m_pkg_40 = new Package[this.m_Packages_3C];
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 64+j * 68+64];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_Text_x_position_40 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_40 = new Package[this.m_Packages_3C];
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 64+j * 68+66];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_Text_y_position_42 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}

     }
public class Package
{
      /// <summary>
      ///Text field (all entries after the fist 00 are useless)
      /// </summary>
      public System.String m_Text_field_0;
      /// <summary>
      ///x-position of the text (from the left/right border of the HUD image)
      /// </summary>
      public System.Int16 m_Text_x_position_40;
      /// <summary>
      ///y-position of the text (from the top border of the HUD image)
      /// </summary>
      public System.Int16 m_Text_y_position_42;
}

  }
}
