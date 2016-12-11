using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using OrangeBricks.Web.Attributes;
using OrangeBricks.Web.Controllers.Viewings.Builders;
using OrangeBricks.Web.Controllers.Viewings.Commands;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Viewings
{
    public class ViewingsController : Controller
    {
        private readonly IOrangeBricksContext _context;

        public ViewingsController(IOrangeBricksContext context)
        {
            _context = context;
        }

        #region Seller

        [OrangeBricksAuthorize(Roles = "Seller")]
        public ActionResult OnProperty(int id)
        {
            var builder = new ViewingsOnPropertyViewModelBuilder(_context);
            var viewModel = builder.Build(id);

            return View(viewModel);
        }

        [HttpPost]
        [OrangeBricksAuthorize(Roles = "Seller")]
        public ActionResult Accept(AcceptViewingCommand command)
        {
            var handler = new AcceptViewingCommandHandler(_context);

            handler.Handle(command);

            return RedirectToAction("OnProperty", new { id = command.PropertyId });
        }

        [HttpPost]
        [OrangeBricksAuthorize(Roles = "Seller")]
        public ActionResult Reject(RejectViewingCommand command)
        {
            var handler = new RejectViewingCommandHandler(_context);

            handler.Handle(command);

            return RedirectToAction("OnProperty", new { id = command.PropertyId });
        }

        #endregion

        #region Buyer

        [OrangeBricksAuthorize(Roles = "Buyer")]
        public ActionResult MyViewings()
        {
            var builder = new MyViewingsViewModelBuilder(_context);
            var viewModel = builder.Build(User.Identity.GetUserId());

            return View(viewModel);
        }

        #endregion
    }
}