namespace Homeless.HomeLess {
    export interface TopicsForm {
        CategoryId: Serenity.LookupEditor;
        CityId: Serenity.LookupEditor;
        CountryId: Serenity.LookupEditor;
        TopicAddress: Serenity.StringEditor;
        TopicContent: Serenity.TextAreaEditor;
        IsClosed: Serenity.BooleanEditor;
        Notes: Serenity.TextAreaEditor;
        LostName: Serenity.StringEditor;
        Mobile: Northwind.PhoneEditor;
        Mail: Serenity.EmailEditor;
        HouseAddress: Serenity.TextAreaEditor;
        MobileUserName: Serenity.StringEditor;
        DNA: Northwind.PhoneEditor;
        ResonOfAbsense: Serenity.StringEditor;
        Photos: Serenity.MultipleImageUploadEditor;
        MainPhoto: Serenity.ImageUploadEditor;
        AbsenceDate: Serenity.DateEditor;
    }

    export class TopicsForm extends Serenity.PrefixedContext {
        static formKey = 'HomeLess.Topics';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TopicsForm.init)  {
                TopicsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.TextAreaEditor;
                var w3 = s.BooleanEditor;
                var w4 = Northwind.PhoneEditor;
                var w5 = s.EmailEditor;
                var w6 = s.MultipleImageUploadEditor;
                var w7 = s.ImageUploadEditor;
                var w8 = s.DateEditor;

                Q.initFormType(TopicsForm, [
                    'CategoryId', w0,
                    'CityId', w0,
                    'CountryId', w0,
                    'TopicAddress', w1,
                    'TopicContent', w2,
                    'IsClosed', w3,
                    'Notes', w2,
                    'LostName', w1,
                    'Mobile', w4,
                    'Mail', w5,
                    'HouseAddress', w2,
                    'MobileUserName', w1,
                    'DNA', w4,
                    'ResonOfAbsense', w1,
                    'Photos', w6,
                    'MainPhoto', w7,
                    'AbsenceDate', w8
                ]);
            }
        }
    }
}

