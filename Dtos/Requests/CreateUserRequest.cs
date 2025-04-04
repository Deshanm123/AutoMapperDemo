namespace AutoMapper_DEmo.Dtos.Requests
{
    public class CreateUserRequest
    {
        public string FirstName{get;set;} = string.Empty;
        public string LastName{get;set;} = string.Empty;
        public string Email{get;set;} = string.Empty;
        public string PostCode{get;set;} = string.Empty;
        public string StreetAddress{get;set;} = string.Empty;
       
    }

}