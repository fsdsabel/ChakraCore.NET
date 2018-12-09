namespace ChakraCore.NET.DebugAdapter2.VSCode.Managed
{
    /// <summary>
    /// Used by the ModuleInit. All code inside the Initialize method is ran as soon as the assembly is loaded.
    /// </summary>
    internal static class ModuleInitializer
    {
        /// <summary>
        /// Initializes the module.
        /// </summary>
        public static void Initialize()
        {
            CosturaUtility.Initialize();
        }
    }

}
