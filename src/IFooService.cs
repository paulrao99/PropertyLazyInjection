﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyLazyInjection
{
    public interface IFooService
    {
       ILogger Logger { get; set; }
    }
}
