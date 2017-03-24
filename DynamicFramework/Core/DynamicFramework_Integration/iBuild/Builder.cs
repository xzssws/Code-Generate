using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using iBuild.Entity;

namespace iBuild
{
    public class Builder
    {
        #region 内部辅助

        private static int ToInt(object obj)
        {
            if (obj == null || obj == DBNull.Value) return 0;
            return Convert.ToInt32(obj);
        }

        private static bool ToBool(object obj)
        {
            if (obj == null || obj == DBNull.Value) return false;
            return Convert.ToBoolean(obj);
        }

        private static string ToString(object obj)
        {
            if (obj == null || obj == DBNull.Value) return string.Empty;
            return obj.ToString();
        }

        /// <summary>
        /// 获取所有实体页面
        /// </summary>
        /// <param name="reader">数据读者</param>
        /// <returns>集合</returns>
        private static List<Page> GetModels(DbDataReader reader)
        {
            List<Page> pages = new List<Page>();
            Page pagetmp = null;
            while (reader.Read())
            {
                string PageName = ToString(reader["FieldPageName"]);
                string PageLabel = ToString(reader["FieldPageLabel"]);
                int ID = ToInt(reader["FieldID"]);
                string Name = ToString(reader["FieldName"]);
                bool IsIdentity = ToString(reader["FieldIdentity"]) == "O";
                bool IsParmary = ToString(reader["FieldPrimary"].ToString()) == "O";
                string Type = reader["FieldType"].ToString();
                int Size = ToInt(reader["FieldSize"]);
                int Length = ToInt(reader["FieldLength"].ToString());
                int Double = ToInt(reader["FieldDouble"].ToString());
                bool CanNull = ToString(reader["FieldIsNull"].ToString()) == "O";
                string Default = reader["FieldDefault"].ToString();
                string Remark = reader["FieldLabel"].ToString();
                if (PageName == "ContractSign")
                {
                    Console.WriteLine("!!!");
                }

                if (pagetmp != null && !string.IsNullOrEmpty(pagetmp.Name) && PageName == pagetmp.Name && PageLabel == pagetmp.Label)
                {
                    Field field = new Field();
                    field.ID = ID;
                    field.Name = Name;
                    field.IsIdentity = IsIdentity;
                    field.IsPrimary = IsParmary;
                    field.Length = Length;
                    field.Size = Size;
                    field.CanNull = CanNull;
                    field.Default = Default;
                    field.Double = Double;
                    field.Remark = Remark;
                    field.Type = Type;

                    pagetmp.Fields.Add(field);
                }
                else
                {
                    pagetmp = new Page();
                    pagetmp.Name = PageName;
                    pagetmp.Label = PageLabel;
                    Field field = new Field();
                    field.ID = ID;
                    field.Name = Name;
                    field.IsIdentity = IsIdentity;
                    field.IsPrimary = IsParmary;
                    field.Length = Length;
                    field.Size = Size;
                    field.CanNull = CanNull;
                    field.Default = Default;
                    field.Double = Double;
                    field.Remark = Remark;
                    field.Type = Type;
                    pagetmp.Fields.Add(field);
                    pages.Add(pagetmp);
                }
            }
            if (!reader.IsClosed) reader.Close();
            Field fi = GetPrimary(pages[0]);
            return pages;
        }

        #endregion 内部辅助

        #region 对外公开

        /// <summary>
        /// 获取所有表字段信息
        /// </summary>
        /// <param name="connStr">数据库地址</param>
        /// <returns>集合</returns>
        private static List<Page> GetMSSQL(string connStr, string ExecuteSQL)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = ExecuteSQL;
                SqlDataReader reader = comm.ExecuteReader();

                return GetModels(reader);
            }
        }
        /// <summary>
        /// 获得所有表字段信息
        /// </summary>
        /// <param name="connStr">数据库连接语句</param>
        /// <returns></returns>
        public static List<Page> GetTableInfo(string connStr)
        {
            return GetMSSQL(connStr, string.Format(DataMessage.TableSQL, ""));
        }
        /// <summary>
        /// 获得所有视图字段信息
        /// </summary>
        /// <param name="connStr">数据库连接语句</param>
        /// <returns></returns>
        public static List<Page> GetViewInfo(string connStr)
        {
            return GetMSSQL(connStr, string.Format(DataMessage.ViewSQL, ""));
        }
        /// <summary>
        /// 获得所有表字段信息筛选表
        /// </summary>
        /// <param name="connStr">数据库连接语句</param>
        /// <returns></returns>
        public static List<Page> GetTableInfo(string connStr, bool IsHas = false, params string[] Tables)
        {
            if (Tables == null || Tables.Length == 0) return GetTableInfo(connStr);
            StringBuilder sb = new StringBuilder();
            foreach (string item in Tables)
            {
                sb.Append("'"+item + "',");
            }
            string where = "And d.name ";
            if (IsHas) where += "in(" + sb.ToString().TrimEnd(',') + ") ";
            else where += "not in (" + sb.ToString().TrimEnd(',') + ") ";
            return GetMSSQL(connStr, string.Format(DataMessage.TableSQL, where));
        }
        /// <summary>
        /// 获得所有视图字段信息筛选
        /// </summary>
        /// <param name="connStr">数据库连接语句</param>
        /// <param name="IsHas">是否包含视图 否是过滤掉这些视图 是只保留这些视图</param>
        /// <param name="Views">视图名称</param>
        /// <returns></returns>
        public static List<Page> GetViewInfo(string connStr, bool IsHas = false, params string[] Views)
        {
            if (Views == null || Views.Length == 0) return GetViewInfo(connStr);
            StringBuilder sb = new StringBuilder();
            foreach (string item in Views)
            {
                sb.Append("'" + item + "',");
            }
            string where = "And d.name ";
            if (IsHas) where += "in(" + sb.ToString().TrimEnd(',') + ") ";
            else where += "not in (" + sb.ToString().TrimEnd(',') + ") ";
            return GetMSSQL(connStr, string.Format(DataMessage.ViewSQL, where));
        }

        /// <summary>
        /// 获得主键
        /// </summary>
        /// <param name="page">页面对象</param>
        /// <returns></returns>
        public static Field GetPrimary(Page page)
        {
            return page.Fields.FirstOrDefault<Field>(i => i.IsPrimary == true);
        }
        /// <summary>
        /// DB类型转换CLR类型
        /// </summary>
        /// <param name="Type">DB类型</param>
        /// <param name="CanNuLL">是否为空</param>
        /// <returns>转换后的CLR类型</returns>
        public static string ToCLR(string TypeName, bool CanNuLL)
        {
            switch (TypeName)
            {
                case "VARCHAR": return "string";
                case "CHAR": return "string";
                case "TEXT": return "string";
                case "DATETIME": return "DateTime" + (CanNuLL ? "?" : "");
                case "BIT": return "bool" + (CanNuLL ? "?" : "");
                case "INT": return "int" + (CanNuLL ? "?" : "");
                case "BIGHT": return "long" + (CanNuLL ? "?" : "");
                case "NUMERIC": return "decimal" + (CanNuLL ? "?" : "");
                case "FLOAT": return "double" + (CanNuLL ? "?" : "");
                case "DOUBLE": return "double" + (CanNuLL ? "?" : "");
                case "BINARY": return "byte[]";
                case "VARBINARY": return "byte[]";
                case "IMAGE": return "byte[]";
                default: return "string";
            }
        }
        #endregion 对外公开

    }
}