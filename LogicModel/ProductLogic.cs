using System;
using System.Collections.Generic;
using System.Text;
using database;

namespace LogicLayer
{
    public class ProductLogic
    {
        DbConnect db = new DbConnect();

        public List<DataModels.productModels> Products()
        {
            List<DataModels.productModels> p = new List<DataModels.productModels>();

            db.getProducts();

            return p;
        }
        

    }
}
