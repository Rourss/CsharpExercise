using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FlowerMIS.DataAccess
{
    public class DBAccess
    {
        /// <summary>
        /// ִ��insert��update��delete���������Ӱ�������
        /// </summary>
        /// <param name="cmd">Ҫִ�е�����</param>
        /// <returns>������Ӱ�������</returns>
        public static int ExecuteSQL(SqlCommand cmd)
        {
            //1.�������Ӷ���
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Flower"].ConnectionString);
            //2.�����������(���ô������Ӳ�������)
            cmd.Connection = conn; //���ò�������������
            try
            { //���ܳ����쳣�����

                //3.������
                conn.Open();
                //4.ִ������
                int num = cmd.ExecuteNonQuery(); //ִ��SQL����
                return num;
            }
            catch (Exception ex)
            { //�׳��쳣

                throw new DBException(ex);
            }
            finally
            { //�����쳣�󻹼������е����

                //5.�ر�����
                if (conn.State == ConnectionState.Open) //�ж������Ƿ�򿪣�����򿪾͹ر�����
                {
                    conn.Close();
                }
            }

        }

        /// <summary>
        ///ִ��select�������һ������(��������) 
        /// </summary>
        /// <param name="cmd">Ҫִ�е�����</param>
        /// <returns>�鵽��һ������(��������)</returns>
        public static object GetScalar(SqlCommand cmd)
        {
            //1.�������Ӷ���
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Flower"].ConnectionString);
            //2.�����������(���ô������Ӳ�������)
            cmd.Connection = conn; //���ò�������������
            try
            { //���ܳ����쳣�����

                //3.������
                conn.Open();
                //4.ִ������
                object num = cmd.ExecuteScalar();//ִ��SQL����
                return num;
            }
            catch (Exception ex)
            { //�׳��쳣

                throw new DBException(ex);
            }
            finally
            { //�����쳣�󻹼������е����

                //5.�ر�����
                if (conn.State == ConnectionState.Open) //�ж������Ƿ�򿪣�����򿪾͹ر�����
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// ִ��select����������ݼ�
        /// </summary>
        /// <param name="cmd">Ҫִ�е�����</param>
        /// <returns>�鵽�����ݼ�</returns>
        public static DataSet QueryData(SqlCommand cmd)
        {
            //1.�������Ӷ���
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Flower"].ConnectionString);
            //2.�����������(���ô������Ӳ�������)
            cmd.Connection = conn; //���ò�������������
            //2.1.������������������
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            //2.2.�������ݼ�����
            DataSet ds = new DataSet();

            try
            { //���ܳ����쳣�����

                ////3.�����ӣ���Ϊ���ݼ����Զ������ӣ�
                //conn.Open();
                //4.ִ������
                ada.Fill(ds); //������ݼ�
                return ds;
            }
            catch (Exception ex)
            { //�׳��쳣

                throw new DBException(ex);
            }
            //finally
            //{ //�����쳣�󻹼������е����

            //    ////5.�ر����ӣ���Ϊ���ݼ����Զ��ر����ӣ�
            //    //if (conn.State == ConnectionState.Open) //�ж������Ƿ�򿪣�����򿪾͹ر�����
            //    //{
            //    //    conn.Close();
            //    //}
            //}
        }
    }
}

