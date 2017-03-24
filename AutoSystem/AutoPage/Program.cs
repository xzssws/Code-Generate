using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using AutoPage.Model;
using System;
using System.Reflection;

namespace AutoPage
{
    public class Program
    {
        #region 内部辅助
        //static Program()
        //{
        //    blqw.LoadResourceDll.RegistDLL();
        //    //AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
        //}

        //static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        //{
        //    var assName = new AssemblyName(args.Name).FullName;
        //    //if (args.Name == "System.Data.SQLite, Version=1.0.82.0, Culture=neutral, PublicKeyToken=db937bc2d44ff139")
        //    //{
        //    Assembly assembly;
        //    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AutoPage.Utils.System.Data.SQLite.dll"))
        //    {
        //        byte[] bytes = new byte[stream.Length];
        //        stream.Read(bytes, 0, (int)stream.Length);
        //        assembly = Assembly.Load(bytes);
        //    }
        //    //}
        //    assembly = Assembly.Load(assName);
        //    return assembly;

        //}

        /// <summary>
        /// 获得配置值
        /// </summary>
        /// <param name="Key">键</param>
        /// <returns>值</returns>
        private static string GetValue(string Key)
        {
            if (Key == "SQLServerSource")
            {
                return @"Data Source=192.168.1.103\SQLEXPRESS;Initial Catalog=FinancialRegulation;User ID=sa;Password=111111";
            }
            else if (Key == "ExecuteSQL")
            {
                return @"SELECT	FieldName,FieldRemark,FieldLabel,FieldType,FieldPageName,FieldPageLabel FROM ShowAllModels ";
            }
            else if (Key == "SQLiteSource")
            {
                return @"D:\我的够快\个人的文件\WorkClound\Project\徐州_房管局预售资金监管项目\代码\项目辅助材料\徐州方管项目.db";
            }
            return ConfigurationManager.AppSettings[Key];
        }

        /// <summary>
        /// 创建页
        /// </summary>
        /// <param name="pagetmp"></param>
        /// <param name="name"></param>
        /// <param name="title"></param>
        /// <param name="remark"></param>
        /// <param name="controlLabel"></param>
        /// <param name="controlName"></param>
        /// <param name="controlRemark"></param>
        /// <param name="controlType"></param>
        /// <returns></returns>
        private static PageModel CreatePage(PageModel pagetmp, string name, string title, string remark, string controlLabel, string controlName, string controlRemark, string controlType)
        {
            pagetmp = new PageModel();
            pagetmp.Name = name;
            pagetmp.Label = title;
            pagetmp.Remark = remark;
            ControlModel cm = new ControlModel();
            cm.Label = controlLabel;
            cm.Name = controlName;
            cm.Remark = controlRemark;
            cm.Type = controlType;
            pagetmp.Controls.Add(cm);
            return pagetmp;
        }

        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="pagetmp"></param>
        /// <param name="name"></param>
        /// <param name="title"></param>
        /// <param name="remark"></param>
        /// <param name="controlLabel"></param>
        /// <param name="controlName"></param>
        /// <param name="controlRemark"></param>
        /// <param name="controlType"></param>
        /// <returns></returns>
        private static PageModel CreatePageM(PageModel pagetmp, string name, string title, string remark, string controlLabel, string controlName, string controlRemark, string controlType)
        {
            pagetmp = new PageModel();
            pagetmp.Name = name;
            pagetmp.Label = title;
            pagetmp.Remark = remark;
            ControlModel cm = new ControlModel();
            cm.Label = controlLabel;
            cm.Name = controlName;
            cm.Remark = controlRemark;
            cm.DataType = controlType;
            pagetmp.Controls.Add(cm);
            return pagetmp;
        }

        #endregion 内部辅助

        /// <summary>
        /// 获取所有界面
        /// </summary>
        /// <returns>所有界面集合</returns>
        public static List<PageModel> SQLitePage(string source)
        {
            string SelectTextPage = @"SELECT PageName,PageTitle,PageRemark,ControlLabel,ControlName,ControlRemark,ControlType FROM ShowAllControls
";
            List<PageModel> pages = new List<PageModel>();
            SQLiteConnectionStringBuilder connstr = new SQLiteConnectionStringBuilder();
            connstr.DataSource = source;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = connstr.ToString();
                conn.Open();
                SQLiteCommand comm = conn.CreateCommand();
                comm.CommandText = SelectTextPage;
                SQLiteDataReader reader = comm.ExecuteReader();

                PageModel pagetmp = null;
                while (reader.Read())
                {
                    string name = reader["PageName"].ToString(); ;
                    string title = reader["PageTitle"].ToString();
                    string remark = reader["PageRemark"].ToString();
                    string controlLabel = reader["ControlLabel"].ToString();
                    string controlName = reader["ControlName"].ToString();
                    string controlRemark = reader["ControlRemark"].ToString();
                    string controlType = reader["ControlType"].ToString();

                    if (pagetmp != null && !string.IsNullOrEmpty(pagetmp.Name))
                    {
                        if (title == pagetmp.Label)
                        {
                            ControlModel cm = new ControlModel();
                            cm.Label = controlLabel;
                            cm.Name = controlName;
                            cm.Remark = controlRemark;
                            cm.Type = controlType;
                            pagetmp.Controls.Add(cm);
                        }
                        else
                        {
                            pagetmp = CreatePage(pagetmp, name, title, remark, controlLabel, controlName, controlRemark, controlType);
                            pages.Add(pagetmp);
                        }
                    }
                    else //对象为空
                    {
                        pagetmp = CreatePage(pagetmp, name, title, remark, controlLabel, controlName, controlRemark, controlType);
                        pages.Add(pagetmp);
                    }
                }
                if (!reader.IsClosed) reader.Close();
            }
            return pages;
        }

