
namespace Homeless.HomeLess {

    @Serenity.Decorators.registerClass()
    export class CountryGrid extends Serenity.EntityGrid<CountryRow, any> {
        protected getColumnsKey() { return 'HomeLess.Country'; }
        protected getDialogType() { return CountryDialog; }
        protected getIdProperty() { return CountryRow.idProperty; }
        protected getLocalTextPrefix() { return CountryRow.localTextPrefix; }
        protected getService() { return CountryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}