namespace VerstaTestTask.Models.DTOs
{
    public class OrderDTO
    {
        public required string SenderCity { get; set; }
        public required string SenderAddress { get; set; }
        public required string RecipientCity { get; set; }
        public required string RecipientAddress { get; set; }
        public required double Weight { get; set; }
    }
}
