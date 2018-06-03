using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcNews.Models
{
    public class NewsItem
    {
        [Key]
        public int Id { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TimeStamp { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(140)]
        public string Text { get; set; }

        public NewsItem() { }

        public NewsItem(DateTime TimeStamp)
        {
            this.TimeStamp = TimeStamp;
        }
    }

    public class NewsDBContext : DbContext
    {
        public DbSet<NewsItem> News { get; set; }
        public NewsDBContext() : base("NewsConnection") { }
    }

}