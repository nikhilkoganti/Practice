﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DataStructures.Startup))]

namespace DataStructures
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
