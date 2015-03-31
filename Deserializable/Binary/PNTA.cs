namespace Round2.Generated.Binary
{
  internal partial class PNTA: Round2.BinaryInitializable
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
      ///Minimum x-coordinate of all packages below
      /// </summary>
      public System.Single m_Minimum_x_coordinate_14;
      /// <summary>
      ///Minimum y-coordinate (height) of all packages below
      /// </summary>
      public System.Single m_Minimum_y_coordinate_18;
      /// <summary>
      ///Minimum z-coordinate of all packages below
      /// </summary>
      public System.Single m_Minimum_z_coordinate_1C;
      /// <summary>
      ///Maximum x-coordinate of all packages below
      /// </summary>
      public System.Single m_Maximum_x_coordinate_20;
      /// <summary>
      ///Maximum y-coordinate (height) of all packages below
      /// </summary>
      public System.Single m_Maximum_y_coordinate_24;
      /// <summary>
      ///Maximum z-coordinate of all packages below
      /// </summary>
      public System.Single m_Maximum_z_coordinate_28;
      /// <summary>
      ///x-coordinate of the center [ (max. x-coord. - min. x-coord.) � 2) + min. x-coord. ]
      /// </summary>
      public System.Single m_Center_x_coordinate_2C;
      /// <summary>
      ///y-coordinate of the center [ (max. y-coord. - min. y-coord.) � 2) + min. y-coord. ]
      /// </summary>
      public System.Single m_Center_y_coordinate_30;
      /// <summary>
      ///z-coordinate of the center [ (max. z-coord. - min. z-coord.) � 2) + min. z-coord. ]
      /// </summary>
      public System.Single m_Center_z_coordinate_34;
      /// <summary>
      ///Distance from the center to each of the both points above
      /// </summary>
      public System.Single m_Distance_38;
      /// <summary>
      ///Amount of packages that follow
      /// </summary>
      public System.Int32 m_Packages_3C;
      /// <summary>
      ///Field for package container
      /// </summary>
      public Package[] m_pkg_40;

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
             l_bytes[i] = data[i + 20];
         }
         this.m_Minimum_x_coordinate_14 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 24];
         }
         this.m_Minimum_y_coordinate_18 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 28];
         }
         this.m_Minimum_z_coordinate_1C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 32];
         }
         this.m_Maximum_x_coordinate_20 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 36];
         }
         this.m_Maximum_y_coordinate_24 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 40];
         }
         this.m_Maximum_z_coordinate_28 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 44];
         }
         this.m_Center_x_coordinate_2C = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 48];
         }
         this.m_Center_y_coordinate_30 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 52];
         }
         this.m_Center_z_coordinate_34 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 56];
         }
         this.m_Distance_38 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 60];
         }
         this.m_Packages_3C = (System.Int32)BinaryDatReader.l_int32(l_bytes, 4);
m_pkg_40 = new Package[this.m_Packages_3C];
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64+j * 12+0];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_x_coordinate_0 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64+j * 12+4];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_y_coordinate_4 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}
for (int j=0;j<this.m_Packages_3C;j++)
{         for(int i=0; i<4; i++)
         {
             l_bytes[i] = data[i + 64+j * 12+8];
         }
{
Package l_pkg;
l_pkg = m_pkg_40[j] == null ?  m_pkg_40[j] = new Package() :   m_pkg_40[j];
l_pkg.m_z_coordinate_8 = (System.Single)BinaryDatReader.l_float(l_bytes, 4);
}
}

     }
public partial class Package
{
      /// <summary>
      ///x-coordinate of the point
      /// </summary>
      public System.Single m_x_coordinate_0;
      /// <summary>
      ///y-coordinate (height) of the point
      /// </summary>
      public System.Single m_y_coordinate_4;
      /// <summary>
      ///z-coordinate of the point
      /// </summary>
      public System.Single m_z_coordinate_8;
}

  }
}
