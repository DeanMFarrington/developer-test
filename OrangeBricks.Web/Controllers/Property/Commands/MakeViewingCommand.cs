using System;

namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class MakeViewingCommand
    {
        public int PropertyId { get; set; }

        public DateTime ViewingDate { get; set; }

        public string BuyerId { get; set; }
    }
}