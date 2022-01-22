namespace Homeless.HomeLess {
    export interface CityRow {
        Id?: number;
        Name?: string;
        Image?: string;
    }

    export namespace CityRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'HomeLess.City';
        export const lookupKey = 'HomeLess.City';

        export function getLookup(): Q.Lookup<CityRow> {
            return Q.getLookup<CityRow>('HomeLess.City');
        }

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Image = "Image"
        }
    }
}

