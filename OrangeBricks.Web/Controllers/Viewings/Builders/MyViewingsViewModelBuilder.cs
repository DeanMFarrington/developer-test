using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using OrangeBricks.Web.Controllers.Offers.ViewModels;
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

        /*
        public MyOffersViewModel Build(string buyerId)
        {
            var properties = _context.Properties
                .Include(y => y.Offers)
                .Where(x => x.Offers.Any(y => y.BuyerId == buyerId))
                .ToList();

            var offersOnProperties = new List<OffersOnPropertyViewModel>();

            foreach (var property in properties)
            {
                var offersOnPropertyViewModel = new OffersOnPropertyViewModel
                {
                    HasOffers = true,
                    Offers = property.Offers.Select(x => new OfferViewModel
                    {
                        Id = x.Id,
                        Amount = x.Amount,
                        CreatedAt = x.CreatedAt,
                        IsPending = x.Status == OfferStatus.Pending,
                        Status = x.Status.ToString()
                    }),
                    PropertyId = property.Id,
                    PropertyType = property.PropertyType,
                    StreetName = property.StreetName,
                    NumberOfBedrooms = property.NumberOfBedrooms
                };
                offersOnProperties.Add(offersOnPropertyViewModel);
            }

            return new MyOffersViewModel
            {
                HasOffers = offersOnProperties.Any(),
                Properties = offersOnProperties
            };
        }
        */
    }
}