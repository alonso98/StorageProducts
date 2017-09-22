namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Product
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Количество")]
        public Nullable<double> Count { get; set; }
        [Display(Name = "Цена")]
        public Nullable<double> Price { get; set; }        
        public Nullable<int> CategoryId { get; set; }
    
        public virtual Service Service { get; set; }
    }
}
