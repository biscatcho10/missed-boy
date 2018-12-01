
namespace Homeless.HomeLess {

    @Serenity.Decorators.registerClass()
    export class AytamPlacesGrid extends Serenity.EntityGrid<AytamPlacesRow, any> {
        protected getColumnsKey() { return 'HomeLess.AytamPlaces'; }
        protected getDialogType() { return AytamPlacesDialog; }
        protected getIdProperty() { return AytamPlacesRow.idProperty; }
        protected getLocalTextPrefix() { return AytamPlacesRow.localTextPrefix; }
        protected getService() { return AytamPlacesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}