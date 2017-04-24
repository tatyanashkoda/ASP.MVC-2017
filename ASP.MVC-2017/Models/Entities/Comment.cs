﻿using System;

namespace ASP.MVC_2017.Models.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Value { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public int? WallId { get; set; }
        public virtual Wall Wall { get; set; }
    }
}