namespace Homeless.HomeLess {
    export interface TopicsForm {
        CategoryId: Serenity.IntegerEditor;
        CityId: Serenity.IntegerEditor;
        TopicAddress: Serenity.StringEditor;
        TopicContent: Serenity.StringEditor;
        IsClosed: Serenity.BooleanEditor;
        Notes: Serenity.StringEditor;
        Mobile: Serenity.StringEditor;
        Mail: Serenity.StringEditor;
        HouseAddress: Serenity.StringEditor;
        MobileUserName: Serenity.StringEditor;
        AnotherMobilePhone: Serenity.StringEditor;
        ResonOfAbsense: Serenity.StringEditor;
        Photos: Serenity.StringEditor;
        MainPhoto: Serenity.StringEditor;
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
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.BooleanEditor;
                var w3 = s.DateEditor;

                Q.initFormType(TopicsForm, [
                    'CategoryId', w0,
                    'CityId', w0,
                    'TopicAddress', w1,
                    'TopicContent', w1,
                    'IsClosed', w2,
                    'Notes', w1,
                    'Mobile', w1,
                    'Mail', w1,
                    'HouseAddress', w1,
                    'MobileUserName', w1,
                    'AnotherMobilePhone', w1,
                    'ResonOfAbsense', w1,
                    'Photos', w1,
                    'MainPhoto', w1,
                    'AbsenceDate', w3
                ]);
            }
        }
    }
}

