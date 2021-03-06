﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

//Making entity class

namespace TestingDb
{
    public class Testing_KeihiDetail
    {
        //[Key]
        //"class name + Id" or "Id"
        //e.g. Testing_KeihiDetailId or Id
        public int Id { get; set; }

        public DateTime Dt { get; set; }

        public string Subject { get; set; }

        public string Payee { get; set; }

        public int Amount { get; set; }

        public string Remark { get; set; }
    }
}
