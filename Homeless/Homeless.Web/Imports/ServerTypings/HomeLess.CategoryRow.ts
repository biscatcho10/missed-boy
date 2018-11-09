namespace Homeless.HomeLess {
    export interface CategoryRow {
        Id?: number;
        Name?: string;
        Description?: string;
    }

    export namespace CategoryRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'HomeLess.Category';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description"
        }
    }
}

