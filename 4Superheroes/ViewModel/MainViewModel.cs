using Superheroes.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Superheroes.ViewModels {
	public class MainViewModel {
		public int NewSpeed { get; set; }
		public string NewName { get; set; }
		public string SelectedUniverse { get; set; }
		public string SelectedGender { get; set; }
		public string NewPower { get; set; }

		public List<string> GenderList { get; set; }
		public List<string> UniverseList { get; set; }

        public ICommand SaveBtnClickedCmd { get; set; }

        public ObservableCollection<SuperheroVm> Heroes { get; set; }

        private Informer SaveBtnClicked;

        public MainViewModel()
        {
            Heroes = new ObservableCollection<SuperheroVm>();
            LoadMasterData();
            SaveBtnClicked = new Informer(SaveEntry);
            SaveBtnClickedCmd = new RelayCommand(SaveBtnClicked);
        }

        private void SaveEntry()
        {
            Heroes.Add(new SuperheroVm()
            {
                Name = NewName,
                Power = NewPower,
                Speed = NewSpeed,
                Gender = SelectedGender,
                Universe = SelectedUniverse
            });
        }

        private void LoadMasterData()
        {
            GenderList = new List<string>
            {
                "male",
                "female",
                "unknown"
            };

            UniverseList = new List<string>
            {
                "DC",
                "Marvel",
                "Whatever"
            };

            Heroes.Add(new SuperheroVm()
            {
                Name = "Thor",
                Gender = "male",

            });
        }
    }
}
