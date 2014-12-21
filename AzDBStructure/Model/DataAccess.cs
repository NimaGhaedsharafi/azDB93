using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Model
{
    public class DataAccess
    {
        // constants
        private const int MAX = 20, DELETE = 0, INSERT = 1, UPDATE = 2;

        // table name
        public string tablename;
        
        // table fields and values for sql parameteres
        private Dictionary<String, Object> fields;
        
        // stored procedure
        private string spname;

        private SqlConnection connect;
        private SqlCommand cmd;

        public DataAccess()
        {
            this.connect = new SqlConnection(ConfigurationManager.ConnectionStrings["AzDBStructure.Properties.Settings.musicStoreCS"].ToString());
            this.resetCmd();
            this.overwriteSPname("sp" + this.GetType().Name.ToLower());
            this.fields = new Dictionary<string, object>();
            
            // open connection for every actions at the first
            this.connect.Open();
        }

        public SqlConnection getCn()
        {
            return this.connect;
        }
        public void overwriteSPname(String name)
        {
            this.spname = name;
        }
        public string getSpName()
        {
            return this.spname;
        }
        public void addField(string key, Object val)
        {
            this.fields.Add(key, val);
        }
        public SqlParameter[] populate()
        {
            SqlParameter[] sp = new SqlParameter[this.fields.Count];

            int i = 0;
            foreach (var fil in this.fields)
            {
                if (fil.Value.GetType().IsInstanceOfType(new SqlParameter()))
                {
                    sp[i++] = (SqlParameter) fil.Value;
                }
                else
                {
                    sp[i++] = new SqlParameter("@" + fil.Key, fil.Value);
                }
            }
            return sp;
        }

        // don't forget ro close connection at the end!
        ~DataAccess()
        {
            if(this.connect.State == ConnectionState.Open)
            {
                //this.connect.Close();
            }
        }
        public void insertQuery(string att, string val)
        {
            this.resetCmd();
            cmd.CommandText = "insert into " + this.tablename + "(" + att + ") values(" + val + ")";
            cmd.ExecuteNonQuery();
        }
        public void insertQuery(string att, string val, SqlParameter[] prm)
        {
            this.resetCmd();
            cmd.CommandText = "insert into " + this.tablename + "(" + att + ") values(" + val + ")";
            cmd.Parameters.AddRange(prm);
            cmd.ExecuteNonQuery();
        }

        public void deleteQuery(string cond)
        {
            this.resetCmd();
            cmd.CommandText = "delete  from " + this.tablename + " where(" + cond + ")";
            cmd.ExecuteNonQuery();

        }
        public void updateQuery(string tbname, string attval, string cond)
        {
            this.resetCmd();
            cmd.CommandText = "update " + this.tablename + " set " + attval + " where(" + cond + ")";
            cmd.ExecuteNonQuery();
        }
        public DataTable getQuery()
        {
            this.resetCmd();
            SqlDataAdapter adp = new SqlDataAdapter();
            this.cmd.CommandText = "SELECT * FROM " + this.tablename;
            
            adp.SelectCommand = this.cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public DataTable getQuery(string cond)
        {
            this.resetCmd();
            SqlDataAdapter adp = new SqlDataAdapter();
            this.cmd.CommandText = "SELECT * FROM " + this.tablename + " WHERE " + cond;
            adp.SelectCommand = this.cmd;
            DataTable dt = new DataTable();            
            adp.Fill(dt);
            return dt;
        }
        public void execute()
        {
            this.resetCmd();
            this.cmd.CommandText = this.spname;
            this.cmd.CommandType = CommandType.StoredProcedure;
            this.cmd.Parameters.AddRange(this.populate());
            this.cmd.ExecuteNonQuery();
        }

        public void execute(string spname, SqlParameter[] sparam)
        {
            this.resetCmd();
            cmd.CommandText = spname;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(sparam);
            cmd.ExecuteNonQuery();
        }

        private void addFlagAndExecute(int flag)
        {
            this.fields.Add("flag", flag);
            this.execute();
            this.fields.Remove("flag");
        }
        public void delete()
        {
            addFlagAndExecute(DELETE);
        }
        public void insert()
        {
            addFlagAndExecute(INSERT);
        }
        public void update()
        {
            addFlagAndExecute(UPDATE);
        }

        private void resetCmd()
        {
            this.cmd = new SqlCommand();
            this.cmd.Connection = this.connect;
        }
    }
}
