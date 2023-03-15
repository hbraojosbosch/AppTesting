using System;
namespace Contracts
{
	public interface IAuthenticationService
	{
        public UserLoginResponse Authenticate(UserLoginRequest loginRequest);

    }
}

