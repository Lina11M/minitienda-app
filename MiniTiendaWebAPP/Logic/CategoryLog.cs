using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;

namespace Logic
{
    public class CategoryLog
    {
        CategoryDat objCat = new CategoryDat();

        public DataSet showCategories()
        {
            return objCat.showCategories();
        }

        public DataSet showCategoriesDDL()
        {
            return objCat.showCategoriesDDL();
        }

        public bool saveCategory(string _description)
        {
            return objCat.saveCategory(_description);

        }

        public bool updateCategory(int _idCategory, string _description)
        {
            return objCat.updateCategory(_idCategory, _description);

        }

        public bool deleteCategory(int _idCategory)
        {
            return objCat.deleteCategory(_idCategory);

        }
    }
}