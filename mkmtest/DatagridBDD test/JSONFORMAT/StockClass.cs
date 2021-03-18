using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class StockClass
{
    public class Language
    {
        public int idLanguage { get; set; }
        public string languageName { get; set; }
    }

    public class Product
    {
        public int idGame { get; set; }
        public string image { get; set; }
        public string enName { get; set; }
        public string locName { get; set; }
        public string expansion { get; set; }
        public string nr { get; set; }
        public int expIcon { get; set; }
        public string rarity { get; set; }
    }

    public class Article
    {
        public int idArticle { get; set; }
        public int idProduct { get; set; }
        public Language language { get; set; }
        public string comments { get; set; }
        public double price { get; set; }
        public int idCurrency { get; set; }
        public string currencyCode { get; set; }
        public int count { get; set; }
        public bool inShoppingCart { get; set; }
        public DateTime lastEdited { get; set; }
        public Product product { get; set; }
        public string condition { get; set; }
        public bool isFoil { get; set; }
        public bool isSigned { get; set; }
        public bool isPlayset { get; set; }
        public bool isAltered { get; set; }
        public bool? isFirstEd { get; set; }
        public bool? isFullArt { get; set; }
        public bool? isUberRare { get; set; }
    }

    public class Root
    {
        public List<Article> article { get; set; }
    }
}
