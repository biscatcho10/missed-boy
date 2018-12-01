
namespace Homeless.HomeLess {
    export class AytamPlacesForm extends Serenity.PrefixedContext {
        static formKey = 'HomeLess.AytamPlaces';
    }

    export interface AytamPlacesForm {
        Mobile: Serenity.StringEditor;
        Website: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        CityId: Serenity.IntegerEditor;
        Mail: Serenity.StringEditor;
        Photos: Serenity.StringEditor;
    }

    [,
        ['Mobile', () => Serenity.StringEditor],
        ['Website', () => Serenity.StringEditor],
        ['Description', () => Serenity.StringEditor],
        ['CityId', () => Serenity.IntegerEditor],
        ['Mail', () => Serenity.StringEditor],
        ['Photos', () => Serenity.StringEditor]
    ].forEach(x => Object.defineProperty(AytamPlacesForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}