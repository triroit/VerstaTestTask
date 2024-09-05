using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VerstaTestTask.Models.DTOs
{
    public class OrderDTO
    {
        public string SenderCity { get; set; }
        public string SenderAddress { get; set; }
        public string RecipientCity { get; set; }
        public string RecipientAddress { get; set; }
        public double Weight { get; set; }
    }
}
