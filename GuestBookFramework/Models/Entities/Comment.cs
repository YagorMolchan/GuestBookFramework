using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuestBookFramework.Models.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}