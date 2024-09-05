using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VerstaTestTask.Models
{
    public class Order
    {
        [DisplayName("Номер заказа")]
        public required Guid Id { get; set; }
        [DisplayName("Город отправителя")]
        [Required(ErrorMessage = "Город отправителя обязателен для заполнения")]
        public required string SenderCity { get; set; }

        [DisplayName("Адрес отправителя")]
        [Required(ErrorMessage = "Адрес отправителя обязателен для заполнения")]
        public required string SenderAddress { get; set; }

        [DisplayName("Город получателя")]
        [Required(ErrorMessage = "Город получателя обязателен для заполнения")]
        public required string RecipientCity { get; set; }

        [DisplayName("Адрес получателя")]
        [Required(ErrorMessage = "Адрес получателя обязателен для заполнения")]
        public required string RecipientAddress { get; set; }

        [DisplayName("Вес")]
        [Required(ErrorMessage = "Вес обязателен для заполнения")]
        public required double Weight { get; set; }

        [DisplayName("Дата приемки")]
        public required DateTime DateOfReceipt { get; set; }
    }
}
