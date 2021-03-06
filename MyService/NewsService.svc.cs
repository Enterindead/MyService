﻿using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace MyService
{
    public class NewsService : INewsHandler
    {

        NewsCollection NewsFromXML = NewsSerializer.Deserialize();

        public int NewsCount()
        {
            return NewsFromXML.New.Length;
        }
        
        public List<New> GetNewsFromTable()
        {
            using (var db = new NewsContext())
            {
                //Database.SetInitializer<NewsContext>(null);
                var query = from b in db.News
                            select b;
                List<New> ReceivedNews = new List<New> { };
                foreach (var item in query)
                {
                    ReceivedNews.Add(item);
                }
                return ReceivedNews;
            }
        }

        public New GetNewByNumber(int number)
        {

            if (NewsFromXML.New.Length > number)
            {
                return NewsFromXML.New[number];
            }

            return null;
        }

        public void SaveNewByNumber(int number)
        {
            using (var db = new NewsContext())
            {
               New newToSave = null;
                if (NewsFromXML.New.Length > number)
                {
                    newToSave =  NewsFromXML.New[number];
                    db.News.Add(newToSave);
                    db.SaveChanges();
                }
            }
        }
    }

    public class NewsContext : DbContext
    {
        public DbSet<New> News { get; set; }
    }
}
