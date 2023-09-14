using FUIServerSample.Layer.ServiceLayer.CustomerServices;

namespace FUIServerSample.Settings.Extensions
{
    public static class SampleServiceExtensions
    {
        public static void AddSampleServices(this IServiceCollection services)
        {
            services.AddScoped<CustomerService>();
        }
    }
}
