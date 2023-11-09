﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryBeanPattern.Models
{
    public class TransactionModel
    {

        [Required]
        public int AccountId { get; set; }

        [Required]
        public int Amount { get; set; }
    }
}
