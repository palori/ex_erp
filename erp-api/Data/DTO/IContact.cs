using System;

namespace erp_api.Data.DTO
{
    public interface IContact
    {
        #nullable enable
        string? Id {get; set;}
        string? Name {get; set;}
        string? PhoneNumber {get; set;}
        string? Email {get; set;}
        DateTime? Registered {get; set;}
        DateTime? LastUpdated {get; set;}
        #nullable disable
    }
}