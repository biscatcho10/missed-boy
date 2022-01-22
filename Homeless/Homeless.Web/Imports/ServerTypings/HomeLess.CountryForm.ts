namespace Homeless.HomeLess {
    export interface CountryForm {
        Name: Serenity.StringEditor;
        Photo: Serenity.ImageUploadEditor;
    }

    export class CountryForm extends Serenity.PrefixedContext {
        static formKey = 'HomeLess.Country';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CountryForm.init)  {
                CountryForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.ImageUploadEditor;

                Q.initFormType(CountryForm, [
                    'Name', w0,
                    'Photo', w1
                ]);
            }
        }
    }
}

