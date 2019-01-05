namespace DotNetCore.HostedServices.Common
{
    public interface ICommonService
    {
        void OnStarted();  
        void OnStopping();  
        void OnStopped();  
    }
}