using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess;
using System.Data;

namespace Library.LibraryBusiness
{
    public class WinLogic
    {
        private BookInfo book;
        private BorrowInfo borrow;
        private User user;
        private Admin admin;
        private LXUser lx;
        public WinLogic()
        {
            book = new BookInfo();
            borrow = new BorrowInfo();
            user = new User();
            admin = new Admin();
            lx = new LXUser();
        }
        /// <summary>
        /// 封装
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public DataSet GetUserInfo(string userid)
        {
            return user.GetUserName(userid);
        }

        public DataSet GetBorrowInfoByUserID(string userid)
        {
            return borrow.GetBorrowInfoByUserID(userid);
        }

        public bool BorrowBook(string bookid, string userid)
        {
            if (!borrow.HasBook(bookid))
            {
                throw new NoRecordException("没有这本书！");
            }
            if (borrow.IsBorrowed(bookid))
            {
                return false;
            }
            return borrow.BorrowBook(bookid, userid);
        }

        public DataSet GetBookInfoByBookID(string bookid)
        {
            return book.GetBookInfo(bookid);
        }

        public DataSet GetBorrowInfoByBookID(string bookid)
        {
            return borrow.GetBorrowInfoByBookID(bookid);
        }

        public bool InsertNewBook(string bookid, string isbn, string bookname, string author, DateTime publishdate, string bookversion, int wordcount, int pagecount, string publisher, string classid)
        {
            return book.InsertNewBook(bookid, isbn, bookname, author, publishdate, bookversion, wordcount, pagecount, publisher, classid);
        }

        public DataSet GetBookInfo(string bookname, string classid)
        {
            return book.GetBookInfo(bookname, classid);
        }

        public bool DeleteBook(string bookid)
        {
            return book.DeleteBook(bookid);
        }

        public bool UpdateBookInfo(string bookid, string isbn, string bookname, string author, DateTime publishdate, string bookversion, int wordcount, int pagecount, string publisher, string classid)
        {
            return book.UpdateBookInfo(bookid, isbn, bookname, author, publishdate, bookversion, wordcount, pagecount, publisher, classid);
        }
        
        public DataSet GetAllBookClass()
        {
            return book.GetAllBookClass();
        }
        
        public bool ReturnBook(string bookid)
        {
            return borrow.ReturnBook(bookid);
        }
        
        public bool ReBorrow(string bookid)
        {
            return borrow.ReBorrow(bookid);
        }
        
        public DataSet GetBookStatisticInfo()
        {
            return book.GetBookStatisticInfo();
        }
        public bool IsOverdue(string bookid)
        {
            return borrow.IsOverdue(bookid); 
        }
        public string IsOverdueDateTime(string bookid)
        {
            return book.IsOverdueDateTime(bookid);
        }
        /// <summary>
        /// 各个查询方法的集合，存储过程由参数传入
        /// 即可达到：方法不变，只需要改存储过程名字就可以查询各种东西
        /// </summary>
        /// <param name="procedure">存储过程名字</param>
        /// <returns></returns>
        public DataSet Overloads(string procedure)
        {
            return book.Overloads(procedure); 
        }

        public bool Login(string adminid, string password)
        {
            return admin.Login(adminid,password);
        }
        public bool ChangePassword(string adminid, string newpassword)
        {
            return admin.ChangePassword(adminid, newpassword);
        }
        public string GetAdminNameByID(string adminid)
        {
            return admin.GetAdminNameByID(adminid);
        }
        public bool InsertAdmin(string adminid, string adminname, string password, string email)
        {
            return admin.InsertAdmin(adminid, adminname, password, email);
        }
        public bool LxInsertUser(string userid, string photoFile)
        {
            return lx.LxInsertUser(userid, photoFile);
        }
        public DataSet LxGetUserInfoByUserID(string userid)
        {
            return lx.LxGetUserInfoByUserID(userid);
        }
        public bool UpdateUserInfoByUserID(string userid, string photo)
        {
            return user.UpdateUserInfoByUserID(userid, photo);
        }
    }
}
