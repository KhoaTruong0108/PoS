using System;
using lhk.POS.Core.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility.Password;

namespace Pos.DataBaseTest
{
    [TestClass]
    public class Logger
    {
        [TestMethod]
        public void GetDefaultPassword()
        {
            var admin = PasswordServiceProvider.Encrypt("admin", "admin");
            var Supervisor = PasswordServiceProvider.Encrypt("Supervisor", "Supervisor");
            var Staff = PasswordServiceProvider.Encrypt("Staff", "Staff");
            var NhanVien = PasswordServiceProvider.Encrypt("NhanVien", "1");
            var ThanhHuong = PasswordServiceProvider.Encrypt("ThanhHuong", "manman12");
        }

        [TestMethod]
        public void ContextConceptions()
        {
           
        }
    }
}
