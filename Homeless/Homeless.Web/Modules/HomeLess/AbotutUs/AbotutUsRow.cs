
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

    [ConnectionKey("HomeLess"), Module("HomeLess"), TableName("[dbo].[AbotutUs]")]
    [DisplayName("Abotut Us"), InstanceName("Abotut Us")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class AbotutUsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Name"), Size(50), QuickSearch,Required]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Photo"), Size(50),ImageUploadEditor, Required]
       
        public String Photo
        {
            get { return Fields.Photo[this]; }
            set { Fields.Photo[this] = value; }
        }

        [DisplayName("Description"),TextAreaEditor]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Fb"), Column("fb")]
        public String Fb
        {
            get { return Fields.Fb[this]; }
            set { Fields.Fb[this] = value; }
        }

        [DisplayName("Twitter"), Column("twitter")]
        public String Twitter
        {
            get { return Fields.Twitter[this]; }
            set { Fields.Twitter[this] = value; }
        }

        [DisplayName("Instgram"), Column("instgram")]
        public String Instgram
        {
            get { return Fields.Instgram[this]; }
            set { Fields.Instgram[this] = value; }
        }

        [DisplayName("Mobile"), Size(50),PhoneEditor, QuickSearch]
        public String Mobile
        {
            get { return Fields.Mobile[this]; }
            set { Fields.Mobile[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AbotutUsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Name;
            public StringField Photo;
            public StringField Description;
            public StringField Fb;
            public StringField Twitter;
            public StringField Instgram;
            public StringField Mobile;
        }
    }
}
