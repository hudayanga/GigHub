using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GigHub.DAL;
using GigHub.ViewModels;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private GigDbContext dbContext;
        public GigsController()
        {
            dbContext = new GigDbContext();
        }
        // GET: Gigs
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel()
            {
                Genres=dbContext.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}