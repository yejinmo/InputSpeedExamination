using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace InputSpeedExamination_Server
{
    public class HandleMain
    {

        public static void Handle(TcpClient client)
        {
            Console.WriteLine("当前线程：" + System.Threading.Thread.CurrentThread.Name);

            NetworkStream networkStream = null;
            //输入
            StreamReader streamReader = null;

            FileStream fileStream = null;
            byte[] buffer = null;

            int length = 3 * 1024;

            try
            {
                networkStream = client.GetStream();
                streamReader = new StreamReader(networkStream);

                //文件名
                string fileName = streamReader.ReadLine();

                fileStream = new FileStream(@"E:\1\" + fileName, FileMode.Create, FileAccess.Write);

                int readLength = 0;

                // int   sumLength = 0;
                //     DateTime myDtStart = DateTime.Now;

                buffer = new byte[length];

                while ((readLength = networkStream.Read(buffer, 0, length)) > 0)
                {
                    fileStream.Write(buffer, 0, readLength);
                    fileStream.Flush();

                    //总量
                    //   sumLength += readLength;
                    //double total = sumLength / 1000;

                    //    TimeSpan ts = DateTime.Now - myDtStart;
                    //当前速度
                    //     double speed = total / ts.TotalSeconds;
                }
                fileStream.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                if (networkStream != null)
                {
                    networkStream.Close();
                }
                if (client != null)
                {
                    client.Close();
                }
            }
        }


    }
}
