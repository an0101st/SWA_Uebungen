using Communication;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ChatApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
		private bool isRunning = false;
		private TcpCom com { get; set; }

		string ip = "127.0.0.1";
		int port = 10100;

		public RelayCommand ActAsClientBtn { get; set; }
		public RelayCommand ActAsServerBtn { get; set; }
		public RelayCommand SendBtn { get; set; }
		public RelayCommand ClearBtn { get; set; }

		public string Message { get; set; }
		public ObservableCollection<string> History { get; set; }

		public MainViewModel()
        {
			History = new ObservableCollection<string>();

			ActAsClientBtn = new RelayCommand(
				() => {
					isRunning = true;
					com = new TcpCom(false, ip, port, UpdateGui);	
				},
				() => { return !isRunning; }
			);
			ActAsServerBtn = new RelayCommand(
				() => {
					isRunning = true;
					com = new TcpCom(true, ip, port, UpdateGui);
				},
				() => { return !isRunning; }
			);
			SendBtn = new RelayCommand(
				() => { com.SendData(Message); },
				() => { return Message != null && Message.Length > 0 && isRunning; }	
			);
			ClearBtn = new RelayCommand(
				() => { History.Clear(); }, //execute
				() => { return History.Count > 0; } //canexecute
			);
		}

		private void UpdateGui(string message) {
			History.Add(message);
		}
	}
}