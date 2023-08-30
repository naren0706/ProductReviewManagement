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

    }
}