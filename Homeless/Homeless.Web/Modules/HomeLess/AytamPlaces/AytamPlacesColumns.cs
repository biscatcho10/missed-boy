
namespace Homeless.HomeLess.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("HomeLess.AytamPlaces")]
    [BasedOnRow(typeof(Entities.AytamPlacesRow), CheckNames = true)]
    public class AytamPlacesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String Mobile { get; set; }
        [EditLink]
        public String Name { get; set; }
        public String Website { get; set; }
        public String Description { get; set; }
        public Int32 CityId { get; set; }
        public String Mail { get; set; }
        public String Photos { get; set; }
    }
}