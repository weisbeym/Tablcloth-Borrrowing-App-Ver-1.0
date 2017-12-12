using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableclothFinal
{
    public class Invoice
    {
        public Invoice() { }

        public Invoice(int BorrowerId, int ProductId, int Quantity, DateTime InvoiceDate)
        {
            this.BorrowerId = BorrowerId;
            this.ProductId = ProductId;
            this.Quantity = Quantity;
            this.InvoiceDate = InvoiceDate;
        }

        public int InvoiceId { get; set;  }

        public int BorrowerId { get; set; }

        public int ProductId { get; set;  }

        public int Quantity { get; set;  }

        public DateTime InvoiceDate { get; set;  }
    }
}
