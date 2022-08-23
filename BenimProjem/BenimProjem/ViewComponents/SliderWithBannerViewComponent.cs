using BenimProjem.Business.Helpers;
using BenimProjem.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.ViewComponents
{
    public class SliderWithBannerViewComponent : ViewComponent
    {
        ISliderService _sliderService;
        public SliderWithBannerViewComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public IViewComponentResult Invoke()
        {
            var sliders = _sliderService.List();
            return View(sliders);   
        }
    }
}
