using Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class ProvidersLog
    {
        ProvidersDat objProviders = new ProvidersDat();


        public DataSet showProviders()
        {
            return objProviders.showProviders();
        }


        public DataSet showProvidersDDL()
        {

            return objProviders.showProvidersDDL();
        }


        public bool saveProviders(string _nit, string _nombre)
        {
            return objProviders.saveProviders(_nit, _nombre);
        }


        public bool updateProveedor(int _id, string _nit, string _nombre)
        {
            return objProviders.updateProveedor(_id, _nit, _nombre);
        }


        public bool deleteProveedor(int _id)
        {
            return objProviders.deleteProveedor(_id);
        }
    }
}