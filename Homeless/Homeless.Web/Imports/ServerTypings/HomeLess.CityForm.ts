namespace Homeless.HomeLess {
    export interface CityForm {
        Name: Serenity.StringEditor;
        CountryId: Serenity.IntegerEditor;
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
                var w1 = s.IntegerEditor;

                Q.initFormType(CityForm, [
                    'Name', w0,
                    'CountryId', w1
                ]);
            }
        }
    }
}

