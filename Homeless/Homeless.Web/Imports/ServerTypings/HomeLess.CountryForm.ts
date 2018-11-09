﻿namespace Homeless.HomeLess {
    export interface CountryForm {
        Name: Serenity.StringEditor;
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

                Q.initFormType(CountryForm, [
                    'Name', w0
                ]);
            }
        }
    }
}

