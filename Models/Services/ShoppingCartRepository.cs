﻿using ComputerShopll.Data;
using ComputerShopll.Models.Interfaces;
using ComputerShopll.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class ShoppingCartRepository : IShoppingCartRepository
{
    private ComputershopDbContext dbContext;

    public ShoppingCartRepository(ComputershopDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public List<ShoppingCartItem>? ShoppingCartItems { get; set; }
    [HttpPost]
    public void AddToCart(Product product)
    {
        var shoppingCartItem = dbContext.shoppingCartItems.FirstOrDefault(s => s.Product.Id == product.Id && s.ShoppingCartId == ShoppingCartId);
        if (shoppingCartItem == null)
        {
            shoppingCartItem = new ShoppingCartItem
            {
                ShoppingCartId = ShoppingCartId,
                Product = product,
                Qty = 1,
            };
            dbContext.shoppingCartItems.Add(shoppingCartItem);
        }
        else
        {
            shoppingCartItem.Qty++;
        }
        dbContext.SaveChanges();
    }

    public void ClearCart()
    {
        var cartItems = dbContext.shoppingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId);
        dbContext.shoppingCartItems.RemoveRange(cartItems);
        dbContext.SaveChanges();
    }

    public List<ShoppingCartItem> GetAllShoppingCartItems()
    {
        return ShoppingCartItems ??= dbContext.shoppingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId).Include(p => p.Product).ToList();
    }

    public decimal GetShoppingCartTotal()
    {
        var totalCost = dbContext.shoppingCartItems.Where(s => s.ShoppingCartId == ShoppingCartId)
        .Select(s => s.Product.Price * s.Qty).Sum();
        return totalCost;
    }

    public int RemoveFromCart(Product product)
    {
        var shoppingCartItem = dbContext.shoppingCartItems.FirstOrDefault(s => s.Product.Id == product.Id && s.ShoppingCartId == ShoppingCartId);
        var quantity = 0;

        if (shoppingCartItem != null)
        {
            if (shoppingCartItem.Qty > 1)
            {
                shoppingCartItem.Qty--;
                quantity = shoppingCartItem.Qty;
            }
            else
            {
                dbContext.shoppingCartItems.Remove(shoppingCartItem);
            }
        }
        dbContext.SaveChanges();
        return quantity;
    }
    public static ShoppingCartRepository GetCart(IServiceProvider services)
    {
        ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
        if (session == null)
        {
            throw new Exception("Session is not configured or available.");
        }
        ComputershopDbContext context = services.GetService<ComputershopDbContext>() ?? throw new
        Exception("Error initializing coffeeshopdbcontext");
        string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();
        session?.SetString("CartId", cartId);
        return new ShoppingCartRepository(context) { ShoppingCartId = cartId };
    }
    public string? ShoppingCartId { set; get; }
}