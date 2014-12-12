namespace Round2.Generated.Binary
{
  internal class CRSA: Round2.BinaryInitializable
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
      ///Amount of packages that are available
      /// </summary>
      public System.Int32 m_Packages_available_14;
      /// <summary>
      ///Amount of packages that follow
      /// </summary>
      public System.Int32 m_Packages_18;
      /// <summary>
      ///Amount of packages that are possible
      /// </summary>
      public System.Int32 m_Packages_possible_1C;
      /// <summary>
      ///Field for package container
      /// </summary>
      public Package[] m_pkg_20;

      public void Convert(byte[] data)
      {
          byte[] l_bytes = new byte[160];
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
             l_bytes[i] = data[i + 20];
         }
         this.m_Packages_available_14 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_Packages_18 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Packages_possible_1C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<160; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Old_file_name_0 = (System.String)BinaryDatReader.l_str(l_bytes, 160);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+160];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_ONCC_link_A0 = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+164];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_A4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+168];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_A8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+172];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_AC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+176];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_B0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+180];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_B4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+184];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_B8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+188];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_BC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+192];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_C0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+196];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_C4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+200];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Pelvis_x_position_C8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+204];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Pelvis_y_position_CC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+208];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Pelvis_z_position_D0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+212];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_D4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+216];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_D8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+220];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_DC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+224];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_E0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+228];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_E4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+232];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_E8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+236];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_EC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+240];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_F0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+244];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_F4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+248];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_thigh_x_position_F8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+252];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_thigh_y_position_FC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+256];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_thigh_z_position_100 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+260];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_104 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+264];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_108 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+268];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_10C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+272];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_110 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+276];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_114 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+280];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_118 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+284];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_11C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+288];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_120 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+292];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_124 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+296];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_calf_x_position_128 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+300];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_calf_y_position_12C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+304];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_calf_z_position_130 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+308];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_134 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+312];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_138 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+316];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_13C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+320];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_140 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+324];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_144 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+328];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_148 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+332];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_14C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+336];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_150 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+340];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_154 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+344];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_foot_x_position_158 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+348];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_foot_y_position_15C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+352];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_foot_z_position_160 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+356];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_164 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+360];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_168 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+364];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_16C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+368];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_170 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+372];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_174 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+376];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_178 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+380];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_17C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+384];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_180 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+388];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_184 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+392];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_thigh_x_position_188 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+396];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_thigh_y_position_18C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+400];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_thigh_z_position_190 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+404];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_194 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+408];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_198 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+412];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_19C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+416];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_1A0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+420];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_1A4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+424];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_1A8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+428];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_1AC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+432];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_1B0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+436];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_1B4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+440];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_calf_x_position_1B8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+444];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_calf_y_position_1BC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+448];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_calf_z_position_1C0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+452];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_1C4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+456];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_1C8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+460];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_1CC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+464];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_1D0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+468];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_1D4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+472];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_1D8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+476];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_1DC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+480];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_1E0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+484];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_1E4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+488];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_foot_x_position_1E8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+492];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_foot_y_position_1EC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+496];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_foot_z_position_1F0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+500];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_1F4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+504];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_1F8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+508];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_1FC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+512];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_200 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+516];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_204 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+520];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_208 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+524];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_20C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+528];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_210 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+532];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_214 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+536];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Mid_x_position_218 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+540];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Mid_y_position_21C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+544];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Mid_z_position_220 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+548];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_224 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+552];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_228 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+556];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_22C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+560];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_230 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+564];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_234 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+568];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_238 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+572];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_23C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+576];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_240 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+580];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_244 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+584];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Chest_x_position_248 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+588];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Chest_y_position_24C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+592];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Chest_z_position_250 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+596];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_254 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+600];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_258 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+604];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_25C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+608];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_260 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+612];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_264 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+616];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_268 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+620];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_26C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+624];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_270 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+628];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_274 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+632];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Neck_x_position_278 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+636];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Neck_y_position_27C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+640];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Neck_z_position_280 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+644];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_284 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+648];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_288 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+652];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_28C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+656];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_290 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+660];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_294 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+664];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_298 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+668];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_29C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+672];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_2A0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+676];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_2A4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+680];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Head_x_position_2A8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+684];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Head_y_position_2AC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+688];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Head_z_position_2B0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+692];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_2B4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+696];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_2B8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+700];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_2BC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+704];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_2C0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+708];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_2C4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+712];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_2C8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+716];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_2CC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+720];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_2D0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+724];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_2D4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+728];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_shoulder_x_position_2D8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+732];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_shoulder_y_position_2DC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+736];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_shoulder_z_position_2E0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+740];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_2E4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+744];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_2E8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+748];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_2EC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+752];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_2F0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+756];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_2F4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+760];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_2F8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+764];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_2FC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+768];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_300 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+772];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_304 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+776];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_bicep_x_position_308 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+780];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_bicep_y_position_30C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+784];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_bicep_z_position_310 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+788];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_314 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+792];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_318 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+796];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_31C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+800];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_320 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+804];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_324 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+808];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_328 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+812];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_32C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+816];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_330 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+820];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_334 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+824];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_wrist_x_position_338 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+828];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_wrist_y_position_33C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+832];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_wrist_z_position_340 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+836];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_344 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+840];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_348 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+844];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_34C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+848];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_350 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+852];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_354 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+856];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_358 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+860];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_35C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+864];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_360 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+868];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_364 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+872];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_hand_x_position_368 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+876];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_hand_y_position_36C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+880];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Left_hand_z_position_370 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+884];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_374 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+888];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_378 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+892];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_37C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+896];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_380 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+900];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_384 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+904];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_388 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+908];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_38C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+912];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_390 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+916];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_394 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+920];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_shoulder_x_position_398 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+924];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_shoulder_y_position_39C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+928];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_shoulder_z_position_3A0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+932];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_3A4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+936];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_3A8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+940];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_3AC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+944];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_3B0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+948];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_3B4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+952];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_3B8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+956];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_3BC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+960];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_3C0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+964];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_3C4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+968];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_bicep_x_position_3C8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+972];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_bicep_y_position_3CC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+976];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_bicep_z_position_3D0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+980];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_3D4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+984];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_3D8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+988];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_3DC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+992];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_3E0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+996];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_3E4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1000];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_3E8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1004];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_3EC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1008];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_3F0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1012];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_3F4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1016];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_wrist_x_position_3F8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1020];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_wrist_y_position_3FC = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1024];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_wrist_z_position_400 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1028];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_x_coordinate_404 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1032];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_y_coordinate_408 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1036];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_1st_point_z_coordinate_40C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1040];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_x_coordinate_410 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1044];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_y_coordinate_414 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1048];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_2nd_point_z_coordinate_418 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1052];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_x_coordinate_41C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1056];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_y_coordinate_420 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1060];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_3rd_point_z_coordinate_424 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1064];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_hand_x_position_428 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1068];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_hand_y_position_42C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1072];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Right_hand_z_position_430 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1076];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Minimal_x_coordinate_434 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1080];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Minimal_y_coordinate_438 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1084];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Minimal_z_coordinate_43C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1088];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Maximal_x_coordinate_440 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1092];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Maximal_y_coordinate_444 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
