//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public int OrderNo { get; set; }
        public string SaleDate { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public string CustomerId { get; set; }
    }
}
