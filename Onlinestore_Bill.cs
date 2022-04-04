using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Class_Library
{
    public class Onlinestore_Bill
    {
        static int Id = 1;
        int order_no;
        int subtotal;
        int cgst;
        int sgst;
        int total;
        string invoicedate;                
        string billing_address;
        string shipping_address;

        #region GET Properties
        public int Order_no
        {
            get { return order_no; }
        }
        public int Subtotal
        {
            get { return subtotal; }
        }
        public int CGST
        {
            get { return cgst; }
        }
        public int SGST
        {
            get { return sgst; }
        }
        public int Total
        {
            get { return total; }
        }        
        public string Invoicedate
        {
            get { return invoicedate; }
        }
        public string Billing_address
        {
            get { return billing_address; }
        }
        public string Shipping_address
        {
            get { return shipping_address; }  
        }
        #endregion
        public Onlinestore_Bill(int subtotal, int cgst, int sgst, int total, string billing_address,, string shipping_address)	
        {
            this.order_no= Id++;
            this.subtotal = subtotal;
            this.cgst = (subtotal * cgst) / 100;
            this.sgst = (subtotal * sgst) / 100;
            this.total = subtotal + cgst + sgst;
            this.invoicedate = DateTime.Now.ToString("dd'-'MM'-'yyyy");
            this.billing_address= billing_address;
            this.shipping_address=shipping_address;
        }
    }
}