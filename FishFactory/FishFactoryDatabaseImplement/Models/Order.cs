﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FishFactoryContracts.Enums;

namespace FishFactoryDatabaseImplement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CannedId { get; set; }
        public virtual Canned Canned { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public decimal Sum { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
    }
}