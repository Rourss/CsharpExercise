﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QiuXingMing.DAL;
using QiuXingMing.Model;


namespace DALTest
{
    /// <summary>
    /// PurchaseDALTest 的摘要说明
    /// </summary>
    [TestClass]
    public class PurchaseDALTest
    {
        public PurchaseDALTest()
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
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ProchaseID()
        {
            PurchaseBillDAL p = new PurchaseBillDAL();
            List<string> list = p.FindPurchaseIDByID("2000");
            Assert.AreEqual(1, list.Count);
        }
        [TestMethod]
        public void FindByIDTest()
        {
            PurchaseBillDAL pdal = new PurchaseBillDAL();
            PurchaseBill list=pdal.FindByID("201706010001");
            Assert.IsNotNull(list);
            Assert.IsNull(pdal.FindByID("2165321010"));
            Assert.AreEqual("201706010001",list.PurchaseID);
            Assert.AreEqual(Convert.ToDateTime("2018.10.1"), list.PurchaseDate);
            Assert.AreEqual("1", list.Clerk);
            Assert.AreEqual(3,list.DetailList.Count);

            //从明细列表中取出一行明细进行测试
            PurchaseDetail pDetail = list.DetailList[0];
            Assert.AreEqual("1", pDetail.PurchaseDetailID);
            Assert.AreEqual(Convert.ToDecimal(3), pDetail.PurchasePrice);
            Assert.AreEqual("10", pDetail.Quantity);
        }
    }
}
