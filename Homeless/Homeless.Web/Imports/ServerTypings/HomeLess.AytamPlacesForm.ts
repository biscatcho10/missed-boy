namespace Homeless.HomeLess {
    export interface AytamPlacesForm {
        Mobile: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Website: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        CityId: Serenity.LookupEditor;
        Mail: Serenity.EmailEditor;
        Photos: Serenity.MultipleImageUploadEditor;
    }

    export class AytamPlacesForm extends Serenity.PrefixedContext {
        static formKey = 'HomeLess.AytamPlaces';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AytamPlacesForm.init)  {
                AytamPlacesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.EmailEditor;
                var w3 = s.MultipleImageUploadEditor;

                Q.initFormType(AytamPlacesForm, [
                    'Mobile', w0,
                    'Name', w0,
                    'Website', w0,
                    'Description', w0,
                    'CityId', w1,
                    'Mail', w2,
                    'Photos', w3
                ]);
            }
        }
    }
}

