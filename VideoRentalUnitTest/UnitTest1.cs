using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentalVideos;

namespace VideoRentalUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        BAL bal = new BAL();
        [TestMethod]
        public void LoginWithIncorrectCorrectCredentails()
        {
            var loginID = "admin";
            var password = "Admin@12344";

            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@userid", loginID);

            sp[1] = new SqlParameter("@pwd", password);
            dt = bal.geDataTableWithParamter("userLogin", sp);
            if (dt != null && dt.Rows.Count > 0)
                Assert.IsTrue(true);
            else
                Assert.IsFalse(false);
        }

        [TestMethod]
        public void GetConnStringFromAppConfig()
        {
            DAL da = new DAL();
            string actualString = da.appsetting;
            string expectedString = System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            Assert.AreEqual(expectedString, actualString);
        }
    }
}
