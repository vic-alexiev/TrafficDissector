using System;
using System.Net;
using System.Net.Sockets;

namespace TrafficDissector.PortScanning
{
    internal class TcpConnectCall
    {
        #region Private Fields

        private Socket socket;
        private Exception connectFailureException;

        #endregion


        #region Constructor

        /// <summary>
        /// The constructor is hidden in order to ensure static access
        /// </summary>
        /// <param name="socket"></param>
        private TcpConnectCall(Socket socket)
        {
            connectFailureException = null;

            // assign the socket on which a connection attempt will be made
            this.socket = socket;
        }

        #endregion


        #region Public Static Methods

        public static ScanMessage Connect(EndPoint remoteEndPoint, int timeout)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            TcpConnectCall connectCall = new TcpConnectCall(socket);

            // Need for controlling timeout period introduces us to asynccallback methods
            AsyncCallback connectedCallback = new AsyncCallback(connectCall.ConnectedCallback);

            try
            {
                IAsyncResult result = socket.BeginConnect(remoteEndPoint, connectedCallback, socket);

                // wait for timeout to connect
                if (result.AsyncWaitHandle.WaitOne(timeout, false) == false)
                {
                    return ScanMessage.Timeout;
                }
                else
                {
                    Exception connectException = connectCall.connectFailureException;
                    if (connectException != null)
                    {
                        return ScanMessage.PortClosed;
                    }

                    return ScanMessage.PortOpened;
                }
            }
            finally
            {
                socket.Close();
            }
        }

        #endregion


        #region private methods

        private void ConnectedCallback(IAsyncResult result)
        {
            try
            {
                Socket socketToServer = (Socket)result.AsyncState;
                socketToServer.EndConnect(result);
            }
            catch (Exception exception)
            {
                connectFailureException = exception;
            }
        }

        #endregion
    }
}
