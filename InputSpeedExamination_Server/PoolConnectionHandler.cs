using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InputSpeedExamination_Server
{
    public class PoolConnectionHandler
    {

        /// <summary>
        ///  池
        /// </summary>
        public static LinkedList<TcpClient> pool = new LinkedList<TcpClient>();

        /// <summary>
        /// 
        /// </summary>
        protected TcpClient client = null;

        /// <summary>
        /// 
        /// </summary>
        public PoolConnectionHandler() { }

        /// <summary>
        /// 业务处理
        /// </summary>
        public void HandleConnection()
        {

            try
            {
                //这里调用，   业务层的方法

                HandleMain.Handle(client);

            }
            catch
            { }

        }


        /// <summary>
        /// 将未处理的请求加入池中
        /// </summary>
        /// <param name="requestToHandle"></param>
        public static void ProcessRequest(TcpClient requestToHandle)
        {
            //对池进行加锁
            lock (pool)
            {
                //把未处理的请求加入池
                pool.AddLast(requestToHandle);
                //将等待线程被唤醒
                Monitor.PulseAll(pool);
            }
        }



        /// <summary>
        ///  一直接读取pool(池),并且对pool进行加锁,判断其集合是否为空
        /// 如果pool为空,则一直的读取
        /// 如要pool不为空,则取出第一个值,到了这一步锁解除(保存池取值的过程是安全,取出的值是唯一),接着执行handleConnection
        /// </summary>
        public void Run()
        {
            while (true)
            {
                try
                {
                    lock (pool)
                    {
                        while (pool.Count == 0)
                        {
                            Monitor.Wait(pool);
                        }
                        //取第一个值
                        client = pool.First.Value;
                        //移除
                        pool.RemoveFirst();
                    }
                    HandleConnection();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

    }
}
