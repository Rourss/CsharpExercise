using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FlowerMIS.Comm
{
   public class Photo
    {
        public byte[] ReadPhoto(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read); //创建一个文件流的对象,把图片的文件名传入

            BinaryReader reader = new BinaryReader(fs); //创建一个二进制流读取器的对象,把文件流的对象传入
            byte[] buffer = reader.ReadBytes(Convert.ToInt32(fs.Length)); //创建一个二进制数组,用于存放从流中读取出来的数据
            return buffer; //返回这个二进制数组

        }
    }
}
