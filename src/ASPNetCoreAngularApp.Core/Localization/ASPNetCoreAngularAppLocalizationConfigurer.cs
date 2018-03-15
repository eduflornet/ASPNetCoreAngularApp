using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ASPNetCoreAngularApp.Localization
{
    public static class ASPNetCoreAngularAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ASPNetCoreAngularAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ASPNetCoreAngularAppLocalizationConfigurer).GetAssembly(),
                        "ASPNetCoreAngularApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
