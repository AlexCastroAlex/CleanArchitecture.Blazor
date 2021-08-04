using CleanArchitecture.Blazor.Application.Common.Interfaces;
using System;

namespace CleanArchitecture.Blazor.WebUI.IntegrationTests
{
    public class TestDateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
