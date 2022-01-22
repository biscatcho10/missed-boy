namespace Homeless.HomeLess {
    export interface AytamPlacesRow {
        Id?: number;
        Mobile?: string;
        Name?: string;
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

        export declare const enum Fields {
            Id = "Id",
            Mobile = "Mobile",
            Name = "Name",
            Website = "Website",
            Description = "Description",
            CityId = "CityId",
            Mail = "Mail",
            Photos = "Photos"
        }
    }
}

