
namespace Homeless.HomeLess.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HomeLess.AytamPlaces")]
    [BasedOnRow(typeof(Entities.AytamPlacesRow), CheckNames = true)]
    public class AytamPlacesForm
    {
        public String Mobile { get; set; }
        public String Name { get; set; }
        public String Website { get; set; }
        public String Description { get; set; }
        public Int32 CityId { get; set; }
        public String Mail { get; set; }
        public String Photos { get; set; }
    }
}