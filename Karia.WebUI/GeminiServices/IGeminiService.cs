namespace Karia.WebUI.GeminiServices
{
    public interface IGeminiService
    {
        Task<string> GetGeminiDataAsync(string prompt);
    }
}
