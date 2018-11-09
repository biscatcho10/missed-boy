
namespace Homeless.HomeLess {

    @Serenity.Decorators.registerClass()
    export class ContactusDialog extends Serenity.EntityDialog<ContactusRow, any> {
        protected getFormKey() { return ContactusForm.formKey; }
        protected getIdProperty() { return ContactusRow.idProperty; }
        protected getLocalTextPrefix() { return ContactusRow.localTextPrefix; }
        protected getNameProperty() { return ContactusRow.nameProperty; }
        protected getService() { return ContactusService.baseUrl; }

        protected form = new ContactusForm(this.idPrefix);

    }
}