using Microsoft.AspNetCore.Mvc;
using Sharetrade.Interfaces;
using System;
using System.Threading.Tasks;

namespace Sharetrade.Controllers
{
    public class FirebaseController : Controller
    {
        /// <summary>
        /// IFirebaseService object.
        /// </summary>
        private readonly IFirebaseService _firebaseService;

        /// <summary> 
        /// Initialize repositories for FirebaseController.
        /// For more information about Dependency injection https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0 .
        /// </summary>
        /// <param name="firebaseService">
        /// Should be added in advance to Startup.ConfigureServices.
        /// </param>
        public FirebaseController(IFirebaseService firebaseService)
        {
            _firebaseService = firebaseService ?? throw new ArgumentNullException(nameof(firebaseService));
        }

        /// <summary>
        /// Saves Articles mocks to Firebase storage.
        /// </summary>
        /// <returns>
        /// StatusCode 200.
        /// </returns>
        public async Task<IActionResult> Index()
        {
            await _firebaseService.AddArticlesMockToFireBase();

            return Ok();
        }
    }
}
