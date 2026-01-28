using System.Threading.Tasks;

    public static class AsyncService
    {
        // 20) Async con retorno Task<string>
        public static async Task<string> SimularDescargaAsync(string recurso)
        {
            await Task.Delay(200);
            return $"Descargado: {recurso}";
        }
    }