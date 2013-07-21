using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FirebirdSql.Data.FirebirdClient;
using System.IO;

namespace FireBirdHelper
{
    class Helper
    {
        private static Helper helper = new Helper();
        private FbConnection cn ;
        private Helper(){
            FbConnectionStringBuilder cs = new FbConnectionStringBuilder();
            cs.DataSource = "127.0.0.1";
            cs.Database = @"C:\HOUSENUMBER.FDB";
            cs.UserID = "sysdba";
            cs.Password = "masterkey";
            //Console.WriteLine(Directory.GetFiles(@"../").ToString());
            //cs.Dialect = 1;
            cn = new FbConnection();
            cn.ConnectionString = cs.ToString();
            cn.Open();
        }
        public static Helper getInstance()
        {
            if(helper == null){
                helper = new Helper();
            }
            return helper;
        }

        public void destroy()
        {
            if (cn != null)
            {
                cn.Close();
            }
        }

        public void delete(int areaNo, int buildingNumber, String roomName)
        {
            FbCommand cmd = cn.CreateCommand();
            String sql = "delete from ROOM where AREANO = " + areaNo + " and BUILDINGNUMBER = " + buildingNumber + " and NAME = '" + roomName+"'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public void add(RoomBean bean)
        {
            String sql ="INSERT INTO ROOM (NAME, BUILDINGNUMBER, FLOOR, ACTUALAREA, PUBLICAREA, TOTALAREA, PUBLICRATIO, UNDERNUMBER, UNDERNAME, UNDERFLOOR,"+
            "UNDERACTUAL, UNDERPUBLIC, UNDERTOTAL, ISRESERVED, ISTOKEN, BUILDINGLEVEL, AREANO)"
                    + "VALUES ('" +
                    bean.getName() + "', " +
                    bean.getBuildingNumber() + ", " +
                    bean.getFloor()+ ", " +
                    bean.getActualArea()+ ", " +
                    bean.getPublicArea()+", " + 
                    bean.getTotalArea()+ ", " + 
                    bean.getPublicRatio()+ ", '" + 
                    bean.getUnderNumber() + "', '" + 
                    bean.getUnderName() + "', " + 
                    bean.getUnderFloor() + ", " + 
                    bean.getUnderActual()+ ", " + 
                    bean.getUnderPublic() + ", " + 
                    bean.getUnderTotal() + ", " + 
                    bean.getIsReserved()+ ", " + 
                    bean.getIsToken()+ ", " + 

                    bean.getBuildingLevel()+ ", " + 
                    bean.getAreaNo() + ")";
            
            FbCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

        }

        public List<RoomBean> find(float min, float max, int reserved, int token, int buildingNumber, int floor, 
            int buildingLevel, int areaNo)
        {
            FbCommand cmd = cn.CreateCommand();
            String sql = "select * from ROOM where 1=1";
            if (min > 0.0 && max > 0.0)
            {
                sql += " and TotalArea >= " + min + " and TotalArea < " + max;
            }
            if (reserved == 1 || reserved == 0)
            {
                sql += " and IsReserved = " + reserved;
            }
            if (token == 0 || token == 1)
            {
                sql += " and IsToken = " + token;
            }
            if (buildingNumber > 0)
            {
                sql += " and BuildingNumber = " + buildingNumber;
            }
            if (floor > 0)
            {
                sql += " and Floor = " + floor;
            }
            if (buildingLevel > 0)
            {
                sql += " and BUILDINGLEVEL = " + buildingLevel;
            }
            if (areaNo > 0)
            {
                sql += " and AREANO = " + areaNo;
            }
            cmd.CommandText = sql;
            Console.WriteLine(sql);
            List<RoomBean> ret = new List<RoomBean>();
            using (FbDataReader reader = cmd.ExecuteReader()){
                while (reader.Read())
                {
                    ret.Add(buildRoomBean(reader));
                }
            }
            return ret;
        }

        public List<RoomBean> find(float min, float max, int reserved, int token, int buildingNumber, int floor
            )
        {
            FbCommand cmd = cn.CreateCommand();
            String sql = "select * from ROOM where 1=1";
            if (min > 0.0 && max > 0.0)
            {
                sql += " and TotalArea >= " + min + " and TotalArea < " + max;
            }
            if (reserved == 1 || reserved == 0)
            {
                sql += " and IsReserved = " + reserved;
            }
            if (token == 0 || token == 1)
            {
                sql += " and IsToken = " + token;
            }
            if (buildingNumber > 0)
            {
                sql += " and BuildingNumber = " + buildingNumber;
            }
            if (floor > 0)
            {
                sql += " and Floor = " + floor;
            }
            
            cmd.CommandText = sql;
            Console.WriteLine(sql);
            List<RoomBean> ret = new List<RoomBean>();
            using (FbDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ret.Add(buildRoomBean(reader));
                }
            }
            return ret;
        }

