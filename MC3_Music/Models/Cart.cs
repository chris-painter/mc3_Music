﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MC3_Music.Models
{
    public class Cart
    {
        [Required]
        public int Id { get; set; }

        public Customer Customer { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int Album_Id { get; set; }

        [ForeignKey("Album_Id")]
        public Album Album { get; set; }

        public int Quantity { get; set; }

        //public double price;

        //public double Price
        //{
        //    get
        //    {
        //        return price;
        //    }
        //    set
        //    {
        //        price = Album.Price;
        //    }
        //}
    }
}