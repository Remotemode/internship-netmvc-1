using Firebase.Database;
using Sharetrade.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sharetrade.Interfaces
{
    /// <summary>
    /// Specification for working with Firebase.
    /// </summary>
    public interface IFirebaseService
    {
        /// <summary>
        /// Saves Articles mocks to Firebase storage.
        /// </summary>
        /// Returns Task.
        Task AddArticlesMockToFireBase();

        /// <summary>
        /// Retrieve Articles from Firebase.
        /// </summary>
        /// <returns>
        /// Returns all Articles from Firebase.
        /// </returns>
        Task<List<FirebaseObject<Article>>> GetAllArticles();

        /// <summary>
        /// Method returns specify Article.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Returns Article.
        /// </returns>
        Task<Article> GetSpecifyArticle(string id);
    }
}
