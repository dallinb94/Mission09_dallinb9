using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission09_dallinb9.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_dallinb9.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository repo;

        public HomeController (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 5;
            
            var data = repo.Books
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize);

            return View(data);
        }
    }
}
