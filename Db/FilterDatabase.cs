using System;
using System.Collections.Generic;
public class FilterDatabase
{
 
    public List<Product> GetAllProducts()
    {
      List<Product> productList = new List<Product>();
      productList.Add(new Product{Id=1,ProductTitle="Bilgisayar",Price=1500,CreatedDate= DateTime.Now.AddDays(-1)}); 
      productList.Add(new Product{Id=2,ProductTitle="Telefon",Price=500,CreatedDate=DateTime.Now.AddDays(-2)}); 
      productList.Add(new Product{Id=1,ProductTitle="Kulaklık",Price=1500,CreatedDate= DateTime.Now.AddDays(-3)}); 
      productList.Add(new Product{Id=2,ProductTitle="Çamaşır Makinesi",Price=500,CreatedDate=DateTime.Now.AddDays(-3)}); 
      productList.Add(new Product{Id=1,ProductTitle="Ütü",Price=1500,CreatedDate= DateTime.Now.AddDays(-4)}); 
      productList.Add(new Product{Id=2,ProductTitle="Televizyon",Price=500,CreatedDate=DateTime.Now.AddDays(-5)}); 
      return productList;
    }
    
}