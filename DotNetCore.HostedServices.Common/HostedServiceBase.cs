using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DotNetCore.HostedServices.Common
{
    public abstract class HostedServiceBase : CommonService, IHostedService
    {
        IApplicationLifetime appLifetime;  
        ILogger<HostedServiceBase> logger;  

        public HostedServiceBase(  
            ILogger<HostedServiceBase> logger,   
            IApplicationLifetime appLifetime)  
        {  
            this.logger = logger;  
            this.appLifetime = appLifetime;  
        }  
  
        public Task StartAsync(CancellationToken cancellationToken)  
        {  
            this.logger.LogInformation("StartAsync method executed.");  
  
            this.appLifetime.ApplicationStarted.Register(OnStarted);  
            this.appLifetime.ApplicationStopping.Register(OnStopping);  
            this.appLifetime.ApplicationStopped.Register(OnStopped);  
  
            return Task.CompletedTask;  
        }  
  
        public Task StopAsync(CancellationToken cancellationToken)  
        {  
            this.logger.LogInformation("StopAsync method executed.");  
            return Task.CompletedTask;  
        }  
    }
}