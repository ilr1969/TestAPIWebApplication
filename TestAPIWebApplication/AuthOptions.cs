using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace OnlineShopWebApi
{
    public class AuthOptions
    {
        public const string ISSUER = "http://localhost:5005"; // издатель токена
        public const string AUDIENCE = "http://localhost:5001"; // потребитель токена
        public const string KEY = "1qaz@WSX3edc$RFV5tgb^YHN7ujm*IK<";   // ключ для шифрации
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }
}