
namespace Homeless.HomeLess {

    @Serenity.Decorators.registerClass()
    export class AbotutUsDialog extends Serenity.EntityDialog<AbotutUsRow, any> {
        protected getFormKey() { return AbotutUsForm.formKey; }
        protected getIdProperty() { return AbotutUsRow.idProperty; }
        protected getLocalTextPrefix() { return AbotutUsRow.localTextPrefix; }
        protected getNameProperty() { return AbotutUsRow.nameProperty; }
        protected getService() { return AbotutUsService.baseUrl; }

        protected form = new AbotutUsForm(this.idPrefix);

    }
}