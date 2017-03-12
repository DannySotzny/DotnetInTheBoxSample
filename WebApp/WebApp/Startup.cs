﻿using Microsoft.AspNetCore.Builder;
using Nancy.Owin;

namespace FP.DotnetInTheBox.Sample.WebApp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(x => x.UseNancy());
        }
    }
}
