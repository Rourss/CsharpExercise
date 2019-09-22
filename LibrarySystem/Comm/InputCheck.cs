using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Comm
{
   public class InputCheck:IInputCheck
    {
        public bool CheckBookID(string bookID)
        {
            //通过ToArray方法把字符串转成字符数组
            //就可以通过字符的编码范围进行判断是否在范围内
            char[] cha = bookID.ToArray(); //创建一个字符数组用来存放通过ToArray方法转换后的字符
            string initial = bookID.Substring(0, 1); //截取字符串，从第一个开始截一位
            if (Convert.ToChar(initial) > 64 && Convert.ToChar(initial) < 91) //如果输入的首字母是大写，进入分支：真
            {
                for (int i = 0; i < cha.Length; i++) //for循环遍历字符数组，循环次数小于这个数组的长度
                {
                    if (cha[i] >= 0x4e00 && cha[i] <= 0x9fbb) //判断输入的编号是否有中文（通过中文的编码范围判断），如果有返回：假
                    {
                        return false;
                    }
                    if (cha[i] >= 32 && cha[i] <= 44 || cha[i]>=59 && cha[i]<=64) //判断输入的编号是否有特殊字符（通过特殊字符的编码范围判断），如果有返回：假
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckISBN(string ISBN)
        {
            int sum1 = 0; //用于计算公式后之和的变量
            int sum2 = 0; //计算奇偶乘之和的变量
            int isbn1 = 0; //用来存放截取到的最后一位数
            int isbn2 = 0; //用来存放截取到的最后一位数
            int s=10; //初值为10，用于计算⑩位的ISBN
            char[] cha = ISBN.ToArray(); //通过ToArray方法把字符串转成字符
            if (cha.Length == 10) //如果ISBN为10位，进入分支
            {
                string sub = ""; //字符串变量主要用来存放X
                if (ISBN.Substring(9, 1) is string)  //把截取到的字符串进行 is转换 （主要用于防止转换失败抛出异常）
                {
                    sub = ISBN.Substring(9, 1); //存放
                }
                else
                {
                    isbn1 = Convert.ToInt32(ISBN.Substring(9, 1)); //取出值并转成int
                }
                for (int i = 0; i < cha.Length-1; i++) //循环字符数组，次数小于这个数组的长度
                {
                    sum1 += int.Parse(cha[i].ToString()) * s; //进行公式计算
                    s--; //每次减一
                }
                int remainder1 = 0; //用于存放和除11后的余数的变量
                int differ1 = 0; //用于存放11减余数的差的变量
                int newisbn1 = 0; //用来存放通过计算公式后得到的isbn值
                remainder1 = sum1 % 11; //和除11的余数
                differ1 = 11 - remainder1; //11减余数
                newisbn1 = differ1; //计算后的isbn
                if (newisbn1 == 10) //进过计算后的最后一位值，如果是10
                {
                    string newisbn2 = "X"; //校验码是X
                    if (newisbn2 == sub) //判断截取到的最后一位是否和计算后的相同
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (newisbn1 == 11) //进过计算后的最后一位值，如果是11
                {
                    newisbn1 = 0; //ISBN最后一位为0
                    if (newisbn1 == isbn1) //判断截取到的最后一位是否和计算后的相同
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (newisbn1 == isbn1) //判断截取到的最后一位是否和计算后的相同
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //当ISBN是13位时，进入分支进行判断
            else if (cha.Length == 13) //判断长度是否是13位
            {
                for (int i = 0; i < cha.Length - 1; i++) //for循环遍历数组，长度减一，把最后一位略掉
                {
                    if (cha[i] >= 48 && cha[i] <= 57) //判断输入的是不是数字，通过数字的编码范围判断
                    {
                        int odd = 0; //用来存放奇数位乘1后的值
                        int even = 0; //用来存放偶数位乘3后的值
                        isbn2 = Convert.ToInt32(ISBN.Substring(12, 1)); //截取字符串，从12位开始截一个
                        if (cha[i] % 2 == 1) //判断是否是奇数
                        {
                            odd = int.Parse(cha[i].ToString()) * 1; //奇数位的乘1
                        }
                        else
                        {
                            even = int.Parse(cha[i].ToString()) * 3; //偶数位的乘3
                        }
                        sum2 += odd + even; //奇数偶数位计算后加起来然后赋给sum，存好总数
                    }
                    else
                    {
                        return false;
                    }
                }
                int remainder2 = 0; //用于存放和除10后的余数的变量
                int differ2 = 0; //用于存放10减余数的差的变量
                int newisbn3 = 0; //用来存放通过计算公式后得到的isbn值
                remainder2 = sum2 % 10; //和除10的余数
                differ2 = 10 - remainder2; //10减余数
                newisbn3 = differ2; //计算后的isbn
                if (newisbn3 == 10)
                {
                    newisbn3 = 0;
                }
                if (newisbn3 != isbn2) //判断计算后的isbn和输入的isbn是否相同
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
            
        public bool CheckPWD(string PWD)
        {
            if (PWD.Length >= 6) //如果密码长度不够6位返回假
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
