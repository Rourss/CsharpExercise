using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Library.DataAccess;
using Library.LibraryBusiness;
using System.Threading;
using Library.Comm;
using System.Timers;
using System.IO;

namespace Library.LibraryWinUI
{
    public partial class FrmLibrarySystem : Form
    {
        private WinLogic logic; //WinLogic类的对象
        private InputCheck ch;//InputCheck类的对象

        private string userIDA; //借书选项卡的读者字段
        private string userIDB; //还书选项卡的读者字段
        private string userIDC; //续借选项卡的读者字段

        private string bookIDB; //还书选项卡的图书编号字段
        private string bookIDC; //续借选项卡的图书编号字段
        private string bookIDD; //图书管理选项卡的图书编号字段

        private string adminID; //定义一个字段用来存放传入的管理员ID

        private bool flagB = true; //标记,真为检索功能,假为还书功能
        private bool flagC = true; //标记,真为检索功能,假为续借功能

        private int currentIndex; //字段,用于存放当前行的下标

        public FrmLibrarySystem(string adminID)
        {
            InitializeComponent();
            logic = new WinLogic(); //初始化类的对象
            ch = new InputCheck();
            this.adminID = adminID; //把传入的管理员ID赋给字段
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ////1.读配置文件
            //string str = ConfigurationManager.ConnectionStrings["Mylibrary"].ConnectionString;
            ////MessageBox.Show(str);

            ////2.验证配置文件是否正确
            ////创建连接对象
            //SqlConnection conn = new SqlConnection(str);
            //conn.Open();
            //MessageBox.Show("OK");
            //conn.Close();

            ////3.测试DBException异常类
            //DBException ex = new DBException(new Exception());
            //MessageBox.Show(ex.Message);

            ////4.测试NoRecordException异常类
            //NoRecordException nre1 = new NoRecordException();
            //MessageBox.Show(nre1.Message);

            //NoRecordException nre2 = new NoRecordException("入库失败");
            //MessageBox.Show(nre2.Message);

            //5.测试DBAccess类中的 ExecuteSQL方法
            //SqlCommand cmd = new SqlCommand("update TBL_User set Password='123' where UserID='20180310042'");
            //int num = DBAccess.ExecuteSQL(cmd);
            //MessageBox.Show(num.ToString());

            //SqlCommand cmd = new SqlCommand("select UserID from TBL_User where UserID='20180310042'");
            //object num = DBAccess.GetScalar(cmd);
            //MessageBox.Show(num.ToString());

            //SqlCommand cmd = new SqlCommand("select UserName,Sex,Class from TBL_User where UserID='20180310042'");
            //dgview.DataSource = DBAccess.QueryData(cmd).Tables[0];
              
            //6.测试BookInfo类的各个方法

            //BookInfo book = new BookInfo();
            //bool i = book.DeleteBook("011");
            //MessageBox.Show(i.ToString());

            //BookInfo book = new BookInfo();
            //bool i = book.InsertNewBook("011", "5151", "axb", "tg", DateTime.Now, "1", 522, 56, "axbb", "T");
            //MessageBox.Show(i.ToString());

            //BookInfo book = new BookInfo();
            //bool i = book.UpdateBookInfo("011", "5151", "axb", "tg", Convert.ToDateTime("1998.1.1"), "1", 522, 56, "axbb", "T");
            //MessageBox.Show(i.ToString());

            //BookInfo book = new BookInfo();
            //dgview.DataSource = book.GetBookInfo("学", "T").Tables[0];

            //BookInfo book = new BookInfo();
            //dgview.DataSource = book.GetBookInfo("011").Tables[0];

            //BookInfo book = new BookInfo();
            //dgview.DataSource=book.GetBookInfo("","学","","T").Tables[0];

            //BookInfo book = new BookInfo();
            //dgview.DataSource = book.GetAllBookClass().Tables[0];

            //BookInfo book = new BookInfo();
            //dgview.DataSource = book.GetBookStatisticInfo().Tables[0];

            //7.测试BorrowInfo类的各个方法

            //BorrowInfo book = new BorrowInfo();
            //bool i = book.BorrowBook("0111", "20180310042");
            //MessageBox.Show(i.ToString());

            //BorrowInfo book = new BorrowInfo();
            //bool i = book.ReturnBook("011");
            //MessageBox.Show(i.ToString());

            //BorrowInfo book = new BorrowInfo();
            //bool i = book.ReBorrow("011");
            //MessageBox.Show(i.ToString());

            //BorrowInfo book = new BorrowInfo();
            //dgview.DataSource = book.GetBorrowInfoByBookID("011").Tables[0];

            //BorrowInfo book = new BorrowInfo();
            //dgview.DataSource = book.GetBorrowInfoByUserID("20180310042").Tables[0];

            //BorrowInfo book = new BorrowInfo();
            //bool i = book.IsBorrowed("TP393/228");
            //MessageBox.Show(i.ToString());

            //BorrowInfo book = new BorrowInfo();
            //bool i = book.HasBook("011");
            //MessageBox.Show(i.ToString());

            //8.测试User类的各个方法

            //User id = new User();
            //dgview.DataSource = id.GetUserName("20180310042").Tables[0];

            //User id = new User();
            //bool i = id.InsertUser("011", "axb", "123", 1, "123", "2018软件3班");
            //MessageBox.Show(i.ToString());

            //9.测试Admin类的各个方法
            //Admin ad = new Admin();
            //bool b = ad.InsertAdmin("100", "axb", "123", "123@163.com");
            //MessageBox.Show(b.ToString());

            //Admin ad=new Admin();
            //string str = ad.GetAdminNameByID("100");
            //MessageBox.Show(str);

            //Admin ad = new Admin();
            //bool b = ad.Login("100", "123");
            //MessageBox.Show(b.ToString());

            //Admin ad=new Admin();
            //bool b = ad.ChangePassword("100", "456");
            //MessageBox.Show(b.ToString());

            //测检验
            //string str = txtTest.Text.Substring(0, 1);
            //if (Convert.ToChar(str) > 64 && Convert.ToChar(str) < 91)
            //{
            //    MessageBox.Show("第一个是大写字母");
            //}
            //else
            //{
            //    MessageBox.Show("第一个不是大写字母");
            //}

            //char[] c = txtTest.Text.ToCharArray();
            //for (int i = 0; i < c.Length; i++)
            //{
            //    if (c[i] >= 0x4e00 && c[i] <= 0x9fbb)
            //    {
            //        MessageBox.Show("有中文");
            //        return;
            //    }
            //}
            
            //string isbn = txtTest.Text.Trim();
            //isbn = isbn.Replace("-", "");
            //if (ch.CheckISBN(isbn))
            //{
            //    MessageBox.Show("ISBN正确！");
            //}
            //else
            //{
            //    MessageBox.Show("ISBN不正确！");
            //}

            //char[] c = txtTest.Text.ToCharArray();
            //for (int i = 0; i < c.Length; i++)
            //{
            //    if (c[i] >= 32 && c[i] <= 46)
            //    {
            //        MessageBox.Show("不能有特殊字符");
            //        return;
            //    }
            //}
            //int sum = 0;
            //char[] num = txtTest.Text.Trim().ToArray();
            //for (int i = 0; i < num.Length; i++)
            //{
            //    int odd = 0;
            //    int even = 0;
            //    if (num[i] % 2 == 1)
            //    {
            //        odd = int.Parse(num[i].ToString()) * 1;
            //        //MessageBox.Show(odd.ToString());
            //    }
            //    else
            //    {
            //        even = int.Parse(num[i].ToString()) * 3;
            //        //MessageBox.Show(even.ToString());
            //    }
            //    sum += odd + even;
            //}
            //int axb = 0;
            //int acb = 0;
            //int isbn = 0;
            //axb = sum % 10;
            //acb = 10 - axb;
            //if (acb == 10)
            //{
            //    MessageBox.Show("0");
            //}
            //else
            //{
            //    MessageBox.Show(acb.ToString());
            //}
            //int sum = 0;
            //int s = 10;
            //char[] num = txtTest.Text.Trim().ToArray();
            //for (int i = 0; i < num.Length; i++)
            //{
            //    sum += int.Parse(num[i].ToString()) * s;
            //    s--;
            //}
            //MessageBox.Show(sum.ToString());

            //if (!ch.CheckBookID(txtTest.Text.Trim()))
            //{
            //    MessageBox.Show("图书编号不正确！");
            //    txtTest.Text = "";
            //    txtTest.Focus();
            //    return;
            //}
            //测存储过程
            //BookInfo book = new BookInfo();
            //string str = book.IsOverdueDateTime("I514.45/5");
            //MessageBox.Show(str);

        }

