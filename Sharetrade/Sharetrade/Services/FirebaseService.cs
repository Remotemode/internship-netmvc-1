using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Sharetrade.Interfaces;
using Sharetrade.Mocks;
using Sharetrade.Models;

namespace Sharetrade.Services
{
    public class FirebaseService : IFirebaseService
    {
        /// <summary>
        /// Saves Articles mocks to Firebase storage.
        /// </summary>
        /// <returns>
        /// Returns Task.
        /// </returns>
        public async Task AddArticlesMockToFireBase()
        {
            // Get Article mocks.
            var articles = new ArticleMocks().GetArticles();

            // Create FirebaseClient with yours Firebase Storage URL.
            var firebaseClient = new FirebaseClient("Firebase storage URL");


            foreach (var article in articles)
            {
                // Saves Articles mocks to Firebase storage.
                _ = await firebaseClient.Child("Articles").PostAsync(article);
            }
        }

        /// <summary>
        /// Retrieve Articles from Firebase.
        /// </summary>
        /// <returns>
        /// Returns all Articles from Firebase.
        /// </returns>
        public async Task<List<FirebaseObject<Article>>> GetAllArticles()
        {
            // Create FirebaseClient with yours Firebase Storage URL.
            var firebaseClient = new FirebaseClient("Firebase storage URL");

            //Retrieve data from Firebase.
            var dbArticles = await firebaseClient.Child("Articles").OnceAsync<Article>();

            // Returns result.
            return dbArticles.ToList();
        }

        /// <summary>
        /// Method returns specify Article.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Returns Article.
        /// </returns>
        public async Task<Article> GetSpecifyArticle(string id)
        {
            // Check argument. Argument can`t be null or empty.
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));

            //Retrieve data from Firebase.
            var dbArticles = await GetAllArticles();

            // Try to fined Article with specify id.
            var specifyArticle = dbArticles?.FirstOrDefault(i => i.Key == id)?.Object;

            // Returns result.
            return specifyArticle;
        }
    }
}
