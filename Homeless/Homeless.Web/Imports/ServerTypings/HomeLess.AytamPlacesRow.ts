
namespace Homeless.HomeLess {
    export interface AytamPlacesRow {
        Id?: number;
        Mobile?: string;
        Website?: string;
        Description?: string;
        CityId?: number;
        Mail?: string;
        Photos?: string;
    }

    export namespace AytamPlacesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Mobile';
        export const localTextPrefix = 'HomeLess.AytamPlaces';

        export namespace Fields {
            export declare const Id;
            export declare const Mobile;
            export declare const Website;
            export declare const Description;
            export declare const CityId;
            export declare const Mail;
            export declare const Photos;
        }

        [
            'Id',
            'Mobile',
            'Website',
            'Description',
            'CityId',
            'Mail',
            'Photos'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}