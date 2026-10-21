namespace WFAnimali
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            FileLogger.Instance.Log("Applicazione avviata.");

            CAnimale a = FactoryAnimale.Crea(TipoAnimale.Cane, "Alessandro", 5);

            Application.Run(new Form1());
        }
    }
}