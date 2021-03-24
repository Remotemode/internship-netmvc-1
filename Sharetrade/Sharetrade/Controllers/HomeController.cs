using Microsoft.AspNetCore.Mvc;
using Sharetrade.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Sharetrade.Mocks;

namespace Sharetrade.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Database Mock.
        /// </summary>
        private readonly List<KeyValuePair<string, Article>> _articles;

        public HomeController()
        {
            // Initialize Database Mock.
            _articles = new ArticleMocks().GetArticleMocks();
        }

        /// <summary>
        /// This is default HomeController`s method.
        /// Route - /home .
        /// </summary>
        /// <returns>
        /// Returns HomePage.
        /// </returns>
        public IActionResult Index()
        {
            // Add item to ViewData.
            ViewData["Articles"] = _articles;

            // Returns HomePage.
            return View();
        }
        /// <summary>
        /// Method returns specify Articles page.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Returns single Articles view.
        /// </returns>
        public IActionResult SingleArticle(string id)
        {
            // Get specify Article.
            var specifyArticle = _articles.FirstOrDefault(item => item.Key == id);

            // Add item to ViewData.
            ViewData["Article"] = specifyArticle.Value;

            // Returns SingleArticle View.
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
