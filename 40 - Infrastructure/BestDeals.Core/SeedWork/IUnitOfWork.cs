//-----------------------------------------------------------------
// <copyright file="IUnitOfWork.cs" company="Smart Solution">
// Copyright (c) Smart Solution. All rights reserved.
// </copyright>
//-----------------------------------------------------------------

namespace BestDeals.Core
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
