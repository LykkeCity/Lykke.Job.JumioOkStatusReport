using System.Threading.Tasks;

namespace Lykke.Job.JumioOkStatusReport.Core.Services
{
    public interface IShutdownManager
    {
        Task StopAsync();
    }
}
