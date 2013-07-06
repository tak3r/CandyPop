﻿

namespace Notebook.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    internal class Transactions
    {
        public float Total { get; set; }

        public string Credit
        {
            get
            {
                if (this is Income)
                {
                    return string.Format("Rp {0:0.00}", this.Total);
                }

                return "-";
            }
        }

        public string Debit
        {
            get
            {
                // TODO: fix this as soon as we have expenses class.
                return "-";
            }
        }
    }
}
