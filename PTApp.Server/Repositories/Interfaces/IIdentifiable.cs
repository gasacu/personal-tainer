using System;

namespace PTApp.Server.Repositories.Interfaces
{
    public interface IIdentifiable
    {
        Guid Id { get; set; }
    }
}
