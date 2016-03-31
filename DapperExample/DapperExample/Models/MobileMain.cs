using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Configuration;
using DapperExample.Models;
using System.Data.SqlClient;

namespace DapperExample.Models
{
    public class MobileMain : IRepo
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

        public string AddMobile(TBMobileDetails objMD)
        {
            string query = "insert into Mobiledata(MobileName, MobileIMEno, MobileManufactured, Mobileprice)VALUES(@MobileName,@MobileMeno,@MobileManufactured,@Mobileprice)";
            con.Execute(query,new { objMD.MobileName, objMD.MobileMeno, objMD.MobileManufactured, objMD.Mobileprice });
            string result = "success";
            return result;
        }
        public IEnumerable<TBMobileDetails> Allmobilelisting()
        {
            string query = "select * from Mobiledata";
            var result = con.Query<TBMobileDetails>(query);
            return result;
        }
    }
}