namespace Homeless.HomeLess {
    export interface CountryRow {
        Id?: number;
        Name?: string;
    }

    export namespace CountryRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'HomeLess.Country';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name"
        }
    }
}

