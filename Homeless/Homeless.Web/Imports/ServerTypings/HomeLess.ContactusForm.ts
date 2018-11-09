namespace Homeless.HomeLess {
    export interface ContactusForm {
        MessageContent: Serenity.TextAreaEditor;
        Mail: Serenity.EmailEditor;
    }

    export class ContactusForm extends Serenity.PrefixedContext {
        static formKey = 'HomeLess.Contactus';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ContactusForm.init)  {
                ContactusForm.init = true;

                var s = Serenity;
                var w0 = s.TextAreaEditor;
                var w1 = s.EmailEditor;

                Q.initFormType(ContactusForm, [
                    'MessageContent', w0,
                    'Mail', w1
                ]);
            }
        }
    }
}

