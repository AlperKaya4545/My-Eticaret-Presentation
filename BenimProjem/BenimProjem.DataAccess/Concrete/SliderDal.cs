using BenimProjem.Core.DataAccess;
using BenimProjem.DataAccess.Abstract;
using BenimProjem.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.DataAccess.Concrete
{
    public class SliderDal : RepositoryBase<Slider, BenimProjemContext>, ISliderDal
    {
    }
}
