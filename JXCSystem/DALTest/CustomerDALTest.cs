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
    /// CustomerDALTest 的摘要说明
    /// </summary>
    [TestClass]
    [Transaction(TransactionOption.Required)]
    public class CustomerDALTest:ServicedComponent
    {
        public CustomerDALTest()
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
            CustomerDAL dal = new CustomerDAL();
            Assert.IsNull(dal.FindByID("12"));

            Customer c = dal.FindByID("123");
            Assert.IsNotNull(c);
            Assert.AreEqual("123", c.CustomerID.ToString().Trim());
            Assert.AreEqual("1", c.CustomerName.ToString().Trim());
            Assert.AreEqual("1", c.SpellingCode.ToString().Trim());
            Assert.AreEqual("1", c.Address.ToString().Trim());
            Assert.AreEqual("1", c.ZipCode.ToString().Trim());
            Assert.AreEqual("1", c.Tel.ToString().Trim());
            Assert.AreEqual("1", c.Fax.ToString().Trim());
            Assert.AreEqual("1", c.BankName.ToString().Trim());
            Assert.AreEqual("1", c.BankAccount.ToString().Trim());
            Assert.AreEqual("1", c.Contacter.ToString().Trim());
            Assert.AreEqual("1", c.Email.ToString().Trim());
        }
        [TestMethod]
        public void GetALLTest()
        {
            CustomerDAL dal = new CustomerDAL();
            List<Customer> list = dal.GetALL();
            Assert.AreEqual(1, list.Count);

            Customer c = list[0];
            Assert.IsNotNull(c);
            Assert.AreEqual("123", c.CustomerID.ToString().Trim());
            Assert.AreEqual("1", c.CustomerName.ToString().Trim());
            Assert.AreEqual("1", c.SpellingCode.ToString().Trim());
            Assert.AreEqual("1", c.Address.ToString().Trim());
            Assert.AreEqual("1", c.ZipCode.ToString().Trim());
            Assert.AreEqual("1", c.Tel.ToString().Trim());
            Assert.AreEqual("1", c.Fax.ToString().Trim());
            Assert.AreEqual("1", c.BankName.ToString().Trim());
            Assert.AreEqual("1", c.BankAccount.ToString().Trim());
            Assert.AreEqual("1", c.Contacter.ToString().Trim());
            Assert.AreEqual("1", c.Email.ToString().Trim());
        }
        [TestMethod]
        public void InsertTest()
        {
            CustomerDAL dal = new CustomerDAL();
            Customer c = new Customer("1", "2","2","2","2","2","2","2","2","2","2");
            Assert.IsTrue(dal.Insert(c));
            Customer c2 = dal.FindByID("1"); 
            Assert.IsNotNull(c2);
            Assert.AreEqual("1", c2.CustomerID.ToString().Trim());
            Assert.AreEqual("2", c2.CustomerName.ToString().Trim());
            Assert.AreEqual("2", c2.SpellingCode.ToString().Trim());
            Assert.AreEqual("2", c2.Address.ToString().Trim());
            Assert.AreEqual("2", c2.ZipCode.ToString().Trim());
            Assert.AreEqual("2", c2.Tel.ToString().Trim());
            Assert.AreEqual("2", c2.Fax.ToString().Trim());
            Assert.AreEqual("2", c2.BankName.ToString().Trim());
            Assert.AreEqual("2", c2.BankAccount.ToString().Trim());
            Assert.AreEqual("2", c2.Contacter.ToString().Trim());
            Assert.AreEqual("2", c2.Email.ToString().Trim());

            c = new Customer("1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1");
            Assert.IsFalse(dal.Insert(c));
        }
        [TestMethod]
        public void UpdateTest()
        {
            CustomerDAL dal = new CustomerDAL();
            Customer c = new Customer("123", "2", "2", "2", "2", "2", "2", "2", "2", "2", "2");
            Assert.IsTrue(dal.Update(c));

            Customer c2 = dal.FindByID("123");
            Assert.AreEqual("123", c2.CustomerID.ToString().Trim());
            Assert.AreEqual("2", c2.CustomerName.ToString().Trim());
            Assert.AreEqual("2", c2.SpellingCode.ToString().Trim());
            Assert.AreEqual("2", c2.Address.ToString().Trim());
            Assert.AreEqual("2", c2.ZipCode.ToString().Trim());
            Assert.AreEqual("2", c2.Tel.ToString().Trim());
            Assert.AreEqual("2", c2.Fax.ToString().Trim());
            Assert.AreEqual("2", c2.BankName.ToString().Trim());
            Assert.AreEqual("2", c2.BankAccount.ToString().Trim());
            Assert.AreEqual("2", c2.Contacter.ToString().Trim());
            Assert.AreEqual("2", c2.Email.ToString().Trim());

            c = new Customer("12", "21", "21", "21", "21", "21", "21", "21", "21", "21", "21");
            Assert.IsFalse(dal.Update(c));
        }
        [TestMethod]
        public void DeleteTest()
        {
            CustomerDAL dal = new CustomerDAL();
            Customer c = new Customer();
            c.CustomerID = "123";
            Assert.IsTrue(dal.Delete(c));
            Assert.IsNull(dal.FindByID("123"));

            c.CustomerID = "6";
            Assert.IsFalse(dal.Delete(c));
        }
    }
}
