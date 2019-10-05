using System;
using SimplBlazor.Shared;
using SimplBlazor.Shared.Models;

namespace SimplBlazor.Client
{
    public class OrderState
    {
        public Order Order { get; private set; } = new Order();
        public event Action OrderChanged;

        public void AddToCart(Product product)
        {
            Order.Products.Add(product);
            NotifyChanged();
        }

        public void RemoveFromCart(Product product)
        {
            Order.Products.Remove(product);
            NotifyChanged();
        }

        public void ResetOrder()
        {
            Order = new Order();
        }

        private void NotifyChanged() => OrderChanged?.Invoke();
    }
}
