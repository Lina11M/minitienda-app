using Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFProducts : System.Web.UI.Page
    {
        /* 
        * Se crean instancias de las clases CategoryLog, ProvidersLog
        * y ProductsLog para interactuar con la lógica de negocio.
        */
        ProductLog objProd = new ProductLog();
        ProvidersLog objPro = new ProvidersLog();
        CategoryLog objCat = new CategoryLog();

        protected void Page_Load(object sender, EventArgs e)
        {
             /* 
              * Se verifica si la página se está cargando por primera vez o 
              * si es una devolución de datos del servidor.
              */
            if (!Page.IsPostBack)
            {

                showProducts();//Se invoca el metodo para mostrar todos los productos
                //showProvidersDDL();//Se invoca el metodo para mostrar los proveedores en el DDL
                showCategoriesDDL();
                // Se oculta el campo de texto TBId.
                //TBId.Visible = false;
            }

        }

        //Metodo para mostrar las categorias en el DDL
        private void showCategoriesDDL()
        {
            // Se asigna el origen de datos al DropDownList,
            // utilizando el método showCategoriesDDL de la instancia objCat de la clase CategoryLog.
            DDLCategories.DataSource = objCat.showCategoriesDDL();

            // Se especifica el campo que se utilizará como valor de cada elemento del DropDownList.
            DDLCategories.DataValueField = "cat_id";

            // Se especifica el campo que se mostrará como texto para cada elemento del DropDownList.
            DDLCategories.DataTextField = "cat_descripcion";

            // Se enlaza el origen de datos con el DropDownList.
            DDLCategories.DataBind();

            // Se agrega un elemento "Seleccione" al principio del DropDownList para indicar al usuario que elija una categoría.
            DDLCategories.Items.Insert(0, "Seleccione");
        }

        //Metodo para mostrar los proveedores en el DDL
        private void showProvidersDDL()
        {
            DDLProviders.DataSource = objPro.showProvidersDDL();
            DDLProviders.DataValueField = "prov_id";//Nombre de la llave primaria
            DDLProviders.DataTextField = "prov_nombre";
            DDLProviders.DataBind();
            DDLProviders.Items.Insert(0, "Seleccione");
        }
        //Metodo para mostrar todos los productos
        private void showProducts()
        {
            DataSet ds = new DataSet();
            ds = objProd.showProducts();
            GVProducts.DataSource = ds;
            GVProducts.DataBind();
        }
    }
}