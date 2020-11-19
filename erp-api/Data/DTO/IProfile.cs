using System;

namespace erp_api.Data.DTO
{
    public interface IProfile: IContact
    {
        #nullable enable
        string? Surnames {get; set;}
        bool? Gender {get; set;}
        int? Year {get; set;}
        #nullable disable
    }
}