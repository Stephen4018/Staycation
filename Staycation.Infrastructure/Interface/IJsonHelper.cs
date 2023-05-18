using System.Threading.Tasks;

namespace Staycation.Infrastructure.Interface
{
    public interface IJsonHelper
    {
        Task<T> Reader<T>(string location);
        Task Writer<T>(string location, T content);
    }
}