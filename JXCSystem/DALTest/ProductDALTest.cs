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
    /// ProductDALTest 的摘要说明
    /// </summary>
    [TestClass]
    [Transaction(TransactionOption.Required)]
    public class ProductDALTest:ServicedComponent
    {
        public ProductDALTest()
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
            ProductDAL dal = new ProductDAL();
            Assert.IsNull(dal.FindByID("10"));

            Product p = dal.FindByID("1");
            Assert.IsNotNull(p);
            Assert.AreEqual("1", p.ProductID);
            Assert.AreEqual("11", p.ProductName);
            Assert.AreEqual("11", p.SpellingCode);
            Assert.AreEqual("11", p.BarCode);
            Assert.AreEqual("11", p.Special);
            Assert.AreEqual("11", p.Unit);
            Assert.AreEqual("11", p.Origin);
            Assert.AreEqual("大香蕉", p.CategoryID);
            Assert.AreEqual(Convert.ToDecimal(11), p.PurchasePrice);
            Assert.AreEqual(Convert.ToDecimal(11), p.SalePrice);
            Assert.AreEqual(11, p.Quantity);

        }
        [TestMethod]
        public void GetALLTest()
        {
            ProductDAL dal = new ProductDAL();
            List<Product> list = dal.GetALL();
            Assert.AreEqual(2, list.Count);

            Product p = list[0];
            Assert.AreEqual("1", p.ProductID);
            Assert.AreEqual("11", p.ProductName);
            Assert.AreEqual("11", p.SpellingCode);
            Assert.AreEqual("11", p.BarCode);
            Assert.AreEqual("11", p.Special);
            Assert.AreEqual("11", p.Unit);
            Assert.AreEqual("11", p.Origin);
            Assert.AreEqual("大香蕉", p.CategoryID);
            Assert.AreEqual(Convert.ToDecimal(11), p.PurchasePrice);
            Assert.AreEqual(Convert.ToDecimal(11), p.SalePrice);
            Assert.AreEqual(11, p.Quantity);
        }
        [TestMethod]
        public void InsertTest()
        {
            ProductDAL dal = new ProductDAL();
            Product p = new Product("2", "1", "1", "1", "1", "1", "1", "1", Convert.ToDecimal(1), Convert.ToDecimal(1), 1);
            Assert.IsTrue(dal.Insert(p));
            Product p2 = dal.FindByID("2");
            Assert.AreEqual("2", p2.ProductID);
            Assert.AreEqual("1", p2.ProductName);
            Assert.AreEqual("1", p2.SpellingCode);
            Assert.AreEqual("1", p2.BarCode);
            Assert.AreEqual("1", p2.Special);
            Assert.AreEqual("1", p2.Unit);
            Assert.AreEqual("1", p2.Origin);
            Assert.AreEqual("1", p2.CategoryID);
            Assert.AreEqual(Convert.ToDecimal(1), p2.PurchasePrice);
            Assert.AreEqual(Convert.ToDecimal(1), p2.SalePrice);
            Assert.AreEqual(1, p2.Quantity);

            p2 = new Product("1", "1", "1", "1", "1", "1", "1", "1", Convert.ToDecimal(1), Convert.ToDecimal(1), 1);
            Assert.IsFalse(dal.Insert(p2));
        }
        [TestMethod]
        public void UpdateTest()
        {
            ProductDAL dal = new ProductDAL();
            Product p = new Product("1", "1", "1", "1", "1", "1", "1", "1", Convert.ToDecimal(1), Convert.ToDecimal(1), 1);
            Assert.IsTrue(dal.Update(p));

            Product p2 = dal.FindByID("1");
            Assert.AreEqual("1", p2.ProductID);
            Assert.AreEqual("1", p2.ProductName);
            Assert.AreEqual("1", p2.SpellingCode);
            Assert.AreEqual("1", p2.BarCode);
            Assert.AreEqual("1", p2.Special);
            Assert.AreEqual("1", p2.Unit);
            Assert.AreEqual("1", p2.Origin);
            Assert.AreEqual("1", p2.CategoryID);
            Assert.AreEqual(Convert.ToDecimal(1), p2.PurchasePrice);
            Assert.AreEqual(Convert.ToDecimal(1), p2.SalePrice);
            Assert.AreEqual(1, p2.Quantity);

            p2 = new Product("2", "1", "1", "1", "1", "1", "1", "1", Convert.ToDecimal(1), Convert.ToDecimal(1), 1);
            Assert.IsFalse(dal.Update(p2));
        }
        [TestMethod]
        public void DeleteTest()
        {
            ProductDAL dal = new ProductDAL();
            Product p = new Product();
            p.ProductID = "3";
            Assert.IsTrue(dal.Delete(p));
            Assert.IsNull(dal.FindByID("3"));

            p.ProductID = "6";
            Assert.IsFalse(dal.Delete(p));
        }
    }
}
