
namespace Homeless.HomeLess {

    @Serenity.Decorators.registerClass()
    export class TopicsDialog extends Serenity.EntityDialog<TopicsRow, any> {
        protected getFormKey() { return TopicsForm.formKey; }
        protected getIdProperty() { return TopicsRow.idProperty; }
        protected getLocalTextPrefix() { return TopicsRow.localTextPrefix; }
        protected getNameProperty() { return TopicsRow.nameProperty; }
        protected getService() { return TopicsService.baseUrl; }

        protected form = new TopicsForm(this.idPrefix);

    }
}