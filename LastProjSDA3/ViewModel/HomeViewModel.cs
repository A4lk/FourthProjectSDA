using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModel
{
    public class HomeViewModel
    {
        public Owner Owner { get; set; }
        public List<PortfolioItem> PortfolioItem { get; set; }

    }
   
}
