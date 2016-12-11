using System;
using System.Collections.Generic;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class MakeViewingCommandHandler
    {
        private readonly IOrangeBricksContext _context;

        public MakeViewingCommandHandler(IOrangeBricksContext context)
        {
            _context = context;
        }

        public void Handle(MakeViewingCommand command)
        {
            var property = _context.Properties.Find(command.PropertyId);

            var viewing = new Viewing
            {
                ViewingDate = command.ViewingDate,
                Status = ViewingStatus.Pending,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                BuyerId = command.BuyerId
            };

            if (property.Viewings == null)
            {
                property.Viewings = new List<Viewing>();
            }

            property.Viewings.Add(viewing);

            _context.SaveChanges();
        }
    }
}