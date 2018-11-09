
namespace Homeless.HomeLess.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("HomeLess.AbotutUs")]
    [BasedOnRow(typeof(Entities.AbotutUsRow), CheckNames = true)]
    public class AbotutUsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId")]
        public Int32 Id { get; set; }
        [EditLink]
        public String Name { get; set; }
        public String Fb { get; set; }
        public String Twitter { get; set; }
        public String Instgram { get; set; }
        public String Mobile { get; set; }
    }
}