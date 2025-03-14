﻿using Domain.Models.Users;

namespace Domain.Models.Purchases
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public DateTime DateOfShoppingCartCreation { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<ShoppingCartProduct> ShoppingCartProducts { get; set; }

        public ShoppingCart()
        {
            Orders = new List<Order>();
            ShoppingCartProducts = new List<ShoppingCartProduct>();
            DateOfShoppingCartCreation = DateTime.Now;
        }
    }
}
