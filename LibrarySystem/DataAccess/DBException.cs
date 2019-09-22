using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class DBException:Exception //异常类
    {
        public DBException(Exception innerException) //构造函数
            : base("不能访问数据库", innerException) //调用父类构造函数
        {

        }
    }
}
