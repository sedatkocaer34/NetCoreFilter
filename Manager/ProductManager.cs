using System.Linq;
using System;
using System.Collections.Generic;
using NetCoreFilter.Paging;
using NetCoreFilter.ModelParameters;
using NetCoreFilter.Result;
namespace NetCoreFilter.Manager
{
    public class ProductManager
    {
        FilterDatabase filterDatabase = new FilterDatabase();

        public DataResultPaging<PagedList<Product>> GetFilterProductList(ProductPageParameter productPageParameter)
        {
            List<Product> productlist = filterDatabase.GetAllProducts().Where(x=>x.ProductTitle.Equals(productPageParameter.productTitle)
            &&x.Price<=productPageParameter.maxPrice&&x.Price>=productPageParameter.minPrice).ToList();
            
            var resultpaging = 
            PagedList<Product>.toPagedList(productlist.AsQueryable(),productPageParameter.PageNumber,productPageParameter.PageSize);
            
            return new DataResultPaging<PagedList<Product>>
            (
                resultpaging,resultpaging.CurrentPage,resultpaging.TotalPages,resultpaging.PageSize,resultpaging.TotalCount
            );
            
        }

    }
}