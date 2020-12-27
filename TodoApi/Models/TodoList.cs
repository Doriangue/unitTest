using System;

namespace TodoApi.Models
{
    public class TodoList
    {
        public long Id { get; set; }
        public string name { get; set; }
        public string content { get; set; }
        public DateTime createdDate { get; set; }
    }
}