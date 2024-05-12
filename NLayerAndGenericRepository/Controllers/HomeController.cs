using Microsoft.AspNetCore.Mvc;
using Pronia.Business.Services.Abstracts;
using System.Diagnostics;

namespace NLayerAndGenericRepository.Controllers
{
    public class HomeController : Controller
    {

        private readonly IFeatureService _featureService;
        private readonly ISliderService _sliderService;
        public HomeController(IFeatureService featureService, ISliderService sliderService)
        {
            _featureService = featureService;
            _sliderService = sliderService;
        }
        public IActionResult Index()
        {
            
            var features = _featureService.GetAllFeatures();
            return View(features);
            var sliders = _sliderService.GetAllSliders();
            return View(sliders);
        }
    }
}
