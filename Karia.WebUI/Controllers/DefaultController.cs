using Karia.WebUI.GeminiServices;
using Microsoft.AspNetCore.Mvc;

namespace Karia.WebUI.Controllers
{
    public class DefaultController(IGeminiService _service) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetAiRecommendation(string prompt)
        {
            string systemInstruction = "Sen bir moda asistanısın. Şu an Kış mevsimindeyiz. " +
                                       "Kullanıcı senden bir ürün veya tarz tavsiyesi isteyecek. " +
                                       "Ona 2025 Kış modasına uygun, trend olan, sıcak tutacak ama şık ürünler öner. " +
                                       "Samimi ve satışa yönlendirici bir dil kullan. Cevabın çok uzun olmasın.";

            string fullPrompt = $"{systemInstruction} Kullanıcının İsteği: {prompt}";

            var response = await _service.GetGeminiDataAsync(fullPrompt);

            return Json(response);
        }
    }
}
