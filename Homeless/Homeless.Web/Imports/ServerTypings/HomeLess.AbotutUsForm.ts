namespace Homeless.HomeLess {
    export interface AbotutUsForm {
        Name: Serenity.StringEditor;
        Photo: Serenity.ImageUploadEditor;
        Description: Serenity.TextAreaEditor;
        Fb: Serenity.StringEditor;
        Twitter: Serenity.StringEditor;
        Instgram: Serenity.StringEditor;
        Mobile: Northwind.PhoneEditor;
    }

    export class AbotutUsForm extends Serenity.PrefixedContext {
        static formKey = 'HomeLess.AbotutUs';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AbotutUsForm.init)  {
                AbotutUsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.ImageUploadEditor;
                var w2 = s.TextAreaEditor;
                var w3 = Northwind.PhoneEditor;

                Q.initFormType(AbotutUsForm, [
                    'Name', w0,
                    'Photo', w1,
                    'Description', w2,
                    'Fb', w0,
                    'Twitter', w0,
                    'Instgram', w0,
                    'Mobile', w3
                ]);
            }
        }
    }
}

