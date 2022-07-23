﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace E_commerce.Models
{
    public partial class Product
    {
        public Product()
        {
            Comments = new HashSet<Comment>();
            ImagesProducts = new HashSet<ImagesProduct>();
        }

        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Report { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        public string DetailsAr { get; set; }
        public string DetailsEn { get; set; }
        public int Duration { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int Views { get; set; }
        public int Discount { get; set; }
        public int Evaluation { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public int? CategoryId { get; set; }
       
        public virtual Category Category { get; set; }
        public virtual Auction Auction { get; set; }
        public virtual Purchase Purchase { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<ImagesProduct> ImagesProducts { get; set; }
    }
}
