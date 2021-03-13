using Microsoft.AspNetCore.Mvc;
using Sharetrade.Interfaces;
using Sharetrade.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Sharetrade.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// IFirebaseService object.
        /// </summary>
        private readonly IFirebaseService _firebaseService;

        /// <summary> 
        /// Initialize repositories for HomeController.
        /// For more information about Dependency injection https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0 .
        /// </summary>
        /// <param name="firebaseService">
        /// Should be added in advance to Startup.ConfigureServices.
        /// </param>
        public HomeController(IFirebaseService firebaseService)
        {
            _firebaseService = firebaseService ?? throw new ArgumentNullException(nameof(firebaseService));
        }

        /// <summary>
        /// This is default HomeController`s method.
        /// Route - /home .
        /// </summary>
        /// <returns>
        /// Returns HomePage.
        /// </returns>
        public async Task<IActionResult> Index()
        {
            // Get all Articles.
            var dbArticles = await _firebaseService.GetAllArticles();

            // Add item to ViewData.
            ViewData["Articles"] = dbArticles;

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
        public async Task<IActionResult> SingleArticle(string id)
        {
            // Get specify Article.
            var specifyArticle = await _firebaseService.GetSpecifyArticle(id);

            // Add item to ViewData.
            ViewData["Article"] = specifyArticle;

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
