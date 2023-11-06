using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            //var values = featureManager.TGetList();
            //ViewBag.image1 = featureManager.TGetById();
                return View();
        }
    }
}