using System.ComponentModel.DataAnnotations;

namespace BlazorIntro.Models
{
    public class ProductAddModel
    {
        private int _id;
        private string _productName;
        private string _description;

        public int Id
        {
            get => _id;
            set => _id = value;
        }
        [Required(ErrorMessage = "Is Valid")]
        [StringLength(20, ErrorMessage = "Max 20")]
        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }
        [Required]
        [StringLength(200)]
     
        public string Description
        {
            get => _description;
            set => _description = value;
        }
        [Required]
        public string CategoryId { get; set; }
    }
}