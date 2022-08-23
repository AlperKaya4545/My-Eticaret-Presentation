using BenimProjem.Business.Helpers;
using BenimProjem.DataAccess.Abstract;
using BenimProjem.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Business.Services
{
    public class SliderService : ISliderService
    {
        ISliderDal _sliderDal;
        ICacheManager _cacheManager;

        public SliderService(ISliderDal sliderDal, ICacheManager cacheManager)
        {
            _sliderDal = sliderDal;
            _cacheManager = cacheManager;
        }

        public List<Slider> List()
        {
            var cacheData = _cacheManager.Get<List<Slider>>("slider.list"); //memorycacheden list tipinde slayer arıyor.
            if (cacheData == null)
            {
                var data = _sliderDal.List();
                _cacheManager.Set("slider.list", data);
                return data;
            }
            else
            {
                return cacheData;   
            }
        }
    }
}
