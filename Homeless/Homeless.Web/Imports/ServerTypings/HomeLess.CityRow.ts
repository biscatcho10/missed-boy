namespace Homeless.HomeLess {
    export interface CityRow {
        Id?: number;
        Name?: string;
        CountryId?: number;
        CountryName?: string;
    }

    export namespace CityRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'HomeLess.City';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            CountryId = "CountryId",
            CountryName = "CountryName"
        }
    }
}

