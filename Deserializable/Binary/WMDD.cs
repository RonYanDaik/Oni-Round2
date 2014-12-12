namespace Round2.Generated.Binary
{
  internal class WMDD: Round2.BinaryInitializable
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
      ///Title of the main-window
      /// </summary>
      public System.String m_Window_title_8;
      /// <summary>
      ///Id of the main-window
      /// </summary>
      public System.Int32 m_Window_id_108;
      /// <summary>
      ///Status of the main-window
      /// </summary>
      public System.Int32 m_Window_status_10C;
      /// <summary>
      ///Design of the main-window
      /// </summary>
      public System.Int16 m_Window_design_110;
      /// <summary>
      ///Position of the main-window
      /// </summary>
      public System.Int16 m_Window_position_112;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_114;
      /// <summary>
      ///x-dimension of the main-window
      /// </summary>
      public System.Int16 m_Width_118;
      /// <summary>
      ///y-dimension of the main-window
      /// </summary>
      public System.Int16 m_Height_11A;
      /// <summary>
      ///Amount of packages that follow
      /// </summary>
      public System.Int32 m_Packages_11C;
      /// <summary>
      ///Field for package container
      /// </summary>
      public Package[] m_pkg_120;

      public void Convert(byte[] data)
      {
          byte[] l_bytes = new byte[256];
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
         for(int i=0; i<256; i++)
         {
             l_bytes[i] = data[i + 8];
         }
         this.m_Window_title_8 = (System.String)BinaryDatReader.l_str(l_bytes, 256);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 264];
         }
         this.m_Window_id_108 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 268];
         }
         this.m_Window_status_10C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 272];
         }
         this.m_Window_design_110 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 274];
         }
         this.m_Window_position_112 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 276];
         }
         this.m_Unknown_114 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 280];
         }
         this.m_Width_118 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 282];
         }
         this.m_Height_11A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 284];
         }
         this.m_Packages_11C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<256; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Caption_0 = (System.String)BinaryDatReader.l_str(l_bytes, 256);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+256];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Type_100 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+258];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Target_id_102 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+260];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Option_104 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+262];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Unknown_106 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+264];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Window_design_108 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+266];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Visible_option_10A = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+268];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_x_position_10C = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+270];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_y_position_10E = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+272];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Width_110 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+274];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Height_112 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+276];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_TSFF_link_114 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+280];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Font_option_118 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+284];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Font_color_B_11C = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+285];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Font_color_G_11D = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+286];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Font_color_R_11E = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<1; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+287];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Unknown_11F = (System.Byte)BinaryDatReader.l_int8(l_bytes, 1);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+288];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Unknown_120 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_120 = new Package[this.m_Packages_11C];
for (int j=0;j<this.m_Packages_11C;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 288+j * 292+290];
         }
{
Package l_pkg;
l_pkg = m_pkg_120[j] == null ?  m_pkg_120[j] = new Package() :   m_pkg_120[j];
l_pkg.m_Font_size_122 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}

     }
public class Package
{
      /// <summary>
      ///Caption of the sub-window
      /// </summary>
      public System.String m_Caption_0;
      /// <summary>
      ///Type
      /// </summary>
      public System.Int16 m_Type_100;
      /// <summary>
      ///Id of the target
      /// </summary>
      public System.Int16 m_Target_id_102;
      /// <summary>
      ///Option
      /// </summary>
      public System.Int16 m_Option_104;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_106;
      /// <summary>
      ///Design of the sub-window
      /// </summary>
      public System.Int16 m_Window_design_108;
      /// <summary>
      ///Visible option of the sub-window
      /// </summary>
      public System.Int16 m_Visible_option_10A;
      /// <summary>
      ///x-position of the sub-window (from the upper left corner of the main-window)
      /// </summary>
      public System.Int16 m_x_position_10C;
      /// <summary>
      ///y-position of the sub-window (from the upper left corner of the main-window)
      /// </summary>
      public System.Int16 m_y_position_10E;
      /// <summary>
      ///x-dimension of the sub-window
      /// </summary>
      public System.Int16 m_Width_110;
      /// <summary>
      ///y-dimension of the sub-window
      /// </summary>
      public System.Int16 m_Height_112;
      /// <summary>
      ///Link to the Font Family
      /// </summary>
      public Link<TSFF> m_TSFF_link_114 =  new Link<TSFF>();
      /// <summary>
      ///Font option
      /// </summary>
      public System.Int32 m_Font_option_118;
      /// <summary>
      ///Font color - blue part
      /// </summary>
      public System.Byte m_Font_color_B_11C;
      /// <summary>
      ///Font color - green part
      /// </summary>
      public System.Byte m_Font_color_G_11D;
      /// <summary>
      ///Font color - red part
      /// </summary>
      public System.Byte m_Font_color_R_11E;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Byte m_Unknown_11F;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_120;
      /// <summary>
      ///Font size
      /// </summary>
      public System.Int16 m_Font_size_122;
}

  }
}
