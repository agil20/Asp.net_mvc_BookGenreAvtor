using ManyToMany.DAL;
using ManyToMany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToMany.Controllers
{
  
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _config;

        public HomeController(AppDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public IActionResult Index()
        {
            List<Book> books = _context.Books.
                Include(i=>i.Images).
                Include(b=>b.BookAuthors)
                .ThenInclude(a=>a.Author).ToList();
           return View(books);
        }

       
    }
}
