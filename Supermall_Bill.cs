using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Class_Library
{
    public class Supermall_Bill
    {
        static int Id = 1;
        int bill_id;        
        int subtotal;        
        int cgst;
        int sgst;
        int total;
        string billdate;
        string billtime;        
        
        #region GET Properties
        public int Bill_id
        {
            get { return bill_id; }
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
        public string Billdate
        {
            get { return billdate; }
        }
        public string Billtime
        {
            get { return billtime; }
        }        
        #endregion
        public Supermall_Bill(int subtotal, int cgst, int sgst,int total)
        {
            this.bill_id = Id++;
            this.subtotal = subtotal;
            this.cgst = (subtotal * cgst) / 100;
            this.sgst = (subtotal * sgst) / 100;
            this.total = subtotal + cgst + sgst;
            this.billdate = DateTime.Now.ToString("dd'-'MM'-'yyyy");
            this.billdate = DateTime.Now.ToString("HH':'mm':'ss");
        }
    }
}
