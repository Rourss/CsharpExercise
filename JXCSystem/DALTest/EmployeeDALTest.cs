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
    /// EmployeeDALTest 的摘要说明
    /// </summary>
    [TestClass]
    [Transaction(TransactionOption.Required)]
    public class EmployeeDALTest:ServicedComponent
    {
        public EmployeeDALTest()
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
            EmployeeDAL dal = new EmployeeDAL();
            Assert.IsNull(dal.FindByID("6"));

            Employee e = dal.FindByID("3");
            Assert.IsNotNull(e);
            Assert.AreEqual("3", e.EmployeeID);
            Assert.AreEqual("3", e.EmployeeName);
            Assert.AreEqual(true, e.Sex);
            Assert.AreEqual(Convert.ToDateTime("2000.1.1"), e.Birthday);
            Assert.AreEqual("1", e.Brief);
        }
        [TestMethod]
        public void GetALLTest()
        {
            EmployeeDAL dal = new EmployeeDAL();
            List<Employee> list = dal.GetALL();
            Assert.AreEqual(2, list.Count);

            Employee e = list[0]; 
            Assert.AreEqual("2", e.EmployeeID);
            Assert.AreEqual("1", e.EmployeeName);
            Assert.AreEqual(true, e.Sex);
            Assert.AreEqual(Convert.ToDateTime("2000.1.1"), e.Birthday);
            Assert.AreEqual("1", e.Brief);
        }
        [TestMethod]
        public void InsertTest()
        {
            EmployeeDAL dal = new EmployeeDAL();
            Employee e = new Employee("1","1",true,Convert.ToDateTime("2000.1.1"),"1");
            Assert.IsTrue(dal.Insert(e));
            Employee e2 = dal.FindByID("1");
            Assert.AreEqual("1", e2.EmployeeID);
            Assert.AreEqual("1", e2.EmployeeName);
            Assert.AreEqual(true, e2.Sex);
            Assert.AreEqual(Convert.ToDateTime("2000.1.1"), e2.Birthday);
            Assert.AreEqual("1", e2.Brief);

            e2 = new Employee("2", "1", true, Convert.ToDateTime("2000.1.1"), "1");
            Assert.IsFalse(dal.Insert(e2));
        }
        [TestMethod]
        public void UpdateTest()
        {
            EmployeeDAL dal = new EmployeeDAL();
            Employee e = new Employee("2", "2", false, Convert.ToDateTime("2000.1.1"), "2");
            Assert.IsTrue(dal.Update(e));

            Employee e2 = dal.FindByID("2");
            Assert.AreEqual("2", e2.EmployeeID);
            Assert.AreEqual("2", e2.EmployeeName);
            Assert.AreEqual(false, e2.Sex);
            Assert.AreEqual(Convert.ToDateTime("2000.1.1"), e2.Birthday);
            Assert.AreEqual("2", e2.Brief);

            e2 = new Employee("11", "2", false, Convert.ToDateTime("2000.1.1"), "2");
            Assert.IsFalse(dal.Update(e2));
        }
        [TestMethod]
        public void DeleteTest()
        {
            EmployeeDAL dal = new EmployeeDAL();
            Employee e = new Employee();
            e.EmployeeID = "3";
            Assert.IsTrue(dal.Delete(e));
            Assert.IsNull(dal.FindByID("3"));

            e.EmployeeID = "6";
            Assert.IsFalse(dal.Delete(e));
        }
    }
}
