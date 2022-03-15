﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FishFactoryDatabaseImplement.Models
{
    public class Canned
    {
        public int Id { get; set; }
        [Required]
        public string CannedName { get; set; }
        [Required]
        public decimal Price { get; set; }

        [ForeignKey("CannedId")]
        public virtual List<CannedComponent> CannedComponents { get; set; }
        [ForeignKey("CannedId")]
        public virtual List<Order> Orders { get; set; }
    }
}