        private void btnConfirmA1_Click(object sender, EventArgs e)
        {
            //1.从文本框中获取读者编号
            userIDA = txtIDA.Text.Trim(); //设置一个string变量用来获取文本框的内容(去除前后空格)

            //2.对读者编号进行判断
            if (userIDA == "")
            {
                MessageBox.Show("读者编号不能为空!");
                txtIDA.Focus(); //放置光标
                return; //返回
            }

            //3.检索数据并显示
            try
            {
                DataSet ds = logic.GetUserInfo(userIDA); //设置一个数据集变量用来存放查找到的内容
                DataTable dt = ds.Tables[0]; //设置一个数据表变量用来存放数据集的第一张表的内容
                if (dt.Rows.Count == 0) //判断是否有值
                {
                    MessageBox.Show("没有这个用户!"); //消息框提示
                    ClearControlsA();
                    return;
                }
                
                //设置一个行变量用来存放数据表第一行的内容
                DataRow dr = dt.Rows[0]; //设置一个行变量用来获取数据表的第一行的内容
                txtNameA.Text = dr["username"].ToString(); //取出username字段的内容并转成字符串,然后赋给姓名文本框
                txtClassA.Text = dr["class"].ToString(); //取出class字段的内容并转成字符串,然后赋给班别文本框

                //如果有照片,代码写这
                if (dr["photo"] == Convert.DBNull) //如果这个字段的值为数据库的：NULL 则显示”暂无“
                {
                    pbPhoto.Image = Image.FromFile("no.gif"); //通过读取文件显示图片
                }
                else
                {
                    byte[] photo = dr["photo"] as byte[]; //把字段的值放入二进制数组中
                    MemoryStream ms = new MemoryStream(photo); //创建一个内存流的对象，把二进制数组传入
                    pbPhoto.Image = Image.FromStream(ms); //读取流的数据并转成图片显示出来
                }

                if (Convert.ToInt32(dr["sex"])==1) //判断读者表的sex字段(转换成int),如果是1就激活男单选按钮
                {
                    rbMaleA.Checked = true; //设置单选按钮的Checked属性为真,即可激活
                }
                else
                {
                    rbFeMaleA.Select(); //调用单选按钮的Select方法来激活按钮
                }
                //4.检索该读者的借阅信息并显示
                dgBorrowInfoA.DataSource = logic.GetBorrowInfoByUserID(userIDA).Tables[0]; //获取借书信息并显示出来
                
                btnConfirmA2.Enabled = true; //启用借书按钮
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //显示异常
            }
        }

