using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comic_book_gallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public string DescriptionHtml { get; set; }
        public int IssueNumber { get; set; }
        public Artists[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
            return SeriesTitle + " #" + IssueNumber;
            }
        }

        //series-title-issuenumber.jpg
        public string CoverImagefileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-")
                    .ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}