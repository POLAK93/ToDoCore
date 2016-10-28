﻿using System.ComponentModel;

namespace ToDoCore.Model
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
        [DefaultValue(false)]
        public bool Done { get; set; }
    }
}