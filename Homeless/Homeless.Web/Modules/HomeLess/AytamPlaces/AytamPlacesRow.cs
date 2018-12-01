
namespace Homeless.HomeLess.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("HomeLess"), Module("HomeLess"), TableName("[dbo].[AytamPlaces]")]
    [DisplayName("Aytam Places"), InstanceName("Aytam Places")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class AytamPlacesRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Mobile"), Size(50), QuickSearch]
        public String Mobile
        {
            get { return Fields.Mobile[this]; }
            set { Fields.Mobile[this] = value; }
        }

        [DisplayName("Website")]
        public String Website
        {
            get { return Fields.Website[this]; }
            set { Fields.Website[this] = value; }
        }

        [DisplayName("Description")]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("City Id")]
        public Int32? CityId
        {
            get { return Fields.CityId[this]; }
            set { Fields.CityId[this] = value; }
        }

        [DisplayName("Mail"), Size(50)]
        public String Mail
        {
            get { return Fields.Mail[this]; }
            set { Fields.Mail[this] = value; }
        }

        [DisplayName("Photos")]
        public String Photos
        {
            get { return Fields.Photos[this]; }
            set { Fields.Photos[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Mobile; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AytamPlacesRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Mobile;
            public StringField Website;
            public StringField Description;
            public Int32Field CityId;
            public StringField Mail;
            public StringField Photos;
        }
    }
}
