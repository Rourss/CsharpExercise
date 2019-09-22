using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiuXingMing.DAL
{
    interface IDAL<T>
    {
        //通过ID查一项记录
        T FindByID(string id);
        //查找所有内容
        List<T> GetALL();
        //插入一条记录
        bool Insert(T o);
        //更新一条记录
        bool Update(T o);
        //删除一条记录
        bool Delete(T o);
    }
}
