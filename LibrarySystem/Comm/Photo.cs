using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library.Comm
{
   public class Photo
    {
       /// <summary>
       /// 把图片文件转成二进制数组的方法
       /// </summary>
       /// <param name="fileName">图片文件名(含路径)</param>
       /// <returns>二进制数组</returns>
        public byte[] ReadPhoto(string fileName)
        {
            FileStream f = new FileStream(fileName, FileMode.Open, FileAccess.Read); //创建一个文件流的对象,把图片的文件名传入

            BinaryReader reader = new BinaryReader(f); //创建一个二进制流读取器的对象,把文件流的对象传入
            byte[] buffer = reader.ReadBytes(Convert.ToInt32(f.Length)); //创建一个二进制数组,用于存放从流中读取出来的数据
            return buffer; //返回这个二进制数组
           
        }
    }
}
