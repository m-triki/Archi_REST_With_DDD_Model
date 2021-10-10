//-----------------------------------------------------------------
// <copyright file="IUserRepository.cs" company="Smart Solution">
// Copyright (c) Smart Solution. All rights reserved.
// </copyright>
//-----------------------------------------------------------------

namespace Identity.Domain
{
    using BestDeals.Core;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IUserRepository : IRepository<User>
    {
        bool Authenticate(string login, string password);

        bool Authentication(string jwtId);

        User Add(User user);

        bool Update(User user);

        bool Delete(User user);

        bool UpdateStatus(Guid userId, UserStatus userstatus);

        bool ResetPassWord(ForgetPassword forgetPassword);
        
        Task<User> GetAsync(Guid userId);

        Task<IEnumerable<User>> GetAllAsync();
    }
}