        public static List<PageModel> SQLitePage()
        {
            string value = GetValue("SQLiteSource");
            return SQLitePage(value);
        }

        /// <summary>
        /// 获取所有实体对象
        /// </summary>
        /// <param name="source">数据库地址</param>
        /// <returns>集合</returns>
        public static List<PageModel> SQLiteModel(string source)
        {
            string ExecuteSQL = GetValue("ExecuteSQL");

            SQLiteConnectionStringBuilder connstr = new SQLiteConnectionStringBuilder();
            connstr.DataSource = source;
            using (SQLiteConnection conn = new SQLiteConnection())
            {
                conn.ConnectionString = connstr.ToString();
                conn.Open();
                SQLiteCommand comm = conn.CreateCommand();
                comm.CommandText = ExecuteSQL;
                SQLiteDataReader reader = comm.ExecuteReader();
                return GetModels(reader);
            }
        }

        public static List<PageModel> SQLiteModel()
        {
            string value = GetValue("SQLiteSource");
            return SQLiteModel(value);
        }

        /// <summary>
        /// 获取所有实体对象
        /// </summary>
        /// <param name="connStr">数据库地址</param>
        /// <returns>集合</returns>
        public static List<PageModel> SQLServerModel(string connStr)
        {
            string ExecuteSQL = GetValue("ExecuteSQL");
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandText = ExecuteSQL;
                SqlDataReader reader = comm.ExecuteReader();

                return GetModels(reader);
            }
        }

        public static List<PageModel> SQLServerModel()
        {
            string value = GetValue("SQLServerSource");
            return SQLServerModel(value);
        }

        /// <summary>
        /// 获取所有实体页面
        /// </summary>
        /// <param name="reader">数据读者</param>
        /// <returns>集合</returns>
        private static List<PageModel> GetModels(DbDataReader reader)
        {
            List<PageModel> pages = new List<PageModel>();
            PageModel pagetmp = null;
            while (reader.Read())
            {
                string name = reader["FieldPageName"].ToString(); ;
                string title = reader["FieldPageLabel"].ToString();
                string remark = reader["FieldRemark"].ToString();
                string controlLabel = reader["FieldLabel"].ToString();
                string controlName = reader["FieldName"].ToString().Replace(' ', '_');
                string controlRemark = reader["FieldRemark"].ToString();
                string controlType = reader["FieldType"].ToString();

                if (pagetmp != null && !string.IsNullOrEmpty(pagetmp.Name))
                {
                    if (title == pagetmp.Label)
                    {
                        ControlModel cm = new ControlModel();
                        cm.Label = controlLabel;
                        cm.Name = controlName;
                        cm.Remark = controlRemark;
                        cm.DataType = controlType;
                        pagetmp.Controls.Add(cm);
                    }
                    else
                    {
                        pagetmp = CreatePageM(pagetmp, name, title, remark, controlLabel, controlName, controlRemark, controlType);
                        pages.Add(pagetmp);
                    }
                }
                else //对象为空
                {
                    pagetmp = CreatePageM(pagetmp, name, title, remark, controlLabel, controlName, controlRemark, controlType);
                    pages.Add(pagetmp);
                }
            }
            if (!reader.IsClosed) reader.Close();
            return pages;
        }

        //测试
        private static void Main(string[] args)
        {
            string constr = GetValue("SQLiteSource");
            SQLiteModel(constr);
        }
    }


    namespace blqw
    {
        using System;
        using System.Collections.Generic;
        using System.Diagnostics;
        using System.Reflection;
        /// <summary> 载入资源中的动态链接库(dll)文件
        /// </summary>
        static class LoadResourceDll
        {
            static Dictionary<string, Assembly> Dlls = new Dictionary<string, Assembly>();
            static Dictionary<string, object> Assemblies = new Dictionary<string, object>();

            static Assembly AssemblyResolve(object sender, ResolveEventArgs args)
            {
                //程序集
                Assembly ass;
                //获取加载失败的程序集的全名
                var assName = new AssemblyName(args.Name).FullName;
                //判断Dlls集合中是否有已加载的同名程序集
                if (Dlls.TryGetValue(assName, out ass) && ass != null)
                {
                    Dlls[assName] = null;//如果有则置空并返回
                    return ass;
                }
                else
                {
                    throw new DllNotFoundException(assName);//否则抛出加载失败的异常
                }
            }

            /// <summary> 注册资源中的dll
            /// </summary>
            public static void RegistDLL()
            {
                //获取调用者的程序集
                var ass = new StackTrace(0).GetFrame(1).GetMethod().Module.Assembly;
                //判断程序集是否已经处理
                if (Assemblies.ContainsKey(ass.FullName))
                {
                    return;
                }
                //程序集加入已处理集合
                Assemblies.Add(ass.FullName, null);
                //绑定程序集加载失败事件(这里我测试了,就算重复绑也是没关系的)
                AppDomain.CurrentDomain.AssemblyResolve += AssemblyResolve;
                //获取所有资源文件文件名
                var res = ass.GetManifestResourceNames();
                foreach (var r in res)
                {
                    //如果是dll,则加载
                    if (r.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
                    {
                        try
                        {
                            var s = ass.GetManifestResourceStream(r);
                            var bts = new byte[s.Length];
                            s.Read(bts, 0, (int)s.Length);
                            var da = Assembly.Load(bts);
                            //判断是否已经加载
                            if (Dlls.ContainsKey(da.FullName))
                            {
                                continue;
                            }
                            Dlls[da.FullName] = da;
                        }
                        catch
                        {
                            //加载失败就算了...
                        }
                    }
                }
            }
        }
    }

}