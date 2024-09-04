namespace VerstaTestTask.Models
{
    public class Order
    {
        public required Guid Id { get; set; }
        public required string SenderCity { get; set; }
        public required string SenderAddress { get; set; }
        public required string RecipientCity { get; set; }
        public required string RecipientAddress { get; set; }
        public required double Weight { get; set; }
        public required DateTime DateOfReceipt { get; set; }
    }
}
