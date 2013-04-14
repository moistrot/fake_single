using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            cs.Database = @"D:\HOUSENUMBER.FDB";
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

        public List<RoomBean> find(float min, float max, int reserved, int token, int buildingNumber, int floor)
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
            Console.WriteLine("++++");
            Console.WriteLine(sql);
            List<RoomBean> ret = new List<RoomBean>();
            using (FbDataReader reader = cmd.ExecuteReader()){
                while (reader.Read())
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
                    ret.Add(bean);
                }
            }
            return ret;
        }

        public void update(RoomBean bean)
        {
            FbCommand cm = new FbCommand();
            cm.Connection = cn;
            String sql = "update ROOM set ISRESERVED = " 
                + bean.getIsReserved() + ", ISTOKEN = " 
                + bean.getIsToken() 
                + " where NAME = '"+ bean.getName() + "'"
                + " and BUILDINGNUMBER = " + bean.getBuildingNumber();
            cm.CommandType = System.Data.CommandType.Text;
            cm.CommandText = sql;
            cm.ExecuteNonQuery();
            
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
