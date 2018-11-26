using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Communication {
	internal class ClientHandler {
		private Action<string> update;
		private Socket socket;
		private byte[] buffer = new byte[512];

		public ClientHandler(Socket socket, Action<string> update) {
			this.update = update;
			this.socket = socket;
			Task.Factory.StartNew(ReceiveData);
		}

		private void ReceiveData() {
			while (true) {
				int length = socket.Receive(buffer);
				string temp = Encoding.UTF8.GetString(buffer, 0, length);
			}
		}

		internal void Send(string message) {
			socket.Send(Encoding.UTF8.GetBytes(message));
		}
	}
}