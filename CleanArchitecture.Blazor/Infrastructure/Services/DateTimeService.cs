using CleanArchitecture.Blazor.Application.Common.Interfaces;
using System;

namespace CleanArchitecture.Blazor.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}