using System;

namespace MRMDesktopUILibrary.Models
{
    public interface ILoggedInUserModel
    {
        DateTime DateCreated { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string Id { get; set; }
        string LastName { get; set; }
        string Token { get; set; }
    }
}