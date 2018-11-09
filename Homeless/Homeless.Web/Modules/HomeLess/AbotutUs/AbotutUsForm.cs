
namespace Homeless.HomeLess.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HomeLess.AbotutUs")]
    [BasedOnRow(typeof(Entities.AbotutUsRow), CheckNames = true)]
    public class AbotutUsForm
    {
        public String Name { get; set; }
        public String Photo { get; set; }
        public String Description { get; set; }
        public String Fb { get; set; }
        public String Twitter { get; set; }
        public String Instgram { get; set; }
        public String Mobile { get; set; }
    }
}