m_pkg_20 = new Package[this.m_Packages_18];
for (int j=0;j<this.m_Packages_18;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32+j * 1100+1096];
         }
{
Package l_pkg;
l_pkg = m_pkg_20[j] == null ?  m_pkg_20[j] = new Package() :   m_pkg_20[j];
l_pkg.m_Maximal_z_coordinate_448 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}

     }
public class Package
{
      /// <summary>
      ///Old file name
      /// </summary>
      public System.String m_Old_file_name_0;
      /// <summary>
      ///Link to the Character Class
      /// </summary>
      public Link<ONCC> m_ONCC_link_A0 =  new Link<ONCC>();
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_A4;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_A8;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_AC;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_B0;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_B4;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_B8;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_BC;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_C0;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_C4;
      /// <summary>
      ///x-position of the pelvis
      /// </summary>
      public System.Single m_Pelvis_x_position_C8;
      /// <summary>
      ///y-position (height) of the pelvis
      /// </summary>
      public System.Single m_Pelvis_y_position_CC;
      /// <summary>
      ///z-position of the pelvis
      /// </summary>
      public System.Single m_Pelvis_z_position_D0;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_D4;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_D8;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_DC;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_E0;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_E4;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_E8;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_EC;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_F0;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_F4;
      /// <summary>
      ///x-position of the left thigh
      /// </summary>
      public System.Single m_Left_thigh_x_position_F8;
      /// <summary>
      ///y-position (height) of the left thigh
      /// </summary>
      public System.Single m_Left_thigh_y_position_FC;
      /// <summary>
      ///z-position of the left thigh
      /// </summary>
      public System.Single m_Left_thigh_z_position_100;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_104;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_108;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_10C;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_110;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_114;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_118;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_11C;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_120;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_124;
      /// <summary>
      ///x-position of the left calf
      /// </summary>
      public System.Single m_Left_calf_x_position_128;
      /// <summary>
      ///y-position (height) of the left calf
      /// </summary>
      public System.Single m_Left_calf_y_position_12C;
      /// <summary>
      ///z-position of the left calf
      /// </summary>
      public System.Single m_Left_calf_z_position_130;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_134;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_138;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_13C;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_140;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_144;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_148;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_14C;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_150;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_154;
      /// <summary>
      ///x-position of the left foot
      /// </summary>
      public System.Single m_Left_foot_x_position_158;
      /// <summary>
      ///y-position (height) of the left foot
      /// </summary>
      public System.Single m_Left_foot_y_position_15C;
      /// <summary>
      ///z-position of the left foot
      /// </summary>
      public System.Single m_Left_foot_z_position_160;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_164;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_168;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_16C;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_170;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_174;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_178;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_17C;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_180;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_184;
      /// <summary>
      ///x-position of the right thigh
      /// </summary>
      public System.Single m_Right_thigh_x_position_188;
      /// <summary>
      ///y-position (height) of the right thigh
      /// </summary>
      public System.Single m_Right_thigh_y_position_18C;
      /// <summary>
      ///z-position of the right thigh
      /// </summary>
      public System.Single m_Right_thigh_z_position_190;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_194;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_198;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_19C;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_1A0;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_1A4;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_1A8;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_1AC;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_1B0;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_1B4;
      /// <summary>
      ///x-position of the right calf
      /// </summary>
      public System.Single m_Right_calf_x_position_1B8;
      /// <summary>
      ///y-position (height) of the right calf
      /// </summary>
      public System.Single m_Right_calf_y_position_1BC;
      /// <summary>
      ///z-position of the right calf
      /// </summary>
      public System.Single m_Right_calf_z_position_1C0;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_1C4;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_1C8;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_1CC;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_1D0;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_1D4;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_1D8;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_1DC;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_1E0;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_1E4;
      /// <summary>
      ///x-position of the right foot
      /// </summary>
      public System.Single m_Right_foot_x_position_1E8;
      /// <summary>
      ///y-position (height) of the right foot
      /// </summary>
      public System.Single m_Right_foot_y_position_1EC;
      /// <summary>
      ///z-position of the right foot
      /// </summary>
      public System.Single m_Right_foot_z_position_1F0;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_1F4;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_1F8;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_1FC;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_200;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_204;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_208;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_20C;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_210;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_214;
      /// <summary>
      ///x-position of the mid
      /// </summary>
      public System.Single m_Mid_x_position_218;
      /// <summary>
      ///y-position (height) of the mid
      /// </summary>
      public System.Single m_Mid_y_position_21C;
      /// <summary>
      ///z-position of the mid
      /// </summary>
      public System.Single m_Mid_z_position_220;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_224;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_228;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_22C;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_230;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_234;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_238;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_23C;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_240;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_244;
      /// <summary>
      ///x-position of the chest
      /// </summary>
      public System.Single m_Chest_x_position_248;
      /// <summary>
      ///y-position (height) of the chest
      /// </summary>
      public System.Single m_Chest_y_position_24C;
      /// <summary>
      ///z-position of the chest
      /// </summary>
      public System.Single m_Chest_z_position_250;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_254;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_258;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_25C;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_260;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_264;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_268;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_26C;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_270;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_274;
      /// <summary>
      ///x-position of the neck
      /// </summary>
      public System.Single m_Neck_x_position_278;
      /// <summary>
      ///y-position (height) of the neck
      /// </summary>
      public System.Single m_Neck_y_position_27C;
      /// <summary>
      ///z-position of the neck
      /// </summary>
      public System.Single m_Neck_z_position_280;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_284;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_288;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_28C;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_290;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_294;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_298;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_29C;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_2A0;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_2A4;
      /// <summary>
      ///x-position of the head
      /// </summary>
      public System.Single m_Head_x_position_2A8;
      /// <summary>
      ///y-position (height) of the head
      /// </summary>
      public System.Single m_Head_y_position_2AC;
      /// <summary>
      ///z-position of the head
      /// </summary>
      public System.Single m_Head_z_position_2B0;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_2B4;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_2B8;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_2BC;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_2C0;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_2C4;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_2C8;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_2CC;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_2D0;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_2D4;
      /// <summary>
      ///x-position of the left shoulder
      /// </summary>
      public System.Single m_Left_shoulder_x_position_2D8;
      /// <summary>
      ///y-position (height) of the left shoulder
      /// </summary>
      public System.Single m_Left_shoulder_y_position_2DC;
      /// <summary>
      ///z-position of the left shoulder
      /// </summary>
      public System.Single m_Left_shoulder_z_position_2E0;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_2E4;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_2E8;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_2EC;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_2F0;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_2F4;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_2F8;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_2FC;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_300;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_304;
      /// <summary>
      ///x-position of the left bicep
      /// </summary>
      public System.Single m_Left_bicep_x_position_308;
      /// <summary>
      ///y-position (height) of the left bicep
      /// </summary>
      public System.Single m_Left_bicep_y_position_30C;
      /// <summary>
      ///z-position of the left bicep
      /// </summary>
      public System.Single m_Left_bicep_z_position_310;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_314;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_318;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_31C;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_320;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_324;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_328;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_32C;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_330;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_334;
      /// <summary>
      ///x-position of the left wrist
      /// </summary>
      public System.Single m_Left_wrist_x_position_338;
      /// <summary>
      ///y-position (height) of the left wrist
      /// </summary>
      public System.Single m_Left_wrist_y_position_33C;
      /// <summary>
      ///z-position of the left wrist
      /// </summary>
      public System.Single m_Left_wrist_z_position_340;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_344;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_348;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_34C;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_350;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_354;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_358;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_35C;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_360;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_364;
      /// <summary>
      ///x-position of the left hand
      /// </summary>
      public System.Single m_Left_hand_x_position_368;
      /// <summary>
      ///y-position (height) of the left hand
      /// </summary>
      public System.Single m_Left_hand_y_position_36C;
      /// <summary>
      ///z-position of the left hand
      /// </summary>
      public System.Single m_Left_hand_z_position_370;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_374;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_378;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_37C;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_380;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_384;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_388;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_38C;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_390;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_394;
      /// <summary>
      ///x-position of the right shoulder
      /// </summary>
      public System.Single m_Right_shoulder_x_position_398;
      /// <summary>
      ///y-position (height) of the right shoulder
      /// </summary>
      public System.Single m_Right_shoulder_y_position_39C;
      /// <summary>
      ///z-position of the right shoulder
      /// </summary>
      public System.Single m_Right_shoulder_z_position_3A0;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_3A4;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_3A8;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_3AC;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_3B0;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_3B4;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_3B8;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_3BC;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_3C0;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_3C4;
      /// <summary>
      ///x-position of the right bicep
      /// </summary>
      public System.Single m_Right_bicep_x_position_3C8;
      /// <summary>
      ///y-position (height) of the right bicep
      /// </summary>
      public System.Single m_Right_bicep_y_position_3CC;
      /// <summary>
      ///z-position of the right bicep
      /// </summary>
      public System.Single m_Right_bicep_z_position_3D0;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_3D4;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_3D8;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_3DC;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_3E0;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_3E4;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_3E8;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_3EC;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_3F0;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_3F4;
      /// <summary>
      ///x-position of the right wrist
      /// </summary>
      public System.Single m_Right_wrist_x_position_3F8;
      /// <summary>
      ///y-position (height) of the right wrist
      /// </summary>
      public System.Single m_Right_wrist_y_position_3FC;
      /// <summary>
      ///z-position of the right wrist
      /// </summary>
      public System.Single m_Right_wrist_z_position_400;
      /// <summary>
      ///x-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_x_coordinate_404;
      /// <summary>
      ///y-position (height) of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_y_coordinate_408;
      /// <summary>
      ///z-position of the 1st point of an equilateral triangle
      /// </summary>
      public System.Single m_1st_point_z_coordinate_40C;
      /// <summary>
      ///x-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_x_coordinate_410;
      /// <summary>
      ///y-position (height) of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_y_coordinate_414;
      /// <summary>
      ///z-position of the 2nd point of an equilateral triangle
      /// </summary>
      public System.Single m_2nd_point_z_coordinate_418;
      /// <summary>
      ///x-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_x_coordinate_41C;
      /// <summary>
      ///y-position (height) of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_y_coordinate_420;
      /// <summary>
      ///z-position of the 3rd point of an equilateral triangle
      /// </summary>
      public System.Single m_3rd_point_z_coordinate_424;
      /// <summary>
      ///x-position of the right hand
      /// </summary>
      public System.Single m_Right_hand_x_position_428;
      /// <summary>
      ///y-position (height) of the right hand
      /// </summary>
      public System.Single m_Right_hand_y_position_42C;
      /// <summary>
      ///z-position of the right hand
      /// </summary>
      public System.Single m_Right_hand_z_position_430;
      /// <summary>
      ///Minimal x-coordinate of the bounding box
      /// </summary>
      public System.Single m_Minimal_x_coordinate_434;
      /// <summary>
      ///Minimal y-coordinate (height) of the bounding box
      /// </summary>
      public System.Single m_Minimal_y_coordinate_438;
      /// <summary>
      ///Minimal z-coordinate of the bounding box
      /// </summary>
      public System.Single m_Minimal_z_coordinate_43C;
      /// <summary>
      ///Maximal x-coordinate of the bounding box
      /// </summary>
      public System.Single m_Maximal_x_coordinate_440;
      /// <summary>
      ///Maximal y-coordinate (height) of the bounding box
      /// </summary>
      public System.Single m_Maximal_y_coordinate_444;
      /// <summary>
      ///Maximal z-coordinate of the bounding box
      /// </summary>
      public System.Single m_Maximal_z_coordinate_448;
}

  }
}
