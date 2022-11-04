using System;
using BubberDinner.Application.Common.Services;

namespace BubberDinner.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime Now => DateTime.UtcNow;
    }
}