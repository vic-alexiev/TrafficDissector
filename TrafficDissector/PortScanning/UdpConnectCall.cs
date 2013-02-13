using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TrafficDissector.PortScanning
{
    internal static class UdpConnectCall
    {
        #region Connect

        public static ScanMessage Connect(EndPoint remoteEndPoint, int timeout)
        {
            Socket socketToServer = null;

            byte[] buffer = new byte[1024];

            try
            {
                socketToServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                socketToServer.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, timeout);

                socketToServer.Connect(remoteEndPoint);

                string greeting = "Hello, are you there?";
                buffer = Encoding.ASCII.GetBytes(greeting);

                socketToServer.Send(buffer);

                int received = socketToServer.Receive(buffer);

                return ScanMessage.PortOpened;
            }
            catch (SocketException ex)
            {
                if (ex.SocketErrorCode == SocketError.HostUnreachable)
                {
                    return ScanMessage.PortClosed;
                }

                return ScanMessage.Timeout;
            }
            catch (Exception)
            {
                return ScanMessage.Unknown;
            }
            finally
            {
                if (socketToServer != null)
                {
                    socketToServer.Close();
                }
            }
        }

        #endregion
    }
}
