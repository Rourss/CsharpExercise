using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Library.Comm
{
  public class Encrypt:IEncrypt //调用接口
    {
      /// <summary>
      /// 加密密码的方法
      /// 通过新建两个类对象，调用它们内的方法加密
      /// </summary>
      /// <param name="pwd">管理员密码</param>
      /// <returns></returns>
        public byte[] EncryptPassword(string pwd)
        {
            //由于SHA加密方法只能加密字节数组，不能加密字符串，所以
            //1.先创建ASCII编码类的对象，调用其中的方法把传入的字符串重新编码成字节数组
            //2.然后创建SHA加密类的对象，调用其中的方法把转好的字节数组进行加密

            ASCIIEncoding en = new ASCIIEncoding(); //创建ASCII编码类的对象，用来调用它里面的方法把字符串转成字节数组
            byte[] password = en.GetBytes(pwd); //调用方法把传入的字符串密码转成字节数组

            SHA1Managed sha = new SHA1Managed(); //创建SHA加密类的对象，用来调用它里面的方法把字节数组加密
            return sha.ComputeHash(password); //返回加密后的密码
        }
    }
}
