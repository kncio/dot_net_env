using ServicioTumoresBackend.Debugging;

namespace ServicioTumoresBackend
{
    public class ServicioTumoresBackendConsts
    {
        public const string LocalizationSourceName = "ServicioTumoresBackend";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "f645f535bf444190a8304e5e45656e00";
    }
}
