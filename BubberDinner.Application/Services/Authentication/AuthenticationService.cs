using System;
using BubberDinner.Application.Common;

namespace BubberDinner.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {

            Guid userId = Guid.NewGuid();

            var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);
            
            return new AuthenticationResult(
                System.Guid.Empty,
                firstName,
                lastName,
                email,
                token
            );
        }

        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult(
                System.Guid.Empty,
                "firstName",
                "lastName",
                email,
                Guid.NewGuid().ToString()
            );
        }

        
    }
}