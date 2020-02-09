using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CandyShop.Models;

namespace CandyShop.Controllers
{
    public class CandyController : Controller
    {

        private readonly ICandyRepository _candyRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;
        }


        public IActionResult Index()
        {
            return View();
        }

        public ViewResult List()
        {
            IEnumerable<Candy> candyList = _candyRepository.GetAllCandy;
            return View(candyList);
        }
    }
}