using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentList :ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        Context context = new();

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount = context.Comments.Where(x=>x.DestinationID==id).Count();
            var values = commentManager.TGetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}