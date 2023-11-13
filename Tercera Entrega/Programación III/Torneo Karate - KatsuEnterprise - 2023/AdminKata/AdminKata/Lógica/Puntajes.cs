using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;

namespace AdminKata.Lógica
{
    class Puntajes
    {
        public class PuntajesHub : Hub
        {
            // Método para enviar los puntajes a los clientes conectados
            public async Task EnviarPuntaje(int puntaje)
            {
                await Clients.All.SendAsync("RecibirPuntaje", puntaje);
            }
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Otras configuraciones

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<PuntajesHub>("/puntajesHub");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

    }
}
