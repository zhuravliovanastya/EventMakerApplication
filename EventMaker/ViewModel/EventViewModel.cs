using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Model;


namespace EventMaker.ViewModel
{
    class EventViewModel : INotifyPropertyChanged
    {
        private int _id;
        private string _name, _description, _place;
        private DateTimeOffset _date;
        private TimeSpan _time;
        private ICommand _createEventCommand;
        private Relaycommand._instance

        public Handler.EventHandler EventHandler { get; set; }

        public EventCatalogSingleton catalogSingelton { get; set; }

        public ICommand CreateEventCommand
        {
            get { return _createEventCommand; }
            set { _createEventCommand = value; }
        }


        public EventViewModel()
        {

            _id = Id;
            _name = Name;
            _description = Description;
            _place = Place;
            _date = Date;
            _time = Time;
            _createEventCommand = new RelayCommand(EventHandler.CreateEvent);
            DateTime dt = System.DateTime.Now;
            _date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, new TimeSpan());
            _time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
            EventHandler = new Handler.EventHandler(this);
          

        }

        public int Id
        { get
            { return _id; } set { _id = value; OnPropertyChanged(); } }
        public string Name {
            get { return _name; }
            set {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string Description {
            get { return _description; }
            set { _description = value; OnPropertyChanged(); }
        }
        
   


        public string Place { get { return _place; }
            set { _place = value; OnPropertyChanged(); } }
        public DateTimeOffset Date { get { return _date; } set { _date = value; OnPropertyChanged(); } }
        public TimeSpan Time { get { return _time; } set { _time = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
