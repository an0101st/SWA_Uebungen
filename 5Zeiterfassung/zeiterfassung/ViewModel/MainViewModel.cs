using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace zeiterfassung.ViewModel {

	public class MainViewModel : ViewModelBase {

		private TimeEntryVm newEntry { get; set; }
		public TimeEntryVm NewEntry {
			get {
				return newEntry;
			}
			set {
				newEntry = value;
				RaisePropertyChanged();
			}
		}

		public ObservableCollection<string> CustomerList { get; set; }
		public ObservableCollection<string> Tasklist { get; set; }

		public ObservableCollection<TimeEntryVm> History { get; set; }

		public RelayCommand SaveBtn { get; set; }
		public RelayCommand ExportBtn { get; set; }

		public MainViewModel() {
			NewEntry = new TimeEntryVm();

			LoadMasterData();

			SaveBtn = new RelayCommand(SaveEntry);
			ExportBtn = new RelayCommand(Export);
		}

		private void LoadMasterData() {
			History = new ObservableCollection<TimeEntryVm>();

			CustomerList = new ObservableCollection<string>();
			CustomerList.Add("IES");
			CustomerList.Add("IBM");

			Tasklist = new ObservableCollection<string>();
			Tasklist.Add("Whaat");
			Tasklist.Add("Ever");

			History.Add(new TimeEntryVm() {
				Task = "Test",
				Notiz = "Notiz"
			});
		}

		private void SaveEntry() {
			History.Add(NewEntry);

			NewEntry = new TimeEntryVm();
		}

		private void Export() {
			History.Add(new TimeEntryVm());

			NewEntry = new TimeEntryVm();
		}
	}
}