using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Class_Library
{
    public class Product
    {
        static int Id = 001;
        int product_id;
        string name;
        int price;
        int quantity;
        DateTime mfg_date;
        DateTime exp_date;

        #region GET Properties
        public string Name
        {
            get { return name; }           
        }        
        public int Price
        {
            get { return price; }            
        }
        public int Quantity
        {
            get { return quantity; }            
        }
        public DateTime Mfg_date
        {
            get { return mfg_date; }            
        }
        public DateTime Exp_date
        {
            get { return exp_date; }            
        }
        #endregion

        public Product(string name,int price,int qty ,DateTime mfg_date,DateTime exp_date)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if ((name[i] < 65 && name[i] > 90) || (name[i] < 97 && name[i] > 122))
                {
                    throw new Exception("Invalid Name");
                }
            }
            this.name = name;
            this.price = price;
            this.quantity = qty;
            this.mfg_date = mfg_date;
            this.exp_date = exp_date;
        }
    }
}
