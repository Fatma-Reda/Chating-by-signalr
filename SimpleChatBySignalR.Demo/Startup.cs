using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(SimpleChatBySignalR.Demo.Startup))]

namespace SimpleChatBySignalR.Demo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.MapSignalR();
            app.Map("/signalr", config =>
            {
                config.UseCors(CorsOptions.AllowAll);
                config.RunSignalR();
            });
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
