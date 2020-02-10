using System;

public class EventHandler
{
    public EventHandler(EventViewModel eventViewModel)
    {
        EventViewModel = eventViewModel;
    }

    public void Delete(Event ev)
    {

    }

    public void CreateEvent()
    {
        Event ev = new Event(EventViewModel._id, EventViewModel._name,EventViewModel._descripition,EventViewModel._place,EventViewModel._date,EventViewModel._time,EventViewModel._date,EventViewModel._time);
        Datetime dt = DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime(EventViewModel._date,EventViewModel._time);
        EventViewModel.catalogSingleton._events.AddEvent(ev);
    }
    public ViewModel.EventViewModel EventViewModel { get; set; }
   
}
