using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FarmPros.ApplicationLogic.ViewModels.ProductCategoryViewModels
{
    public class ProductCategoryViewModel
    {
        public Guid Id { get; set; }

        public Guid? ParentId { get; set; }

        [Required]
        [Display(Name = "Product Category")]
        public string Name { get; set; }
    }
}
