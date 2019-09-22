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
    /// CategoryDALTest 的摘要说明
    /// </summary>
    [TestClass]
    [Transaction(TransactionOption.Required)]
    public class CategoryDALTest:ServicedComponent
    {
        public CategoryDALTest()
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
            CategoryDAL dal = new CategoryDAL();
            Assert.IsNull(dal.FindByID("10"));

            Category c = dal.FindByID("大香蕉");
            Assert.IsNotNull(c);
            Assert.AreEqual("大香蕉", c.CategoryID);
            Assert.AreEqual("芭蕉", c.CategoryName);
        }
        [TestMethod]
        public void GetALLTest()
        {
            CategoryDAL dal = new CategoryDAL();
            List<Category> list = dal.GetALL();
            Assert.AreEqual(4, list.Count);

            Category c = list[3];
            Assert.AreEqual("大香蕉", c.CategoryID);
            Assert.AreEqual("芭蕉", c.CategoryName);
        }
        [TestMethod]
        public void InsertTest()
        {
            CategoryDAL dal = new CategoryDAL();
            Category c=new Category("5","2");
            Assert.IsTrue(dal.Insert(c));
            Category c2 = dal.FindByID("2");
            Assert.AreEqual("2", c2.CategoryID);
            Assert.AreEqual("2", c2.CategoryName);

            c = new Category("2", "西瓜");
            Assert.IsFalse(dal.Insert(c));
        }
        [TestMethod]
        public void UpdateTest()
        {
            CategoryDAL dal = new CategoryDAL();
            Category c = new Category("大香蕉", "小香蕉");
            Assert.IsTrue(dal.Update(c));

            Category c2 = dal.FindByID("大香蕉");
            Assert.AreEqual("大香蕉", c2.CategoryID);
            Assert.AreEqual("小香蕉", c2.CategoryName);

            c = new Category("阿西吧","阿西吧");
            Assert.IsFalse(dal.Update(c));
        }
        [TestMethod]
        public void DeleteTest()
        {
            CategoryDAL dal = new CategoryDAL();
            Category c = new Category();
            c.CategoryID = "2";
            Assert.IsTrue(dal.Delete(c));
            Assert.IsNull(dal.FindByID("2"));

            c.CategoryID = "6";
            Assert.IsFalse(dal.Delete(c));
        }
    }
}
