﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class Event
    {
        private int _id;
        private string _name;
        private string _description;
        private string _place;
        private DateTime _dateTime;

        public Event(int id, string name, string description, string place, DateTime dateTime)
        {
            Id = id;
            Name = name;
            Description = description;
            Place = place;
            DateTime = dateTime;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public string Place { get => _place; set => _place = value; }
        public DateTime DateTime { get => _dateTime; set => _dateTime = value; }

        public override string ToString()
        {
            return $"{nameof(Id)}:{Id}, {nameof(Name)}: {Name},  {nameof(Description)}: {Description},  {nameof(Place)}: {Place},  {nameof(DateTime)}: {DateTime}";

        }
    }
}
