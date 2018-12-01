
namespace Homeless.HomeLess {

    @Serenity.Decorators.registerClass()
    export class AytamPlacesDialog extends Serenity.EntityDialog<AytamPlacesRow, any> {
        protected getFormKey() { return AytamPlacesForm.formKey; }
        protected getIdProperty() { return AytamPlacesRow.idProperty; }
        protected getLocalTextPrefix() { return AytamPlacesRow.localTextPrefix; }
        protected getNameProperty() { return AytamPlacesRow.nameProperty; }
        protected getService() { return AytamPlacesService.baseUrl; }

        protected form = new AytamPlacesForm(this.idPrefix);

    }
}