using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QiuXingMing.DAL;
using QiuXingMing.Model;
using System.EnterpriseServices;

namespace DALTest
{
    /// <summary>
    /// SupplierDALTest 的摘要说明
    /// </summary>
    [TestClass]
    [Transaction(TransactionOption.Required)]
    public class SupplierDALTest:ServicedComponent
    {
        public SupplierDALTest()
        {
            //
            //TODO:  在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        [TestCleanup()]
        public void MyTestCleanup()
        {
            if (ContextUtil.IsInTransaction)
            {
                ContextUtil.SetAbort();
            }
        }
        #endregion

        [TestMethod]
        public void FindByIDTest()
        {
            SupplierDAL dal = new SupplierDAL();
            Assert.IsNull(dal.FindByID("10"));

            Supplier s = dal.FindByID("12");
            Assert.IsNotNull(s);
            Assert.AreEqual("12", s.SupplierID);
            Assert.AreEqual("1", s.SupplierName);
            Assert.AreEqual("1", s.SpellingCode);
            Assert.AreEqual("1", s.Address);
            Assert.AreEqual("1", s.ZipCode.ToString().Trim());
            Assert.AreEqual("1", s.Tel);
            Assert.AreEqual("1", s.Fax);
            Assert.AreEqual("1", s.BankName);
            Assert.AreEqual("1", s.BankAccount);
            Assert.AreEqual("1", s.Contacter);
            Assert.AreEqual("1", s.Email);

        }
        [TestMethod]
        public void GetALLTest()
        {
            SupplierDAL dal = new SupplierDAL();
            List<Supplier> list = dal.GetALL();
            Assert.AreEqual(2  , list.Count);

            Supplier s = list[0];
            Assert.AreEqual("12", s.SupplierID);
            Assert.AreEqual("1", s.SupplierName);
            Assert.AreEqual("1", s.SpellingCode);
            Assert.AreEqual("1", s.Address);
            Assert.AreEqual("1", s.ZipCode.ToString().Trim());
            Assert.AreEqual("1", s.Tel);
            Assert.AreEqual("1", s.Fax);
            Assert.AreEqual("1", s.BankName);
            Assert.AreEqual("1", s.BankAccount);
            Assert.AreEqual("1", s.Contacter);
            Assert.AreEqual("1", s.Email);
        }
        [TestMethod]
        public void InsertTest()
        {
            SupplierDAL dal = new SupplierDAL();
            Supplier s = new Supplier("1","1","1","1","1","1","1","1","1","1","1");
            Assert.IsTrue(dal.Insert(s));
            Supplier s2 = dal.FindByID("1");
            Assert.AreEqual("1", s2.SupplierID);
            Assert.AreEqual("1", s2.SupplierName);
            Assert.AreEqual("1", s2.SpellingCode);
            Assert.AreEqual("1", s2.Address);
            Assert.AreEqual("1", s2.ZipCode.ToString().Trim());
            Assert.AreEqual("1", s2.Tel);
            Assert.AreEqual("1", s2.Fax);
            Assert.AreEqual("1", s2.BankName);
            Assert.AreEqual("1", s2.BankAccount);
            Assert.AreEqual("1", s2.Contacter);
            Assert.AreEqual("1", s2.Email);

            s2 = new Supplier("12", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1");
            Assert.IsFalse(dal.Insert(s2));
        }
        [TestMethod]
        public void UpdateTest()
        {
            SupplierDAL dal = new SupplierDAL();
            Supplier s = new Supplier("12", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1");
            Assert.IsTrue(dal.Update(s));

            Supplier s2 = dal.FindByID("12");
            Assert.AreEqual("12", s2.SupplierID);
            Assert.AreEqual("1", s2.SupplierName);
            Assert.AreEqual("1", s2.SpellingCode);
            Assert.AreEqual("1", s2.Address);
            Assert.AreEqual("1", s2.ZipCode.ToString().Trim());
            Assert.AreEqual("1", s2.Tel);
            Assert.AreEqual("1", s2.Fax);
            Assert.AreEqual("1", s2.BankName);
            Assert.AreEqual("1", s2.BankAccount);
            Assert.AreEqual("1", s2.Contacter);
            Assert.AreEqual("1", s2.Email);

            s2 = new Supplier("1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1");
            Assert.IsFalse(dal.Update(s2));
        }
        [TestMethod]
        public void DeleteTest()
        {
            SupplierDAL dal = new SupplierDAL();
            Supplier s = new Supplier();
            s.SupplierID = "2";
            Assert.IsTrue(dal.Delete(s));
            Assert.IsNull(dal.FindByID("2"));

            s.SupplierID = "6";
            Assert.IsFalse(dal.Delete(s));
        }
    }
}
