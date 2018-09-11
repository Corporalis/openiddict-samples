namespace AuthorizationServer.Models
{
    public class AuthOptions
    {
        public string Secret { get; set; }
        public string Authority { get; set; }
        public string[] AllowedOrigins { get; set; }
    }
}