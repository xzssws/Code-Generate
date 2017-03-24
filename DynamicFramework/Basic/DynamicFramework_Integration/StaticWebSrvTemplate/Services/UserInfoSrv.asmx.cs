using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DynamicDao;

namespace DynamicWebSrv
{
    /// <summary>
    /// UserInfoSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class UserInfoSrv : System.Web.Services.WebService
    {	
        [WebMethod(Description="添加[UserInfo]")]
        public bool Add(DynamicEntity.UserInfoEntity o)
        {
            return UserInfoDao.Add(o);
        }
        [WebMethod(Description="更新[UserInfo]")]
        public bool Update(DynamicEntity.UserInfoEntity o)
        {
            return UserInfoDao.Update(o);
        }
        [WebMethod(Description="删除[UserInfo]")]
        public bool Delete(string o)
        {
            return UserInfoDao.Delete(o);
        }
        [WebMethod(Description="查询所有[UserInfo]")]
        public List<DynamicEntity.UserInfoEntity> Selects()
        {
            return UserInfoDao.Selects() as List<DynamicEntity.UserInfoEntity>;
        }
        [WebMethod(Description="条件查询[UserInfo]")]
        public List<DynamicEntity.UserInfoEntity> Select(DynamicEntity.UserInfoEntity o)
        {
            return UserInfoDao.Select(o) as List<DynamicEntity.UserInfoEntity>;
        }
        [WebMethod(Description="查询并排序所有[UserInfo]")]
        public List<DynamicEntity.UserInfoEntity> SelectsOrderBy(string orderField,bool isDesc)
        {
            return UserInfoDao.SelectsOrderBy(orderField, isDesc) as List<DynamicEntity.UserInfoEntity>;
        }
    }
}
