using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.DataAccess;
using System.Data;
using System.EnterpriseServices;

namespace DataAccessTest
{
    /// <summary>
    /// BookInfoTest 的摘要说明
    /// </summary>
    [TestClass]
    [Transaction(TransactionOption.Required)] //设置该类为事务，如果不是事务就创建
    public class BookInfoTest:ServicedComponent //继承事务类
    {
        public BookInfoTest()
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

        //在每个测试运行完之后，使用 TestCleanup 来运行代码
        [TestCleanup()]
        public void TransactionTest()
        {
            if (ContextUtil.IsInTransaction) //如果这个类是事务
            {
                ContextUtil.SetAbort();//撤销操作，相当于回滚操作
            }
        }
        [TestMethod]
        public void GetAllBookClassTest()
        {
            BookInfo book = new BookInfo();
            DataSet ds = book.GetAllBookClass();
            Assert.IsNotNull(ds);
            Assert.AreEqual(22, ds.Tables[0].Rows.Count);
        }
        [TestMethod]
        public void GetBookInfoTest()
        {
            BookInfo book = new BookInfo();
            DataSet ds = book.GetBookInfo("011");
            Assert.IsNotNull(ds);
            Assert.AreEqual("axb", ds.Tables[0].Rows[0]["BookName"]);
        }
        [TestMethod]
        public void InsertNewBook()
        {
            BookInfo book = new BookInfo();
            Assert.IsTrue(book.InsertNewBook("t4050000", "12345678912360", "axb", "axb", Convert.ToDateTime("1999-1-1"), "1", 12, 12, "axb", "T"));
            DataSet ds = book.GetBookInfo("t4050000");
            Assert.IsNotNull(ds);
            Assert.AreEqual("12345678912360", ds.Tables[0].Rows[0]["isbn"].ToString().Trim());
            Assert.AreEqual("axb", ds.Tables[0].Rows[0]["bookname"]);
            Assert.AreEqual("axb", ds.Tables[0].Rows[0]["author"]);
            Assert.AreEqual(Convert.ToDateTime( "1999-1-1"), ds.Tables[0].Rows[0]["publishdate"]);
            Assert.AreEqual("1", ds.Tables[0].Rows[0]["bookversion"]);
            Assert.AreEqual(12, ds.Tables[0].Rows[0]["wordcount"]);
            Assert.AreEqual(Convert.ToInt16(12), ds.Tables[0].Rows[0]["pagecount"]);
            Assert.AreEqual("axb", ds.Tables[0].Rows[0]["publisher"]);
            Assert.AreEqual("T", ds.Tables[0].Rows[0]["classid"]);
        }
        [TestMethod]
        public void DeleteBook()
        {
            BookInfo book = new BookInfo();
            Assert.IsTrue(book.DeleteBook("A23"));
            DataSet ds = book.GetBookInfo("A23");
            Assert.IsNotNull(ds);
            Assert.AreEqual(0, ds.Tables[0].Rows.Count);
        }
        [TestMethod]
        public void UpdateBook()
        {
            BookInfo book = new BookInfo();
            Assert.IsTrue(book.UpdateBookInfo("A23", "12345", "111", "axb", Convert.ToDateTime("1999-1-1"), "1", 123, 123, "axb", "T"));
            DataSet ds = book.GetBookInfo("A23");
            Assert.IsNotNull(ds);
            Assert.AreEqual("12345", ds.Tables[0].Rows[0]["isbn"].ToString().Trim());
            Assert.AreEqual("111", ds.Tables[0].Rows[0]["bookname"]);
            Assert.AreEqual("axb", ds.Tables[0].Rows[0]["author"]);
            Assert.AreEqual(Convert.ToDateTime("1999-1-1"), ds.Tables[0].Rows[0]["publishdate"]);
            Assert.AreEqual("1", ds.Tables[0].Rows[0]["bookversion"]);
            Assert.AreEqual(123, ds.Tables[0].Rows[0]["wordcount"]);
            Assert.AreEqual(Convert.ToInt16(123), ds.Tables[0].Rows[0]["pagecount"]);
            Assert.AreEqual("axb", ds.Tables[0].Rows[0]["publisher"]);
            Assert.AreEqual("T", ds.Tables[0].Rows[0]["classid"]);
        }
    }
}
