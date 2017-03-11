using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhatsCool.Startup))]
namespace WhatsCool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
