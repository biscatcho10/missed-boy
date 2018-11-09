
namespace Homeless.HomeLess {

    @Serenity.Decorators.registerClass()
    export class TopicsGrid extends Serenity.EntityGrid<TopicsRow, any> {
        protected getColumnsKey() { return 'HomeLess.Topics'; }
        protected getDialogType() { return TopicsDialog; }
        protected getIdProperty() { return TopicsRow.idProperty; }
        protected getLocalTextPrefix() { return TopicsRow.localTextPrefix; }
        protected getService() { return TopicsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}