
namespace Homeless.HomeLess.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("HomeLess.Contactus")]
    [BasedOnRow(typeof(Entities.ContactusRow), CheckNames = true)]
    public class ContactusColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId")]
        public Int32 Id { get; set; }
        [EditLink]
        public String MessageContent { get; set; }
        public String Mail { get; set; }
    }
}