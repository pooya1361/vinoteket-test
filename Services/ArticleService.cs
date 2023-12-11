using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VinoteketTestWebApp.Models;
using VinoteketTestWebApp.Repositories;

namespace VinoteketTestWebApp.Services
{
    public class ArticleService
    {
        private ArticleRepository _articleRepository;
        public ArticleService(ArticleRepository articleRepository) {
            this._articleRepository = articleRepository;
        }

        public Product GetArticle(string url)
        {

            if (string.IsNullOrEmpty(url))
                return null;

            return _articleRepository.GetArticle(url);
        }

        public List<Product> GetAllArticles()
        {
            return _articleRepository.GetAllArticles();
        }
    }
}