
namespace Homeless.HomeLess {

    @Serenity.Decorators.registerClass()
    export class ContactusGrid extends Serenity.EntityGrid<ContactusRow, any> {
        protected getColumnsKey() { return 'HomeLess.Contactus'; }
        protected getDialogType() { return ContactusDialog; }
        protected getIdProperty() { return ContactusRow.idProperty; }
        protected getLocalTextPrefix() { return ContactusRow.localTextPrefix; }
        protected getService() { return ContactusService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}