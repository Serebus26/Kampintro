﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class AutoLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi Hesaplandı");
        }
    }
}
