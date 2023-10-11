namespace E_Shop.Models.Entities
{
    public class GiftCard
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Message { get; set; }
        public int Balance { get; set; }
        public User user { get; set; }

    }
}
