//// See https://aka.ms/new-console-template for more information
//using Business.Concrete;
//using DataAccess.Abstract;
//using DataAccess.Concrete.EntityFramework;
//using DataAccess.Concrete.InMemory;
//using Entities.Concrete;
//using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

//ProductTest();
////CategoryTest();




//static void ProductTest()
//{
//    ProductManager productManager = new ProductManager(new EfProductDal());
//    var result = productManager.GetProductDetail();
//    if (result.Success)
//    {
//        foreach (var item in result.Data)
//        {
//            Console.WriteLine(item.ProductName + " --- " + item.CategoryName);
//        }
//    }
//    else
//    {
//        Console.WriteLine(result.Message);
//    }
    
//}

//static void CategoryTest()
//{
//    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
//    foreach (var item in categoryManager.GetAll())
//    {
//        Console.WriteLine(item.CategoryName);
//    }
//}
