namespace Homeless.HomeLess {
    export interface CategoryRow {
        Id?: number;
        Name?: string;
        Description?: string;
        Photo?: string;
    }

    export namespace CategoryRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'HomeLess.Category';
        export const lookupKey = 'HomeLess.Category';

        export function getLookup(): Q.Lookup<CategoryRow> {
            return Q.getLookup<CategoryRow>('HomeLess.Category');
        }

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description",
            Photo = "Photo"
        }
    }
}

