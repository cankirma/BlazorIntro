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
        [Required]
        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }
        [Required]
        public string Description
        {
            get => _description;
            set => _description = value;
        }
    }
}