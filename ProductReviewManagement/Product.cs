namespace ProductReviewManagement
{
    internal class Product
    {
        public int ProductId { get; set; }
        public int User { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }
    }
}