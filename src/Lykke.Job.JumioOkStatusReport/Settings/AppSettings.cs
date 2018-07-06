using Lykke.Job.JumioOkStatusReport.Settings.JobSettings;
using Lykke.Job.JumioOkStatusReport.Settings.SlackNotifications;
using Lykke.SettingsReader.Attributes;

namespace Lykke.Job.JumioOkStatusReport.Settings
{
    public class AppSettings
    {
        public JumioOkStatusReportSettings JumioOkStatusReportJob { get; set; }

        public SlackNotificationsSettings SlackNotifications { get; set; }

        [Optional]
        public MonitoringServiceClientSettings MonitoringServiceClient { get; set; }
    }
}
