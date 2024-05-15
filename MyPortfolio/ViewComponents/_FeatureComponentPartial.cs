using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        //private readonly MyPortfolioContext _portfolioContext;

        //public _FeatureComponentPartial(MyPortfolioContext portfolioContext)
        //{
        //    _portfolioContext = portfolioContext;
        //}

        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
