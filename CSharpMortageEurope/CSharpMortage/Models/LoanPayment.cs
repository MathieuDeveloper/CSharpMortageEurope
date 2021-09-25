using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//
namespace CSharpMortage.Models
{
    public class LoanPayment
    {
        public int Month { get; set; }

        //non Bobby use this at a time: [DisplayFormat(DataFormatString  ="{0:C0}", ApplyFomatInEditMode = true)]
        public decimal Payment { get; set; }
        public decimal MonthlyPrincipal { get; set; }
        public decimal MonthlyInterest { get; set; }
        public decimal TotalInterest { get; set; }
        public decimal Balance { get; set; }
    }
}
