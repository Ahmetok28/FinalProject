using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";

        public static string MaintenanceTime = "Sisterm bakımda";
        public static string ProductListed = "Ürünler listelendi ";

        public static string ProductCountOfCategoryError = "bir kategoride en fazla 10 ürün olabilir";

        public static string ProductNameAlreadyExists ="Bu isimde bir ürün zaten mevcut";

        public static string CategoryCountExceeded = "Kategori sayısı aşıldı";
    }
}
