using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationHandlers _getAllDestinationHandlers;
        private readonly GetDestinationByIDQueryHandler _getDestinationByIDQueryHandler;

        public DestinationCQRSController(GetAllDestinationHandlers getAllDestinationHandlers, GetDestinationByIDQueryHandler getDestinationByIDQueryHandler)
        {
            _getAllDestinationHandlers = getAllDestinationHandlers;
            _getDestinationByIDQueryHandler = getDestinationByIDQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getAllDestinationHandlers.Handle();
            return View(values);
        }
        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationByIDQueryHandler.Handle(new GetDestinationByIDQuery(id));
            return View(values);
        }
    }
}