using Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class ProductLog
    {
        ProductDat objProduct = new ProductDat();

  
        public DataSet showProducts()
        {

            return objProduct.showProducts(); 
        }



        public bool saveProducts(string _code, string _description, int _quantity, double _price, int _fkProvider, int _fkCategory)
        {
            
            return objProduct.saveProducts(_code, _description, _quantity, _price, _fkProvider, _fkCategory);
        }



        public bool updateProducts(int _id, string _code, string _description, int _quantity, double _price, int _fkProvider, int _fkCategory)
        {
            
            return objProduct.updateProducts(_id, _code, _description, _quantity, _price, _fkProvider, _fkCategory);
        }



        public bool deleteProducts(int _id)
        {
            return objProduct.deleteProducts(_id);
        }

    }
}