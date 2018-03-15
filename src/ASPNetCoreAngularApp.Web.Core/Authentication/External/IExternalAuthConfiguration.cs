using System.Collections.Generic;

namespace ASPNetCoreAngularApp.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
