using System;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class MakeViewingViewModel
    {
        public string PropertyType { get; set; }
        public string StreetName { get; set; }
        public DateTime ViewingDate { get; set; }
        public int PropertyId { get; set; }
    }
}