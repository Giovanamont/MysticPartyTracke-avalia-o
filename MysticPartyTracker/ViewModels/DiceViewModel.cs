using System;
using System.Collections.Generic;
using System.Linq;
using MysticPartyTracker.ViewModels;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace MysticPartyTracker.ViewModels
{
   public partial class DiceViewModel: ObservableObject
    {

        public  DiceViewModel() { 
        RollCommand = new Command(Roll);
        }
        [ObservableProperty]
        public int _numberSides;

        [ObservableProperty]
        public int quantity;

        [ObservableProperty]
        public int _total;

        private observableCollection<int > rolls = new observableCollection<int>();
        public ObservableCollection<int> Rolls { 
            get { return _rolls; }
            set { _rolls = value; }
        }
        public ICommand RollCommand { get; }

        public void Roll()
        {
            Rolls.Clear
            total = 0;
            Dice dice = new Dice(SidesPicker);

                 for (int i = 0; i < quantity; i++) ;
            {
                int roll = dice.Roll ();
                Rolls.Add(roll);
                total += roll;
            }
           
        }

    }
}
