﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndrKarmStore.DB;

namespace AndrKarmStore.ClassHelper
{
    class EFClass
    {
        public static DB.Entities1 Context { get; } = new DB.Entities1();
    }
}
