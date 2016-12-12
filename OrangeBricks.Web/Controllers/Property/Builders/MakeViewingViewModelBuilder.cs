using System;
using OrangeBricks.Web.Controllers.Property.ViewModels;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Property.Builders
{
    public class MakeViewingViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public MakeViewingViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public MakeViewingViewModel Build(int id)
        {
            var property = _context.Properties.Find(id);

            return new MakeViewingViewModel
            {
                PropertyId = property.Id,
                PropertyType = property.PropertyType,
                StreetName = property.StreetName,
                ViewingDate = DateTime.Now
            };
        }
    }
}