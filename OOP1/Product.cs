﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet hazırkodlar demek tab tab yababilirsin.
    ////Bu tip classlarda sadece özellik olur.
    class Product
    { 
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

       
    }
}