        private RoomBean buildRoomBean(FbDataReader reader)
        {
            RoomBean bean = new RoomBean();
            bean.setName((String)reader["NAME"]);
            bean.setBuildingNumber((int)(long)reader["BUILDINGNUMBER"]);
            bean.setFloor((int)(long)reader["FLOOR"]);
            bean.setActualArea((float)reader["ACTUALAREA"]);
            bean.setPublicArea((float)reader["PUBLICAREA"]);
            bean.setTotalArea((float)reader["TOTALAREA"]);
            bean.setPublicRatio((float)reader["PUBLICRATIO"]);
            
            
            try
            {
                bean.setBuildingLevel((int)(long)reader["BUILDINGLEVEL"]);
            }
            catch (Exception e)
            {
            }
            try
            {
                
                bean.setAreaNo((int)(long)reader["AREANO"]);
            }
            catch (Exception e)
            {
            }

            try
            {
                bean.setUnderName((String)reader["UNDERNAME"]);
            }
            catch (Exception e)
            {
            }
            try
            {
                bean.setUnderFloor((int)(long)reader["UNDERFLOOR"]);
            }
            catch (Exception e)
            {
            }
            try
            {
                bean.setUnderActual((float)reader["UNDERACTUAL"]);
            }
            catch (Exception e)
            {
            }
            try
            {
                bean.setUnderPublic((float)reader["UNDERPUBLIC"]);
            }
            catch (Exception e)
            {
            }
            try
            {
                bean.setUnderTotal((float)reader["UNDERTOTAL"]);
            }
            catch (Exception e)
            {
            }
            try
            {
                bean.setIsReserved((int)(long)reader["ISRESERVED"]);
            }
            catch (Exception e)
            {
            }
            try
            {
                bean.setIsToken((int)(long)reader["ISTOKEN"]);
            }
            catch (Exception e)
            {
            }
            try
            {
                bean.setOwner((String)reader["OWNER"]);
            }
            catch (Exception e)
            {
            }
            return bean;
        }

        public void update(RoomBean bean)
        {
            FbCommand cm = new FbCommand();
            cm.Connection = cn;
            String sql = "update ROOM set ISRESERVED = " 
                + bean.getIsReserved() + ", ISTOKEN = " 
                + bean.getIsToken() 
                + " where NAME = '"+ bean.getName() + "' and AREANO = "+ bean.getAreaNo()
                + " and BUILDINGNUMBER = " + bean.getBuildingNumber();
            Console.WriteLine(sql);
            cm.CommandType = System.Data.CommandType.Text;
            cm.CommandText = sql;
            cm.ExecuteNonQuery();
            
        }

