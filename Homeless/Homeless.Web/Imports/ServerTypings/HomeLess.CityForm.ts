namespace Homeless.HomeLess {
    export interface CityForm {
        Name: Serenity.StringEditor;
        Image: Serenity.ImageUploadEditor;
    }

    export class CityForm extends Serenity.PrefixedContext {
        static formKey = 'HomeLess.City';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CityForm.init)  {
                CityForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.ImageUploadEditor;

                Q.initFormType(CityForm, [
                    'Name', w0,
                    'Image', w1
                ]);
            }
        }
    }
}

