using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Communication
{
    public class TcpCom
    {
		Socket serverSocket;
		private List<ClientHandler> connectedClients;

		public TcpCom(bool isServer, string ip, int port, Action<string> update) {
			if (isServer) {
				serverSocket = new Socket(
					AddressFamily.InterNetwork,
					SocketType.Stream,
					ProtocolType.Tcp
					);
				serverSocket.Bind(new IPEndPoint(IPAddress.Parse(ip), port));
				serverSocket.Listen(5);
				ThreadPool.QueueUserWorkItem(AcceptClient);
			} else {
				TcpClient tcp = new TcpClient();
				tcp.Connect(new IPEndPoint(IPAddress.Parse(ip), port));
				connectedClients.Add(new ClientHandler(tcp.Client));
			}
		}

		private void AcceptClient(object state) {
			while (true) {
				connectedClients.Add(new ClientHandler(serverSocket.Accept(), update));
			}
		}

		public void SendData(string message) {
			foreach (var item in connectedClients) {
				item.Send(message);
			}
		}
	}
}
