using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrangeBricks.Web.Controllers.Offers.ViewModels
{
    public class MyOffersViewModel
    {
        // Matching implementation of OffersOnPropertyViewModel.
        public bool HasOffers { get; set; }
        public List<OffersOnPropertyViewModel> Properties { get; set; }
    }
}