        private void btnCancelA1_Click(object sender, EventArgs e)
        {
            ClearControlsA(); //调用清除方法
            
        }

        private void ClearControlsA()
        {
            txtIDA.Text = ""; //清空文本框
            txtIDA.Focus(); //放置光标
            txtNameA.Text = ""; //清空文本框
            txtClassA.Text = ""; //清空文本框
            txtBookIDA.Text = "";
            if (btnConfirmA2.Enabled == true) //如果该按钮是启用状态,就设置为假
            {
                btnConfirmA2.Enabled = false; //按钮禁用
            }
            rbMaleA.Checked = false; //设置男单选按钮的属性为假
            rbFeMaleA.Checked = false; //设置女单选按钮的属性为假
            dgBorrowInfoA.DataSource = false; //清空DataGridView内容
            pbPhoto.Image = null;
        }

        private void ClearContorlsB()
        {
            //清空文本框
            txtBookIDB.Text = "";
            txtBookIDB.Focus();
            txtNameB.Text = ""; 
            txtClassB.Text = ""; 
            txtAuthorB.Text = "";
            txtBookNameB.Text = "";
            txtPublisherB.Text = "";
            txtISBNB.Text = "";
            //属性设为假，去除选用状态
            rbOverTimeNB.Checked = false;
            rbOverTimeYB.Checked = false;
            btnBorrow.Text = "检索";
            //取消禁用
            flagB = true; //设为真，跳回检索状态
            txtBookIDB.Enabled = true;
            rbMaleB.Checked = false; //设置男单选按钮的属性为假
            rbFeMaleB.Checked = false; //设置女单选按钮的属性为假
            dgBorrowInfoB.DataSource = false; //清空DataGridView内容
            lblAlertMessageB.Visible = false; //设置标签的可见性为假,隐藏标签
        }

