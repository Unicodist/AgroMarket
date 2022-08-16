﻿namespace AgroMarket.Data.Models;

public class Cart
{
    public Cart()
    {

    }
    public Cart(User user, Product product)
    {
        this.AddedBy = user;
        this.Product = product;
    }

    public long Id { get; set; }
    public long UserId { get; set; }
    public long ProductId { get; set; }
    public virtual User AddedBy { get; set; }
    public Product Product { get; set; }
}