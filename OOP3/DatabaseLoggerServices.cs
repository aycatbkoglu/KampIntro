﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerServices : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("veritabanına loglandı");
        }
    }


}
