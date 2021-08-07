using BlazorWasamAssignment.Models;
using System;
using System.Collections.Generic;

namespace BlazorWasamAssignment
{
    public class AppStateContainer
    {
        public int ValueState { get; set; }
        public List<PurchaseProducts> products { get; set; } = new List<PurchaseProducts>();
        public event Action OnStateChanged;
        public void UpdateState(int v)
        {
            ValueState = v;
            NotifyStateChanged();
        }

        public void UpdatePurchasedProducts(PurchaseProducts product)
        {
            products.Add(product);
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnStateChanged?.Invoke();
    }
}
