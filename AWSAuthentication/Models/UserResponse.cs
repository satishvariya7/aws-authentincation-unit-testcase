namespace AWSAuthentication.Models
{
    //Created class for managin Userinfo aws API
    public class UserResponse
    {
        public string? sub { get; set; }
        public string? email_verified { get; set; }
        public string? email { get; set; }
        public string? username { get; set; }
    }
}
