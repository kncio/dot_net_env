using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ServicioTumoresBackend.Localization
{
    public static class ServicioTumoresBackendLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ServicioTumoresBackendConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ServicioTumoresBackendLocalizationConfigurer).GetAssembly(),
                        "ServicioTumoresBackend.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
