
namespace Homeless.HomeLess.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("HomeLess"), Module("HomeLess"), TableName("[dbo].[Contactus]")]
    [DisplayName("Contactus"), InstanceName("Contactus")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class ContactusRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Message Content"), NotNull, QuickSearch,TextAreaEditor]
        public String MessageContent
        {
            get { return Fields.MessageContent[this]; }
            set { Fields.MessageContent[this] = value; }
        }

        [DisplayName("Mail"), Size(50),EmailEditor]
        public String Mail
        {
            get { return Fields.Mail[this]; }
            set { Fields.Mail[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.MessageContent; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ContactusRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField MessageContent;
            public StringField Mail;
        }
    }
}
