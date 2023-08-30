using System.ComponentModel.DataAnnotations;

namespace ProductReviewManagement
{
    internal class Operation
    {
        public static Random rnd = new Random();
        public void Display(List<Product> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ProductId + " | " + item.User + " | " + item.Rating + " | " + item.Review + " | " + item.IsLike + " | " );
            }
        }
        internal List<Product> AddValuesToList()
        {
            List<Product> products = new List<Product>();

            for (int i = 0; i < 25; i++)
            {
                Product product = new Product()
                {
                    ProductId = i,
                    User = i,
                    Rating = rnd.Next(6),
                    Review = GoodOrBad(),
                    IsLike = TORF(),
                };
                products.Add(product);
            }
            return products;
        }
        private bool TORF()
        {
            return rnd.Next(2) == 1;
        }

        private string GoodOrBad()
        {
            if (TORF())
            {
                return "GOOD";
            }
            else
            {
                return "BAD";
            }
        }

        internal void RetrieveTopRecords(List<Product> list)
        {
            var result = list.Where(x=>x.Rating==5).ToList();
            Display(result);
        }

        internal void RetrieveAllRecordsWithCondition(List<Product> list)
        {
            var result = list.Where(x => x.Rating>3 && (x.ProductId==1 || x.ProductId==4 || x.ProductId==9)).ToList();
            Display(result);
        }

        internal void RetrieveReviewCount(List<Product> list)
        {
            var result = list.GroupBy(x => x.ProductId).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var data in result)
            {
                Console.WriteLine(data.ProductID + "   " + data.Count);
            }
        }

        internal void SkipTopRecords(List<Product> list)
        {
            var result = list.Skip(5).ToList();
            Display(result);
        }

        internal void RetrieveProductIdAndReview(List<Product> list)
        {
            var result = list.Select(x => new { ProductId = x.ProductId, Review = x.Review });
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductId+" | "+item.Review);
            }
        }
    }
}