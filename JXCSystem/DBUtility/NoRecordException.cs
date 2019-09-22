using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiuXingMing.DBUtility
{
    public class NoRecordException:Exception //异常类
    {
        public NoRecordException() //构造函数
            : base("没有这条记录") //调用父类构造函数
        {

        }
        public NoRecordException(string message) // 构造函数
            : base(message) //调用父类构造函数
        {

        }

    }
}
