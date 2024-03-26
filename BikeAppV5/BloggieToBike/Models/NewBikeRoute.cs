﻿using Microsoft.Extensions.Hosting;

namespace BloggieToBike.Models
{
    public class NewBikeRoute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public int Elevation { get; set; }
        public string Direction { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string StravaLink { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool Featured { get; set; }

        public ICollection<Event>? Events { get; }
    }
}
