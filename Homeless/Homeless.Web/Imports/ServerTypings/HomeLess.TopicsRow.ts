namespace Homeless.HomeLess {
    export interface TopicsRow {
        Id?: number;
        CategoryId?: number;
        CountryId?: number;
        CityId?: number;
        TopicAddress?: string;
        TopicContent?: string;
        IsClosed?: boolean;
        Notes?: string;
        Mobile?: string;
        Mail?: string;
        LostName?: string;
        HouseAddress?: string;
        MobileUserName?: string;
        DNA?: string;
        ResonOfAbsense?: string;
        Photos?: string;
        MainPhoto?: string;
        AbsenceDate?: string;
        CategoryName?: string;
        CategoryDescription?: string;
        CityName?: string;
        CountryName?: string;
        CityCountryId?: number;
    }

    export namespace TopicsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'TopicAddress';
        export const localTextPrefix = 'HomeLess.Topics';

        export declare const enum Fields {
            Id = "Id",
            CategoryId = "CategoryId",
            CountryId = "CountryId",
            CityId = "CityId",
            TopicAddress = "TopicAddress",
            TopicContent = "TopicContent",
            IsClosed = "IsClosed",
            Notes = "Notes",
            Mobile = "Mobile",
            Mail = "Mail",
            LostName = "LostName",
            HouseAddress = "HouseAddress",
            MobileUserName = "MobileUserName",
            DNA = "DNA",
            ResonOfAbsense = "ResonOfAbsense",
            Photos = "Photos",
            MainPhoto = "MainPhoto",
            AbsenceDate = "AbsenceDate",
            CategoryName = "CategoryName",
            CategoryDescription = "CategoryDescription",
            CityName = "CityName",
            CountryName = "CountryName",
            CityCountryId = "CityCountryId"
        }
    }
}

