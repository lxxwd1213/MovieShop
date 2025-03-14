﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        public int  UserId { get; set; }
        public Guid PurchaseNumber { get; set; }//Data type is uniqueidentifier
        public decimal TotalPrice { get; set; }
        public DateTime PurchaseDateTime { get; set; }
        public int MovieId { get; set; }

        public Movie Movie { get; set; }
        public User User { get; set; }

    }
}
