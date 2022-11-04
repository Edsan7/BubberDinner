using System;

namespace BubberDinner.Application.Common.Services
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
    }
}