using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VinoteketTestWebApp.Repositories;

namespace VinoteketTestWebApp.Services
{
    public class ArticleService
    {
        private ArticleRepository _articleRepository;
        public ArticleService(ArticleRepository articleRepository) {
            this._articleRepository = articleRepository;
        }

        public string GetArticle(string url) {

            if (string.IsNullOrEmpty(url))
                return null;

            return _articleRepository.GetArticle(url);
        }
    }
}