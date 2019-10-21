using EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFCodeFirst.Services
{
    public class BlogPostRepository
    {
        public List<BlogPost> ObtenerTodos()
        {
            using (var db = new BlogContext())
            {
                return db.BlogPost.Include(x => x.Comentarios).ToList();
            }
        }

        internal void Crear(BlogPost model)
        {
            using (var db = new BlogContext())
            {
                db.BlogPost.Add(model);
                db.SaveChanges();
            }
        }
    }
}