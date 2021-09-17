using Core.Entities;
using eTickets.Interface;
using eTickets.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eTickets.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<PortfolioItem> _portfolioItem;
        public HomeController(
            IUnitOfWork<Owner> owner,
            IUnitOfWork<PortfolioItem> portfolioItem)
        {
            _owner = owner;
            _portfolioItem = portfolioItem;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Owner = _owner.Entity.GetAll().First(),
                PortfolioItem = _portfolioItem.Entity.GetAll().ToList()
            };
            return View(homeViewModel);
        }
    
    }
}
