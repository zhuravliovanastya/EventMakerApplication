using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class EventCatalogSingleton
    {

        public ObservableCollection<Event> _events { get; set; }

        private static EventCatalogSingleton _Instance;

        private EventCatalogSingleton()
        {
            _events = new ObservableCollection<Event>();

            _events.Add(new Event(1, "Roskilde Festival", "A lot of loud music", "Roskilde", new DateTime(2020, 6, 9, 12, 0, 0)));
            _events.Add(new Event(2, "Jazz Festival", "A lot of jazz music", "Copenhagen", new DateTime(2020, 8, 7, 13, 0, 0)));
        }

        public static EventCatalogSingleton Instance
        {
            get
            {
                return _Instance ?? (_Instance = new EventCatalogSingleton());
            }

        }
    }
}