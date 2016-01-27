using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace AngularjsTest.WebService
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        //[ScriptMethod(UseHttpGet=true)]
        [WebMethod]
        public object GetList()
        {
            List<Model> list = new List<Model>();
            list.Add(new Model() { Name = "a", Country = "b" });
            list.Add(new Model() { Name = "a1", Country = "b1" });
            list.Add(new Model() { Name = "a2", Country = "b2" });
            list.Add(new Model() { Name = "a3", Country = "b3" });
            list.Add(new Model() { Name = "a4", Country = "b4" });
            return list;
        }

        class Model
        {
            public string Name { set; get; }
            public string Country { set; get; }
        }
    }
}
