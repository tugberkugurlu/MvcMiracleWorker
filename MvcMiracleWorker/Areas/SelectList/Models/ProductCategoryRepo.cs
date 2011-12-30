using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMiracleWorker.Areas.SelectList.Models {

    public class ProductCategory {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class ProductCategoryRepo {

        public List<ProductCategory> GetAll() {

            List<ProductCategory> categories = new List<ProductCategory>();

            for (int i = 1; i <= 10; i++) {

                categories.Add(new ProductCategory { 
                    CategoryId = i,
                    CategoryName = string.Format("Category {0}", i)
                });
            }

            return categories;
        }
    }
}