
namespace Homeless.HomeLess {

    @Serenity.Decorators.registerClass()
    export class AbotutUsGrid extends Serenity.EntityGrid<AbotutUsRow, any> {
        protected getColumnsKey() { return 'HomeLess.AbotutUs'; }
        protected getDialogType() { return AbotutUsDialog; }
        protected getIdProperty() { return AbotutUsRow.idProperty; }
        protected getLocalTextPrefix() { return AbotutUsRow.localTextPrefix; }
        protected getService() { return AbotutUsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}