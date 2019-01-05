namespace DotNetCore.HostedServices.Core
{
    public interface ICommonService
    {
        void OnStarted();  
        void OnStopping();  
        void OnStopped();  
    }
}