using System;

namespace BubberDinner.Application.Common
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(Guid userId, string firstName, string lastName);
        
    }
}