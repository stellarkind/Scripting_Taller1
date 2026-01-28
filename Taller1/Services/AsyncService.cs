using System.Threading.Tasks;

namespace Taller1.Services
{
    public static class AsyncService
    {
        public static async Task<string> SimularDescargaAsync(string recurso)
        {
            await Task.Delay(200);
            return $"Descargado: {recurso}";
        }
    }
}
