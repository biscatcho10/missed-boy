
namespace Homeless.HomeLess.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("HomeLess.Contactus")]
    [BasedOnRow(typeof(Entities.ContactusRow), CheckNames = true)]
    public class ContactusForm
    {
        public String MessageContent { get; set; }
        public String Mail { get; set; }
    }
}