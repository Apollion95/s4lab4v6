using System;
using System.Collections.Generic;

#nullable disable

namespace s4lab4v6.ScaffoldModel
{
    public partial class SummaryOfSalesByQuarter
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
