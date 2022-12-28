using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar_StoreApp
{
    internal interface IStore
    {
        Sale[] Sales { get; }
        void Sell(string name);
        Product[] Products {get;}
        double TotalAmount {get;}
        void AddProduct(Product product);
    }
}
