namespace RegisterMyBooks_00012453.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateOnly RegisterDate { get; set; }

        public int NumberOfBooks { get; set;}

        public string Orderer { get; set; }

        public OrderStatus OrderStatus { get; set; }
    }
    public enum OrderStatus
    {
        Given,
        Taken,
        InProgress,
        Delivered,
        Confirmed,
        Completed,
        Cancelled
    }
}