        public void updateAll(RoomBean bean)
        {
            FbCommand cm = new FbCommand();
            cm.Connection = cn;
            String sql = "update ROOM set "
                + "NAME = '" + bean.getName()
                + "',BUILDINGNUMBER = " + bean.getBuildingNumber()
                + ",FLOOR = " + bean.getFloor()
                + ",ACTUALAREA = " + bean.getActualArea()
                + ",PUBLICAREA = " + bean.getPublicArea()
                + ",TOTALAREA = " + bean.getTotalArea()
                + ",PUBLICRATIO = " + bean.getPublicRatio()
                + ",UNDERNUMBER = '" + bean.getUnderNumber()
                + "',UNDERNAME = '" + bean.getUnderName()
                + "',UNDERFLOOR = " + bean.getUnderFloor()
                + ",UNDERACTUAL = " + bean.getUnderActual()
                + ",UNDERPUBLIC = " + bean.getUnderPublic()
                + ",UNDERTOTAL = " + bean.getUnderTotal()
                + ",ISRESERVED = " + bean.getIsReserved()
                + ",BUILDINGLEVEL = "+ bean.getBuildingLevel()
                + ",AREANO = " + bean.getAreaNo()
                + ", ISTOKEN = "+ bean.getIsToken()

                + " where NAME = '" + bean.getName() + "' and AREANO = "+ bean.getAreaNo() 
                + " and BUILDINGNUMBER = " + bean.getBuildingNumber();
            Console.WriteLine(sql);
            cm.CommandType = System.Data.CommandType.Text;
            cm.CommandText = sql;
            cm.ExecuteNonQuery();

        }

        public RoomBean getRoomBean(string name, int building)
        {
            RoomBean room = new RoomBean();
            FbCommand cm = new FbCommand();
            cm.Connection = cn;
            String sql = "select * from ROOM where NAME = '" + name
                            + "' and BUILDINGNUMBER = " + building;
            cm.CommandType = System.Data.CommandType.Text;
            cm.CommandText = sql;

            
            using (FbDataReader reader = cm.ExecuteReader())
            {
                while (reader.Read())
                {
                    room = buildRoomBean(reader);
                }
            }
            return room;
        }

        public RoomBean getRoomBean(string name, int building, int buildingLevel, int areaNo )
        {
            RoomBean room = new RoomBean();
            FbCommand cm = new FbCommand();
            cm.Connection = cn;
            String sql = "select * from ROOM where NAME = '" + name
                            + "' and BUILDINGNUMBER = " + building;
            if (buildingLevel > 0)
            {
                sql += " and BUILDINGLEVEL = " + buildingLevel;
            }
            if (areaNo > 0)
            {
                sql += " and AREANO = " + areaNo;
            }
            cm.CommandType = System.Data.CommandType.Text;
            cm.CommandText = sql;


            using (FbDataReader reader = cm.ExecuteReader())
            {
                while (reader.Read())
                {
                    room = buildRoomBean(reader);
                }
            }
            return room;
        }

        public void update(String name,int buildingNumber, int reserved, int token)
        {
            FbCommand cm = new FbCommand();
            cm.Connection = cn;
            String sql = "update ROOM set ISRESERVED = " + reserved + ", ISTOKEN = " + token + " where NAME = '" + name + 
                 "' and BUILDINGNUMBER = " + buildingNumber  ;
            cm.CommandType = System.Data.CommandType.Text;
            cm.CommandText = sql;
            cm.ExecuteNonQuery();
            
        }

        public List<SECTION> getSections()
        {

            FbCommand cmd = cn.CreateCommand();
            String sql = "select * from AREASECTION";
            
            cmd.CommandText = sql;

            List<SECTION> ret = new List<SECTION>();
            using (FbDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    SECTION bean = new SECTION();
                    bean.setId((long)reader["ID"]);
                    bean.setMin((float)reader["MINAREA"]);
                    bean.setMax((float)reader["MAXAREA"]);
                    ret.Add(bean);
                }
            }
            return ret;
        }

        public List<int> getBuildingNums()
        {
            FbCommand cmd = cn.CreateCommand();
            String sql = "select distinct(BUILDINGNUMBER) from ROOM";

            cmd.CommandText = sql;

            List<int> ret = new List<int>();
            using (FbDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    long num = (long)reader["BUILDINGNUMBER"];
                    ret.Add((int)num);
                }
            }
            return ret;
        }

    }
}
