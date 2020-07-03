﻿namespace MagicCrawler.Models
{
    public class Endpoint
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Tag { get; set; }
        public string File { get; set; }
        public bool IsVirtual { get; set; }

        public string GetUrl()
        {
            return !string.IsNullOrWhiteSpace(Url) ? Url : Id.ToLower();
        }

        public string GetTag()
        {
            return !string.IsNullOrWhiteSpace(Tag) ? Tag : Id.ToLower();
        }

        public string GetFile()
        {
            return !string.IsNullOrWhiteSpace(File) ? File : $"{Id}.json";
        }
    }
}
