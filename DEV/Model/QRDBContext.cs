﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class QRDBContext:DbContext
    {
        private QRDBContext() : base("QRDBContext")
        {

        }
    }
}