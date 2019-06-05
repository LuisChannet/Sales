namespace Sales.ViewModels
{
    using Sales.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;

    public class ProductsViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
    }
}
