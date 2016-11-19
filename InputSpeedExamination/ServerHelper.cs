using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Net;
using System.Net.Sockets;

namespace InputSpeedExamination
{
    public static class ServerHelper
    {

        static string server_address_in = "server-in.inputspeedexamination.yejinmo.com";
        static string server_address_out = "server-out.inputspeedexamination.yejinmo.com";
        static string server_address = "";
        static byte[] result = new byte[1024];
        static int server_prot = 9671;

        #region 初始化

        /// <summary>
        /// 初始化客户端并尝试连接服务器
        /// </summary>
        /// <returns>成功连接的服务器地址</returns>
        public static string Load()
        {
            server_address = GetHostNameToIP(server_address_in);
            if (CheckServer(server_address, server_prot))
                return server_address;
            else
            {
                server_address = GetHostNameToIP(server_address_out);
                if (CheckServer(server_address, server_prot))
                    return server_address;
            }
            return null;
        }

        /// <summary>
        /// 域名转换为IP地址
        /// </summary>
        /// <param name="hostname">域名或IP地址</param>
        /// <returns>IP地址</returns>
        public static string GetHostNameToIP(string hostname)
        {
            try
            {
                IPAddress ip;
                if (IPAddress.TryParse(hostname, out ip))
                    return ip.ToString();
                else
                    return Dns.GetHostEntry(hostname).AddressList[0].ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region 方法

        /// <summary>
        /// 检查服务器状态是否可用
        /// </summary>
        /// <param name="ip">服务器IP</param>
        /// <param name="port">服务器端口</param>
        /// <returns>可用状态</returns>
        public static bool CheckServer(string ip, int port)
        {
            try
            {

                return true;
            }
            catch
            {

                return false;
            }
        }

        #endregion

    }
}
