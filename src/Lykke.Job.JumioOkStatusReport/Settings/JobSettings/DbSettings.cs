using Lykke.SettingsReader.Attributes;

namespace Lykke.Job.JumioOkStatusReport.Settings.JobSettings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
