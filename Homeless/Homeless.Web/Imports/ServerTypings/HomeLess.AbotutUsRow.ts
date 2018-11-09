namespace Homeless.HomeLess {
    export interface AbotutUsRow {
        Id?: number;
        Name?: string;
        Photo?: string;
        Description?: string;
        Fb?: string;
        Twitter?: string;
        Instgram?: string;
        Mobile?: string;
    }

    export namespace AbotutUsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'HomeLess.AbotutUs';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Photo = "Photo",
            Description = "Description",
            Fb = "Fb",
            Twitter = "Twitter",
            Instgram = "Instgram",
            Mobile = "Mobile"
        }
    }
}

