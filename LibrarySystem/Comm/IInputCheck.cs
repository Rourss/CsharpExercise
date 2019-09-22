using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Comm
{
    interface IInputCheck
    {
        //接口是一种规范,它只包含抽象属性和抽象方法
        bool CheckBookID(string bookID);
        bool CheckISBN(string ISBN);
        bool CheckPWD(string PWD);
    }
}
