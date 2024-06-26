﻿using BookSale.Sale.Entities.CartModels;

namespace BookSale.MVC.Helpers
{
    public interface ICartSessionHelper
    {
        Cart GetCart(string key);
        void SetCart(string key, Cart cart);
        void Clear();
    }
}
