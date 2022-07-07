﻿namespace ChatApp.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public User FromUser { get; set; }
        public int InGroupId { get; set; }
    }
}
