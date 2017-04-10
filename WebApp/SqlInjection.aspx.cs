using System;
using System.Web.UI;
using System.Data.Entity.Core.EntityClient;

namespace WebApp
{
    public partial class SqlInjection : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["command"] != null)
            {
                var con = new EntityConnection("connection");
                con.GetSchema(Request.Params["command"]);
            }
        }
    }
}