using System;
using System.Collections.Generic;
using System.Text;

//Making entity class

namespace KeihiDetail.Entity
{
    public class KeihiDetail
    {
        public int KeihiDetailId { get; set; }

        public DateTime Dt { get; set; }

        public string Subject { get; set; }

        public string Payee { get; set; }

        public int Amount { get; set; }

        public string Remark { get; set; }
    }
}
