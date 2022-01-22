
namespace Homeless.HomeLess.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("HomeLess.City")]
    [BasedOnRow(typeof(Entities.CityRow), CheckNames = true)]
    public class CityColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId")]
        public Int32 Id { get; set; }
        [EditLink]
        public String Name { get; set; }
        public String Image { get; set; }
    }
}