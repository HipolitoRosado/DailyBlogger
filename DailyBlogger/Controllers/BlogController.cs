using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DailyBlogger.Models;


namespace DailyBlogger.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext _context;
        public BlogController(BlogContext context)
        {
            _context = context;
        }
        public IActionResult List()
        {
            IEnumerable<BlogPost> post = _context.blogPost.ToList<BlogPost>();
            return View();
        }

        public IActionResult New()
        {
            BlogPost blogPost = new BlogPost();

            return View(blogPost);
       
        }

        public IActionResult Details(int id)
        {
            BlogPost blogPost = _context.blogPost.Find(id);
            return View(blogPost);
         
        }

        public IActionResult Edit(int id)
        {
            BlogPost blogPost = _context.blogPost.Find(id);
            return View(blogPost);
        }
    }

}