
namespace Homeless.HomeLess.Entities
{
    using Homeless.Northwind;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("HomeLess"), Module("HomeLess"), TableName("[dbo].[Topics]")]
    [DisplayName("Topics"), InstanceName("Topics")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class TopicsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Category"), ForeignKey("[dbo].[Category]", "id"), LeftJoin("jCategory"), TextualField("CategoryName")]
        [LookupEditor(typeof(CategoryRow), InplaceAdd = true)]
        public Int32? CategoryId
        {
            get { return Fields.CategoryId[this]; }
            set { Fields.CategoryId[this] = value; }
        }

        [DisplayName("City"), NotNull, ForeignKey("[dbo].[City]", "id"), LeftJoin("jCity"), TextualField("CityName")]
        [LookupEditor(typeof(CityRow), InplaceAdd = true)]
        public Int32? CityId
        {
            get { return Fields.CityId[this]; }
            set { Fields.CityId[this] = value; }
        }

        [DisplayName("Topic Address"), NotNull, QuickSearch]
        public String TopicAddress
        {
            get { return Fields.TopicAddress[this]; }
            set { Fields.TopicAddress[this] = value; }
        }

        [DisplayName("Topic Content"), NotNull,Required]
        public String TopicContent
        {
            get { return Fields.TopicContent[this]; }
            set { Fields.TopicContent[this] = value; }
        }

        [DisplayName("Is Closed"), NotNull]
        public Boolean? IsClosed
        {
            get { return Fields.IsClosed[this]; }
            set { Fields.IsClosed[this] = value; }
        }

        [DisplayName("Notes"), Size(50),TextAreaEditor]
        public String Notes
        {
            get { return Fields.Notes[this]; }
            set { Fields.Notes[this] = value; }
        }

        [DisplayName("Mobile"), Size(50), NotNull, Required,PhoneEditor]
        public String Mobile
        {
            get { return Fields.Mobile[this]; }
            set { Fields.Mobile[this] = value; }
        }

        [DisplayName("Mail"), Size(50),EmailEditor]
        public String Mail
        {
            get { return Fields.Mail[this]; }
            set { Fields.Mail[this] = value; }
        }

        [DisplayName("House Address"), Size(50),TextAreaEditor]
        public String HouseAddress
        {
            get { return Fields.HouseAddress[this]; }
            set { Fields.HouseAddress[this] = value; }
        }

        [DisplayName("Mobile User Name"), Size(50), Required]
        public String MobileUserName
        {
            get { return Fields.MobileUserName[this]; }
            set { Fields.MobileUserName[this] = value; }
        }

        [DisplayName("Another Mobile Phone"), Size(50),QuickSearch,PhoneEditor]
        public String AnotherMobilePhone
        {
            get { return Fields.AnotherMobilePhone[this]; }
            set { Fields.AnotherMobilePhone[this] = value; }
        }

        [DisplayName("Reson Of Absense"),QuickSearch]
        public String ResonOfAbsense
        {
            get { return Fields.ResonOfAbsense[this]; }
            set { Fields.ResonOfAbsense[this] = value; }
        }

        [DisplayName("Photos"),MultipleImageUploadEditor]
        public String Photos
        {
            get { return Fields.Photos[this]; }
            set { Fields.Photos[this] = value; }
        }

        [DisplayName("Main Photo"),ImageUploadEditor, Required]
        public String MainPhoto
        {
            get { return Fields.MainPhoto[this]; }
            set { Fields.MainPhoto[this] = value; }
        }

        [DisplayName("Absence Date"),DateEditor,QuickFilter]
        public DateTime? AbsenceDate
        {
            get { return Fields.AbsenceDate[this]; }
            set { Fields.AbsenceDate[this] = value; }
        }

        [DisplayName("Category Name"), Expression("jCategory.[name]"),QuickFilter]
        public String CategoryName
        {
            get { return Fields.CategoryName[this]; }
            set { Fields.CategoryName[this] = value; }
        }

        [DisplayName("Category Description"), Expression("jCategory.[description]")]
        public String CategoryDescription
        {
            get { return Fields.CategoryDescription[this]; }
            set { Fields.CategoryDescription[this] = value; }
        }

        [DisplayName("City Name"), Expression("jCity.[name]"), QuickFilter]
        public String CityName
        {
            get { return Fields.CityName[this]; }
            set { Fields.CityName[this] = value; }
        }

        [DisplayName("City Country Id"), Expression("jCity.[CountryId]")]
        public Int32? CityCountryId
        {
            get { return Fields.CityCountryId[this]; }
            set { Fields.CityCountryId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.TopicAddress; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TopicsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field CategoryId;
            public Int32Field CityId;
            public StringField TopicAddress;
            public StringField TopicContent;
            public BooleanField IsClosed;
            public StringField Notes;
            public StringField Mobile;
            public StringField Mail;
            public StringField HouseAddress;
            public StringField MobileUserName;
            public StringField AnotherMobilePhone;
            public StringField ResonOfAbsense;
            public StringField Photos;
            public StringField MainPhoto;
            public DateTimeField AbsenceDate;

            public StringField CategoryName;
            public StringField CategoryDescription;

            public StringField CityName;
            public Int32Field CityCountryId;
        }
    }
}
