using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using OrangeBricks.Web.Controllers.Viewings.ViewModels;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Viewings.Builders
{
    public class MyViewingsViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public MyViewingsViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public MyViewingsViewModel Build(string buyerId)
        {
            var properties = _context.Properties
                .Include(y => y.Viewings)
                .Where(x => x.Viewings.Any(y => y.BuyerId == buyerId))
                .ToList();

            var viewingsOnProperties = new List<ViewingsOnPropertyViewModel>();

            foreach (var property in properties)
            {
                var viewingsOnPropertyViewModel = new ViewingsOnPropertyViewModel
                {
                    HasViewings = true,
                    Viewings = property.Viewings.Select(x => new ViewingViewModel
                    {
                        Id = x.Id,
                        ViewingDate = x.ViewingDate,
                        CreatedAt = x.CreatedAt,
                        IsPending = x.Status == ViewingStatus.Pending,
                        Status = x.Status.ToString()
                    }),
                    PropertyId = property.Id,
                    PropertyType = property.PropertyType,
                    StreetName = property.StreetName,
                    NumberOfBedrooms = property.NumberOfBedrooms
                };
                viewingsOnProperties.Add(viewingsOnPropertyViewModel);
            }

            return new MyViewingsViewModel()
            {
                HasViewings = viewingsOnProperties.Any(),
                Viewings = viewingsOnProperties
            };
        }
    }
}