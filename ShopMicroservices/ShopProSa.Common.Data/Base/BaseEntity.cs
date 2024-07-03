﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProSa.Common.Data.Base
{
    public abstract class BaseEntity <TType>
    {
        public abstract TType Id { get; set; }
    }
}
