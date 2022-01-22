namespace Homeless.HomeLess {
    export interface CategoryForm {
        Name: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        Photo: Serenity.ImageUploadEditor;
    }

    export class CategoryForm extends Serenity.PrefixedContext {
        static formKey = 'HomeLess.Category';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CategoryForm.init)  {
                CategoryForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = s.ImageUploadEditor;

                Q.initFormType(CategoryForm, [
                    'Name', w0,
                    'Description', w1,
                    'Photo', w2
                ]);
            }
        }
    }
}

