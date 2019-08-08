using System.Collections.Generic;
using OrchardCore.Commerce.Money;

namespace OrchardCore.Commerce.ViewModels
{
    public class ShoppingCartLineViewModel
    {
        public int Quantity { get; set; }
        public string ProductSku { get; set; }
        public string ProductName { get; set; }
        public string ProductUrl { get; set; }
        public string ProductImageUrl { get; set; }
        public Amount Price { get; set; }
        public IDictionary<string, string> Attributes { get; set; }
    }
}