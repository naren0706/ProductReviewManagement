namespace ProductReviewManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Operation operation = new Operation();
            List<Product> products = operation.AddValuesToList();
            //operation.Display(products);
            operation.RetrieveTopRecords(products);
        }       
    }
}