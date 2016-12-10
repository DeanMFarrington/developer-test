using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrangeBricks.Web.Controllers.Viewings.ViewModels
{
    public class MyViewingsViewModel
    {
        public bool HasViewings { get; set; }
        public List<ViewingsOnPropertyViewModel> Viewings { get; set; }
    }
}