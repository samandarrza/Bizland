using BizLand.Models;
using System.Collections.Generic;

namespace BizLand.ViewModels
{
    public class HomeViewModel
    {
        public List<Feature> Features { set; get; }
        public List<Service> Services { set; get; }
        public List<Testimonial> Testimonials { set; get; }
    }
}
