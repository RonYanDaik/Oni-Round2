namespace Round2.Generated.Binary
{
  internal class AISA: Round2.BinaryInitializable
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
          byte[] l_bytes = new byte[32];
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
{         for(int i=0; i<32; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_0 = (System.String)BinaryDatReader.l_str(l_bytes, 32);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+32];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Charcter_id_20 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+34];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Flag_id_22 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+36];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_24 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+38];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_26 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+40];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_ONCC_link_28 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+44];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_2C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<32; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+48];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_30 = (System.String)BinaryDatReader.l_str(l_bytes, 32);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<32; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+80];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Spawn_function_50 = (System.String)BinaryDatReader.l_str(l_bytes, 32);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<32; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+112];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Lose_function_70 = (System.String)BinaryDatReader.l_str(l_bytes, 32);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<32; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+144];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Alert_function_90 = (System.String)BinaryDatReader.l_str(l_bytes, 32);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<32; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+176];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_B0 = (System.String)BinaryDatReader.l_str(l_bytes, 32);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<32; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+208];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Hit_function_D0 = (System.String)BinaryDatReader.l_str(l_bytes, 32);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<32; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+240];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Health___1_function_F0 = (System.String)BinaryDatReader.l_str(l_bytes, 32);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<32; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+272];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Reload_function_110 = (System.String)BinaryDatReader.l_str(l_bytes, 32);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<32; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+304];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_130 = (System.String)BinaryDatReader.l_str(l_bytes, 32);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+340];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_154 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<2; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+342];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_156 = (System.Int16)BinaryDatReader.l_int16(l_bytes, 2);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+344];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_158 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_1E];
for (int j=0;j<this.m_Packages_1E;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 352+348];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Unknown_15C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}

     }
public class Package
{
      /// <summary>
      ///unknown; always zero; maybe space for notes
      /// </summary>
      public System.String m_Unknown_0;
      /// <summary>
      ///Id of the character, which you can spawn with the script command "chr_create"
      /// </summary>
      public System.Int16 m_Charcter_id_20;
      /// <summary>
      ///Od of the flag, where Oni spawns the character (works only, if the flag exits; look to Flag.BINA for a flag list)
      /// </summary>
      public System.Int16 m_Flag_id_22;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_24;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_26;
      /// <summary>
      ///Link to the Character Class
      /// </summary>
      public Link<ONCC> m_ONCC_link_28 =  new Link<ONCC>();
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_2C;
      /// <summary>
      ///Unknown; never used in Oni
      /// </summary>
      public System.String m_Unknown_30;
      /// <summary>
      ///Name of the function, which is called up when Oni spawns the character
      /// </summary>
      public System.String m_Spawn_function_50;
      /// <summary>
      ///Name of the function, which is called up when the character dies
      /// </summary>
      public System.String m_Lose_function_70;
      /// <summary>
      ///Name of the function, which is called up when the character notices the player
      /// </summary>
      public System.String m_Alert_function_90;
      /// <summary>
      ///Unknown; never used in Oni
      /// </summary>
      public System.String m_Unknown_B0;
      /// <summary>
      ///Name of the function, which is called up when someone hits the character the first time
      /// </summary>
      public System.String m_Hit_function_D0;
      /// <summary>
      ///Name of the function, which is called up when the health of the character is equal 1
      /// </summary>
      public System.String m_Health___1_function_F0;
      /// <summary>
      ///Name of the function, which is called up when the character reloads its weapon with its last ammo/cell; works only, if the character has some ammo/cells when Oni spawns it
      /// </summary>
      public System.String m_Reload_function_110;
      /// <summary>
      ///Unknown; never used in Oni
      /// </summary>
      public System.String m_Unknown_130;
      /// <summary>
      ///Unknown
      /// </summary>
      public System.Int16 m_Unknown_154;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int16 m_Unknown_156;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_158;
      /// <summary>
      ///Unknown; always the same
      /// </summary>
      public System.Int32 m_Unknown_15C;
}

  }
}
