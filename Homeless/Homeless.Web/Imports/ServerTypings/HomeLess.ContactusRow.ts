namespace Homeless.HomeLess {
    export interface ContactusRow {
        Id?: number;
        MessageContent?: string;
        Mail?: string;
    }

    export namespace ContactusRow {
        export const idProperty = 'Id';
        export const nameProperty = 'MessageContent';
        export const localTextPrefix = 'HomeLess.Contactus';

        export declare const enum Fields {
            Id = "Id",
            MessageContent = "MessageContent",
            Mail = "Mail"
        }
    }
}

