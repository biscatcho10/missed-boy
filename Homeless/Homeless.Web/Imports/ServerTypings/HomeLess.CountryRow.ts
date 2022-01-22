namespace Homeless.HomeLess {
    export interface CountryRow {
        Id?: number;
        Name?: string;
        Photo?: string;
    }

    export namespace CountryRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'HomeLess.Country';
        export const lookupKey = 'HomeLess.Country';

        export function getLookup(): Q.Lookup<CountryRow> {
            return Q.getLookup<CountryRow>('HomeLess.Country');
        }

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Photo = "Photo"
        }
    }
}