        private void btnConfirmA2_Click(object sender, EventArgs e)
        {
            //1.从文本框中获取图书编号
            string bookIDA = txtBookIDA.Text.Trim(); //设置一个string变量用来获取文本框的内容(去除前后空格)
            //2.对图书编号进行判断
            if (bookIDA == "")
            {
                MessageBox.Show("图书编号不能为空!");
                txtBookIDA.Focus(); //放置光标
                return; //返回
            }
            try
            {
                //3.进行借书操作
                bool i = logic.BorrowBook(bookIDA, userIDA); //调用借书方法,用一个bool变量存放结果
                if (i)
                {
                    MessageBox.Show("借书成功!");
                    txtBookIDA.Text = ""; //清空文本框
                    txtBookIDA.Focus(); //放置光标
                    //4.刷新借阅信息
                    dgBorrowInfoA.DataSource = logic.GetBorrowInfoByUserID(userIDA).Tables[0]; //获取借书信息并显示出来
                }
                else
                {
                    MessageBox.Show("借书失败!");
                    txtBookIDA.Text = ""; //清空文本框
                    txtBookIDA.Focus(); //设置光标
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnCancelA2_Click(object sender, EventArgs e)
        {
            ClearControlsA();
            txtBookIDA.Focus();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            lblAlertMessageB.Visible = false; //设置标签的可见性为假,隐藏标签

            try
            {
                if (flagB) //默认为真,所以进入检索分支
                {
                    //检索功能
                    //1.从文本框中获取图书编号
                    bookIDB = txtBookIDB.Text.Trim();
                    //2.对图书编号进行判断
                    if (bookIDB == "")
                    {
                        MessageBox.Show("图书编号不能为空!");
                        txtBookIDB.Focus();
                        return;
                    }
                    //3.通过图书编号进行检索操作
                    DataSet ds = logic.GetBorrowInfoByBookID(bookIDB); //调用查找方法
                    DataTable dt = ds.Tables[0]; //设置一个数据表变量用来存放数据集的第一张表
                    if (dt.Rows.Count == 0)
                    {
                        lblAlertMessageB.Visible = true; //设置标签的可见性为真,显示标签
                        txtBookIDB.Text = "";
                        txtBookIDB.Focus();
                        return;
                    }

                    DataRow dr = dt.Rows[0]; //设置一个行变量用来存放数据表中第一行内容
                    if(Convert.ToInt32(dr["IsReturned"])==1) //如果归还状态为1就显示消息框
                    {
                        MessageBox.Show("此书已经归还!");
                        ClearContorlsB();
                        txtBookIDB.Text = "";
                        txtBookIDB.Focus();
                        return;
                    }
                    txtISBNB.Text = dr["ISBN"].ToString();
                    txtAuthorB.Text = dr["Author"].ToString();
                    txtPublisherB.Text = dr["Publisher"].ToString();
                    txtBookNameB.Text = dr["BookName"].ToString();
                    txtNameB.Text = dr["UserName"].ToString();
                    txtClassB.Text = dr["Class"].ToString();
                    if (Convert.ToInt32(dr["Sex"]) == 1) //判断读者表的sex字段(转换成int),如果是1就激活男单选按钮
                    {
                        rbMaleB.Checked = true; //设置单选按钮的Checked属性为真,即可激活
                    }
                    else
                    {
                        rbFeMaleB.Select(); //调用单选按钮的Select方法来激活按钮
                    }
                    try
                    {
                        //逾期（扩展功能）
                        if (logic.IsOverdue(bookIDB))
                        {
                            rbOverTimeYB.Checked = true;
                            string day = logic.IsOverdueDateTime(bookIDB); //创建一个变量用来存放逾期的天数
                            double num = Convert.ToInt32(day) * 0.1; //创建一个变量用来存放计算罚款后的值
                            MessageBox.Show("您已逾期：" + day + "天" + "\n" + "罚款金额为：" + num + "元"); //显示对话框
                        }
                        else
                        {
                            rbOverTimeNB.Checked = true;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    userIDB=dr["UserID"].ToString(); //用字段存放UserID的内容,用来通过读者编号查找借阅信息
                    dgBorrowInfoB.DataSource = logic.GetBorrowInfoByUserID(userIDB).Tables[0];

                    btnBorrow.Text = "还书"; //当检索完成后把检索变成还书
                    txtBookIDB.Enabled = false;
                    flagB = false; //标记换成假.让下次能进入还书分支
                }
                else //当为假,进入还书分支
                {
                    if (logic.ReturnBook(bookIDB)) //还书方法
                    {
                        MessageBox.Show("还书成功!");
                        ClearContorlsB();
                        //刷新
                        dgBorrowInfoB.DataSource = logic.GetBorrowInfoByUserID(userIDB).Tables[0];
                        
                    }
                    else
                    {
                        MessageBox.Show("还书失败!");
                    }
                    btnBorrow.Text = "检索"; //当还书完成后把还书变成检索
                    flagB = true; //标记换成真,
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelB_Click(object sender, EventArgs e)
        {
            ClearContorlsB();
        }

        private void btnReborrow_Click(object sender, EventArgs e)
        {
            lblAlertMessageC.Visible = false; //设置标签的可见性为假,隐藏标签

            try
            {
                if (flagC) //默认为真,所以进入检索分支
                {
                    //检索功能
                    //1.从文本框中获取图书编号
                    bookIDC = txtBookIDC.Text.Trim();
                    //2.对图书编号进行判断
                    if (bookIDC == "")
                    {
                        MessageBox.Show("图书编号不能为空!");
                        txtBookIDC.Focus();
                        return;
                    }
                    //3.通过图书编号进行检索操作
                    DataSet ds = logic.GetBorrowInfoByBookID(bookIDC);
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count == 0)
                    {
                        lblAlertMessageC.Visible = true; //设置标签的可见性为真,显示标签
                        txtBookIDC.Text = "";
                        txtBookIDC.Focus();
                        return;
                    }

                    DataRow dr = dt.Rows[0];
                    if (Convert.ToInt32(dr["IsReturned"]) == 1) //如果归还状态为1就显示消息框
                    {
                        MessageBox.Show("此书已经归还!");
                        ClearContorlsB();
                        txtBookIDC.Text = "";
                        txtBookIDC.Focus();
                        return;
                    }
                    txtISBNC.Text = dr["ISBN"].ToString();
                    txtAuthorC.Text = dr["Author"].ToString();
                    txtPublisherC.Text = dr["Publisher"].ToString();
                    txtBookNameC.Text = dr["BookName"].ToString();
                    txtNameC.Text = dr["UserName"].ToString();
                    txtClassC.Text = dr["Class"].ToString();
                    if (Convert.ToInt32(dr["Sex"]) == 1) //判断读者表的sex字段(转换成int),如果是1就激活男单选按钮
                    {
                        rbMaleC.Checked = true; //设置单选按钮的Checked属性为真,即可激活
                    }
                    else
                    {
                        rbFeMaleC.Select(); //调用单选按钮的Select方法来激活按钮
                    }
                    try
                    {
                        //逾期（扩展功能）
                        if (logic.IsOverdue(bookIDC))
                        {
                            rbOverTimeYC.Checked = true;
                            string day = logic.IsOverdueDateTime(bookIDC); //创建一个变量用来存放逾期的天数
                            double num = Convert.ToInt32(day) * 0.1; //创建一个变量用来存放计算罚款后的值
                            MessageBox.Show("您已逾期：" + day + "天" + "\n" + "罚款金额为：" + num + "元"); //显示对话框
                        }
                        else
                        {
                            rbOverTimeNC.Checked = true;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                    userIDC = dr["UserID"].ToString(); //用字段存放UserID的内容,用来通过读者编号查找借阅信息 
                    dgBorrowInfoC.DataSource = logic.GetBorrowInfoByUserID(userIDC).Tables[0];

                    btnReborrow.Text = "续借"; //当检索完成后把检索变成还书
                    txtBookIDC.Enabled = false;
                    flagC = false; //标记换成假.让下次能进入还书分支
                }
                else //当为假,进入还书分支
                {
                    if (logic.ReBorrow(bookIDC)) //还书方法
                    {
                        MessageBox.Show("续借成功!");
                        ClearContorlsC();
                        //刷新
                        dgBorrowInfoC.DataSource = logic.GetBorrowInfoByUserID(userIDC).Tables[0];
                        
                    }
                    else
                    {
                        MessageBox.Show("续借失败!");
                    }
                    btnReborrow.Text = "检索"; //当还书完成后把还书变成检索
                    flagC = true; //标记换成真,
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearContorlsC()
        {
            txtBookIDC.Text = "";
            txtBookIDC.Focus();
            txtNameC.Text = ""; //清空文本框
            txtClassC.Text = ""; //清空文本框
            txtAuthorC.Text = "";
            txtBookNameC.Text = "";
            txtPublisherC.Text = "";
            txtISBNC.Text = "";
            rbOverTimeNC.Checked = false;
            rbOverTimeYC.Checked = false;
            btnReborrow.Text = "检索";
            flagC = true;
            txtBookIDC.Enabled = true;
            rbMaleC.Checked = false; //设置男单选按钮的属性为假
            rbFeMaleC.Checked = false; //设置女单选按钮的属性为假
            dgBorrowInfoC.DataSource = false; //清空DataGridView内容
            lblAlertMessageC.Visible = false; //设置标签的可见性为假,隐藏标签
        }

        private void btnCancelC_Click(object sender, EventArgs e)
        {
            ClearContorlsC();
        }
        /// <summary>
        /// 当用户加载窗体时就执行代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLibrarySystem_Load(object sender, EventArgs e)
        {
            //当用户一运行窗体时就运行代码

            try
            {
                DataSet ds = logic.GetAllBookClass(); //调用查找类别编号的方法
                cbBookTypeD1.DataSource = ds.Tables[0]; //填充数据
                cbBookTypeD1.DisplayMember = "ClassName"; //设置显示的属性为ClassName字段的值
                cbBookTypeD1.ValueMember = "ClassID"; //设置实际的值为ClassID字段的值

                DataSet dst = logic.GetAllBookClass();
                cbBookTypeD2.DataSource = dst.Tables[0];
                cbBookTypeD2.DisplayMember = "ClassName";
                cbBookTypeD2.ValueMember = "ClassID";

                rbModify.Enabled = false;
                lblAdminName.Text = logic.GetAdminNameByID(adminID); //调用方法把管理员的名字显示到标签

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchD_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = SelectDataD(); //调用方法
                if (dt.Rows.Count == 0) //如果没有记录则显示
                {
                    dgBookInfoD.DataSource = false; //刷新
                    MessageBox.Show("没有您查找的书!");
                    return;
                }
                dgBookInfoD.DataSource = dt; //填充
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 调用方法，返回一个数据表
        /// </summary>
        /// <returns></returns>
        private DataTable SelectDataD()
        {
            //1.从控件中获取对应的值
            string bookName = txtBookNameD2.Text.Trim();
            string classID = Convert.ToString(cbBookTypeD2.SelectedValue); //获取控件的实际的值(通过SekectedValue属性)

            //2.进行检索操作并显示
            DataSet ds = logic.GetBookInfo(bookName, classID); //调用查找方法
            DataTable dt = ds.Tables[0];
            return dt;
        }

        private void dgBookInfoD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //1.将当前行反蓝
                dgBookInfoD.CurrentRow.Selected = true;//用属性获取当前行是否被选中，如果选中则获取该值
                rbModify.Enabled = true;
                DataTable dt = dgBookInfoD.DataSource as DataTable; // as 用于引用类型转换
                currentIndex = dgBookInfoD.CurrentRow.Index; //定义一个字段，用于存放该视图当前选中行的下标
                DataRow dr = dt.Rows[currentIndex]; //设置一个行变量用来存放数据表的行的内容（行的内容用CurrentRow属性的下标获得）
                bookIDD = dr["bookID"].ToString();
                txtBookIDD.Text = bookIDD;
                txtBookNameD.Text = dr["bookName"].ToString();
                txtISBND.Text = dr["ISBN"].ToString();
                txtPublishDateD.Text = dr["PublishDate"].ToString();
                txtPublisherD.Text = dr["Publisher"].ToString();
                txtWordCountD.Text = dr["WordCount"].ToString();
                txtPageCountD.Text = dr["PageCount"].ToString();
                txtBookVersionD.Text = dr["BookVersion"].ToString();
                txtAuthorD.Text = dr["Author"].ToString();

                cbBookTypeD1.Text= dr["ClassName"].ToString();//通过Text属性更改内容
                cbBookTypeD1.SelectedValue = dr["ClassID"]; //通过SelectedValue属性获取对应的实际值

                rbModify.Checked = true; //选中控件
                txtBookIDD.Enabled = false; //禁用控件
                btnDelD.Enabled = true; //启用控件
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelD_Click(object sender, EventArgs e)
        {
            ClearContorlsD();
        }

        private void ClearContorlsD()
        {
            try
            {

                foreach (Control c in gbInsertBook.Controls) //使用foreach循环该分组框集合的全部控件
                {
                    if (c is TextBox) //如果该控件是文本框
                    {
                        c.Text = ""; //清空文本框
                        txtBookIDD.Enabled = true; //启用控件
                    }
                    else if (c is RadioButton) //如果是单选按钮
                    {
                        rbNewBook.Checked = true;
                    }
                    else if (c is Button) //如果是按钮
                    {
                        btnDelD.Enabled = false;
                    }
                }
                cbBookTypeD1.SelectedIndex = 0; //重新设置下拉框的索引为0
                cbBookTypeD2.SelectedIndex = 0;
                dgBookInfoD.DataSource = false; //清空DataGridView内容
                rbModify.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelD_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("是否要删除?", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);  //显示一个选项框
                if (result == DialogResult.Yes) //如果选择是
                {
                    //进行删除操作
                    if (logic.DeleteBook(bookIDD))
                    {
                        MessageBox.Show("删除成功!");
                        dgBookInfoD.DataSource = SelectDataD(); //调用方法刷新数据
                    }
                    else
                    {
                        MessageBox.Show("删除失败!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbNewBook_Click(object sender, EventArgs e)
        {
            txtBookIDD.Enabled = true;
        }

        private void rbModify_Click(object sender, EventArgs e)
        {
            txtBookIDD.Enabled = false;
        }

        private void btnConfirmD_Click(object sender, EventArgs e)
        {
            //使用foreach循环该分组框的全部控件
            foreach (Control c in gbInsertBook.Controls)
            {
                if (c is TextBox && c.Text.Trim() == "") //当它是文本框并为空值时
                {
                    MessageBox.Show("请输入图书信息!");
                    c.Focus();
                    return;
                }
            }
            //定义各个变量用于下边存放数据
            int wordCount;
            int pageCount;
            DateTime publishDate;
            string bookID = txtBookIDD.Text.Trim();
            string ISBN = txtISBND.Text.Trim();
            string ISBN1 = ISBN.Replace("-", ""); //把“ - ”替换成空串，这样就只有10位或13位了
            string author = txtAuthorD.Text.Trim();
            string bookName = txtBookNameD.Text.Trim();
            string publisher = txtPublisherD.Text.Trim();
            string bookVersion = txtBookVersionD.Text.Trim();
            string classID = cbBookTypeD1.SelectedValue.ToString(); //获取实际值

            if (!ch.CheckBookID(bookID)) //通过类的对象调用接口的检测,如果不通过则消息框提示
            {
                MessageBox.Show("图书编号不正确!");
                txtBookIDD.Focus();
                return;
            }
            if (!ch.CheckISBN(ISBN1)) //通过类的对象调用接口的检测,如果不通过则消息框提示
            {
                MessageBox.Show("ISBN不正确!");
                txtISBND.Focus();
                return;
            }
            //因为转换不成功会抛出异常,所以放入try里
            try
            {
                wordCount = Convert.ToInt32(txtWordCountD.Text.Trim()); //类型转换
                if (wordCount == 0)
                {
                    MessageBox.Show("字数不能为0!");
                    txtWordCountD.Text = "";
                    txtWordCountD.Focus();
                    return;
                }
            }
            catch 
            {
                MessageBox.Show("字数不正确!"); //抛出消息框
                txtWordCountD.Focus();
                return;
            }

            try
            {
                pageCount = Convert.ToInt32(txtPageCountD.Text.Trim());
                if (pageCount == 0)
                {
                    MessageBox.Show("页数不能为0!");
                    txtPageCountD.Text = "";
                    txtPageCountD.Focus();
                    return;
                }
            }
            catch 
            {
                MessageBox.Show("页数不正确!");
                txtPageCountD.Focus();
                return;
            }

            try
            {
                publishDate = Convert.ToDateTime(txtPublishDateD.Text.Trim());
            }
            catch 
            {
                MessageBox.Show("日期格式不正确!");
                txtPublishDateD.Focus();
                return;
            }

            try
            {
                if (rbNewBook.Checked) 
                {
                    //调用方法插入新的图书
                    if (logic.InsertNewBook(bookID,ISBN,bookName,author,publishDate,bookVersion,wordCount,pageCount,publisher,classID))
                    {
                        MessageBox.Show("新书入库成功!");
                        rbModify.Enabled = true;
                        //刷新
                        dgBookInfoD.DataSource = logic.GetBookInfoByBookID(bookID).Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("新书入库失败!");
                    }
                }
                else
                {
                    //调用方法更新图书信息
                    if (logic.UpdateBookInfo(bookID, ISBN, bookName, author, publishDate, bookVersion, wordCount, pageCount, publisher, classID))
                    {
                        MessageBox.Show("修改成功!");
                        //刷新
                        //1.只显示修改的行
                        //dgBookInfoD.DataSource = logic.GetBookInfoByBookID(bookID).Tables[0];
                        //2.显示多个行,并反蓝选中行
                        dgBookInfoD.DataSource = SelectDataD();//调用方法返回数据表，填充视图
                        //把选中的行反蓝
                        dgBookInfoD.Rows[currentIndex].Selected = true; //通过下标，设置当前选中的行反蓝
                        //取消第一行第一个单元格的默认活跃状态
                        dgBookInfoD.CurrentCell.Selected = false; //通过CurrentCell属性获取当前选中的单元格，然后取消选中
                        //自动跳到选中行
                        dgBookInfoD.CurrentCell = dgBookInfoD.Rows[currentIndex].Cells[0]; //获取当前选中行的第一个单元格，设置为活跃单元格
                    }
                    else  
                    {
                        MessageBox.Show("修改失败!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchE_Click(object sender, EventArgs e)
        {
            string str; //定义一个字符串变量用来存放存储过程
            int num = 0; //定义一个变量用来匹配数字（下标值），初值为0
            try
            {
                //定义一个字符串数组，用来存放各个存储过程
                string[] arr = { "CheckBookInfoAndNumber", "CheckThisHasBook", "CheckThisReadership", "CheckPublisherAndNumber", "CheckPyKnowledge", "CheckJhKnowledge", "CheckHsKnowledge", "CheckUyKnowledge", "CheckChinese", "CheckMath", "CheckEnglish", "CheckGeographical", "CheckPhysics", "CheckChemistry", "CheckBiology", "CheckHistory", "CheckPolitics", "CheckDynamics", "CheckEngineering", "CheckLiterature", "CheckComputer", "CheckReadingStar", "CheckPopularityKing", "CheckBlacklist" };
                //使用for循环遍历数组
                for (int i = 0; i < arr.Length; i++)
                {
                    str = arr[i]; //把遍历到的存储过程放入变量中
                    //if条件判断下拉框的下标是否匹配
                    if (cbSearchCondition.SelectedIndex == num)
                    {
                        DataSet ds = logic.Overloads(str); //调用方法执行各个存储过程
                        dgResultE.DataSource = ds.Tables[0]; //把内容填充到视图中
                    }
                    //每循环一次在此基础上加1，即可达到每次选的下标都能匹配上，然后执行对应的存储过程
                    num = num + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0); //终止为这个程序提供环境的方法和进程,强力退出
        }

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0; //当点到借书的时候会跳到对应的页面(通过索引下标)
        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void 续借ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void 报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }
        /// <summary>
        /// Timer控件的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeDate_Tick(object sender, EventArgs e)
        {
            //创建一个Timer控件,用于一直获取当前的时间
            //ToLongDate是长整型日期,只有中文的 年月日
            //ToLongTime是长整型时间,有时分秒
            lblTime.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString(); //把获取到的系统日期存到标签中
        }

        private void btnConfirmF_Click(object sender, EventArgs e)
        {
            try
            {
                string oglPWD = txtOriginalPWD.Text.Trim(); //定义一个变量用来存放输入的原始密码
                string newPWD = txtNewPWD.Text.Trim(); //定义一个变量用来存放输入的新密码
                string cfmPWD = txtConfirmPWD.Text.Trim(); //定义一个变量用来存放输入的确认密码
                //下边的三个if都是用来判断变量是否为空
                if (oglPWD == "")
                {
                    MessageBox.Show("密码不能为空!");
                    ClearContorlsF();
                    return;
                }
                if (newPWD == "")
                {
                    MessageBox.Show("密码不能为空!");
                    ClearContorlsF();
                    return;
                }
                if (cfmPWD == "")
                {
                    MessageBox.Show("密码不能为空!");
                    ClearContorlsF();
                    return;
                }

                //当新密码和确认密码一致时,才进入分支
                if (newPWD == cfmPWD)
                {
                    //验证该密码是否符合要求
                    if (ch.CheckPWD(newPWD))
                    {
                        //验证原始密码是否正确
                        if (logic.Login(adminID, oglPWD))
                        {
                            //执行修改密码的方法
                            if (logic.ChangePassword(adminID, newPWD))
                            {
                                MessageBox.Show("密码修改成功!"); //弹出消息框
                                ClearContorlsF(); //清除控件
                            }
                            else
                            {
                                MessageBox.Show("密码修改失败!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("原始密码不正确!");
                            txtOriginalPWD.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("密码长度小于6位");
                        txtNewPWD.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("新密码和确认密码不一致");
                    txtNewPWD.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 清空测试选项卡的方法
        /// </summary>
        private void ClearContorlsG()
        {
            dgview.DataSource = false;
        }
        /// <summary>
        /// 清空报表选项卡的方法
        /// </summary>
        private void ClearContorlsE()
        {
            cbSearchCondition.SelectedIndex = 0;
            dgResultE.DataSource = false;
        }
        private void btnCancelF_Click(object sender, EventArgs e)
        {
            ClearContorlsF(); //调用清除控件的方法
        }
        /// <summary>
        /// 清空更新密码选项卡的方法
        /// </summary>
        private void ClearContorlsF()
        {
            txtOriginalPWD.Text = "";
            txtNewPWD.Text = "";
            txtConfirmPWD.Text = "";
            txtOriginalPWD.Focus();
        }

        delegate void Delegate(); //网上搜的，定义一个新的委托，用来存放函数
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当选项卡更改时，执行对应的清除方法
            //因为委托可以把函数当参数进行传递，所以先新建一个委托
            //通过它新建一个数组，把方法存放进去
            //再循环使用，即可达到选项卡发生改变时清空控件，一一对应
            try
            {
                int num = 0; //设置一个计数的变量
                Delegate[] array = { ClearControlsA, ClearContorlsB, ClearContorlsC, ClearContorlsD, ClearContorlsE, ClearContorlsF, ClearContorlsG }; //创建一个委托数组，用来存放清空控件的方法
                for (int i = 0; i < tabControl1.TabCount; i++) //for循环，循环次数不超过选项卡的数量
                {
                    if (tabControl1.SelectedIndex == num) //当选项卡的索引下标发生改变时
                    {
                        array[num](); //执行这个委托数组内的方法，跟选项卡的下标一一对应
                    }
                    num = num + 1; //每循环一次计一次数
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("公共图书馆的职能就是收藏并且传播先进文化,通过各类文献资料图书的收藏和知识、信息的传播，在索质教育和教育现代化、信息化中发挥着重要作用。\n“书籍是人类进步的阶梯”。\n图书馆也就是一个很重要的、层次很高的服务机构。\n近年来,随着教育和信息技术的飞速发展，图书馆建设滞后的现象已日益成为影响和制约我国教育进一步发展的桎梏。\n\n为了推动学校图书馆建设，促进办学水平的不断提高。\n在通过老师和学生的不懈努力下，构建了这个图书文献信息自动化管理系统。\n\n不仅加大了学校图书馆的建设力度，改进了图书馆目前的运作方式和手段,还提供更为有效和多样化的服务,充分发挥了图书馆信息化、专业化、智能化的功能。");
        }
    }
}
