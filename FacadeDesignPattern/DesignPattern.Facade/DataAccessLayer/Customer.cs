﻿namespace DesignPattern.Facade.DataAccessLayer
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
