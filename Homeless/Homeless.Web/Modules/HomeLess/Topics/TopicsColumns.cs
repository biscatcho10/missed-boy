
namespace Homeless.HomeLess.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("HomeLess.Topics")]
    [BasedOnRow(typeof(Entities.TopicsRow), CheckNames = true)]
    public class TopicsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String CategoryName { get; set; }
        [EditLink]
        public String CityName { get; set; }
        public String CountryName { get; set; }
        [EditLink]
        public String TopicAddress { get; set; }    
        [EditLink]
        public String LostName { get; set; }
        public String TopicContent { get; set; }
        public Boolean IsClosed { get; set; }
        public String Notes { get; set; }
        public String Mobile { get; set; }
        public String Mail { get; set; }
        public String HouseAddress { get; set; }
        public String MobileUserName { get; set; }
        public String DNA { get; set; }
        public String ResonOfAbsense { get; set; }
        public String Photos { get; set; }
        public String MainPhoto { get; set; }
        public DateTime AbsenceDate { get; set; }
    }
}