using ZeldaGuide.Models.Token;

namespace ZeldaGuide.Services.Token;

public interface ITokenService
{
    Task<TokenResponse?> GetTokenAsync(TokenRequest model);
}