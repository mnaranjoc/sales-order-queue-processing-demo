using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sales_order_queue_processing_demo.Startup))]
namespace sales_order_queue_processing_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
