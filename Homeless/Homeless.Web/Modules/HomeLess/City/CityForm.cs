
namespace Homeless.HomeLess.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HomeLess.City")]
    [BasedOnRow(typeof(Entities.CityRow), CheckNames = true)]
    public class CityForm
    {
        public String Name { get; set; }
        public String Image { get; set; }
    }
}