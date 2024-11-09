using SeriLogExceptionHandlingLib;

namespace SeriLogWebapp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) { services.AddControllers(); }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) 
            {
                app.UseDeveloperExceptionPage(); 
            }
            else
            {
                app.UseExceptionHandling(); // Use custom middleware
             } 
            app.UseRouting(); 
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); }); 
        }
    }
            }
        
    
