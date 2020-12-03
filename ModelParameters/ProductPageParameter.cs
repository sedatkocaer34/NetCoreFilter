namespace NetCoreFilter.ModelParameters
{
    public class ProductPageParameter:QueryPageParameter
    {
       public int maxPrice {get;set;}
       public int minPrice {get;set;}
       public string productTitle {get;set;}
    }
}