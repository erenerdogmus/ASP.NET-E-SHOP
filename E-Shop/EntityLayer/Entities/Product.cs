using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
   public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Adı")]
        [StringLength(50, ErrorMessage = "max 50 karakter olmalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Açıklama")]
        [StringLength(50, ErrorMessage = "max 50 karakter olmalıdır.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Stok")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Popüler")]

        public bool Popular { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Onay")]
        public bool IsApproved { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Resim")]
        public string Image { get; set; }

      
       

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual List<Cart> Cart { get; set; }
        public virtual List<Sales> Sales { get; set; }
    }
}
